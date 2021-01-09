using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using capaDTO;
using CapaNegocio;


namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceInicioSesion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceInicioSesion : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que verifica si el user y contraseña es correcto")]
        public int GetUser(string user, string contra)
        {
            NegocioLogin auxneg = new NegocioLogin(); 
            string userfind = auxneg.GetUser(user);
            string contrafind = auxneg.GetPasw(user);
            if (user == userfind && contra == contrafind)
            {
                return 2;
            }
            return 0;
        }
        [WebMethod(Description = "Metodo que Inserta un nuevo usuario ")]
        public void ServiceinsertarUser(User user)
        {
            NegocioLogin auxn = new NegocioLogin();
            auxn.insertaruser(user);
        }
        [WebMethod(Description = "Metodo que borra un  usuario existente ")]
        public void ServiceDeleteUser(string user)
        {
            NegocioLogin auxn = new NegocioLogin();
            auxn.eliminarUsr(user);
        }
        [WebMethod(Description = "Metodo que busca a  un  usuario existente ")]
        public User ServiceBuscarUser(String user)
        {
            NegocioLogin auxn = new NegocioLogin();
            return auxn.buscaUsr(user);
        }
    }
}
