using ProvVe.MachineService.NetworkMessages.Requests;
using ProvVe.MachineService.NetworkMessages.Responses;
using System;
using System.ServiceModel;

namespace ProvVe.MachineService.Interfaces
{
    [ServiceContract]
    public interface ICommunication
    {
        [OperationContract(Name = "OpenPort")]
        OpenPortResponse OpenPort(OpenPortRequest request);
    }
}