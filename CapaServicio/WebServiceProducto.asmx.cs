using capaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProducto : System.Web.Services.WebService
    {

        
        [WebMethod(Description = "Metodo que Inserta el producto ")]
        public void Serviceinsertarproducto(Producto producto) {
            NegocioProducto auxn = new NegocioProducto();
            auxn.insertarproducto(producto);
        }

        [WebMethod(Description = "Metodo que busca el producto por su id")]
        public Producto ServicebuscaProv(String producto)
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.buscaProv(producto);
        }
       
        [WebMethod(Description = "Metodo que elimina un producto por su id")]
        public void ServiceeliminarProv(string IDaborrar)
        {
            NegocioProducto auxn = new NegocioProducto();
            auxn.eliminarProv(IDaborrar);
        }

        [WebMethod(Description = "Metodo que Actualiza o Modifica un producto por su id")]
        public void ServiceactualizarProv(Producto producto) 
        {
            NegocioProducto auxn = new NegocioProducto();
            auxn.actualizarProv(producto);
        }
        [WebMethod(Description = "Metodo que retorna los dias mas sercanos a vencer")]
        public int ServiceGetMinDiasV() 
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.GetMinDiasV();
        }
        [WebMethod(Description = "Metodo que retorna el primer nombre retornado a partir de los dias a vencer")]
        public string GetName(int diasv) 
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.GetName(diasv);
        }
        [WebMethod(Description = "Metodo que retorna la cantidad del producto si le entregas la id de el mismo")]
        public int ServiceGetCantidadP(string idproducto)
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.GetCantidad(idproducto);
        }
        [WebMethod(Description = "Metodo que setea la nueva cantidad del producto si le entregas la id de el mismo")]
        public int ServiceSetCantidadP(string idproducto, int newcantidad)
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.SetCantidad(idproducto, newcantidad);
        }
        [WebMethod(Description = "Metodo que retorna los datos del producto con mas compras, independiente de la cantidad de unidades vendidas")]
        public Producto ServiceGetProductMasVendido()
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.GetProductMasVendido();
        }
        [WebMethod(Description = "Metodo que retorna los datos del cliente con mas compras")]
        public Producto ServiceGetClienteConMasCompras()
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.GetClienteConMasCompras();
        }
        [WebMethod(Description = "Metodo que llena la tabla producto de datos")]
        public DataSet ServiceGetConsultaProducto()
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.consulta();
        }


    }
}
