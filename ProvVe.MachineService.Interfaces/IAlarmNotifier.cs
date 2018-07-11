using ProvVe.MachineService.NetworkMessages.Requests;
using ProvVe.MachineService.NetworkMessages.Responses;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace ProvVe.MachineService.Interfaces
{
    [ServiceContract]
    public interface IAlarmNotifier
    {
        [OperationContract]
        NewAlarmOccurredResponse NewAlarmOccured
            (NewAlarmOccurredRequest request);
    }
}