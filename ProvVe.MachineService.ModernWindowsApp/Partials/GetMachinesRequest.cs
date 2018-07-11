using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvVe.MachineService.ModernWindowsApp.DeviceService
{
    public partial class GetMachinesRequest
    {
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            this.ApplicationName = "";
            this.ClientVersion = new Version(2, 3);
            this.Username = "igord";
            Debug.WriteLine("OnSerializing");
        }
    }
}