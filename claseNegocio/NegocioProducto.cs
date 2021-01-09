using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDTO;
using CapaConexion;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "panaderia";
            this.Conec.NombreTabla = "producto";
            this.Conec.CadenaConexion = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
        }
        public Boolean insertarproducto(Producto producto)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO producto(idproducto, precio_unitario, cantidad, dias_paravencimiento, idproveedor, tipo_producto, caracteristica, marca )VALUES('"
                                       + producto.Idproducto + "','" + producto.Precio_unitario + "','" + producto.Cantidad + "','" + producto.Dias_vencimiento + "','" + producto.Idproveedor + "','" + producto.Tipo_producto + "','" + producto.Caracteristica + "','" + producto.Marca + "');";
                this.Conec.EsSelect = false;
                this.Conec.conectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                Console.WriteLine("");
                return false;
            }

        } //Fin insertar

        public Producto buscaProv(String idproducto)
        {
            Producto auxProv = new Producto();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM producto"
                                   + " WHERE idproducto = '" + idproducto + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Idproducto = (String)dt.Rows[0]["idproducto"];
                auxProv.Tipo_producto = (String)dt.Rows[0]["tipo_producto"];
            }
            else
            {
                auxProv.Idproducto = String.Empty;
                auxProv.Tipo_producto = String.Empty;
            }
            return auxProv;
        } //Fin Busca
        public void eliminarProv(string IDaborrar)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = " DELETE FROM producto " +
                                                " WHERE idproducto = '" + IDaborrar + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();

        } //Fin eliminar
        public void actualizarProv(Producto producto)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE producto SET idproducto = '"
                                   + producto.Idproducto +
                                   "', precio_unitario = '" + producto.Precio_unitario +
                                   "', cantidad = '" + producto.Cantidad +
                                   "', dias_paravencimiento = '" + producto.Dias_vencimiento +
                                   "', tipo_producto = '" + producto.Tipo_producto +
                                   "', caracteristica = '" + producto.Caracteristica +
                                   "', marca = '" + producto.Marca +

                                   "' WHERE idproducto = '" + producto.Idproducto + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar  

        public string GetName(int diasv)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select idproducto, tipo_producto, marca from producto"
                                                         + " WHERE dias_paravencimiento = " + diasv + "", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return "ID : " + (string)ds["idproducto"] + ", Tipo: " + (string)ds["tipo_producto"] + ", Marca: " + (string)ds["marca"];
            }
            else
            {
                return "Error";
            }
        }
        //Metodo que busca en la bsd la pk (sku) ingresada, y retorna la cantidad disponible
        public int GetCantidad(string sku)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("SELECT cantidad FROM producto"
                                   + " WHERE idproducto = '" + sku + "'", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["cantidad"];
            }
            else
            {
                return 0;
            }
        }
        //Metodo que busca en la bsd la pk (sku) ingresada, y actualiza la cantidad de stock
        public int SetCantidad(string sku, int cantidad)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("update producto set cantidad = '" + cantidad
                                   + "' WHERE idproducto = '" + sku + "'", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["cantidad"];
            }
            else
            {
                return cantidad;
            }
        }
        //inicio estadisticas
        public int GetMinDiasV()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select dias_paravencimiento from producto order by dias_paravencimiento asc;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["dias_paravencimiento"];
            }
            else
            {
                return 0;
            }
        }
        /*public int GetProductMasVendido()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select v.idproducto,count(v.idproducto) as cuenta,p.tipo_producto from venta v join producto p on v.idproducto = p.idproducto group by v.idproducto, p.tipo_producto order by cuenta desc;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["cuenta"];
            }
            else
            {
                return 0;
            }
        }*/
        public Producto GetProductMasVendido()
        {
            Producto auxProv = new Producto();
            this.configurarConexion();
            this.Conec.CadenaSQL = "select v.idproducto,count(v.idproducto) as cuenta, sum(v.cantidad) as cantidad, p.tipo_producto from venta v join producto p on v.idproducto = p.idproducto group by v.idproducto, p.tipo_producto order by cuenta desc;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Idproducto = (String)dt.Rows[0]["idproducto"];
                auxProv.Tipo_producto = (String)dt.Rows[0]["tipo_producto"];
                auxProv.Cantidad = (int)dt.Rows[0]["cuenta"];
                auxProv.Dias_vencimiento = (int)dt.Rows[0]["cantidad"];
            }
            else
            {
                auxProv.Idproducto = String.Empty;
                auxProv.Tipo_producto = String.Empty;
                auxProv.Cantidad = 0;
                auxProv.Dias_vencimiento = 0;
            }
            return auxProv;
        }
        public DataSet consulta()
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "select * from producto";
            //this.Conec.CadenaSQL = "select v.idproducto,count(v.idproducto) as cuenta, sum(v.cantidad) as cantidad, p.tipo_producto from venta v join producto p on v.idproducto = p.idproducto group by v.idproducto, p.tipo_producto order by cuenta desc;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        } //Fin consulta

        public Producto GetClienteConMasCompras()
        {
            Producto auxProv = new Producto();
            this.configurarConexion();
            this.Conec.CadenaSQL = "select v.rutcliente,count(v.rutcliente) as cuenta, c.nombre, c.idcliente from venta v join cliente c on v.rutcliente = c.rutcliente group by v.rutcliente,c.nombre, c.idcliente order by cuenta desc;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Caracteristica = (String)dt.Rows[0]["rutcliente"];
                auxProv.Cantidad = (int)dt.Rows[0]["cuenta"];
                auxProv.Tipo_producto = (String)dt.Rows[0]["nombre"];
                auxProv.Precio_unitario = (int)dt.Rows[0]["idcliente"];
            }
            else
            {
                auxProv.Caracteristica = String.Empty;
                auxProv.Tipo_producto = String.Empty;
                auxProv.Cantidad = 0;
                auxProv.Precio_unitario = 0;
            }
            return auxProv;
        }
    }
}
