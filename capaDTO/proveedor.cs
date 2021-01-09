using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Proveedor
    {
        private String idproveedor;
        private String nombre_prov;
        private int numero_prov;

        public String Idproveedor { get => idproveedor; set => idproveedor = value; }
        public String Nombre_prov { get => nombre_prov; set => nombre_prov = value; }
        public int Numero_prov { get => numero_prov; set => numero_prov = value; }
    }
}
