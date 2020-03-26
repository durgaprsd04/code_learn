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
            
            //BinarySearchTree bst = new BinarySearchTree();
            STArray<char, int> st = new STArray<char,int>();
        
            /* count positions */
        
            Console.WriteLine("Enter String");
            var entry = "helloworld";//Console.ReadLine();
            for(int i =0;i<entry.Length;i++)
               st.Add( (char)entry[i],i+1);
            st.Print();
            /*
            Console.WriteLine("Search of o is {0}",st.Search('o'));
            Console.WriteLine("Size of the ST is "+ st.Size());
            Console.WriteLine("Removal of o is {0}",st.Remove('o'));
            st.Print();
            Console.WriteLine("Removal of a is {0}",st.Remove('a'));
            st.Print();
            Console.WriteLine("Size of the ST is "+ st.Size());
            var v = st.Keys();
            foreach(var c in v)
            {
                Console.WriteLine(c.ToString());
            }
            */
                //s1.Print();
            /* count occurences */
            /*
            for(int i =0;i<entry.Length;i++)
                    if(s1.HasElement(entry[i].ToString()))
                        s1.Add( entry[i].ToString(),(s1.GetElement(entry[i].ToString())+1));
                    else
                        s1.Add( entry[i].ToString(),1);
             */
            //for(int i =0;i<entry.Length;i++)
              //  {
                //bst.Add(entry[i].ToString());
                //}
            //bst.Print();
        }
    }
}
