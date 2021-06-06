using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trie workout!");
            var trie= new Trie();
            trie.Add("hello");
            trie.Add("helloworld");
            trie.Add("hell");
            trie.Add("hilarious");
            trie.Add("hilary");
            trie.Add("hilbert");
            trie.Print();

            Console.WriteLine($"string hell exists in "+trie.LookUp("hell"));
            Console.WriteLine($"string hello exists in "+trie.LookUp("hello"));
            Console.WriteLine($"string hel exists in "+trie.LookUp("hel"));
        }
    }
}
