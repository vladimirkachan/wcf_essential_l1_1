using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf_essential_l1_1.Server
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}
