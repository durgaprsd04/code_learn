using System;
using System.Reflection;
using System.Text;
namespace CSharp.Advanced
{
    public class SpanTest
    {
        public  string TestSpan(int n, int start, int length)
        {
            var  arr= new int[n];
            for(int i=0;i<n;i++)
                arr[i] =i+1;
            Span<int> span = arr;
            var sliced  = span.Slice(start: start , length:length);
            var sb = new StringBuilder();
            foreach (var slice in sliced)
            {
                sb.Append(slice);
            }
            return sb.ToString();
        }
    }
}