using System;
using System.IO;
public class RandomNumberGenerator
{
    public RandomNumberGenerator(int n)
    {
        var r = new Random();
        using(StreamWriter  sw = new StreamWriter(@"numberlist.txt"))
        {
            for(int i=0;i<n;i++)
            {
                sw.WriteLine(r.Next(-n/2,n/2));
            }
            sw.Close();
        }
    }
}