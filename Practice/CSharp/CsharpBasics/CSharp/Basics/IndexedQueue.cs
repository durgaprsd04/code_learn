using System;
namespace CSharp.Basics
{            
    public class IndexerTest<T>
    {
       private T [] arr = new T[100];
        public T this[int i]
            {
                get { return arr[i]; }
                set { arr[i] = value; }
            }
    }
    public class Queue<T>
    {
        private Node<T> head;
        private int N=0;
        public void  Enqueue(T node)
        {
            head = new Node<T>(node, head);
            N++;
        }
        public T Dequeue()
        {
            T temp =default(T);
            if(head!=null)
            {
                temp = head.val;
                head = head.next;
                N--;
            }
            //Console.ReadKey();
            return temp;
        }
        public void Print()
        {
            for(var temp = head; temp!=null ;temp =temp.next)
                Console.Write(temp.val+"->");
            Console.WriteLine();
        }
        public bool isEmpty()
        {
            return head==null;
        }
    }
    public class IndexedQueue<T>
    {
        private T [] queue;
        private int N;
        public IndexedQueue()
        {
            this.queue = new T[1];
        }
        public void Enqueue(T element)
        {
            if(N+1>queue.Length)
            {
                var temp = new T[queue.Length];
                Array.Copy(queue, temp, queue.Length);
                queue = new T[temp.Length*2];
                Array.Copy(temp, queue, temp.Length);
            }
            queue[N++]= element;
        }
        public T Dequeue()
        {
            T temp = default(T);
            if(N==0)
                return temp;
            temp= queue[--N];

            if(N< queue.Length/2)
            {
                var t = new T[queue.Length];
                Array.Copy(queue, t, queue.Length);
                queue = new T[queue.Length/2];
                Array.Copy(t, queue, queue.Length);
            }
            return temp;
        }
        public bool isEmpty()
        {
            return N==0;
        }
        public T this[int index]
        {
           get { return queue[index]; }
            set { queue[index] = value; }
        }
        public void Print()
        {
            for(int i=0;i<N;i++)
            {
                Console.Write(queue[i]+"->");
            }
            Console.WriteLine();
        }
    }
    
}