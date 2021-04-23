using System;
using System.Collections;
using System.Collections.Generic;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Reverse");
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
            rs.PrintSpiralMatrix(8);
            Console.WriteLine();
            //fibnonnaci
            Console.WriteLine("Fibonnaci upto 10 "+string.Join( ',', rs.Fibonacci(10).ToArray()));
            //fibonnacci recursion
             Console.WriteLine("Fibonnaci upto 10 (recursion)");
             rs.FibonacciRecurse(10);
             //myquee implementation
            MyQueue<string> myqueue = new MyQueue<string>();
            var string1 = "Harum unde numquam eaque non. Molestiae sint molestias pariatur maxime. Esse non non molestiae sapiente quas enim occaecati. Voluptas quia vel ratione tempore nisi consequatur. Dolores repellendus nesciunt rerum delectus quia dignissimos.";
            var result = string1.Split(' ');
            foreach(string s in result)
            {
                myqueue.Enqueue(s);
            }
            Console.WriteLine();
            myqueue.Traverse();
            Console.WriteLine();
            Console.WriteLine(myqueue.DeQueue());
            Console.WriteLine(myqueue.DeQueue());
            Console.WriteLine(myqueue.DeQueue());
            myqueue.Traverse();
            //hackerranktest
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Solution.almostSorted(arr);
            */
            /*
            MyQueue<string> s1 = new MyQueue<string>();
            MyQueue<string> s2 = new MyQueue<string>();
            foreach(char c in "abcdef")
                s1.Enqueue(c.ToString());
            foreach(char c in "ghijkl")
                s2.Enqueue(c.ToString());
            s1.Traverse();
            Console.WriteLine();
            s2.Traverse();
            Console.WriteLine();
            Weave w = new Weave();
            var s4= w.WeaveQueue(s1,s2);
            s4.Traverse();
            Console.WriteLine(s4.DeQueue());
            */
            /*
            MyStack<string> myStack =new MyStack<string>();
            foreach(char c in "abcdef")
                myStack.Push(c.ToString());
            myStack.Traverse();
            var c1 = myStack.Pop();
            while(c1!=null)
            {
                Console.WriteLine("popped "+c1);
                c1 = myStack.Pop();
            }*/
            /*
            QueueWitStacks<string> qs = new QueueWitStacks<string>();
            foreach(char c in "abcdef")
            {
                qs.Enqueue(c.ToString());
            }
            Console.WriteLine(qs.Dequeue());
            Console.WriteLine(qs.Dequeue());
            */
            /*
            LinkedList<string> linkedList = new LinkedList<string>();
            foreach(char c in "abcdef")
                linkedList.Add(c.ToString());
            linkedList.Traverse();
            var c1 = linkedList.GetLast();
            Console.WriteLine("node last "+c1.ToString());
            */
            /*
            Trees<string> tree = new Trees<string>("a");
            foreach(var str in "bcdefg")
            {
                tree.Add(str.ToString());
                tree.DFS();
                Console.WriteLine();
            }

            tree.DFS();*/
            Console.WriteLine($"Version: {Environment.Version}");
        }
    }
}
