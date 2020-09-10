using System;
using System.Linq;
namespace RadixSort
{
  public class KeyIndexCount
    {
      public string KeyIndexCounting(string input)
      {
        //upto f so used 6 can use 255.
        //Aindex also like that
        var R=6;
        var AIndex = 97;
        var array = new int [R+1];
        var inputArray = input.ToCharArray();
        var charArray = new char [input.Length];
        for(int i=0;i<inputArray.Length;i++)
        {
            array[((int)inputArray[i]-(AIndex-1))]++;
        }
        for(int i=0;i<R;i++)
        {
            array[i+1] += array[i];
        }
        for(int i=0;i<inputArray.Length;i++)
        {
            charArray[array[(int)inputArray[i]-AIndex]++] = inputArray[i];
        }
        return string.Join("", charArray);
      }
    }
}
