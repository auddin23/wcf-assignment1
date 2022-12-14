//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Check_Prime", ReplyAction="http://tempuri.org/IService1/Check_PrimeResponse")]
        string Check_Prime(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Check_Prime", ReplyAction="http://tempuri.org/IService1/Check_PrimeResponse")]
        System.Threading.Tasks.Task<string> Check_PrimeAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sum_Digit", ReplyAction="http://tempuri.org/IService1/Sum_DigitResponse")]
        int Sum_Digit(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sum_Digit", ReplyAction="http://tempuri.org/IService1/Sum_DigitResponse")]
        System.Threading.Tasks.Task<int> Sum_DigitAsync(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Reverse_String", ReplyAction="http://tempuri.org/IService1/Reverse_StringResponse")]
        string Reverse_String(string stringToReverse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Reverse_String", ReplyAction="http://tempuri.org/IService1/Reverse_StringResponse")]
        System.Threading.Tasks.Task<string> Reverse_StringAsync(string stringToReverse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Print_Tag", ReplyAction="http://tempuri.org/IService1/Print_TagResponse")]
        string Print_Tag(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Print_Tag", ReplyAction="http://tempuri.org/IService1/Print_TagResponse")]
        System.Threading.Tasks.Task<string> Print_TagAsync(string tag, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sorting", ReplyAction="http://tempuri.org/IService1/sortingResponse")]
        int[] sorting(string sortType, int[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sorting", ReplyAction="http://tempuri.org/IService1/sortingResponse")]
        System.Threading.Tasks.Task<int[]> sortingAsync(string sortType, int[] data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment1.ServiceReference1.IService1>, Assignment1.ServiceReference1.IService1 {
        
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
        
        public string Check_Prime(int n) {
            return base.Channel.Check_Prime(n);
        }
        
        public System.Threading.Tasks.Task<string> Check_PrimeAsync(int n) {
            return base.Channel.Check_PrimeAsync(n);
        }
        
        public int Sum_Digit(int num) {
            return base.Channel.Sum_Digit(num);
        }
        
        public System.Threading.Tasks.Task<int> Sum_DigitAsync(int num) {
            return base.Channel.Sum_DigitAsync(num);
        }
        
        public string Reverse_String(string stringToReverse) {
            return base.Channel.Reverse_String(stringToReverse);
        }
        
        public System.Threading.Tasks.Task<string> Reverse_StringAsync(string stringToReverse) {
            return base.Channel.Reverse_StringAsync(stringToReverse);
        }
        
        public string Print_Tag(string tag, string data) {
            return base.Channel.Print_Tag(tag, data);
        }
        
        public System.Threading.Tasks.Task<string> Print_TagAsync(string tag, string data) {
            return base.Channel.Print_TagAsync(tag, data);
        }
        
        public int[] sorting(string sortType, int[] data) {
            return base.Channel.sorting(sortType, data);
        }
        
        public System.Threading.Tasks.Task<int[]> sortingAsync(string sortType, int[] data) {
            return base.Channel.sortingAsync(sortType, data);
        }
    }
}
