using ProvVe.MachineService.NetworkMessages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Responses
{
    [DataContract]
    public class GetMachinesResponse : BaseResponse
    {
        [DataMember]
        public List<MachineDto> Items { get; set; }
    }
}