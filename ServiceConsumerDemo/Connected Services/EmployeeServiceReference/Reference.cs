﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceConsumerDemo.EmployeeServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchByEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchByEmployee(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchByEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchByEmployeeAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Adding", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Adding(int n2, int n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Adding", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddingAsync(int n2, int n1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ServiceConsumerDemo.EmployeeServiceReference.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ServiceConsumerDemo.EmployeeServiceReference.WebService1Soap>, ServiceConsumerDemo.EmployeeServiceReference.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet SearchByEmployee(string name) {
            return base.Channel.SearchByEmployee(name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchByEmployeeAsync(string name) {
            return base.Channel.SearchByEmployeeAsync(name);
        }
        
        public int Adding(int n2, int n1) {
            return base.Channel.Adding(n2, n1);
        }
        
        public System.Threading.Tasks.Task<int> AddingAsync(int n2, int n1) {
            return base.Channel.AddingAsync(n2, n1);
        }
    }
}
