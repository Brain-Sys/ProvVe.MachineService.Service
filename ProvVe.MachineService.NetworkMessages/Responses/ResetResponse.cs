using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Responses
{
    [DataContract]
    public class ResetResponse : BaseResponse
    {
        [DataMember]
        public DateTime ActualTimestamp { get; set; }

        //// By default non fa parte del contratto
        //public string XYZ { get; set; }
    }
}