using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace Timeproject
{
    public class Program
    {
        public static async Task  Main(string[] args)
        {
          
            //HostFactory.Run(x => x.Service<TimeLoggingService>());
           Console.WriteLine("hello world");
           // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            var logger = LogManager.GetLogger(typeof(Program));
            logger.Info("here being logger");
          FileReader file = new FileReader("xml/flatfile.xml");
           var a=  file.GetExecutionTimeFromXML();
           var t1 =TimeSpan.Parse(a);
           var v1 =DateTime.Today.Add(t1);
           Console.WriteLine($"time {t1.ToString()} date {v1.ToString()}");
           
           logger.Info("nothing hapens");
           TimeAPIHelper t = new TimeAPIHelper(@"http://worldtimeapi.org/api/ip");
           var str = await t.GetUTCTimeFromAPI();
            DateTime d;
            DateTime.TryParse(str, out d);
            if(d!=null)
            {
                Console.WriteLine("utc time from this "+ str);
                Console.WriteLine("utc time from this "+ d.ToString());
                Console.WriteLine($" Time difference in the set {(d.ToUniversalTime()-v1).ToString()}");
            }

        }

       
            
    }
}
