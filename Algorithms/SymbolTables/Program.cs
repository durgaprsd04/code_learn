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
            //NodeSymbolTables();
            //OrderedSymbolTables();
            BST();
            
        }
        public static void BST()
        {
            Console.WriteLine("Binary Symobl table implementation");
            BST<char,int>  st = new BST<char, int>();
            //Console.WriteLine("Is ST array empty {0}",st.IsEmpty());
        
            Console.WriteLine("Enter String");
            var entry ="helloworldarg"; 
            //Console.ReadLine(); 
            for(int i =0;i<entry.Length;i++)
               st.Add( (char)entry[i],i+1);
            st.Print();
            Console.WriteLine("Mininmum of tree "+st.Min());
            Console.WriteLine("Mininmum of tree "+st.Max());
            Console.WriteLine("Floor of 't' is  "+st.Floor('t'));
            Console.WriteLine("Floor of 'g' is  "+st.Floor('g'));
            Console.WriteLine("Floor of 'x' is  "+st.Floor('x'));

        }

        public static void NodeSymbolTables()
        {
            
            Console.WriteLine("Ordered Symobl table implementation");
            ST  st = new ST();
            //Console.WriteLine("Is ST array empty {0}",st.IsEmpty());
        
            Console.WriteLine("Enter String");
            var entry = Console.ReadLine();
            for(int i =0;i<entry.Length;i++)
               st.Add( (char)entry[i],i+1);
            st.Print();
            Console.WriteLine("After removing h");
            st.Remove('h');
            st.Print();
            Console.WriteLine("Position of k is {0}",st.Search('k'));
            Console.WriteLine("Position of l is {0}",st.Search('l'));
            Console.WriteLine("Size of the ST {0}", st.Size());

        }
        public static void OrderedSymbolTables()
        {
            Console.WriteLine("Ordered Symobl table implementation");
            STArray<char, int> st = new STArray<char,int>();
            Console.WriteLine("Is ST array empty {0}",st.IsEmpty());
        
            Console.WriteLine("Enter String");
            var entry = Console.ReadLine();
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
        }
    }
}
