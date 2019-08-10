using System;
namespace DesignPatterns
{
    public class Counter
    {
        private static Counter counter;
        int count;
        private Counter(int i)
        {
            count=i;
        }
        public void IncrCount()
        {
            count=count+1;
        }
        public override string ToString()
        {
            return "Count as of now is "+count;
        } 
        public static Counter GetInstance(int i)
        {
            if(counter==null)
            {
                counter=new Counter(i);
                return counter;
            }
            else
            return counter;
        }
    }
}