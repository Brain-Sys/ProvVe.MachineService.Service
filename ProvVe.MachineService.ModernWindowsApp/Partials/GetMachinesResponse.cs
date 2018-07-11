using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvVe.MachineService.ModernWindowsApp.DeviceService
{
    public partial class GetMachinesResponse
    {
        public double Axis { get; set; }

        [OnDeserialized]
        private void AfterDeserialization(StreamingContext context)
        {
            this.Axis = this.Interval.Milliseconds * Math.PI;
            Debug.WriteLine("AfterDeserialization()");
            Debug.WriteLine(this.Axis);
        }
    }
}