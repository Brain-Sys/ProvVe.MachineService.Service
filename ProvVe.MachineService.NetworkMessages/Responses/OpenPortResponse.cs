﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Responses
{
    [DataContract]
    public class OpenPortResponse : BaseResponse
    {
        [DataMember]
        public byte[] Content { get; set; }
    }
}