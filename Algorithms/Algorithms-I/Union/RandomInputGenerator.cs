using System;
using System.IO;
namespace Union
{
    class RandomInputGenerator
    {
        public void RandomGenerator(int n)
        {           
            Console.WriteLine("Generating for c :"+n);
            var writer = new System.IO.StreamWriter(@"numberlist.txt");
            var writer1 = new System.IO.StreamWriter(@"connectlist.txt");
            var random = new Random();
            for(int i=0;i<n/2;i++)
            {
                writer.WriteLine(random.Next(n)+" "+random.Next(n));
                writer1.WriteLine(random.Next(n)+" "+random.Next(n));
            }
            writer.Close();
            writer1.Close();
        }
    }
}
