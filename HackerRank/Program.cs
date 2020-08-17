using System;
using System.IO;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //StreamReader sr = new StreamReader("input_larryarray.txt");
            //while(sr.Peek()>=0)
            //{
             // int n = Convert.ToInt32(sr.ReadLine());
             // int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
             // var v = LarryArray.larrysArray(arr);
              //Console.WriteLine(v);
            //}
            /*
            sr = new StreamReader("input_valid.txt");
            while(sr.Peek()>=0)
            {
              var line = sr.ReadLine();
              var result = SherlockString.isValid(line);
              Console.WriteLine(result);
            }
            */
            /*
            sr = new StreamReader("input_caesar.txt");
            while(sr.Peek()>=0)
            {
              var line = Convert.ToInt32( sr.ReadLine());
              var str = sr.ReadLine();
              var k = Convert.ToInt32(sr.ReadLine());
              var result = CaesarCipherClass.CaesarCipher(str,k);
              Console.WriteLine(result);
            }
            StreamReader sr = new StreamReader("input_commonchild.txt");
            while(sr.Peek()>=0)
            {
              var str1 =sr.ReadLine();
              var str2 = sr.ReadLine();
              var result = CommonChildClass.CommonChild(str1,str2);
              Console.WriteLine(result);
            }*/
            StreamReader sr = new StreamReader("input_tutchallenge.txt");
            var intro = new IntroTutorial();
            while(sr.Peek()>=0)
            {
                  int V = Convert.ToInt32(sr.ReadLine());
                  int n = Convert.ToInt32(sr.ReadLine());
                  int[] arr = Array.ConvertAll(sr.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                  int result = intro.introTutorial(V, arr);
                  Console.WriteLine($"index of ${V} is "+result);
            }

            Console.WriteLine("hello");
        }
    }
}
