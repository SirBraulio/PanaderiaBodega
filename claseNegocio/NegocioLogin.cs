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
    public class NegocioLogin
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "panaderia";
            this.Conec.NombreTabla = "login";
            this.Conec.CadenaConexion = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
        }
        public Boolean insertaruser(User user)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO login(usuario, contraseña, nombre, correo )VALUES('"
                                       + user.Usuario + "','" + user.Contraseña + "','" + user.Nombre + "','" + user.Correo + "');";
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

        public string GetUser(string user)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select usuario from login " + " WHERE usuario = '" + user + "'", conn);
            SqlDataReader ds = da.ExecuteReader();


            if (ds.Read())
            {
                string userfind = (string)ds["usuario"];

                
                return userfind;
            }
            else
            {
                return " ";
            }
        }

        public void eliminarUsr(string IDaborrar)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = " DELETE FROM login " +
                                                " WHERE usuario = '" + IDaborrar + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();

        } //Fin eliminar

        public User buscaUsr(String user)
        {
            User auxProv = new User();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM login"
                                   + " WHERE usuario = '" + user + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Usuario = (String)dt.Rows[0]["usuario"];
                auxProv.Contraseña = (String)dt.Rows[0]["contraseña"];
            }
            else
            {
                auxProv.Usuario = String.Empty;
                auxProv.Contraseña = String.Empty;
            }
            return auxProv;
        } //Fin Busca
        public string GetPasw(string user)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
            conn.Open();
            SqlCommand da = new SqlCommand("select contraseña from login " + " WHERE usuario = '" + user + "'", conn);
            SqlDataReader ds = da.ExecuteReader();


            if (ds.Read())
            {
                string contrafind = (string)ds["contraseña"];

                return contrafind;
            }
            else
            {
                return " ";
            }
        }



    }
}

