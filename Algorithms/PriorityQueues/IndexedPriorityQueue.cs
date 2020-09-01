using System;
using System.Linq;
namespace PriorityQueues
{
  public class IndexedPriorityQueue<T> where T:IComparable<T>
  {
      private int Size=1;
      private Node<T> [] indexedArray;
      class Node<T1>
      {
        private int key;
        private T1 value;
        public Node(int key, T1 value)
        {
          this.key =key;
          this.value=value;
        }
        public int Key => key;
        public T1 Value => value;
        public override string ToString() => $"{key}:{value}";
      }
      public IndexedPriorityQueue(int N)
      {
        indexedArray = new Node<T> [N + 1];
        Size=1;
      }
      private int IsKeyAdded(int n)
      {
        int i=1;bool keyExists=false;
        for( i=1;i<=Size;i++)
        {
          if(indexedArray[i]?.Key == n)
          {
            keyExists=true;
            break;
          }
        }
        if(keyExists)
          return i;
        else return -1;
      }
      public void Add(int n, T element)
      {
        var t = IsKeyAdded(n);
        var index = t==-1?Size:t;
        //Console.WriteLine($"index {index} Size {Size} t {t} n {n} ");
        indexedArray [index] = new Node<T>(n,element);
        if(t==-1)
          Size++;
        if(Size>=indexedArray.Length-1)
        {
          //Console.WriteLine($"Resizing at {Size}");
          var temp = new Node<T> [Size+1];
          for(int i=1;i<indexedArray.Length;i++)
          {
            temp[i] = indexedArray[i];
          }
          indexedArray = new Node<T> [(indexedArray.Length)*2+1];
          for(int i=1;i<temp.Length;i++)
          {
            indexedArray[i] = temp[i];
          }
        }
        Sort();
      }
      private void Sort()
      {
         for(int k=Size/2;k>=1;k--)
         {
            //Console.WriteLine($"sink {k} {Size}");
            Sink(k,Size);
         }
      }
      private void Sink(int n,int limit)
      {
            int largerindex=0;
            var flag=false;
            if(2*n >=limit)
                return;
            if((2*n+1)>=limit)
            {
                if(indexedArray[2*n].Key < indexedArray[n].Key)
                    {
                        largerindex=2*n;
                        Swap(largerindex,n);
                        return;
                    }
                return;
            }
            if((indexedArray[2*n+1].Key < indexedArray[n].Key)  || (indexedArray[2*n].Key < indexedArray[n].Key))
            {
                largerindex = indexedArray[2*n+1].Key< indexedArray[n].Key?2*n+1:2*n;
                Swap(largerindex, n);
                flag=true;
            }
            if(!flag)
                return;
            Sink(largerindex, limit);
      }

      public T DeleteMin()
      {
        Swap(1,Size-1);
        var returnChar = indexedArray[--Size].Value ;
        if(Size<= indexedArray.Length/4)
        {
           var temp = new Node<T> [Size+1];
          for(int i=0;i<indexedArray.Length ;i++)
          {
            temp[i] = indexedArray[i];
          }
          indexedArray = new Node<T> [(indexedArray.Length)/2];
          for(int i=0;i<temp.Length;i++)
          {
            indexedArray[i] = temp[i];
          }
        }
        Sort();
        return returnChar;
      }
      private void Swap(int i, int j)
      {
        var swap = indexedArray[i];
        indexedArray[i]=indexedArray[j];
        indexedArray[j]=swap;
      }
      public void Print()
      {
        for(int i =1 ;i<Size;i++)
          Console.Write(indexedArray[i]+" ");
        Console.WriteLine();
      }
    }
}
