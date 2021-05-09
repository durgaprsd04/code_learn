using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.LinqPractise
{
    public class LinqTest
    {

        public int SumUpto(int n)
        {
            int sum =0;
            for(int i=1;i<=n;i++)
                sum+=i;
         
            return Enumerable.Range(1 , n).Aggregate((sum, n) => sum+n);
            //return sum;
        }
        public IEnumerable<int> GetAllInts(int n)
        {
            for(int i=0;i<n;i++)
            {
                yield return i;
            }
        }
        public IEnumerable<float> MovingSum(IEnumerable<float> n)
        {
           return Enumerable.Range(1 , n.Count()).Select(i => n.Take(i).Aggregate((x,y)=> x+y));
        }
        public IEnumerable<int> Fibonacci(int n)
        { int a=1, b=0,c=0;

            //Enumerable.TakeWhile( b=>)
           
            while(c<n)
            {
                c = a+b;
                b= a;
                a=c;
                yield return b;
            }
        }
        public void Test()
        {
            ArrayList a  = new ArrayList();
            foreach(var v in a)
            {
                Console.WriteLine("A " +a);
            }
        }
        public int [] Test5()
        {
            Dictionary<int,int> dict = new Dictionary<int, int>();
            for(int i=0;i<5;i++)
            {
                dict.Add(i, i*4);
            }
            return dict.Values.Select(x => x).Take(3).ToArray();
        }
        public IEnumerable<int> GetSequence(int n)
        {
            for(int i=1;i<=n;i++)
            {
                yield return GetSequence1(i);
            }
        }
        public int GetSequence1(int n)
        {
            var count=0;
            var backUp = n;
            while(n>0)
            {
                count+=n%2;
                n=n/2;
            }
            if(count==1)
                return backUp;
            else
            {
                if(backUp%2==1)
                    return (int)Math.Pow(2, count-1);
                else
                    return (int)(2*Math.Pow(2,count));
            }
        }
    }
}