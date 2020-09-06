using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class LetterComb
    {
 public IList<string> LetterCombinations(string digits) {
          if(string.IsNullOrWhiteSpace(digits))
            return new List<string>();
          var dict = new Dictionary<string, string>{{"2","abc"}, {"3","def"}, {"4","ghi"}, {"5","jkl"},{"6","mno"},{"7","pqrs"},{"8","tuv"},{"9","wxyz"}};
          IList<string> listOfChars = new List<string>();
          var digitArray = digits.ToCharArray();
          var len = digitArray.Length;
          IList<string> list1 = new List<string>();
          foreach(char c in dict[digitArray[0].ToString()].ToCharArray())
              list1.Add(c.ToString());
          for(int i=1;i<len;i++)
          {
            foreach(char c in dict[digitArray[i].ToString()])
            {
              List<string> list2 = new List<string>();
              foreach(string s in list1.Where(x => x.Length>=1 && x.Length<=(len-1)  ))
              {
                  if(!AnyChar(s, dict[digitArray[i].ToString()]))
                      list2.Add(s+c.ToString());
              }
              foreach(string l in list2)
                if(!list1.Contains(l))
                    list1.Add(l);
            }
            foreach(char c in dict[digitArray[i].ToString()])
            {
              list1.Add(c.ToString());
            }

          }
            return list1.Where(x=> x.Length==len).ToList();
    }
      public bool AnyChar(string s1, string s2){
        var flag=false;
        foreach(char c1 in s1)
          if(s2.Contains(c1))
              {
                flag=true;
                break;
              }
        return flag;
      }

    }
}
