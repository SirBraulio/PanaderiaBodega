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
    public class NegocioCliente
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "panaderia";
            this.Conec.NombreTabla = "cliente";
            this.Conec.CadenaConexion = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
        }

        public Boolean insertarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "insert into cliente(rutcliente,nombre,numero_celular,cant_compras)values('"
                                       + cliente.Rutcliente + "','" + cliente.Nombre + "','" + cliente.Numero_celular + "','" + cliente.Cant_compras + "');";
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

        public Cliente buscaCliente(String cliente)
        {
            Cliente auxProv = new Cliente();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM cliente"
                                   + " WHERE rutcliente = '" + cliente + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Rutcliente = (String)dt.Rows[0]["rutcliente"];
                auxProv.Nombre = (String)dt.Rows[0]["nombre"];
            }
            else
            {
                auxProv.Rutcliente = String.Empty;
                auxProv.Nombre = String.Empty;
            }
            return auxProv;
        } //Fin Busca//fin buscar
        public void actualizarCliente(Cliente cliente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE cliente SET rutcliente = '"
                                   + cliente.Rutcliente +
                                   "', nombre = '" + cliente.Nombre +
                                   "', numero_celular = '" + cliente.Numero_celular +
                                   
                                   "' WHERE idcliente = '" + cliente.Idcliente + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar
        /*public void actualizarCompreasCliente(Cliente cliente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE cliente SET cant_compras = '"
                                   + cliente.Cant_compras +
                                   "' WHERE rutcliente = '" + cliente.Idcliente + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } */
        public int SetCantidad(string sku, int cantidad)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("update cliente set cant_compras = '" + cantidad
                                   + "' WHERE rutcliente = '" + sku + "'", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["cant_compras"];
            }
            else
            {
                return cantidad;
            }
        }
    }
}
