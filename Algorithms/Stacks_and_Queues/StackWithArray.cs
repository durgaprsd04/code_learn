using System;
namespace Stacks_and_Queues
{
    public class StackWithArray
    {
        private string [] s;
        private int N;
        public StackWithArray()
        {
            s = new String [1];
        }
        public void Push(string element)
        {
            s[N]=element;
            N++;
            if(s.Length==N)
            {
                Resize(2*s.Length);
            }
            //Console.WriteLine("Size of s " +s.Length);
        }
        public string Pop()
        {
            var element = s[N-1];
            //N has gone down we can halve the array
            N--;
            if(N>0 && N<s.Length/4)
            {
                Resize(s.Length/2);
            }
            //Console.WriteLine("Size of s " +s.Length);
            return element;

        }
        public string Current()
        {
            //Console.WriteLine("Size of s " +s.Length);
            return s[N-1];
        }
        public void Resize(int capacity)
        {
            Console.WriteLine("test "+capacity);
            Console.WriteLine(String.Join(",",s ));
            string [] s1 = new string [capacity] ;
            var n = s1.Length<s.Length?s1.Length:s.Length;
            for(int i=0;i<n;i++)
                {
                    s1[i]=s[i];
                }
            s=s1;
        }

    }
}