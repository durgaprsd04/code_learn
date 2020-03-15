using System;

namespace SymbolTables
{
    /* define symbol table
    put, get, delete, contains, isempty, size, keys,
    should look like ST<key value>
    should be generic
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            BinarySearchTree bst = new BinarySearchTree();

            /* count positions */
        
            Console.WriteLine("Enter String");
            var entry = Console.ReadLine();
            //for(int i =0;i<entry.Length;i++)
            //    s1.Add( entry[i].ToString(),i);
            //s1.Print();
            /* count occurences */
            /*
            for(int i =0;i<entry.Length;i++)
                    if(s1.HasElement(entry[i].ToString()))
                        s1.Add( entry[i].ToString(),(s1.GetElement(entry[i].ToString())+1));
                    else
                        s1.Add( entry[i].ToString(),1);
             */
            for(int i =0;i<entry.Length;i++)
                {
                bst.Add(entry[i].ToString());
                }
            bst.Print();
        }
    }
}
