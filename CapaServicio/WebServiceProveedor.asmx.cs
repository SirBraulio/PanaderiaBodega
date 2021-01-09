using capaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceProveedor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProveedor : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que Inserta un nuevo proveedor ")]
        public Boolean ServicioinsertarProveedor(Proveedor proveedor) 
        {
            NegocioProveedor auxn = new NegocioProveedor();
            return auxn.insertarProveedor(proveedor);
        }
        [WebMethod(Description = "Metodo que busca un proveedor por su id ")]
        public Proveedor ServiciobuscaProv(String idproveedor) 
        {
            NegocioProveedor auxn = new NegocioProveedor();
            return auxn.buscaProv(idproveedor);
        }
        [WebMethod(Description = "Metodo que busca un proveedor si hay coincidencias por su id ")]
        public Proveedor ServiciobuscaConcidencia(String idproveedor) 
        {
            NegocioProveedor auxn = new NegocioProveedor();
            return auxn.buscaConcidencia(idproveedor);
        }
        [WebMethod(Description = "Metodo que elimina a un proveedor por su id ")]
        public void ServicioeliminarProv(string IDaborrar) 
        {
            NegocioProveedor auxn = new NegocioProveedor();
            auxn.eliminarProv(IDaborrar);
        }
        [WebMethod(Description = "Metodo que actualiza o modifica a un proveedor por su id ")]
        public void ServcioactualizarProv(Proveedor proveedor) 
        {
            NegocioProveedor auxn = new NegocioProveedor();
            auxn.actualizarProv(proveedor);
        }
    }
}
