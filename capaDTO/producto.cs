using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Producto
    {
        private String idproducto;
        private int precio_unitario;
        private int cantidad;
        private int dias_vencimiento;
        private String idproveedor;
        private String tipo_producto;
        private String caracteristica;
        private String marca;

        public String Idproducto { get => idproducto; set => idproducto = value; }
        public int Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Dias_vencimiento { get => dias_vencimiento; set => dias_vencimiento = value; }
        public String Idproveedor { get => idproveedor; set => idproveedor = value; }
        public String Tipo_producto { get => tipo_producto; set => tipo_producto = value; }
        public String Caracteristica { get => caracteristica; set => caracteristica = value; }
        public String Marca { get => marca; set => marca = value; }
    }
    
}
