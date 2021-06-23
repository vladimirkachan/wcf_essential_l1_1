using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcf_essential_l1_1.Server
{
    public class Service : IContract
    {
        public void Say(string input)
        {
            Console.WriteLine($"Message received, Body contains: {input}");
        }
    }
}
