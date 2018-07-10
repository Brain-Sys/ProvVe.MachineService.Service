using ProvVe.MachineService.Interfaces;
using ProvVe.MachineService.NetworkMessages.Requests;
using ProvVe.MachineService.NetworkMessages.Responses;
using System;
using System.ServiceModel;

namespace ProvVe.MachineService.Service
{
    [ServiceContract]
    public interface IDeviceService : ICommunication
    {
        [OperationContract]
        DateTime Ping();

        // SOA = Service Oriented Architecture
        [OperationContract]
        ResetResponse Reset(ResetRequest input);
    }
}