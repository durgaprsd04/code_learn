using System;
using System.IO;
using System.Collections.Generic;
namespace RadixSort
{
    class ThreeWayQuickSort
    {
        public void Sort(string [] strings)
        {
          Sort(strings, 0, 0, strings.Length);
        }

        public void Sort(string [] strings, int index, int lo, int hi)
        {
          int i=lo+1;
          int lt =lo;
          int gt = hi-1;
          char t;
          if(lo>=strings.Length)
            return;
          if(index < strings[lo].Length)
            t = strings[lo][index];
          else
            return;
          if(lt>=gt)
            return;
          while(lt<gt && i<hi)
          {
            var v = strings[i][index];
            if(v<t) exchange(strings, lt++, i++);
            else if (v>t)exchange(strings, gt--,i);
            else i++;
          }
          Console.WriteLine($"lo {lo} lt {lt} gt {gt} hi {hi} index {index}");
          Console.WriteLine("array "+string.Join(',',strings));
          Sort(strings, index+1, lo, lt);
          if(lt<=gt) Sort(strings, index+1, lt+1, gt);
          Sort(strings, index+1, gt+1,hi);
        }
        public void exchange(string [] strings, int i, int j)
        {
          var swap = strings[i];
          strings[i]= strings[j];
          strings[j] = swap;
        }
    }
}
