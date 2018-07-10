using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Dto
{
    [DataContract]
    public class CustomerDto
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<string> MachineCodes { get; set; }
    }
}