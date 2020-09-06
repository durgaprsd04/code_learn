using System;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace SymbolTables
{
    public class STArray<T1, T2> where T1 :System.IComparable<T1> 
    {
        private T1 [] keyarray =new T1[1];
        private T2 [] valuearray = new T2[1];
        
        private int size=0;
        public void Add(T1 key, T2 value)
        {
            if(keyarray.Length<=(size+1))
            {
                var limit=keyarray.Length;
                var tempKeyArray = new T1[limit];
                var tempValueArray = new T2[limit];
                for(int i=0;i<limit;i++)
                {
                    tempKeyArray[i]=keyarray[i];
                    tempValueArray[i]=valuearray[i];
                }
                keyarray= new T1[limit*2];
                valuearray = new T2[limit*2];
                for(int i=0;i<limit;i++)
                {
                    keyarray[i]=tempKeyArray[i];
                    valuearray[i]=tempValueArray[i];
                }
            }
            var index= Contains(key);
            if(index!=-1)
                valuearray[index]=value;
            else{
                AddInOrder(key,value);
            }
            
        }
        public T2 Get(T1 key)
        {
            var c = Contains(key);
            if(c==-1)
                return default(T2);
            else
                return valuearray[c];
        }
        public bool ContainsKey(T1 key)
        {
            return (Contains(key)==-1)?false:true;
        }
        public bool IsEmpty()
        {
            return (size==0);
        }
        public int Size()
        {
            return size;
        }
        public T1 MinKey()
        {
            return keyarray[0];
        }
        public T1 MaxKey()
        {
            return keyarray[size];
        }
        public T1 Floor( T1 key)
        {
            int i;
            for(i=0;i<size;i++)
            {
                if(keyarray[i].CompareTo(key)>0)
                    break;
            }
            if(i!=0)
                return keyarray[i-1];
            else 
                return default(T1);
        }
         public T1 Ceil( T1 key)
        {
            int i;
            for(i=0;i<size;i++)
            {
                if(keyarray[i].CompareTo(key)>0)
                    break;
            }
            if(i!=0)
                return keyarray[i];
            else 
                return default(T1);
        }
        public int Rank(T1 key)
        {
            int i;
            for(i=0;i<size;i++)
            {
                if(keyarray[i].CompareTo(key)>0)
                    break;
            }
            return i-1;
        }
        public void DeleteMin()
        {
            for(int i=0;i<size-1;i++)
            {
                keyarray[i]=keyarray[i+1];
                valuearray[i]=valuearray[i+1];
            }
             keyarray[size-1]=default(T1);
            valuearray[size-1]=default(T2);
            size=size-1;
        }
        public void DeleteMax()
        {
            keyarray[size-1]=default(T1);
            valuearray[size-1]=default(T2);
            size = size-1;
        }
        public void Delete(T1 key)
        {
            var index = Contains(key);
            if(index ==-1)
                return;
            for(int i=index;i<size;i++)
            {
                keyarray[i]=keyarray[i+1];
                valuearray[i]=valuearray[i+1];
            }
            keyarray[size-1]=default(T1);
            valuearray[size-1]=default(T2);
            size = size-1;
            //resizing
            if(size<keyarray.Length/4)
            {
                var limit = keyarray.Length/2;
                var tempKeyArray = new T1[limit];
                var tempValueArray = new T2[limit];
                for(int i=0;i<limit;i++)
                {
                    tempKeyArray[i]=keyarray[i];
                    tempValueArray[i]=valuearray[i];
                }
                keyarray = new T1[limit];
                valuearray = new T2[limit];
                for(int i=0;i<limit;i++)
                {
                    keyarray[i]=tempKeyArray[i];
                    valuearray[i]=tempValueArray[i];
                }
            }
        }
        private int Contains(T1 key)
        {
            var index =-1;
            for(int i=0;i<size;i++)
            {
                if(keyarray[i].Equals(key))
                {
                    index=i;
                    break;
                }
            }
            return index;
        }
       
        private void AddInOrder(T1 key, T2 value)
        {
            int i=0;
            for(i=0;i<size;i++)
            {
                if(key.CompareTo(keyarray[i])<=0)
                    break;
            }
             Insert(key, value,i);
            
        }
        private void Insert(T1  key , T2 value, int index)
        {
            //Console.WriteLine("inserting {0} ,{1},{2}",key.ToString(),index,size);
            for(int i=size;i>index;i--)
            {
                //Console.WriteLine("inserting "+i);
                keyarray[i]=keyarray[i-1];
                valuearray[i]=valuearray[i-1];
            }
            keyarray[index]=key;
            valuearray[index]=value;
            size++;
        }
        public void Print()
        {
                Console.WriteLine(string.Join(",", keyarray.Where(a => a.Equals(default(T1))==false).ToArray()));
                Console.WriteLine(string.Join(",", valuearray.Where(a => a.Equals(default(T2))==false).ToArray()));
        }

        public int CompareTo([AllowNull] T1 other)
        {
            throw new NotImplementedException();
        }
    }
}