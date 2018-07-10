using ProvVe.MachineService.NetworkMessages.Dto;
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
        [FaultContract(typeof(ErrorDto))]
        OpenPortResponse OpenPort(OpenPortRequest request);
    }
}