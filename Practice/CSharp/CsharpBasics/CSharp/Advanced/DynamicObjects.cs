using System.Dynamic;
using System;
using System.Collections.Generic;
using System.IO;
namespace CSharp.Advanced
{
    public class DynamicObject
    {
        public dynamic MainTest(string s1)
        {
            dynamic obj = new ExpandoObject();   
            obj.name= s1;
            obj.Func1 = (Func<string,string>)((string s1 )=> { Console.WriteLine(s1); return s1;});
            obj.Func1("new hello");
            return obj;
        }
        public dynamic ParseCsv(string filePath)
        {
            List<dynamic> l = new List<dynamic>();
            using(var sr = new StreamReader(filePath))
            {
                while(!sr.EndOfStream)
                {
                    var s1 = sr.ReadLine();
                    var s2 = s1.Split(",");
                    dynamic v1 = new ExpandoObject();
                    foreach( var s3 in s2)
                    {

                        var s4 = s3.Split(":");
                        switch(s4[0])
                        {
                            case "Name":
                                v1.Name = s4[1];
                                break;
                            case "age":
                                v1.age = s4[1];
                                break;
                            case "address":
                                v1.address = s4[1];
                                break;
                            case "phone":
                                v1.phone =s4[1];
                                break;
                            case "mobile":
                                v1.mobile = s4[1];
                                break;
                        }
                    }
                    l.Add(v1);
                }

            }
            return l;
        }
    }
}