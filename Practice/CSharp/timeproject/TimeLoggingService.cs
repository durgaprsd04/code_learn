using Topshelf;
using log4net;
namespace timeproject
{
    public class TimeLoggingService : ServiceControl
    {
        public bool Start(HostControl hostControl)
        {
            var logger =LogManager.GetLogger(typeof(TimeLoggingService));
            logger.Info("Service started");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            throw new System.NotImplementedException();
        }
    }
}