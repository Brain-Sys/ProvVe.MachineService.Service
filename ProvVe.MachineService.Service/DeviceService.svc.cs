using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using ProvVe.MachineService.NetworkMessages.Requests;
using ProvVe.MachineService.NetworkMessages.Responses;

namespace ProvVe.MachineService.Service
{
    public class DeviceService : IDeviceService
    {
        private void debug()
        {
#if DEBUG
            Thread.Sleep(5000);
#endif
        }

        public DateTime Ping()
        {
            debug();
            return DateTime.Now;
        }

        public ResetResponse Reset(ResetRequest input)
        {
            debug();

            ResetResponse response = new ResetResponse();
            response.Success = true;

            return response;
        }
    }
}