using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf_essential_l1_1.Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";
            Uri address = new("http://localhost:4000/IContract");
            BasicHttpBinding binding = new();
            EndpointAddress endpoint = new(address);
            ChannelFactory<IContract> factory = new(binding, endpoint);
            IContract channel = factory.CreateChannel();
            channel.Say("Message from Client application");
            Console.WriteLine(channel.Method("Second Client message"));
            Console.ReadKey();
        }
    }
}
