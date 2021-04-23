using System;
using System.Xml.Linq;
using Timeproject.Interface;
using System.Configuration;
namespace Timeproject
{
    public class FileReader : IFileReader
    {
        private readonly string filepath;
        public FileReader(string filepath)
        {
            this.filepath = filepath;
        }
        public string GetExecutionTimeFromXML()
        {
            //var key = ConfigurationManager.AppSettings["xmlKey"];
            XElement xmlFile = XElement.Load(filepath);
            var result =string.Empty;
            foreach(var x in xmlFile.Nodes())
                if(x.Parent.Name=="ExecutionTime")
                    result = x.ToString();
            return result;
        }
    }
}
