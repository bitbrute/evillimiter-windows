using System.Linq;
using System.Reflection;
using System.ServiceProcess;

namespace EvilLimiter.Windows.Common
{
    public static class Globals
    {

        public static string Version => string.Join(".", Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.').Reverse().Skip(1).Reverse());
        public static string GithubRepoLink => @"https://github.com/bitbrute/evillimiter-windows";

        public static ServiceController RoutingService
        {
            get
            {
                if (_routingService is null)
                    _routingService = new ServiceController("RemoteAccess");

                return _routingService;
            }
        }


        private static ServiceController _routingService;
    }
}
