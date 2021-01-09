using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceVerificarDatos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceVerificarDatos : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que verifica si los datos estan vacion, o si superan el largo estimado")]
        public string VerificarDatosProducto(string dto1, string dto2, string dto3, string dto4, string dto5, string dto6, string dto7, string dto8)
        {
            if (String.IsNullOrEmpty(dto1) || String.IsNullOrEmpty(dto2) || String.IsNullOrEmpty(dto3) || String.IsNullOrEmpty(dto4) || String.IsNullOrEmpty(dto5) || String.IsNullOrEmpty(dto6) || String.IsNullOrEmpty(dto8))
            {
                return "A excepcion de Caracteristicas, los datos no pueden ser nulo.";
            }
            else if (dto1.Length >= 7)
            {
                return ("El id debe tener como maximo 6 caracteres");
                
            }
            else if (dto5.Length >= 7)
            {
                return("El id debe tener como maximo 6 caracteres");
                
            }
            else if (dto6.Length >= 20)
            {
                return ("El numero de caracteres supera al maximo en el Tipo de producto");
                
            }
            else if (dto7.Length >= 20)
            {
                return("El numero de caracteres supera al maximo en la Caracteristica");
                
            }
            else if (dto8.Length >= 20)
            {
                return("El numero de caracteres supera al maximo en la Marca");
                ;
            }
            else {
                return("bn");
            }
        }
    }
}
