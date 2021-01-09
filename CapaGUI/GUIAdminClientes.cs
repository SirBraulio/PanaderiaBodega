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
    public partial class GUIAdminClientes : Form
    {
        public GUIAdminClientes()
        {
            InitializeComponent();
        }

        private void GUIAdminClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetClientes.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.panaderiaDataSetClientes.cliente);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (String.IsNullOrEmpty(this.txtRutCliente.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el RUT ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el nombre del cliente ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtNumeroCel.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el numero ", "Mensaje Sistema");
                    return;
                }
                else
                {

                    ServiceCliente.WebServiceClienteSoapClient aux = new ServiceCliente.WebServiceClienteSoapClient();
                    if (!String.IsNullOrEmpty(aux.ServicebuscaCliente(this.txtRutCliente.Text).Rutcliente))
                    {
                        MessageBox.Show("Cliente ya existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceCliente.Cliente new_proc = new ServiceCliente.Cliente();
                        new_proc.Rutcliente = this.txtRutCliente.Text;
                        new_proc.Nombre = this.txtNombre.Text;
                        new_proc.Numero_celular = Convert.ToInt32(this.txtNumeroCel.Text);
                        new_proc.Cant_compras = 0;
                        aux.ServiceinsertarCliente(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        clienteTableAdapter.Fill(this.panaderiaDataSetClientes.cliente);

                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void irAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUImenu pMenu = new GUImenu();
            pMenu.ShowDialog();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtRutCliente.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el RUT ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el nombre del cliente ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtNumeroCel.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el numero ", "Mensaje Sistema");
                    return;
                }
                else
                {

                    ServiceCliente.WebServiceClienteSoapClient aux = new ServiceCliente.WebServiceClienteSoapClient();
                    if (Convert.ToInt32(txtIdCliente.Text) == 0)
                    {
                        MessageBox.Show("El Cliente NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceCliente.Cliente new_proc = new ServiceCliente.Cliente();
                        new_proc.Idcliente = Convert.ToInt32(this.txtIdCliente.Text);
                        new_proc.Rutcliente = this.txtRutCliente.Text;
                        new_proc.Nombre = this.txtNombre.Text;
                        new_proc.Numero_celular = Convert.ToInt32(this.txtNumeroCel.Text);
                        aux.ServiceactualizarCliente(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        clienteTableAdapter.Fill(this.panaderiaDataSetClientes.cliente);
                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
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
                        if (i == 0) { txtIdCliente.Text = Nombre; }
                        else if (i == 1) { txtRutCliente.Text = Nombre; }
                        else if (i == 2) { txtNombre.Text = Nombre; }
                        else if (i == 3) { txtNumeroCel.Text = Nombre; }
                        
                    }

                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);
                    
                }
            }
        }
        public void limpiar()
        {
            this.txtIdCliente.Text = String.Empty;
            this.txtRutCliente.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.txtNumeroCel.Text = String.Empty;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (btnList.Text == "Mostrar Lista")
            {
                btnList.Text = "Ocultar Lista";
            }
            else if (btnList.Text == "Ocultar Lista") {btnList.Text = "Mostrar Lista"; dataGridView1.Visible = false; }
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
