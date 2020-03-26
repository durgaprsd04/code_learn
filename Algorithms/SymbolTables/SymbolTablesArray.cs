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
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("{0}:{1}",keyarray[i].ToString(), valuearray[i].ToString());
            }
        }

        public int CompareTo([AllowNull] T1 other)
        {
            throw new NotImplementedException();
        }
    }
}