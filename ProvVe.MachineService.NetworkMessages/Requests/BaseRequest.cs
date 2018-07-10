using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Requests
{
    [DataContract]
    public abstract class BaseRequest
    {
        [DataMember]
        public string ApplicationName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public Version ClientVersion { get; set; }
    }
}