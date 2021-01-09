using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class GUIAdminUsers : Form
    {
        public GUIAdminUsers()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el Usuario ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtContra.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para la contraseña ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el nombre ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtCorreo.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el correo ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtVerif.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para la verificacion de la contraseña ", "Mensaje Sistema");
                    return;
                }
                else if (txtContra.Text != txtVerif.Text) 
                {
                    MessageBox.Show("Las contraseñas no coinciden ", "Mensaje Sistema");
                    return;
                }
                else
                {
                    ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient auxN = new ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient();
                    if (!String.IsNullOrEmpty(auxN.ServiceBuscarUser(this.txtUsuario.Text).Usuario))
                    {
                        MessageBox.Show("Usuario ya existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient aux = new ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient();
                        ServiceVerificarUserPsw.User new_proc = new ServiceVerificarUserPsw.User();
                        //ServiceProducto.Producto new_proc = new ServiceProducto.Producto();
                        //Producto new_proc = new Producto();
                        new_proc.Usuario = this.txtUsuario.Text;
                        new_proc.Contraseña = this.txtContra.Text;
                        new_proc.Nombre = this.txtNombre.Text;
                        new_proc.Correo = this.txtCorreo.Text;

                        aux.ServiceinsertarUser(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    MessageBox.Show("Por Favor seleccione o ingrese un Usuario EXISTENTE ", "Mensaje Sistema");
                    return;
                }
                else 
                {
                    ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient auxN = new ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient();
                    if (String.IsNullOrEmpty(auxN.ServiceBuscarUser(this.txtUsuario.Text).Usuario))
                    {
                        MessageBox.Show("Usuario No existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient aux = new ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient();
                        string idaborrar = txtUsuario.Text;
                        aux.ServiceDeleteUser(idaborrar);
                        MessageBox.Show("Usuario Eliminado Satisfactoriamente ", "Mensaje Sistema");
                        limpiar();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }

        }
        private void limpiar() {
            this.txtUsuario.Text = String.Empty;
            this.txtContra.Text = String.Empty;
            this.txtNombre.Text = String.Empty;            
            this.txtCorreo.Text = String.Empty;
            this.txtVerif.Text = String.Empty;

        }

        private void GUIAdminUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetUser.login' Puede moverla o quitarla según sea necesario.
            this.loginTableAdapter.Fill(this.panaderiaDataSetUser.login);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {

                    int j = 4;
                    for (int i = 0; i < j; i++)
                    {
                        Console.WriteLine(" el i " + i);
                        String Nombre = this.dataGridView1[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + Nombre);
                        if (i == 0) { txtUsuario.Text = Nombre; }
                        else if (i == 1) { txtContra.Text = Nombre; txtVerif.Text = Nombre; }
                        else if (i == 2) { txtNombre.Text = Nombre; }
                        else if (i == 3) { txtCorreo.Text = Nombre; }
                        else if (i == 4) { }
                    }

                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (btnMostrarTabla.Text == "Mostrar Lista")
            {
                btnMostrarTabla.Text = "Ocultar Lista";
            }
            else if (btnMostrarTabla.Text == "Ocultar Lista") { btnMostrarTabla.Text = "Mostrar Lista"; dataGridView1.Visible = false; }
            else { }
        }

        private void irAMantenedorDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIProducto pProducto = new GUIProducto();
            pProducto.ShowDialog();
        }

        private void irAMantenedorDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIProveedor pProducto = new GUIProveedor();
            pProducto.ShowDialog();
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void irAAdministracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIAdminUsers pProducto = new GUIAdminUsers();
            pProducto.ShowDialog();
        }

        private void irAAdminnistracionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIAdminClientes pProducto = new GUIAdminClientes();
            pProducto.ShowDialog();
        }

        private void irANuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIVentas pProducto = new GUIVentas();
            pProducto.ShowDialog();
        }

        private void irAMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUImenu pMenu = new GUImenu();
            pMenu.ShowDialog();
        }
    }
}
