using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvVe.MachineService.ModernWindowsApp.DeviceService
{
    public partial class ResetRequest
    {
        public ResetRequest(int machineId, string userId)
        {
            this.MaxRetry = 3;
            this.MachineId = machineId;
            this.UserId = userId;
        }
    }
}