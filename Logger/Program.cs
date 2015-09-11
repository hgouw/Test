using log4net;
using log4net.Config;

namespace Logger
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger("Test.Logger");
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Log.Debug("Application is starting");
            Log.Debug("Application is ending");
        }
    }
}
