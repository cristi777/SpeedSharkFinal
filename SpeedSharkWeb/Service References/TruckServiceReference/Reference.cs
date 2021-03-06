﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpeedSharkWeb.TruckServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Truck", Namespace="http://schemas.datacontract.org/2004/07/SpeedSharkWCF")]
    [System.SerializableAttribute()]
    public partial class Truck : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TruckIdField;
        
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
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TruckId {
            get {
                return this.TruckIdField;
            }
            set {
                if ((this.TruckIdField.Equals(value) != true)) {
                    this.TruckIdField = value;
                    this.RaisePropertyChanged("TruckId");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TruckServiceReference.ITruckService")]
    public interface ITruckService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/insertTruck", ReplyAction="http://tempuri.org/ITruckService/insertTruckResponse")]
        void insertTruck(string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/insertTruck", ReplyAction="http://tempuri.org/ITruckService/insertTruckResponse")]
        System.Threading.Tasks.Task insertTruckAsync(string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/updateTruck", ReplyAction="http://tempuri.org/ITruckService/updateTruckResponse")]
        void updateTruck(int truckId, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/updateTruck", ReplyAction="http://tempuri.org/ITruckService/updateTruckResponse")]
        System.Threading.Tasks.Task updateTruckAsync(int truckId, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getTruck", ReplyAction="http://tempuri.org/ITruckService/getTruckResponse")]
        SpeedSharkWeb.TruckServiceReference.Truck getTruck(int truckId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getTruck", ReplyAction="http://tempuri.org/ITruckService/getTruckResponse")]
        System.Threading.Tasks.Task<SpeedSharkWeb.TruckServiceReference.Truck> getTruckAsync(int truckId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getTrucks", ReplyAction="http://tempuri.org/ITruckService/getTrucksResponse")]
        SpeedSharkWeb.TruckServiceReference.Truck[] getTrucks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getTrucks", ReplyAction="http://tempuri.org/ITruckService/getTrucksResponse")]
        System.Threading.Tasks.Task<SpeedSharkWeb.TruckServiceReference.Truck[]> getTrucksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getFunctionalTrucks", ReplyAction="http://tempuri.org/ITruckService/getFunctionalTrucksResponse")]
        int[] getFunctionalTrucks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getFunctionalTrucks", ReplyAction="http://tempuri.org/ITruckService/getFunctionalTrucksResponse")]
        System.Threading.Tasks.Task<int[]> getFunctionalTrucksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getAvailableTrucks", ReplyAction="http://tempuri.org/ITruckService/getAvailableTrucksResponse")]
        int[] getAvailableTrucks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITruckService/getAvailableTrucks", ReplyAction="http://tempuri.org/ITruckService/getAvailableTrucksResponse")]
        System.Threading.Tasks.Task<int[]> getAvailableTrucksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITruckServiceChannel : SpeedSharkWeb.TruckServiceReference.ITruckService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TruckServiceClient : System.ServiceModel.ClientBase<SpeedSharkWeb.TruckServiceReference.ITruckService>, SpeedSharkWeb.TruckServiceReference.ITruckService {
        
        public TruckServiceClient() {
        }
        
        public TruckServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TruckServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TruckServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TruckServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertTruck(string status) {
            base.Channel.insertTruck(status);
        }
        
        public System.Threading.Tasks.Task insertTruckAsync(string status) {
            return base.Channel.insertTruckAsync(status);
        }
        
        public void updateTruck(int truckId, string status) {
            base.Channel.updateTruck(truckId, status);
        }
        
        public System.Threading.Tasks.Task updateTruckAsync(int truckId, string status) {
            return base.Channel.updateTruckAsync(truckId, status);
        }
        
        public SpeedSharkWeb.TruckServiceReference.Truck getTruck(int truckId) {
            return base.Channel.getTruck(truckId);
        }
        
        public System.Threading.Tasks.Task<SpeedSharkWeb.TruckServiceReference.Truck> getTruckAsync(int truckId) {
            return base.Channel.getTruckAsync(truckId);
        }
        
        public SpeedSharkWeb.TruckServiceReference.Truck[] getTrucks() {
            return base.Channel.getTrucks();
        }
        
        public System.Threading.Tasks.Task<SpeedSharkWeb.TruckServiceReference.Truck[]> getTrucksAsync() {
            return base.Channel.getTrucksAsync();
        }
        
        public int[] getFunctionalTrucks() {
            return base.Channel.getFunctionalTrucks();
        }
        
        public System.Threading.Tasks.Task<int[]> getFunctionalTrucksAsync() {
            return base.Channel.getFunctionalTrucksAsync();
        }
        
        public int[] getAvailableTrucks() {
            return base.Channel.getAvailableTrucks();
        }
        
        public System.Threading.Tasks.Task<int[]> getAvailableTrucksAsync() {
            return base.Channel.getAvailableTrucksAsync();
        }
    }
}
