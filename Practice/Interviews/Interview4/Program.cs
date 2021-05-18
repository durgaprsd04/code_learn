using System;

namespace Interview4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var element = new int[3][];
            element[0] = new int[4]{1,  2,   6,  7};
            element[1] = new int[4]{5,  8,   9,  10};
            element[2] = new int[4]{8,  11,  14, 17};
            //element[3] = new int[4]{12, 15,  18, 20};
            var x = new SearchinGrid();
            var search = new int[] {5, 15, 10, 19};
            //var search = new int[] {10};
            foreach(var e in search)
                Console.WriteLine($" {e} is in {x.HasElement(element, e)}");;
        }
    }
}
