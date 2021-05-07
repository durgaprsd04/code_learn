using System;
using System.Text;
using System.Collections;
using  System.IO;
using System.Linq;
namespace interview2
{
    public class Listnode
{
        public int val;
        public Listnode next;
        public Listnode(int val, Listnode node)

        {
            this.val = val;
            this.next = node;
        }
}

    public class Interview2
    {
        public (int carry, Listnode result) Sum(Listnode l1, Listnode l2)
        {
            //var num = l1?l1.val?0;
            //4->
            //846
            //268
           if(l1.next==null && l2.next==null)
           {
               var sum = l1.val+l2.val;
               var carry = sum/10;
                return (carry,new Listnode(sum%10, null));
           }
           else
           {
               var result = Sum(l1.next, l2.next);
               var sum = l1.val + l2.val+result.carry;
               var carry  = sum/10;
               sum = sum%10;
               return (carry, new Listnode(sum,result.result));
           }
        }
         public int PartionArray(int [] arr)
        {
            // 2 3 4 1  4  5
            // 2 5 9 10 14 19

           //prefix[k] = sum (arr[0] ... arr[k])
           //prefix[n-1]- prefix[k]  ==  prefix[k-1]
            var prefix = new int [arr.Length];
            prefix[0] = arr[0];
            for(int i =1;i<arr.Length;i++)
            {
                prefix[i] = prefix[i-1]+ arr[i];
            }
            var flag =false;
            var index =0;
            for(int i=1;i<arr.Length;i++)
            {
                if(prefix[arr.Length-1]- prefix[i]  ==  prefix[i-1])
                {
                    index=i;
                    flag=true;
                }
            }
            if(flag)
            return index;
            else
            return -1;
        }    
         public void SumofTwoNumber()
        {
            var sr = new StreamReader("a.txt");
            var num1 = sr.ReadLine();
            var sr2 = new StreamReader("b.txt");
            var num2 = sr2.ReadLine();
            //9877896

            //67987
            var len1 = num1.Length;
            var len2 = num2.Length;
            var max = len1>len2? len1:len2;
            var rem =0;
            var sum=0;
            var sb = new StringBuilder();
            for(int i=0;i<max;i++)
            {
                var digit1=0;
                if(len1-i-1>0)
                    digit1 = Convert.ToInt32(num1[len1-i-1].ToString());
                var digit2 =0;
                if(len2-i-1>0)
                    digit2 = Convert.ToInt32(num1[len2-i-1].ToString());
                sum = digit1+digit2+rem;
                
                rem = sum/10;//1
                sum = sum%10;//3
                sb.Append(sum);
            }
           using( var sr3 =new  StreamWriter("c.txt"))
           {
            sr3.Write(sb.ToString().Reverse());
            sr3.Close();
           }
        }
    }


      


       


    /*
    ID	Name	Dept	Salary
1	A	   Finance	 25000
2	B	  Finance	 10000
3	C	  Finance	 5000
4	D	  Accounts	 2000
5	E	  Accounts	 1000
6	F	  IT	     500000
7	G	  IT	     3000
*/

/*

select row_number( over order by  salary)  as id, Salary , name
from Salaries 
where id =3


*/
} 