using System;
using System.Collections.Generic;
using System.Linq;
namespace SymbolTables
{
public class ST<T1,T2>
{
    private class SingleST<T3,T4>
    {
        private T3 key;
        private T4 value;
        public SingleST(T3 key, T4 value)
        {
            this.key=key;
            this.value=value;
        }
        public string Print()
        {
            return key.ToString() +" : "+value.ToString();
        }
        public  T4 GetValue()
        {
            return this.value;
        }
    }
    private  Dictionary<T1,SingleST<T1, T2>> DictOfST;
    private List<T1> listOfSTKeys;
    
    public ST()
    {
        DictOfST = new  Dictionary<T1,SingleST<T1, T2>>();
        listOfSTKeys = new List<T1>();

    }
    public void Add(T1 a, T2 b)
    {
        if(listOfSTKeys.Contains(a))
        {
            DictOfST[a]= new SingleST<T1,T2>(a,b);
        }
        else
        {
         DictOfST.Add(a,new SingleST<T1, T2>(a,b));
         listOfSTKeys.Add(a);   
        }
    }
    public void Print()
    {
        foreach(var s in DictOfST)
        {
            Console.WriteLine(s.Value.Print());
        }
    }
    public bool HasElement(T1 a)
    {
        return listOfSTKeys.Contains(a);
    }
    public T2 GetElement(T1 a)
    {
        return DictOfST[a].GetValue();

    }
}
}