using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class VersionComparer
    {
        public int CompareVersion(string version1, string version2) 
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');
           
            var res =0;
            var len  = v1.Length>v2.Length?v1.Length:v2.Length;
            for(int i=0;i<len;i++)
            {
                var  a = i>=v1.Length?0: Convert.ToInt32(v1[i]);
                var b = i>=v2.Length?0:Convert.ToInt32(v2[i]);
                if(a>b)
                {
                    res =1;
                    break;
                }
                else if(b>a)
                {
                    res =-1;
                    break;
                }
                else
                {
                    res =0;
                }
            }
            return res;
        }
    }
}