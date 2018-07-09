﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Requests
{
    [DataContract]
    public class ResetRequest
    {
        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public byte MaxRetry { get; set; }
    }
}