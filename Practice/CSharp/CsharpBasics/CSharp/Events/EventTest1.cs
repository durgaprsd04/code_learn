using System;
using System.IO;
namespace CSharp.Events
{
    public class Metronome
    {
        public int lineCount;
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(Metronome m, EventArgs e);
        public void Start()
        {   
            var count =3;
            int count1=0;
            while (true)
            {
                System.Threading.Thread.Sleep(30000);             
               /// Console.WriteLine("here");
                using(var sr= new StreamReader(@"tesfile.txt"))
                {
                    while(!sr.EndOfStream)
                    {
                        count1++;
                        sr.ReadLine();
                    }
                    //Console.WriteLine($"count1 is {count1}");
                }
                if(count1!=count)
                {
                    lineCount = count1-count;
                    count=count1;
                    if (Tick != null)
                    {
                        Tick(this, e);                       
                    } 
                }  
                count1=0;
            }
        }
    }
    public class Listener
    {
        public void Subscribe(Metronome m)
        {
            m.Tick += new Metronome.TickHandler(HeardIt);
        }

        private void HeardIt(Metronome m, EventArgs e)
        {
            System.Console.WriteLine($"Updated line with count {m.lineCount}");
        }
    }
}