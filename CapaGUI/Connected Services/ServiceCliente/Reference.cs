﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdclienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RutclienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        private int Numero_celularField;
        
        private int Cant_comprasField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Idcliente {
            get {
                return this.IdclienteField;
            }
            set {
                if ((this.IdclienteField.Equals(value) != true)) {
                    this.IdclienteField = value;
                    this.RaisePropertyChanged("Idcliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Rutcliente {
            get {
                return this.RutclienteField;
            }
            set {
                if ((object.ReferenceEquals(this.RutclienteField, value) != true)) {
                    this.RutclienteField = value;
                    this.RaisePropertyChanged("Rutcliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Numero_celular {
            get {
                return this.Numero_celularField;
            }
            set {
                if ((this.Numero_celularField.Equals(value) != true)) {
                    this.Numero_celularField = value;
                    this.RaisePropertyChanged("Numero_celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Cant_compras {
            get {
                return this.Cant_comprasField;
            }
            set {
                if ((this.Cant_comprasField.Equals(value) != true)) {
                    this.Cant_comprasField = value;
                    this.RaisePropertyChanged("Cant_compras");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCliente.WebServiceClienteSoap")]
    public interface WebServiceClienteSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceinsertarCliente", ReplyAction="*")]
        CapaGUI.ServiceCliente.ServiceinsertarClienteResponse ServiceinsertarCliente(CapaGUI.ServiceCliente.ServiceinsertarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceinsertarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceinsertarClienteResponse> ServiceinsertarClienteAsync(CapaGUI.ServiceCliente.ServiceinsertarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicebuscaCliente", ReplyAction="*")]
        CapaGUI.ServiceCliente.ServicebuscaClienteResponse ServicebuscaCliente(CapaGUI.ServiceCliente.ServicebuscaClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServicebuscaCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServicebuscaClienteResponse> ServicebuscaClienteAsync(CapaGUI.ServiceCliente.ServicebuscaClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cliente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceactualizarCliente", ReplyAction="*")]
        CapaGUI.ServiceCliente.ServiceactualizarClienteResponse ServiceactualizarCliente(CapaGUI.ServiceCliente.ServiceactualizarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceactualizarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceactualizarClienteResponse> ServiceactualizarClienteAsync(CapaGUI.ServiceCliente.ServiceactualizarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento sku del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceActualizarCompreasCliente", ReplyAction="*")]
        CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponse ServiceActualizarCompreasCliente(CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceActualizarCompreasCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponse> ServiceActualizarCompreasClienteAsync(CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceinsertarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceinsertarCliente", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServiceinsertarClienteRequestBody Body;
        
        public ServiceinsertarClienteRequest() {
        }
        
        public ServiceinsertarClienteRequest(CapaGUI.ServiceCliente.ServiceinsertarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServiceinsertarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceCliente.Cliente cliente;
        
        public ServiceinsertarClienteRequestBody() {
        }
        
        public ServiceinsertarClienteRequestBody(CapaGUI.ServiceCliente.Cliente cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceinsertarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceinsertarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServiceinsertarClienteResponseBody Body;
        
        public ServiceinsertarClienteResponse() {
        }
        
        public ServiceinsertarClienteResponse(CapaGUI.ServiceCliente.ServiceinsertarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ServiceinsertarClienteResponseBody {
        
        public ServiceinsertarClienteResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicebuscaClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicebuscaCliente", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServicebuscaClienteRequestBody Body;
        
        public ServicebuscaClienteRequest() {
        }
        
        public ServicebuscaClienteRequest(CapaGUI.ServiceCliente.ServicebuscaClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicebuscaClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cliente;
        
        public ServicebuscaClienteRequestBody() {
        }
        
        public ServicebuscaClienteRequestBody(string cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServicebuscaClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServicebuscaClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServicebuscaClienteResponseBody Body;
        
        public ServicebuscaClienteResponse() {
        }
        
        public ServicebuscaClienteResponse(CapaGUI.ServiceCliente.ServicebuscaClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServicebuscaClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceCliente.Cliente ServicebuscaClienteResult;
        
        public ServicebuscaClienteResponseBody() {
        }
        
        public ServicebuscaClienteResponseBody(CapaGUI.ServiceCliente.Cliente ServicebuscaClienteResult) {
            this.ServicebuscaClienteResult = ServicebuscaClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceactualizarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceactualizarCliente", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServiceactualizarClienteRequestBody Body;
        
        public ServiceactualizarClienteRequest() {
        }
        
        public ServiceactualizarClienteRequest(CapaGUI.ServiceCliente.ServiceactualizarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServiceactualizarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceCliente.Cliente cliente;
        
        public ServiceactualizarClienteRequestBody() {
        }
        
        public ServiceactualizarClienteRequestBody(CapaGUI.ServiceCliente.Cliente cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceactualizarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceactualizarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServiceactualizarClienteResponseBody Body;
        
        public ServiceactualizarClienteResponse() {
        }
        
        public ServiceactualizarClienteResponse(CapaGUI.ServiceCliente.ServiceactualizarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ServiceactualizarClienteResponseBody {
        
        public ServiceactualizarClienteResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceActualizarCompreasClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceActualizarCompreasCliente", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequestBody Body;
        
        public ServiceActualizarCompreasClienteRequest() {
        }
        
        public ServiceActualizarCompreasClienteRequest(CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ServiceActualizarCompreasClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sku;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int cantidad;
        
        public ServiceActualizarCompreasClienteRequestBody() {
        }
        
        public ServiceActualizarCompreasClienteRequestBody(string sku, int cantidad) {
            this.sku = sku;
            this.cantidad = cantidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ServiceActualizarCompreasClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ServiceActualizarCompreasClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponseBody Body;
        
        public ServiceActualizarCompreasClienteResponse() {
        }
        
        public ServiceActualizarCompreasClienteResponse(CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ServiceActualizarCompreasClienteResponseBody {
        
        public ServiceActualizarCompreasClienteResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceClienteSoapChannel : CapaGUI.ServiceCliente.WebServiceClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceClienteSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceCliente.WebServiceClienteSoap>, CapaGUI.ServiceCliente.WebServiceClienteSoap {
        
        public WebServiceClienteSoapClient() {
        }
        
        public WebServiceClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceCliente.ServiceinsertarClienteResponse CapaGUI.ServiceCliente.WebServiceClienteSoap.ServiceinsertarCliente(CapaGUI.ServiceCliente.ServiceinsertarClienteRequest request) {
            return base.Channel.ServiceinsertarCliente(request);
        }
        
        public void ServiceinsertarCliente(CapaGUI.ServiceCliente.Cliente cliente) {
            CapaGUI.ServiceCliente.ServiceinsertarClienteRequest inValue = new CapaGUI.ServiceCliente.ServiceinsertarClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServiceinsertarClienteRequestBody();
            inValue.Body.cliente = cliente;
            CapaGUI.ServiceCliente.ServiceinsertarClienteResponse retVal = ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceinsertarCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceinsertarClienteResponse> CapaGUI.ServiceCliente.WebServiceClienteSoap.ServiceinsertarClienteAsync(CapaGUI.ServiceCliente.ServiceinsertarClienteRequest request) {
            return base.Channel.ServiceinsertarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceinsertarClienteResponse> ServiceinsertarClienteAsync(CapaGUI.ServiceCliente.Cliente cliente) {
            CapaGUI.ServiceCliente.ServiceinsertarClienteRequest inValue = new CapaGUI.ServiceCliente.ServiceinsertarClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServiceinsertarClienteRequestBody();
            inValue.Body.cliente = cliente;
            return ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceinsertarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceCliente.ServicebuscaClienteResponse CapaGUI.ServiceCliente.WebServiceClienteSoap.ServicebuscaCliente(CapaGUI.ServiceCliente.ServicebuscaClienteRequest request) {
            return base.Channel.ServicebuscaCliente(request);
        }
        
        public CapaGUI.ServiceCliente.Cliente ServicebuscaCliente(string cliente) {
            CapaGUI.ServiceCliente.ServicebuscaClienteRequest inValue = new CapaGUI.ServiceCliente.ServicebuscaClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServicebuscaClienteRequestBody();
            inValue.Body.cliente = cliente;
            CapaGUI.ServiceCliente.ServicebuscaClienteResponse retVal = ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServicebuscaCliente(inValue);
            return retVal.Body.ServicebuscaClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServicebuscaClienteResponse> CapaGUI.ServiceCliente.WebServiceClienteSoap.ServicebuscaClienteAsync(CapaGUI.ServiceCliente.ServicebuscaClienteRequest request) {
            return base.Channel.ServicebuscaClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServicebuscaClienteResponse> ServicebuscaClienteAsync(string cliente) {
            CapaGUI.ServiceCliente.ServicebuscaClienteRequest inValue = new CapaGUI.ServiceCliente.ServicebuscaClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServicebuscaClienteRequestBody();
            inValue.Body.cliente = cliente;
            return ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServicebuscaClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceCliente.ServiceactualizarClienteResponse CapaGUI.ServiceCliente.WebServiceClienteSoap.ServiceactualizarCliente(CapaGUI.ServiceCliente.ServiceactualizarClienteRequest request) {
            return base.Channel.ServiceactualizarCliente(request);
        }
        
        public void ServiceactualizarCliente(CapaGUI.ServiceCliente.Cliente cliente) {
            CapaGUI.ServiceCliente.ServiceactualizarClienteRequest inValue = new CapaGUI.ServiceCliente.ServiceactualizarClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServiceactualizarClienteRequestBody();
            inValue.Body.cliente = cliente;
            CapaGUI.ServiceCliente.ServiceactualizarClienteResponse retVal = ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceactualizarCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceactualizarClienteResponse> CapaGUI.ServiceCliente.WebServiceClienteSoap.ServiceactualizarClienteAsync(CapaGUI.ServiceCliente.ServiceactualizarClienteRequest request) {
            return base.Channel.ServiceactualizarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceactualizarClienteResponse> ServiceactualizarClienteAsync(CapaGUI.ServiceCliente.Cliente cliente) {
            CapaGUI.ServiceCliente.ServiceactualizarClienteRequest inValue = new CapaGUI.ServiceCliente.ServiceactualizarClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServiceactualizarClienteRequestBody();
            inValue.Body.cliente = cliente;
            return ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceactualizarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponse CapaGUI.ServiceCliente.WebServiceClienteSoap.ServiceActualizarCompreasCliente(CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest request) {
            return base.Channel.ServiceActualizarCompreasCliente(request);
        }
        
        public void ServiceActualizarCompreasCliente(string sku, int cantidad) {
            CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest inValue = new CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequestBody();
            inValue.Body.sku = sku;
            inValue.Body.cantidad = cantidad;
            CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponse retVal = ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceActualizarCompreasCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponse> CapaGUI.ServiceCliente.WebServiceClienteSoap.ServiceActualizarCompreasClienteAsync(CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest request) {
            return base.Channel.ServiceActualizarCompreasClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteResponse> ServiceActualizarCompreasClienteAsync(string sku, int cantidad) {
            CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest inValue = new CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequest();
            inValue.Body = new CapaGUI.ServiceCliente.ServiceActualizarCompreasClienteRequestBody();
            inValue.Body.sku = sku;
            inValue.Body.cantidad = cantidad;
            return ((CapaGUI.ServiceCliente.WebServiceClienteSoap)(this)).ServiceActualizarCompreasClienteAsync(inValue);
        }
    }
}