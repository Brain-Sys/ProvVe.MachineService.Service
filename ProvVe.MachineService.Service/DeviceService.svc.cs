using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace ProvVe.MachineService.Service
{
    public class DeviceService : IDeviceService
    {
        public DateTime Ping()
        {
#if DEBUG
            Thread.Sleep(10000);
#endif

            return DateTime.Now;
        }
    }
}