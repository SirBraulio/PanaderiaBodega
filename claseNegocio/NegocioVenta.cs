using CapaConexion;
using capaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioVenta
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "panaderia";
            this.Conec.NombreTabla = "venta";
            this.Conec.CadenaConexion = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
        }
        //misma venta se refiere a agregar una venta pero con el mismo identificador, 
        //esto para mantenerlo en el mismo grupo y poder somar el total final de la venta
        //para una venta abierta diferenciador = 0 para una cerrada = 1
        public Boolean insertarVenta(Venta venta)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO venta(idproducto, rutcliente, cantidad, total, diferenciador )VALUES('"
                                       + venta.Idproducto + "','" + venta.Rutcliente + "','" + venta.Cantidad + "','" + venta.Total + "','" + venta.Diferenciador + "');";
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
        public void actualizarVent(Venta venta)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE venta SET diferenciador = '"
                                   + venta.Diferenciador +
                                   "' WHERE diferenciador = '0';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar

        public int GetSuma()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select sum(total) as result from venta where diferenciador = 0;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["result"];
            }
            else
            {
                return 0;
            }
        }
        public int GetVentasSinCliente()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select  count(LEN(rutcliente)) as cuenta from venta where LEN(rutcliente) = 0;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["cuenta"];
            }
            else
            {
                return 0;
            }
        }
        public int GetSumaTotaldeVentas()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select ISNULL(sum(total),0) as sumafinal from venta;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["sumafinal"];
            }
            else
            {
                return 0;
            }
        }

        public DataSet consulta()
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "select * from venta";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        } //Fin consulta

    }
}
