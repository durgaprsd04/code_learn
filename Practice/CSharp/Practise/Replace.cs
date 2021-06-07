using System;
using System.Text;
/*

IMplementation of replace in string
*/
namespace Practise
{
public static class Replace
{
    public static string MyReplace(this string str1, string str2 )
    {
        int j=0;
        var sb = new StringBuilder();
        var sb2 = new StringBuilder();
        var i=0;
        while(i<str1.Length)
        {
            if(str2[j]==str1[i])
            {
                sb2.Append(str2[j++]);
            }
            else
            {
                if(sb2.Length>0)
                {
                    if(sb2.Length!=str2.Length)
                    {
                        sb2.Clear();
                        i = i-j;
                    }
                    else
                    {
                        sb.Append(sb2.ToString());
                        sb2.Clear();
                        j=0;
                    }
                }
                else
                    sb.Append(str1[i]);
            }
        }
        return sb.ToString();
    }
}
}