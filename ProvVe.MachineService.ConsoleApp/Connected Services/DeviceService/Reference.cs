﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProvVe.MachineService.ConsoleApp.DeviceService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeviceService.IDeviceService")]
    public interface IDeviceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeviceService/Ping", ReplyAction="http://tempuri.org/IDeviceService/PingResponse")]
        System.DateTime Ping();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDeviceServiceChannel : ProvVe.MachineService.ConsoleApp.DeviceService.IDeviceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeviceServiceClient : System.ServiceModel.ClientBase<ProvVe.MachineService.ConsoleApp.DeviceService.IDeviceService>, ProvVe.MachineService.ConsoleApp.DeviceService.IDeviceService {
        
        public DeviceServiceClient() {
        }
        
        public DeviceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeviceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeviceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeviceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.DateTime Ping() {
            return base.Channel.Ping();
        }
    }
}
