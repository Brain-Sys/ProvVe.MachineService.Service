using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvVe.MachineService.ModernWindowsApp.DeviceService
{
    public partial class ResetResponse
    {
        public bool IsResetRecent
        {
            get
            {
                var ts = DateTime.Now.Subtract(this.ActualTimestamp);
                return ts > TimeSpan.FromMinutes(1);
            }
        }
    }
}