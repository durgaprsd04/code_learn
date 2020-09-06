using System;
namespace Sorts
{
    //does not work for non powers of 2
    ///refer text book for code
    class Merge_Sort_bottomUP
    {
       
        int N ;
        int [] a;
        int [] aux;
        public void Sort(int [] array)
        {
           
             a = new int [array.Length];
             aux = new int[array.Length];
            for(int i =0;i<array.Length;i++)
            {  
                  a[i]=array[i];
                   aux[i]=array[i];
            }
            N  = array.Length;
            //Print();
            for(int i=2;i<=N;i=i+i)
            {
                for(int j =0;j<N;j=j+i)
                {
                    var mid = j+i/2;
                    var hi = ((j+i/2)>=N)?N:j+i;
                    Merge(a, aux,j,mid, hi);
                }
            }
        }
        public void Merge(int [] array, int [] aux, int lo , int mid, int high)
        {
            int i = lo, j = mid;
            var N = array.Length;
            Console.WriteLine("low {0}, mid{1}, high{2}",lo, mid, high);
            for(int k=lo;k<high;k++)
            { 
               if    (i>=mid)                    {aux[k]=a[j++]; //Console.WriteLine(" 1low {0}, mid{1}, high{2}",i, j, k);
               }
                else if(j>=high)                 {aux[k]=a[i++]; //Console.WriteLine(" 2low {0}, mid{1}, high{2}",i, j, k);
                }
                else if   (less(a[j], a[i]))    {aux[k]=a[j++]; //Console.WriteLine("3low {0}, mid{1}, high{2}",i, j, k);
                }
                else                            {aux[k]=a[i++]; ///Console.WriteLine("4low {0}, mid{1}, high{2}",i, j, k);
                }
                
            }
            
            for(int i1=lo;i1<high;i1++)
                a[i1]=aux[i1];
            Print();
        } 
         public bool less(int a, int b)
        {
            return a<b;  
        }
        public void Print()
        {
            Console.WriteLine(string.Join(',', a));
        }
        public void swap(int l, int m)
        {
             var k = a[l];
             a[l]=a[m];
             a[m]=k;
        }
        
    }
}