using System;
using System.IO;
using System.Collections.Generic;
namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Key Indexed Sorting");
            KeyIndexCount key = new KeyIndexCount();
            var input  = "eeeddbbbfffaaaaacccc";
            Console.WriteLine("Input for Key index sorting "+input);
            var result = key.KeyIndexCounting(input);
            Console.WriteLine("Key Indexed Sort result "+ result);
            Console.WriteLine("LSD Sorting");
            var lsd = new LowestRadixSort();
            List<string> listOfStrings = new List<string>();
            StreamReader sr = new StreamReader("strings1.txt");
            while(!sr.EndOfStream)
            {
                listOfStrings.Add(sr.ReadLine());
            }
            var resultArray = listOfStrings.ToArray();
            Console.WriteLine("Before Sort "+ string.Join(',', resultArray));
            lsd.LowestRadixSortFunc(resultArray);
            Console.WriteLine("After sort " + string.Join(',', resultArray));
            Console.WriteLine("MSD Sorting");
            var resultArray1 = listOfStrings.ToArray();
            Console.WriteLine("Before Sort  "+string.Join(',', resultArray1));
            MostSignificantDigitRadixSort msd = new MostSignificantDigitRadixSort();
            msd.MSD(resultArray1);
            Console.WriteLine("Result array "+string.Join(',', resultArray1));
        }
    }
}
