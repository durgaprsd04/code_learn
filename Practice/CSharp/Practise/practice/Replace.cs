using System;
using System.Text;
/*

IMplementation of replace in string
*/
public static class Replace
{
    public static string MyReplace(this string str1, string str2, string str3)
    {
        int j=0;
        var sb = new StringBuilder();
        var sb2 = new StringBuilder();
        int count=0;
        for(int i=0;i< str1.Length;i++)
        {
            if(j< str2.Length && str1[i]==str2[j])
            {
                count++;
                j++;
            }
            else
            {
                if(count==str2.Length) 
                    sb.Append(str3);
                else
                    {
                        for(int k=i-count;k<i;k++)
                            sb.Append(str1[k]);
                    }
                count=0;
                j=0;
                sb.Append(str1[i]);
            }
        }
        return sb.ToString();
    }
}