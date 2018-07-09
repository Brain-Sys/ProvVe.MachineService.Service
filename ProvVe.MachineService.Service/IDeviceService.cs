using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProvVe.MachineService.Service
{
    [ServiceContract]
    public interface IDeviceService
    {
        [OperationContract]
        DateTime Ping();
    }
}