using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf_essential_l1_1.Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            Uri address = new("http://localhost:4000/IContract");
            BasicHttpBinding binding = new();
            Type contract = typeof(IContract);
            using ServiceHost host = new(typeof(Service));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();
            Console.WriteLine("The application is ready to receive messages.");
            Console.ReadKey();
        }
    }
}
