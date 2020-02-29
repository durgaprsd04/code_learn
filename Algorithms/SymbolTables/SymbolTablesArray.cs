using System;
namespace SymbolTables
{
public class STNew<T1,T2>
{

    private const int INIT_COUNT=1;
    ArrayHelper<T1> t1 = new ArrayHelper<T1>();
    ArrayHelper<T2> t2 = new ArrayHelper<T2>();

    private T1 [] t1Array = new T1[INIT_COUNT];
    private T2 [] t2Array = new T2 [INIT_COUNT];
    private int count=0;

    public void Add(T1 a, T2 b)
    {
        if(count >= t1Array.Length)
        {
            T1 [] t1ArrayNew = new T1[4*count];
            for(int i=0;i<t1Array.Length;i++)
            {
                t1ArrayNew[i]=t1Array[i];
            }
            t1Array= t1ArrayNew;
            T2 [] t2ArrayNew = new T2[4*count];
            for(int i=0;i<t2Array.Length;i++)
            {
                t2ArrayNew[i]=t2Array[i];
            }
            t2Array= t2ArrayNew;
        }
        int c=-1;
        if(count>=1){ c= t1.HasElement(t1Array, a);}
        if(c==-1)
        {
            t1Array[count]=a;
            t2Array[count]=b;
            count++;
        }
        else
        {
            //Console.WriteLine(c);
            t2Array[c]=b;   
        }
        
    }
    public bool HasElement(T1 a)
    {
        Console.WriteLine(t1.HasElement(t1Array, a));
        return t1.HasElement(t1Array, a)!=-1?true:false;
    }
    public T2 GetElement(T1 a)
    {
        var c1=t1.HasElement(t1Array, a);
        if(c1!=-1)
            return t2Array [c1];
        else
            return default(T2);
    }
    public void Print()
    {
        for(int i=0;i<count;i++)
        {
            Console.WriteLine("{0} : {1}",t1Array[i],t2Array[i]);
        }
    }
    public void Remove(T1 a)
    {
        int i;
        for( i=0;i<t1Array.Length;i++)
            if(t1Array[i].Equals(a))
                break;
        
        t1.RemoveAt(t1Array, i);
        t2.RemoveAt(t2Array,i);
        count--;
        /* if(count<t1Array.Length/4)
        {
            T1 [] t1ArrayNew = new T1[4*count];
            for(int i=0;i<t1Array.Length;i++)
            {
                t1ArrayNew[i]=t1Array[i];
            }
            t1Array= t1ArrayNew;
            T2 [] t2ArrayNew = new T2[4*count];
            for(int i=0;i<t2Array.Length;i++)
            {
                t2ArrayNew[i]=t2Array[i];
            }
            t2Array= t2ArrayNew;
        } */
        
    }   
}
public class ArrayHelper<T3>
{
    public  void  RemoveAt(T3 [] a, int i)
    {
        T3 [] a1 = new T3 [i];
        for(int j=0;j<a.Length;j++)
            if(i!=j)
                a1[j]=a[j];   
        a=a1;
    }
    public int HasElement(T3 [] a, T3 j)
    {
        //Console.WriteLine(a.Length);
        int i;
        for( i=0;i<a.Length;i++)
        {
            if(a[i]==null)
            {
                i=-1;
                break;
            }
            if(a[i].Equals(j))
                break;
        }
        if(i<a.Length)
            return i;
        else
            return -1;
    }
}

}