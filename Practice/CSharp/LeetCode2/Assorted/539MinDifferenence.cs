using System;

namespace LeetCode2
{

    public class Time24 :IComparable<Time24>
    {
        private int hr;
        private int min;
        public Time24(string s)
        {
            var time = s.Split(":");
            hr = Convert.ToInt32(time[0]);
            min = Convert.ToInt32(time[1]);
        }

        public int CompareTo(Time24 other)
        {
            if(this.hr-other.hr!=0)
                return this.hr -other.hr;
            else
                return this.min - other.min;
        }
        public override string ToString()
        {
            return string.Format("{0:00}", hr)+":"+string.Format("{0:00}", min);
        }
        public int GetDiff(Time24 other)
        {
            return (this.hr-other.hr)*60 + (this.min-other.min);
        }
    }
}