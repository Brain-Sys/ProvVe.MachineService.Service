﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Requests
{
    [DataContract]
    public class NewAlarmOccurredRequest : BaseRequest
    {
        [DataMember]
        public int Count { get; set; }
    }
}