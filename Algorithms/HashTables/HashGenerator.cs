using System;
public class HashGenerator<T1>
{
    public  int GetHash(T1 value, int n)
    {
        if(n!=0)
            return (value.GetHashCode()& 0x7fffffff) %n;
        else return -1;
    }
}