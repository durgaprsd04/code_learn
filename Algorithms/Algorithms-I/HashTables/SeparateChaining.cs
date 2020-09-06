using System;

namespace HashTables
{
    public class Node<T1> where T1:System.IComparable<T1>
    {
        internal T1 value;
        internal Node<T1> next;
        public Node(T1 value)
        {
            this.value = value;
        }
        public override string ToString(){
           return value.ToString();
        }
    }
    public class SeparateChaining<T1> where T1:System.IComparable<T1>
    {
        public Node<T1> [] valueArray  ;
        private int size;
        HashGenerator<T1> hashGenerator = new HashGenerator<T1>();
        public SeparateChaining(int n)
        {
            size = n;
            valueArray = new Node<T1> [n];
        }
        public void Add (T1 element)
        {
            var hash = hashGenerator.GetHash(element, size);
            valueArray[hash] = Add( valueArray[hash] , element);
        }
        private Node<T1> Add(Node<T1> elementNode , T1 element)
        {  
            if(elementNode==null)
            {
                elementNode = new Node<T1>(element);
                return elementNode;
            }
            else{
                if(elementNode.value.CompareTo( element)==0)
                    return elementNode;
                elementNode.next= Add(elementNode.next, element);

                return elementNode;

            }
                
        }
        public void Print()
        {
            foreach(var element in valueArray)
            {

                if(element!=null)
                    {
                        Console.Write(element);
                        PrintNode(element.next);
                        Console.WriteLine();
                    }
            }
        }
        private void PrintNode(Node<T1> node)
        {
            if(node!=null)
            {
                Console.Write("-> "+node);
                PrintNode(node.next);
            }
        }
        
    }
}
