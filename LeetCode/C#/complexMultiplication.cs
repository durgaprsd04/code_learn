using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class ComplexMultiplication
    {
      public string ComplexNumberMultiply(string a, string b)
      {
        var v1 = getcomplexreal(a);
        var v2 = getcomplexreal(b);
        var real = v1.a*v2.a - v1.b*v2.b;
        var img = v1.a*v2.b + v1.b*v2.a;
        return real.ToString()+"+"+img.ToString()+"i";
      }
      public (int a ,int b) getcomplexreal(string a)
      {
          var v1 = Convert.ToInt32(a.Split('+')[0]);
          var v2 = Convert.ToInt32(a.Split('+')[1].Replace("i",""));
          return (v1,v2);
      }
    }
}
