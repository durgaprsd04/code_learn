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
            Console.WriteLine("Is ST array empty {0}",st.IsEmpty());
            /* count positions */
        
            Console.WriteLine("Enter String");
            var entry = "helliworld";//Console.ReadLine();
            for(int i =0;i<entry.Length;i++)
               st.Add( (char)entry[i],i+1);
            st.Print();

            Console.WriteLine("Is ST array empty {0}",st.IsEmpty());
            Console.WriteLine("Value of o is {0}",st.Get('o'));
            Console.WriteLine("Value of o is {0}",st.Get('z'));
            Console.WriteLine("The key z is {0}",st.ContainsKey('z'));
            Console.WriteLine("The floor of k is {0}",st.Floor('k'));
            Console.WriteLine("The ceil of  k {0}",st.Ceil('k'));
            st.DeleteMin();
            Console.WriteLine("After delete min");
            st.Print();
            st.DeleteMax();
            Console.WriteLine("after delete max");
            st.Print();
            Console.WriteLine("After deleting 'i'");
            st.Delete('i');
            st.Print();
            st.Delete('l');
            st.Delete('o');
            st.Print();
            /*
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
