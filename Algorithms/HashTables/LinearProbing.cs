using System;

namespace HashTables
{
public class LinearNode<T1> where T1:System.IComparable<T1>
    {
        internal T1 value;
        public LinearNode(T1 value)
        {
            this.value=value;
        }
        public override string ToString(){
           return value.ToString();
        }
    }

  public class LinearProbing<T1> where T1:System.IComparable<T1>
    {
        public LinearNode<T1> [] valueArray  ;
        private int size;
        HashGenerator<T1> hashGenerator = new HashGenerator<T1>();
        public LinearProbing(int n)
        {
            size = n;
            valueArray = new LinearNode<T1> [n];
        }
        public void Add(T1 element)
        {
            var hash = hashGenerator.GetHash(element,size);
            var node = new LinearNode<T1>(element);
            Add(node, hash);
        }
        private void Add(LinearNode<T1> node, int hash )
        {
            Console.WriteLine(hash );
            if(valueArray[hash]==null)
                valueArray[hash]=node;
            else
            {
                if(valueArray[hash].value.CompareTo(node.value)==0)
                return;
                var counter = hash +1;
                if(counter>=size)
                    counter = counter - (size);
                Add(node, counter);
            }
        }
        public void Print()
        {
            foreach(var k in valueArray)
            {
                if(k!=null)
                {
                    Console.Write("[{0}]  ", hashGenerator.GetHash( k.value, size));
                }
                
            }
            Console.WriteLine();
            foreach(var k in valueArray)
            {
                if(k!=null)
                {
                    Console.Write("[{0}]  ",  k);
                }
                
            }
        }
    }
}
