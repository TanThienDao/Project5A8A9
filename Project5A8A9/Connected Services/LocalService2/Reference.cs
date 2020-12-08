﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project5A8A9.LocalService2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocalService2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Encrypt", ReplyAction="http://tempuri.org/IService1/EncryptResponse")]
        string Encrypt(string plaintext);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Encrypt", ReplyAction="http://tempuri.org/IService1/EncryptResponse")]
        System.Threading.Tasks.Task<string> EncryptAsync(string plaintext);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Decrypt", ReplyAction="http://tempuri.org/IService1/DecryptResponse")]
        string Decrypt(string encryptedText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Decrypt", ReplyAction="http://tempuri.org/IService1/DecryptResponse")]
        System.Threading.Tasks.Task<string> DecryptAsync(string encryptedText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWindEnergyIndex", ReplyAction="http://tempuri.org/IService1/GetWindEnergyIndexResponse")]
        double GetWindEnergyIndex(int lattitude, int longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWindEnergyIndex", ReplyAction="http://tempuri.org/IService1/GetWindEnergyIndexResponse")]
        System.Threading.Tasks.Task<double> GetWindEnergyIndexAsync(int lattitude, int longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVerifierString", ReplyAction="http://tempuri.org/IService1/GetVerifierStringResponse")]
        string GetVerifierString(string length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVerifierString", ReplyAction="http://tempuri.org/IService1/GetVerifierStringResponse")]
        System.Threading.Tasks.Task<string> GetVerifierStringAsync(string length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetImage", ReplyAction="http://tempuri.org/IService1/GetImageResponse")]
        System.IO.Stream GetImage(string myString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetImage", ReplyAction="http://tempuri.org/IService1/GetImageResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetImageAsync(string myString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addAcoundt", ReplyAction="http://tempuri.org/IService1/addAcoundtResponse")]
        string addAcoundt(string username, string password, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addAcoundt", ReplyAction="http://tempuri.org/IService1/addAcoundtResponse")]
        System.Threading.Tasks.Task<string> addAcoundtAsync(string username, string password, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/search", ReplyAction="http://tempuri.org/IService1/searchResponse")]
        string[] search(string username, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/search", ReplyAction="http://tempuri.org/IService1/searchResponse")]
        System.Threading.Tasks.Task<string[]> searchAsync(string username, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/removeFromXML", ReplyAction="http://tempuri.org/IService1/removeFromXMLResponse")]
        bool removeFromXML(string username, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/removeFromXML", ReplyAction="http://tempuri.org/IService1/removeFromXMLResponse")]
        System.Threading.Tasks.Task<bool> removeFromXMLAsync(string username, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/returnXML", ReplyAction="http://tempuri.org/IService1/returnXMLResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(byte[]))]
        object[] returnXML(string xmlfile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/returnXML", ReplyAction="http://tempuri.org/IService1/returnXMLResponse")]
        System.Threading.Tasks.Task<object[]> returnXMLAsync(string xmlfile);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Project5A8A9.LocalService2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Project5A8A9.LocalService2.IService1>, Project5A8A9.LocalService2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string Encrypt(string plaintext) {
            return base.Channel.Encrypt(plaintext);
        }
        
        public System.Threading.Tasks.Task<string> EncryptAsync(string plaintext) {
            return base.Channel.EncryptAsync(plaintext);
        }
        
        public string Decrypt(string encryptedText) {
            return base.Channel.Decrypt(encryptedText);
        }
        
        public System.Threading.Tasks.Task<string> DecryptAsync(string encryptedText) {
            return base.Channel.DecryptAsync(encryptedText);
        }
        
        public double GetWindEnergyIndex(int lattitude, int longitude) {
            return base.Channel.GetWindEnergyIndex(lattitude, longitude);
        }
        
        public System.Threading.Tasks.Task<double> GetWindEnergyIndexAsync(int lattitude, int longitude) {
            return base.Channel.GetWindEnergyIndexAsync(lattitude, longitude);
        }
        
        public string GetVerifierString(string length) {
            return base.Channel.GetVerifierString(length);
        }
        
        public System.Threading.Tasks.Task<string> GetVerifierStringAsync(string length) {
            return base.Channel.GetVerifierStringAsync(length);
        }
        
        public System.IO.Stream GetImage(string myString) {
            return base.Channel.GetImage(myString);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetImageAsync(string myString) {
            return base.Channel.GetImageAsync(myString);
        }
        
        public string addAcoundt(string username, string password, int role) {
            return base.Channel.addAcoundt(username, password, role);
        }
        
        public System.Threading.Tasks.Task<string> addAcoundtAsync(string username, string password, int role) {
            return base.Channel.addAcoundtAsync(username, password, role);
        }
        
        public string[] search(string username, int role) {
            return base.Channel.search(username, role);
        }
        
        public System.Threading.Tasks.Task<string[]> searchAsync(string username, int role) {
            return base.Channel.searchAsync(username, role);
        }
        
        public bool removeFromXML(string username, int role) {
            return base.Channel.removeFromXML(username, role);
        }
        
        public System.Threading.Tasks.Task<bool> removeFromXMLAsync(string username, int role) {
            return base.Channel.removeFromXMLAsync(username, role);
        }
        
        public object[] returnXML(string xmlfile) {
            return base.Channel.returnXML(xmlfile);
        }
        
        public System.Threading.Tasks.Task<object[]> returnXMLAsync(string xmlfile) {
            return base.Channel.returnXMLAsync(xmlfile);
        }
    }
}
