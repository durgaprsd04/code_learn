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
            //BST();
            two3BST();
            
        }
        public static void two3BST()
        {
            Console.WriteLine("Binary Search Tree implementation");
            two3Tree<char,int>  st = new two3Tree<char, int>();
            //Console.WriteLine("Is ST array empty {0}",st.IsEmpty());
        
            Console.WriteLine("Enter String");
            var entry ="helodr"; 
            //Console.ReadLine(); 
            for(int i =0;i<entry.Length;i++)
            {
                st.Add( (char)entry[i],i+1);
                //Console.WriteLine("------------------------------------------------------------------");
            }
               
            st.Print();

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
            /*st.Print();
            Console.WriteLine("Mininmum of tree "+st.Min());
            Console.WriteLine("Mininmum of tree "+st.Max());
            Console.WriteLine("Floor of 't' is  "+st.Floor('t').GetKey());
            Console.WriteLine("Floor of 'g' is  "+st.Floor('g').GetKey());
            Console.WriteLine("Floor of 'p' is  "+st.Floor('p').GetKey());
            Console.WriteLine("Floor of 'k' is  "+st.Ceil('k').GetKey());
            Console.WriteLine("Floor of 'f' is  "+st.Ceil('f').GetKey());
            Console.WriteLine("Floor of 'p' is  "+st.Ceil('p').GetKey());
            Console.WriteLine("Size of tree is "+st.Size(st.Floor('p')));
            Console.WriteLine("Rank of 'o' is "+st.Rank('o'));
            Console.WriteLine("Rank of 'r' is "+st.Rank('r'));
            Console.WriteLine("Rank of 'e' is "+st.Rank('e'));
            Console.WriteLine("Rank of 'g' is "+st.Rank('g'));
            Console.WriteLine("BST queue ");
            var c= st.InOrder();
            while(c.Count>0)
            {
                Console.Write(c.Dequeue());
            }
            st.DeleteMin();
            st.Add('a',10);
            */
            st.Add('y', 11);
            st.Add('x', 11);
            st.Add('z', 11);
            Console.WriteLine("------------------------------------------------------------------");
            st.Print();
            Console.WriteLine("------------------------------------------------------------------");
            st.DeleteNode('g');
            st.Print();
            Console.WriteLine("------------------------------------------------------------------");
            st.DeleteNode('r');
            st.Print();
            Console.WriteLine("------------------------------------------------------------------");
            st.DeleteNode('y');
            st.Print();
            Console.WriteLine("------------------------------------------------------------------");
            st.DeleteNode('h');
            st.Print();
            Console.WriteLine("------------------------------------------------------------------");

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
