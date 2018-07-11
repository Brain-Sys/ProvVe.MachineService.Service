﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProvVe.MachineService.ModernWindowsApp.MaintenanceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseRequest", Namespace="http://schemas.datacontract.org/2004/07/Mares.Maintenance.NetworkMessages.Request" +
        "s")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeRequest))]
    public partial class BaseRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Version ClientVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName {
            get {
                return this.ApplicationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationNameField, value) != true)) {
                    this.ApplicationNameField = value;
                    this.RaisePropertyChanged("ApplicationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Version ClientVersion {
            get {
                return this.ClientVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientVersionField, value) != true)) {
                    this.ClientVersionField = value;
                    this.RaisePropertyChanged("ClientVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WelcomeRequest", Namespace="http://schemas.datacontract.org/2004/07/Mares.Maintenance.NetworkMessages.Request" +
        "s")]
    [System.SerializableAttribute()]
    public partial class WelcomeRequest : ProvVe.MachineService.ModernWindowsApp.MaintenanceService.BaseRequest {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponse", Namespace="http://schemas.datacontract.org/2004/07/Mares.Maintenance.NetworkMessages.Respons" +
        "es")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse))]
    public partial class BaseResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan IntervalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Version ServerVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionMessage {
            get {
                return this.ExceptionMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMessageField, value) != true)) {
                    this.ExceptionMessageField = value;
                    this.RaisePropertyChanged("ExceptionMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan Interval {
            get {
                return this.IntervalField;
            }
            set {
                if ((this.IntervalField.Equals(value) != true)) {
                    this.IntervalField = value;
                    this.RaisePropertyChanged("Interval");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Version ServerVersion {
            get {
                return this.ServerVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerVersionField, value) != true)) {
                    this.ServerVersionField = value;
                    this.RaisePropertyChanged("ServerVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WelcomeResponse", Namespace="http://schemas.datacontract.org/2004/07/Mares.Maintenance.NetworkMessages.Respons" +
        "es")]
    [System.SerializableAttribute()]
    public partial class WelcomeResponse : ProvVe.MachineService.ModernWindowsApp.MaintenanceService.BaseResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WelcomeMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WelcomeMessage {
            get {
                return this.WelcomeMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.WelcomeMessageField, value) != true)) {
                    this.WelcomeMessageField = value;
                    this.RaisePropertyChanged("WelcomeMessage");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MaintenanceService.IMaintenanceService")]
    public interface IMaintenanceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceService/WelcomeMethod", ReplyAction="http://tempuri.org/IMaintenanceService/WelcomeMethodResponse")]
        ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse WelcomeMethod(ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceService/WelcomeMethod", ReplyAction="http://tempuri.org/IMaintenanceService/WelcomeMethodResponse")]
        System.Threading.Tasks.Task<ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse> WelcomeMethodAsync(ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeRequest Request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceService/WelcomeMethod2", ReplyAction="http://tempuri.org/IMaintenanceService/WelcomeMethod2Response")]
        ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse WelcomeMethod2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceService/WelcomeMethod2", ReplyAction="http://tempuri.org/IMaintenanceService/WelcomeMethod2Response")]
        System.Threading.Tasks.Task<ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse> WelcomeMethod2Async();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMaintenanceServiceChannel : ProvVe.MachineService.ModernWindowsApp.MaintenanceService.IMaintenanceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MaintenanceServiceClient : System.ServiceModel.ClientBase<ProvVe.MachineService.ModernWindowsApp.MaintenanceService.IMaintenanceService>, ProvVe.MachineService.ModernWindowsApp.MaintenanceService.IMaintenanceService {
        
        public MaintenanceServiceClient() {
        }
        
        public MaintenanceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MaintenanceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaintenanceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaintenanceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse WelcomeMethod(ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeRequest Request) {
            return base.Channel.WelcomeMethod(Request);
        }
        
        public System.Threading.Tasks.Task<ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse> WelcomeMethodAsync(ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeRequest Request) {
            return base.Channel.WelcomeMethodAsync(Request);
        }
        
        public ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse WelcomeMethod2() {
            return base.Channel.WelcomeMethod2();
        }
        
        public System.Threading.Tasks.Task<ProvVe.MachineService.ModernWindowsApp.MaintenanceService.WelcomeResponse> WelcomeMethod2Async() {
            return base.Channel.WelcomeMethod2Async();
        }
    }
}
