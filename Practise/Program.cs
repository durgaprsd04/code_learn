using System;
using System.Collections;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse");
            Operations rs = new Operations();
            Console.WriteLine(" reverse of hello world!" +rs.reverse("Hello World!"));
            //paliendrome 
            Console.WriteLine("paliendrome");
            Console.WriteLine("Malayalam is paliendrome "+rs.isPaliendrome("malayalam"));
            Console.WriteLine("English is paliendrome "+rs.isPaliendrome("English"));
            //int reversse
            Console.WriteLine("int reversse");
            Console.WriteLine("reverse of  12345678910 "+rs.reverseInt(12345678910));
            //classic Fizzubzz
            Console.WriteLine("classic Fizzubzz");
            rs.FizzBuzz(100);
            //max chars problem
            Console.WriteLine();
            Console.WriteLine("Max chars ");
            Console.WriteLine("The max char element is '"+rs.MaxChars("HeeeeeelloWorld!")+"'");
            //circle
            rs.DrawCircle(5);
            //chunkc array
            int []a=    {3,4,2,1,27,8,3};
            rs.ChunkSize(a, 3);
            //anagram
            Console.WriteLine();
            Console.WriteLine("Fairytale and railsafe are anagram "+rs.isAnagram("fairytales", "railsafety"));
            Console.WriteLine("Fairytale and manga are anagram "+rs.isAnagram("fairytale", "manga"));
            // joined string lines
            Console.WriteLine("String joined "+ rs.CapitalizeFirst("a quick fox jumped over a lazy dog"));
            //printing steps
            Console.WriteLine("printing steps ");
            rs.Steps(4,4);
            //pyramid
             Console.WriteLine("printing pyramid ");
            rs.Pyramid(4,4);
            //Find Vowels
            Console.WriteLine("Number of vowels in abcdef "+rs.FindVowels("abcdef"));
            Console.WriteLine("Number of vowels in hello world "+rs.FindVowels("hello world"));
            //print matrix
            rs.PrintSpiralMatrix(3);
        }   
    }
}
