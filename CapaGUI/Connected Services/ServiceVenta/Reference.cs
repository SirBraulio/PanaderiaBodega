﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceVenta {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceVenta.WebServiceVentaSoap")]
    public interface WebServiceVentaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Serviceinsertarproducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Serviceinsertarproducto(CapaGUI.ServiceVenta.Venta producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Serviceinsertarproducto", ReplyAction="*")]
        System.Threading.Tasks.Task ServiceinsertarproductoAsync(CapaGUI.ServiceVenta.Venta producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceActulizarVent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ServiceActulizarVent(CapaGUI.ServiceVenta.Venta producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceActulizarVent", ReplyAction="*")]
        System.Threading.Tasks.Task ServiceActulizarVentAsync(CapaGUI.ServiceVenta.Venta producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetSum", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ServiceGetSum();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetSum", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ServiceGetSumAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetVentasSinCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ServiceGetVentasSinCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetVentasSinCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ServiceGetVentasSinClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetSumaTotaldeVentas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ServiceGetSumaTotaldeVentas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetSumaTotaldeVentas", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ServiceGetSumaTotaldeVentasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetConsultaVenta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ServiceGetConsultaVenta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ServiceGetConsultaVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ServiceGetConsultaVentaAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Venta : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idproductoField;
        
        private string rutclienteField;
        
        private int cantidadField;
        
        private int totalField;
        
        private int diferenciadorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Idproducto {
            get {
                return this.idproductoField;
            }
            set {
                this.idproductoField = value;
                this.RaisePropertyChanged("Idproducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Rutcliente {
            get {
                return this.rutclienteField;
            }
            set {
                this.rutclienteField = value;
                this.RaisePropertyChanged("Rutcliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
                this.RaisePropertyChanged("Cantidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
                this.RaisePropertyChanged("Total");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Diferenciador {
            get {
                return this.diferenciadorField;
            }
            set {
                this.diferenciadorField = value;
                this.RaisePropertyChanged("Diferenciador");
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
    public interface WebServiceVentaSoapChannel : CapaGUI.ServiceVenta.WebServiceVentaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceVentaSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceVenta.WebServiceVentaSoap>, CapaGUI.ServiceVenta.WebServiceVentaSoap {
        
        public WebServiceVentaSoapClient() {
        }
        
        public WebServiceVentaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceVentaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceVentaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceVentaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Serviceinsertarproducto(CapaGUI.ServiceVenta.Venta producto) {
            base.Channel.Serviceinsertarproducto(producto);
        }
        
        public System.Threading.Tasks.Task ServiceinsertarproductoAsync(CapaGUI.ServiceVenta.Venta producto) {
            return base.Channel.ServiceinsertarproductoAsync(producto);
        }
        
        public void ServiceActulizarVent(CapaGUI.ServiceVenta.Venta producto) {
            base.Channel.ServiceActulizarVent(producto);
        }
        
        public System.Threading.Tasks.Task ServiceActulizarVentAsync(CapaGUI.ServiceVenta.Venta producto) {
            return base.Channel.ServiceActulizarVentAsync(producto);
        }
        
        public int ServiceGetSum() {
            return base.Channel.ServiceGetSum();
        }
        
        public System.Threading.Tasks.Task<int> ServiceGetSumAsync() {
            return base.Channel.ServiceGetSumAsync();
        }
        
        public int ServiceGetVentasSinCliente() {
            return base.Channel.ServiceGetVentasSinCliente();
        }
        
        public System.Threading.Tasks.Task<int> ServiceGetVentasSinClienteAsync() {
            return base.Channel.ServiceGetVentasSinClienteAsync();
        }
        
        public int ServiceGetSumaTotaldeVentas() {
            return base.Channel.ServiceGetSumaTotaldeVentas();
        }
        
        public System.Threading.Tasks.Task<int> ServiceGetSumaTotaldeVentasAsync() {
            return base.Channel.ServiceGetSumaTotaldeVentasAsync();
        }
        
        public System.Data.DataSet ServiceGetConsultaVenta() {
            return base.Channel.ServiceGetConsultaVenta();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ServiceGetConsultaVentaAsync() {
            return base.Channel.ServiceGetConsultaVentaAsync();
        }
    }
}