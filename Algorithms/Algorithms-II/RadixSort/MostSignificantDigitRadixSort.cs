using System;
using System.IO;
using System.Collections.Generic;
namespace RadixSort
{
    class MostSignificantDigitRadixSort
    {
        private const int R=5;
        private string [] aux;
        private const int ALimit=97;
        public void MSD (string [] strings)
        {
          aux = new string [strings.Length];
          Sort(strings,strings.Length, 0, 0);
          //Console.WriteLine("string atter MSD Sort "+string.Join(',',strings));
        }
        public void Sort(string [] strings, int hi, int lo, int index)
        {
          //Console.WriteLine("index is "+index);
          if(lo>=hi)
            return;
          int [] count = new int [R+1];
          var tempCount = new int [R+1];
          for(int i=lo;i<hi;i++)
          {
            //char At has no limits in textbook implementation hence anything more that array size 
            //do not cause any issues
            count[((int)strings[i][index] - (ALimit-1))]++;
          }
          for(int j=0;j<R;j++)
          {
            count[j+1] += count[j];
          }
          tempCount[0]=0;
          for(int j=1;j<R;j++)
            tempCount[j]= count[j];

          //Console.WriteLine("Count "+string.Join(',', count));
          for(int i=lo;i<hi;i++)
          {
            aux[count[((int)strings[i][index] - ALimit)]++] = strings[i];
          }
          for(int i=lo;i<hi;i++)
          {
            strings[i] = aux[i];
          }
          for(int i=index;i<2;i++)
            Sort(strings, tempCount[i+1], tempCount[i],index+1);
        }
      }
  }
