//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWPF.srOperaciones {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srOperaciones.wbOperacionesSoap")]
    public interface wbOperacionesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        double Sumar(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SumarAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Restar", ReplyAction="*")]
        double Restar(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Restar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RestarAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicar", ReplyAction="*")]
        double Multiplicar(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> MultiplicarAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Dividir", ReplyAction="*")]
        double Dividir(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Dividir", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DividirAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Potencia", ReplyAction="*")]
        double Potencia(double b, [System.ServiceModel.MessageParameterAttribute(Name="potencia")] double potencia1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Potencia", ReplyAction="*")]
        System.Threading.Tasks.Task<double> PotenciaAsync(double b, double potencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        double Factorial(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        System.Threading.Tasks.Task<double> FactorialAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Seno", ReplyAction="*")]
        double Seno(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Seno", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SenoAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tangente", ReplyAction="*")]
        double Tangente(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tangente", ReplyAction="*")]
        System.Threading.Tasks.Task<double> TangenteAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Inverso", ReplyAction="*")]
        double Inverso(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Inverso", ReplyAction="*")]
        System.Threading.Tasks.Task<double> InversoAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RaizSqr", ReplyAction="*")]
        double RaizSqr(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RaizSqr", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RaizSqrAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RaizEn", ReplyAction="*")]
        double RaizEn(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RaizEn", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RaizEnAsync(double n1, double n2);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClienteWPF.srOperaciones.HelloWorldResponse HelloWorld(ClienteWPF.srOperaciones.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWPF.srOperaciones.HelloWorldResponse> HelloWorldAsync(ClienteWPF.srOperaciones.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWPF.srOperaciones.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClienteWPF.srOperaciones.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClienteWPF.srOperaciones.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClienteWPF.srOperaciones.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wbOperacionesSoapChannel : ClienteWPF.srOperaciones.wbOperacionesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wbOperacionesSoapClient : System.ServiceModel.ClientBase<ClienteWPF.srOperaciones.wbOperacionesSoap>, ClienteWPF.srOperaciones.wbOperacionesSoap {
        
        public wbOperacionesSoapClient() {
        }
        
        public wbOperacionesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wbOperacionesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wbOperacionesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wbOperacionesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Sumar(double n1, double n2) {
            return base.Channel.Sumar(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SumarAsync(double n1, double n2) {
            return base.Channel.SumarAsync(n1, n2);
        }
        
        public double Restar(double n1, double n2) {
            return base.Channel.Restar(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> RestarAsync(double n1, double n2) {
            return base.Channel.RestarAsync(n1, n2);
        }
        
        public double Multiplicar(double n1, double n2) {
            return base.Channel.Multiplicar(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplicarAsync(double n1, double n2) {
            return base.Channel.MultiplicarAsync(n1, n2);
        }
        
        public double Dividir(double n1, double n2) {
            return base.Channel.Dividir(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DividirAsync(double n1, double n2) {
            return base.Channel.DividirAsync(n1, n2);
        }
        
        public double Potencia(double b, double potencia1) {
            return base.Channel.Potencia(b, potencia1);
        }
        
        public System.Threading.Tasks.Task<double> PotenciaAsync(double b, double potencia) {
            return base.Channel.PotenciaAsync(b, potencia);
        }
        
        public double Factorial(double n1) {
            return base.Channel.Factorial(n1);
        }
        
        public System.Threading.Tasks.Task<double> FactorialAsync(double n1) {
            return base.Channel.FactorialAsync(n1);
        }
        
        public double Seno(double n1) {
            return base.Channel.Seno(n1);
        }
        
        public System.Threading.Tasks.Task<double> SenoAsync(double n1) {
            return base.Channel.SenoAsync(n1);
        }
        
        public double Tangente(double n1) {
            return base.Channel.Tangente(n1);
        }
        
        public System.Threading.Tasks.Task<double> TangenteAsync(double n1) {
            return base.Channel.TangenteAsync(n1);
        }
        
        public double Inverso(double n1) {
            return base.Channel.Inverso(n1);
        }
        
        public System.Threading.Tasks.Task<double> InversoAsync(double n1) {
            return base.Channel.InversoAsync(n1);
        }
        
        public double RaizSqr(double n1) {
            return base.Channel.RaizSqr(n1);
        }
        
        public System.Threading.Tasks.Task<double> RaizSqrAsync(double n1) {
            return base.Channel.RaizSqrAsync(n1);
        }
        
        public double RaizEn(double n1, double n2) {
            return base.Channel.RaizEn(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> RaizEnAsync(double n1, double n2) {
            return base.Channel.RaizEnAsync(n1, n2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWPF.srOperaciones.HelloWorldResponse ClienteWPF.srOperaciones.wbOperacionesSoap.HelloWorld(ClienteWPF.srOperaciones.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClienteWPF.srOperaciones.HelloWorldRequest inValue = new ClienteWPF.srOperaciones.HelloWorldRequest();
            inValue.Body = new ClienteWPF.srOperaciones.HelloWorldRequestBody();
            ClienteWPF.srOperaciones.HelloWorldResponse retVal = ((ClienteWPF.srOperaciones.wbOperacionesSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWPF.srOperaciones.HelloWorldResponse> ClienteWPF.srOperaciones.wbOperacionesSoap.HelloWorldAsync(ClienteWPF.srOperaciones.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWPF.srOperaciones.HelloWorldResponse> HelloWorldAsync() {
            ClienteWPF.srOperaciones.HelloWorldRequest inValue = new ClienteWPF.srOperaciones.HelloWorldRequest();
            inValue.Body = new ClienteWPF.srOperaciones.HelloWorldRequestBody();
            return ((ClienteWPF.srOperaciones.wbOperacionesSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}
