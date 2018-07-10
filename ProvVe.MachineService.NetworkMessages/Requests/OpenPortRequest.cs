using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Requests
{
    [DataContract]
    public class OpenPortRequest
    {
        [DataMember(Name = "PortName", IsRequired = true)]
        public string Name { get; set; }

        [DataMember]
        public string Protocol { get; set; }
    }
}