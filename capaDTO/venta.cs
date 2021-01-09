using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Venta
    {
     
        private String idproducto;
        private String rutcliente;
        private int cantidad;
        private int total;
        private int diferenciador;

        
        public string Idproducto { get => idproducto; set => idproducto = value; }
        public string Rutcliente { get => rutcliente; set => rutcliente = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total { get => total; set => total = value; }
        public int Diferenciador { get => diferenciador; set => diferenciador = value; }
    }
}
