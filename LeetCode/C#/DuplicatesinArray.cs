using System;
using System.IO;
using System.Collections.Generic;
namespace LeetCode
{
    public class DuplicatesInArray
    {
          public bool ContainsDuplicate(int[] nums) 
          {
              var flag =false;
              HashSet<int> hs = new HashSet<int>();
              foreach(var v in nums)
              {
                  if(!hs.Contains(v))
                    {   
                        hs.Add(v);                       
                       
                    }
                    else
                    {
                         flag =true;
                          break;
                    }
              }
              return flag;
          }
    }
}