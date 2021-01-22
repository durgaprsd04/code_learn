using System;
using System.IO;
namespace CSharp
{
    public class Metronome1
    {
            public void TestFunct(Okay o)
            {
                o.i=7;
                o.j=8;
                Console.WriteLine($" i {o.i} and j {o.j}");
            }
            public void TestFunct(metro1 o)
            {
                o.X=7;
                o.Y=8;
                Console.WriteLine($" i {o.X} and j {o.Y}");
            }
       
    }
    public struct metro1 
    {
           public metro1(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set;}
    public int Y { get;set; }
     public override string ToString()
        {
            return $" i {this.X} and j {this.Y}";
        }
    }
    public class Okay
        {
            public int i=4;
            public int j =5;
            public override string ToString()
        {
            return $" i {this.i} and j {this.j}";
        }
        }
        
}