using ProvVe.MachineService.DomainModel;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Dto
{
    [DataContract]
    public class MachineDto
    {
        // Field privato: l'oggetto di dominio
        private Machine internalInstance;

        [DataMember]
        public string Code
        {
            get { return internalInstance.Code; }
            set
            {
                internalInstance.Code = value;
            }
        }

        [DataMember]
        public int WorkHours
        {
            get { return (int)internalInstance.WorkHours; }
            set
            {
                internalInstance.WorkHours = value;
            }
        }

        [DataMember]
        public List<CustomerDto> Customers { get; set; }

        public MachineDto(Machine internalInstance)
        {
            this.internalInstance = internalInstance;
        }
    }
}