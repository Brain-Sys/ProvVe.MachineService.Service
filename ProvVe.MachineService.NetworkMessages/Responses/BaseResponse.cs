using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;

namespace ProvVe.MachineService.NetworkMessages.Responses
{
    [DataContract]
    public abstract class BaseResponse
    {
        [DataMember]
        public TimeSpan Interval { get; set; }

        [DataMember]
        public Version ServerVersion { get; set; }

        // Soluzione "fatta in casa"
        [DataMember]
        public bool Success { get; set; }

        //[DataMember]
        //public Exception Exception { get; set; }

        [DataMember]
        public string ExceptionMessage { get; set; }

        [OnDeserialized]
        private void DopoLaDeserializzazione(StreamingContext context)
        {
            Debug.WriteLine("DopoLaDeserializzazione");
        }
    }
}