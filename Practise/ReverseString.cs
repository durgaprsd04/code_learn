using System;
using System.Collections.Generic;
namespace Practise
{
    public class Operations
    {
        public string reverse(string s)
        {
            char [] stringArray = s.ToCharArray();
            var length = stringArray.Length;
            for(int i =0;i< length/2;i++)
            {                
                var temp =stringArray[i];
                stringArray[i]= stringArray[ length-i-1];
                stringArray[length-i-1] = temp;               
            }
            return new string(stringArray);
        }
        public bool isPaliendrome(string s)
        {
            return reverse(s)==s;
        }
        public  long reverseInt(long digit)
        {
            long c= digit;
            long element=0;
            while(c>0)
            {
                var c1 = c%10;
                element = element*10+ c1;
                c/=10;
            }
            return element;
        }
        public void FizzBuzz(int n)
        {
            for(int i=1;i<=n;i++)
            {
                if((i%3==0)&&(i%5==0))
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i%3==0)
                {
                     Console.Write("Fizz ");
                }
                 else if (i%5==0)
                {
                     Console.Write("Buzz ");
                }
                else{
                    Console.Write(i+" ");
                }
            }
        }
        public char MaxChars(string s)
        {
            var charArray = s.ToCharArray();
            char [] array1 = new char[charArray.Length];
            int [] array2 = new int[charArray.Length];
            var arrayOperations1 = new ArrayOperations();
           
            int i=0;
            foreach(char c in charArray) 
            {
                var index =arrayOperations1.HasElement(array1,c);
                if(index==-1)
                    {
                        array1[i] =c;
                        array2[i]=1;
                        i++;
                    }
                else{
                    array2[index]++;
                }
            }
            //Console.WriteLine("array 1 "+string.Join(',', array1));
            //Console.WriteLine("array 1 "+string.Join(',', array2));
            return array1[arrayOperations1.Max(array2, true)];
        }
        public void DrawCircle(int radius)
        {
            var resolution = 180.0/(2*radius);
            for(int i=0;i<2*radius;i++)
            {
                Console.WriteLine(new string(' ',radius)+"#"+new string(' ',(int)(1*radius*Math.Cos((Math.PI/180.0)*(-90.0+(double)i*resolution))))+"#");
            }
        }
        public bool isAnagram(string a, string b)
        {
            var dict1 = GetCharDict(a);
            var dict2 = GetCharDict(b);
            var isAnagramString =false;
            foreach(var key in dict1.Keys)
            {
                if(dict2.ContainsKey(key))
                {
                    if(dict2[key]==dict1[key])
                        isAnagramString=true;
                    else
                    {
                        isAnagramString=false;
                        break;
                    }
                        
                }
                else
                {
                     isAnagramString=false;
                        break;    
                }
            }
            return isAnagramString;
        }
        private Dictionary<char,int> GetCharDict(string a)
        {
            Dictionary<char,int> charDict = new Dictionary<char, int>();
            foreach(char c in a)
            {
                if(!charDict.ContainsKey(c))
                {
                    charDict.Add(c,1);
                }
                else
                {
                    charDict[c]++;
                }
            }
            return charDict;
        }
        public void ChunkSize(int [] array, int size)
        {
            List<List<int>> listofArrrays = new List<List<int>>();
            int i=0;
            List<int> minorList = new List<int>();
            foreach(var v in array)
            {
                minorList.Add(v);
                i++;               
                if(i>=size)
                {
                    i=0;
                    listofArrrays.Add(minorList);
                    minorList=new List<int>();                   
                }
            }
            listofArrrays.Add(minorList);
            Console.Write("[");
            foreach(var list in listofArrrays)
            {
                Console.Write("["+ string.Join(",", list)+"]");
            }
            Console.Write("]");
           
        }
        
    }
    public class ArrayOperations
    {
        public int HasElement(char [] array, char element)
        {   
            int i=0;
            foreach(var e in array)
            {
                if(e==element)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public int Max(int [] array, bool isIndex)
        {   
            int max=array[0], index=0;
            for(int i =1;i<array.Length;i++)
            {
                if(max<array[i])
                {
                   max=array[i];
                   index=i;
                }               
            }
            if(isIndex)
                return index;
            else 
                return max;
        }
    }
}
