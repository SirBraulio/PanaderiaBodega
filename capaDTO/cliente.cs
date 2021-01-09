using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Cliente
    {
        private int idcliente;
        private String rutcliente;
        private String nombre;
        private int numero_celular;
        private int cant_compras;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Rutcliente { get => rutcliente; set => rutcliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero_celular { get => numero_celular; set => numero_celular = value; }
        public int Cant_compras { get => cant_compras; set => cant_compras = value; }
    }
}
