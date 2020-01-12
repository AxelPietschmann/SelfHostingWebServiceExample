using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceLocator.Initalize(new InventoryRepository());

            var config = new HttpSelfHostConfiguration("http://localhost:8080");

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                "text/html",
                StringComparison.InvariantCultureIgnoreCase,
                true,
                "application/json"));

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine(config.BaseAddress);
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
