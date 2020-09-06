using System;
using System.Collections;
using System.Linq;

namespace LeetCode
{
  public class ValidParenthesisClass
  {
      public bool IsValid(string s)
      {
        if(string.IsNullOrWhiteSpace(s))
          return true;
       Stack stack = new Stack();
       bool validStack=false;
       foreach(char c in s)
       {
            if(c=='(' || c=='{' || c=='[')
            {
              stack.Push(c);
            }
            else {
            if((c==')' || c=='}' || c==']') && stack.Count>0)
            {
              var v = (char)stack.Pop();
              if(((c==')' && v=='(')|| (c==']' && v=='[') || (c=='}' && v=='{')))
                  validStack=true;
              else {validStack=false; break;}
            }
            else
            {
              validStack=false;
              break;
            }}
       }
       if(stack.Count>0)
         validStack=false;
       return validStack;
    }

  }
}
