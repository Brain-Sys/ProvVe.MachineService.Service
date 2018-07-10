using ProvVe.MachineService.Interfaces;
using ProvVe.MachineService.NetworkMessages.Dto;
using ProvVe.MachineService.NetworkMessages.Requests;
using ProvVe.MachineService.NetworkMessages.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [OperationContract]
        GetMachinesResponse GetMachines(GetMachinesRequest input);





        [OperationContract]
        IQueryable<MachineDto> SearchMachines(GetMachinesRequest input);
    }
}