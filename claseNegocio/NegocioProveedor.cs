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
    public class NegocioProveedor
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "panaderia";
            this.Conec.NombreTabla = "proveedor";
            this.Conec.CadenaConexion = @"Data Source=LAPTOP-42GIDD10\SQLEXPRESS01;Initial Catalog=panaderia;Integrated Security=True";
        }

        public Boolean insertarProveedor(Proveedor proveedor)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO proveedor(idproveedor, nombre_prov, numero_prov)VALUES('"
                                       + proveedor.Idproveedor + "','" + proveedor.Nombre_prov + "','" + proveedor.Numero_prov + "');";
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

        public Proveedor buscaProv(String idproveedor)
        {
            Proveedor auxProv = new Proveedor();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM proveedor"
                                   + " WHERE idproveedor = '" + idproveedor + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Idproveedor = (String)dt.Rows[0]["idproveedor"];
                auxProv.Nombre_prov = (String)dt.Rows[0]["nombre_prov"];
            }
            else
            {
                auxProv.Idproveedor = String.Empty;
                auxProv.Nombre_prov = String.Empty;
            }
            return auxProv;
        } //Fin Busca
        public Proveedor buscaConcidencia(String idproveedor)
        {
            Proveedor auxProv = new Proveedor();
            this.configurarConexion();
            this.Conec.CadenaSQL = "select idproducto, idproveedor from producto"
                                   + " WHERE idproveedor = '" + idproveedor + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Idproveedor = (String)dt.Rows[0]["idproveedor"];
                auxProv.Nombre_prov = (String)dt.Rows[0]["idproducto"];
            }
            else
            {
                auxProv.Idproveedor = String.Empty;
                auxProv.Nombre_prov = String.Empty;
            }
            return auxProv;
        } //Fin Busca
        public void eliminarProv(string IDaborrar)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = " DELETE FROM proveedor " +
                                                " WHERE idproveedor = '" + IDaborrar + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();

        } //Fin eliminar
        public void actualizarProv(Proveedor proveedor)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE proveedor SET nombre_prov = '"
                                   + proveedor.Nombre_prov + "', numero_prov = '" + proveedor.Numero_prov + "' WHERE idproveedor = '" + proveedor.Idproveedor + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar
    }
}
