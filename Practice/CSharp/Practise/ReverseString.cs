using System;
using System.Collections.Generic;
using System.Collections;
namespace Practise
{
    public class Operations
    {
        private static List<int> fiblist = new List<int>();
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
                var cosComponent=(int)(1*radius*Math.Cos((Math.PI/180.0)*(-90.0+(double)i*resolution)));
                if(i==0)
                    continue;
                Console.WriteLine(new string(' ',radius-cosComponent)+"#"+new string(' ',2*cosComponent)+"#");
            }
        }
        public string CapitalizeFirst(string s)
        {
            //better capitalize chars which are after space.
            var stringarray = s.Split(' ');
            for(int i=0;i<stringarray.Length;i++)
            {
                stringarray[i] = stringarray[i].Replace(stringarray[i][0],stringarray[i][0].ToString().ToUpperInvariant().ToCharArray()[0]);
            }
            return string.Join(' ', stringarray );
        }
        public void Steps(int n, int i)
        {
            //column less than  row
            if(i==0)
                return;
            
            Console.WriteLine("'"+new string('#',n-i+1)+new string(' ',i-1)+"'");
            Steps(n, i-1);
        }
        public void Pyramid(int n, int i)
        {
            //column less than  row
            if(i==0)
                return;
            
            Console.WriteLine("'"+new string(' ',i-1)+new string('#',2*(n-i)+1)+new string(' ',i-1)+"'");
            Pyramid(n, i-1);
        }
        public int FindVowels(string s)
        {
            //regex matching.
            List<char> vowels = new List<char>{'a','e','i','o','u'};
            int count=0;
            foreach(char c in s)
            {
                if(vowels.Contains(c))
                count++;
            }
            return count;
        }
        public void PrintSpiralMatrix(int n)
        {
            int [,] a = new int [n,n];
            int maxLimit=n;
            int minLimit=0;
            bool jIncrement=true, jDecrement=false, iIncrement=false, iDecrement=false;
            int i=0,j=0,k=0;
            while(k<=n*n-1)
            {
                a[i,j]=++k;
                Console.WriteLine($"Inserting into {i} postion  {j} with k value {k}");
                if(i==1 &&j==2)
                {
                  Console.WriteLine("max limit "+maxLimit);
                  //break;
                }
                if(jIncrement)
                    j++;
                if(jDecrement)
                    j--;
                if(iIncrement)
                    i++;
                if(iDecrement)
                  i--;
                if(j+1>=maxLimit){jIncrement=false; iIncrement=true;}
                if(iIncrement&& i+1>=maxLimit){iIncrement=false;}
                if(!iIncrement && !jIncrement&&!jDecrement &&!iDecrement ){jDecrement=true; maxLimit--;}
                if(jDecrement&&j<=minLimit){jDecrement=false;iDecrement=true; minLimit++; }
                if(iDecrement&&i<=minLimit){iDecrement=false;jIncrement=true;}
           }
            PrintArray(a, n);
        }
        public void PrintArray(int [,] a, int n)
        {
            for(int i=0;i<n;i++)
             {  
                Console.WriteLine();  
                Console.Write("[");
                for(int j=0;j<n;j++)
                {
                    Console.Write(" "+a[i,j]+" ");
                }
                Console.Write("]");
             }
        }
        public List<int> Fibonacci(int n)
        {
            int first=0, second=1;
            List<int> fib = new List<int>{first, second};
            var counter=2;
            while(counter<=n)
            {
                var temp = second;
                second = first +second;
                first = temp;
                fib.Add(second);
                counter++;
            }
            return fib;
        }
        public void FibonacciRecurse(int n)
        {
            var v = fib(n);
            //Console.WriteLine("nth fibonacci is "+string.Join(',',fiblist.ToArray()));
            Console.Write("nth fibonacci is "+v);
        }
        private int fib(int n)
        {
            //you can use memoization.
            if(n<2)
            {
                //Console.WriteLine(n+",");
               //fiblist.Add(0);
                return n;                
            }                
            var v= fib(n-2)+fib(n-1);
            //Console.Write(v+",");
            //fiblist.Add(v);
            return v;
        }
        public bool isAnagram(string a, string b)
        {
            //sorting strings are easier
            var dict1 = GetCharDict(a);
            var dict2 = GetCharDict(b);
            var isAnagramString =false;
            if(dict1.Count!=dict2.Count)
            {
                return false;
            }
                
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
