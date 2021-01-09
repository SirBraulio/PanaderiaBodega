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
    /// Descripción breve de WebServiceVenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceVenta : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que Inserta una venta: para una venta abierta diferenciador = 0 para una cerrada = 1 ")]
        public void Serviceinsertarproducto(Venta producto)
        {
            NegocioVenta auxn = new NegocioVenta();
            auxn.insertarVenta(producto);
        }

        [WebMethod(Description = "Metodo que actualiza los registros de venta poniendo el diferenciador = 1 ")]
        public void ServiceActulizarVent(Venta producto)
        {
            NegocioVenta auxn = new NegocioVenta();
            auxn.actualizarVent(producto);
        }
        [WebMethod(Description = "Metodo que retorna la suma total de valores ")]
        public int ServiceGetSum()
        {
            NegocioVenta auxn = new NegocioVenta();
            return auxn.GetSuma();
        }
        [WebMethod(Description = "Metodo que retorna el total de ventas sin clientes asociados ")]
        public int ServiceGetVentasSinCliente()
        {
            NegocioVenta auxn = new NegocioVenta();
            return auxn.GetVentasSinCliente();
        }
        [WebMethod(Description = "Metodo que retorna la suma total de las ventas ")]
        public int ServiceGetSumaTotaldeVentas()
        {
            NegocioVenta auxn = new NegocioVenta();
            return auxn.GetSumaTotaldeVentas();
        }

        [WebMethod(Description = "Metodo que llena la tabla producto de datos")]
        public DataSet ServiceGetConsultaVenta()
        {
            NegocioVenta auxn = new NegocioVenta();
            return auxn.consulta();
        }

    }
}
