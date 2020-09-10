using System;
using System.Linq;
namespace RadixSort
{
  public class LowestRadixSort
  {
        public void LowestRadixSortFunc(string [] lsdInput)
        {
          //the input is having keys upto n,
          //we are using upto 'e' so using only 5 for the index array
          //you can use upto 255 also
          int R=5;
          int N=2;//LSD length;
          var aux = new string [lsdInput.Length];
          var AIndex =97;
          for(int i=N;i>=0;i--)
          {
            var count = new int [R+1];
            for(int j=0;j<lsdInput.Length;j++)
            {
                count[(int)lsdInput[j][i]-(AIndex-1)]++;
            }
            for(int r=0;r<R;r++)
            {
                count[r+1]+=count[r];
            }
            for(int j=0;j<lsdInput.Length;j++)
            {
              aux[count[(int)lsdInput[j][i]-AIndex]++] = lsdInput[j];
            }
            for(int j=0;j<lsdInput.Length;j++)
            {
                lsdInput[j]=aux[j];
            }
          }
        }
  }
}
