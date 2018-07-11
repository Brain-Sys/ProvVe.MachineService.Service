using ProvVe.MachineService.NetworkMessages.Dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Responses
{
    [DataContract]
    public class GetMachinesResponse : BaseResponse
    {
        [DataMember]
        public IQueryable<MachineDto> Items { get; set; }

        [OnDeserialized]
        private void DopoLaDeserializzazione(StreamingContext context)
        {
            Debug.WriteLine("GetMachinesResponse - DopoLaDeserializzazione");
        }
    }
}