using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class AccountMergeClass
    {
      public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
      {
        var distinctEmail = new List<string>();
        IList<string> l1  = new List<string>();
        IList<IList<string>> l2 = new List<IList<string>>();
        foreach(var l in accounts)
        {
          for(int i=1;i<l.Count;i++)
            if(!distinctEmail.Contains(l[i]))
              distinctEmail.Add(l[i]);
        }
        foreach(var email in distinctEmail)
        {
          var names = accounts.Where(x => x.Contains(email)).ToList();
          string c1=string.Empty;
          var k =0;
          foreach( var v in names)
            for(int i=k;i<v.Count;i++)
            {
              if(!l1.Contains(v[i]))
                  l1.Add(v[i]);
              k=1;
            }
          l1 = l1.OrderBy(x=>x).ToList();
          foreach(var v3 in l1)
            Console.Write(v3);
          Console.WriteLine();
          if(l1.Count>0)
             l2.Add( (new List<string>(l1)).OrderBy(x=>x).ToList() );
          l1.Clear();
          accounts = accounts.Where(x => !x.Contains(email)).ToList();
          Console.WriteLine("----------------accounts-------------");
          foreach(var acc in accounts)
            foreach(var a in acc)
              Console.WriteLine(string.Join(',', a));
        }
        return l2;

      }
    }
}
