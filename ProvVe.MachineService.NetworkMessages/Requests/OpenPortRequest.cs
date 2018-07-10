using ProvVe.MachineService.NetworkMessages.Enumerations;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Requests
{
    [DataContract]
    public class OpenPortRequest : BaseRequest
    {
        [DataMember(Name = "PortName", IsRequired = true)]
        public Ports Name { get; set; }

        [DataMember]
        public string Filename { get; set; }

        [DataMember(Order = 999)]
        public string Protocol { get; set; }
    }
}