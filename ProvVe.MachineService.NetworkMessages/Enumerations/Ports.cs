using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Enumerations
{
    public enum Ports
    {
        COM1,
        COM2,
        COM3 = 3,
        COM4 = 9,
        localhost = 5,
        [NonSerialized]
        Port8080
    }
}