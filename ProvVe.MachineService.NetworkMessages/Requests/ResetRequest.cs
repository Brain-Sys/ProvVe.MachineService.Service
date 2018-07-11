using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Requests
{
    [DataContract]
    public class ResetRequest : BaseRequest
    {
        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public byte MaxRetry { get; set; }

        public int AxisX { get; set; }

        // Ctor per "forzare" istanze consistenti
        public ResetRequest(int machineId, string userId)
        {
            this.MaxRetry = 3;
            this.MachineId = machineId;
            this.UserId = userId;
        }

        [OnSerializing]
        void PrimaDellaSerializzazione(StreamingContext context)
        {
            System.Diagnostics.Debug.WriteLine("PrimaDellaSerializzazione");
            this.AxisX = int.Parse(this.UserId) + 1;
        }

        [OnDeserialized]
        void DopoLaDeserializzazione(StreamingContext context)
        {
            this.AxisX = int.Parse(this.UserId) + 1;
        }
    }
}