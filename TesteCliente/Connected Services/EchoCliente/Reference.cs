﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TesteCliente.EchoCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://control/", ConfigurationName="EchoCliente.Echo")]
    public interface Echo {
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento frase no namespace  não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://control/Echo/echoRequest", ReplyAction="http://control/Echo/echoResponse")]
        TesteCliente.EchoCliente.echoResponse echo(TesteCliente.EchoCliente.echoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://control/Echo/echoRequest", ReplyAction="http://control/Echo/echoResponse")]
        System.Threading.Tasks.Task<TesteCliente.EchoCliente.echoResponse> echoAsync(TesteCliente.EchoCliente.echoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class echoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="echo", Namespace="http://control/", Order=0)]
        public TesteCliente.EchoCliente.echoRequestBody Body;
        
        public echoRequest() {
        }
        
        public echoRequest(TesteCliente.EchoCliente.echoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class echoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string frase;
        
        public echoRequestBody() {
        }
        
        public echoRequestBody(string frase) {
            this.frase = frase;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class echoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="echoResponse", Namespace="http://control/", Order=0)]
        public TesteCliente.EchoCliente.echoResponseBody Body;
        
        public echoResponse() {
        }
        
        public echoResponse(TesteCliente.EchoCliente.echoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class echoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public echoResponseBody() {
        }
        
        public echoResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EchoChannel : TesteCliente.EchoCliente.Echo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoClient : System.ServiceModel.ClientBase<TesteCliente.EchoCliente.Echo>, TesteCliente.EchoCliente.Echo {
        
        public EchoClient() {
        }
        
        public EchoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EchoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TesteCliente.EchoCliente.echoResponse TesteCliente.EchoCliente.Echo.echo(TesteCliente.EchoCliente.echoRequest request) {
            return base.Channel.echo(request);
        }
        
        public string echo(string frase) {
            TesteCliente.EchoCliente.echoRequest inValue = new TesteCliente.EchoCliente.echoRequest();
            inValue.Body = new TesteCliente.EchoCliente.echoRequestBody();
            inValue.Body.frase = frase;
            TesteCliente.EchoCliente.echoResponse retVal = ((TesteCliente.EchoCliente.Echo)(this)).echo(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TesteCliente.EchoCliente.echoResponse> TesteCliente.EchoCliente.Echo.echoAsync(TesteCliente.EchoCliente.echoRequest request) {
            return base.Channel.echoAsync(request);
        }
        
        public System.Threading.Tasks.Task<TesteCliente.EchoCliente.echoResponse> echoAsync(string frase) {
            TesteCliente.EchoCliente.echoRequest inValue = new TesteCliente.EchoCliente.echoRequest();
            inValue.Body = new TesteCliente.EchoCliente.echoRequestBody();
            inValue.Body.frase = frase;
            return ((TesteCliente.EchoCliente.Echo)(this)).echoAsync(inValue);
        }
    }
}
