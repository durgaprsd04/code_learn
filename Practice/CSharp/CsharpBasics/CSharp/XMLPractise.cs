using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace CSharp
{

    public class XMLPractise
    {
        public void XMLTests()
        {
            var test ="<root><child id='1'><name>vinod</name><pname>vinu</pname></child><parent id='1'><name>viplab</name><pname>minu</pname></parent> </root>";
            CreateTest(test);
        }
        public void CreateTest(string test)
        {
            Console.WriteLine("Create test");
            var xml  = XElement.Parse(test);
            var element = xml.Elements("child").SingleOrDefault();///.Elements("child").SingleOrDefault();
            element.Name="grandchild";
           var srcTree  = XElement.Parse(test);
           srcTree.RemoveNodes();
           foreach( var x in xml.Elements())
           {    
                if(x.Name=="child")
                    x.Name="grandchild";
                srcTree.Add(x);
                "safsafd".Reverse();
           }
           // xml.ReplaceNodes(xml, xml.Elements().Select(x => x.Name=="child"( x.Name="grand")));
            Console.WriteLine(srcTree);
        }
    }   
}