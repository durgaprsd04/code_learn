using System;
namespace Sorts
{
    class Merge_Sort
    {
        private int [] a;
        public void Sort(int [] array, int [] auxarray, int lo, int hi)
        {
            var mid = lo +(hi-lo)/2 ;
            if(lo>=hi)
                return;
            Sort(array,auxarray, lo, mid);
            Sort(array, auxarray, mid+1, hi);
            Merge(array,auxarray, lo, mid ,hi );
            //Console.WriteLine("Main array");
            //Print(array);
            //Console.WriteLine("Aux array ");
            //Print(auxarray);
        }
        public void Print()
        {
            Console.WriteLine(string.Join(',', a));
        }
        public void Merge(int [] a, int [] aux, int lo,int mid, int high)
        {
            int i = lo, j = mid+1;
            //Console.WriteLine("low {0}, mid{1}, high{2}",lo, mid, high);
            for(int k=lo;k<=high;k++)
            { 
                if    (i>mid)                   aux[k]=a[j++]; ///Console.WriteLine(" 1low {0}, mid{1}, high{2}",i, j, k);Print(aux);}
                else if(j>high)                 aux[k]=a[i++]; //Console.WriteLine(" 2low {0}, mid{1}, high{2}",i, j, k);Print(aux);}
                else if   (less(a[j], a[i]))    aux[k]=a[j++]; //Console.WriteLine("3low {0}, mid{1}, high{2}",i, j, k);Print(aux);}
                else                            aux[k]=a[i++]; //Console.WriteLine("4low {0}, mid{1}, high{2}",i, j, k);Print(aux);}
                
            }
            
            for(int i1=lo;i1<=high;i1++)
                a[i1]=aux[i1];
            //Console.WriteLine("___");    
            //Print(aux);
            //Console.WriteLine("___");
            //Print(a);
        }
        public void Sort(int [] array)
        {
            a = new int [array.Length];
            for(int i =0;i<array.Length;i++)
                a[i]=array[i];
            var high=array.Length;
            int [] aux = new int [high];
            for(var i=0;i<high;i++)
                aux[i]=array[i];
            Sort(a, aux, 0, high-1);
        }
        public bool less(int a, int b)
        {
            return a<b;  
        }
    }
}