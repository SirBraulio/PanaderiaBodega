using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDTO;
using CapaNegocio;

namespace CapaGUI
{
    public partial class GUIProveedor : Form
    {
        public GUIProveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.panaderiaDataSet.proveedor);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProv.Text) || String.IsNullOrEmpty(this.txtNameProv.Text) || String.IsNullOrEmpty(this.txtNumberProv.Text))
                {
                    MessageBox.Show("No se pueden dejar datos en blanco ", "Mensaje Sistema");
                    return;
                }
                else if (txtIdProv.Text.Length >= 7)
                {
                    MessageBox.Show("El id debe tener como maximo 6 caracteres", "Mensaje Sistema");
                    return;
                }
                else if (txtNameProv.Text.Length >= 50)
                {
                    MessageBox.Show("La cantidad de caracteres de Nombre excede el maximo ", "Mensaje Sistema");
                    return;
                }
                else
                {
                    ServiceProveedor.WebServiceProveedorSoapClient Aux_negProv = new ServiceProveedor.WebServiceProveedorSoapClient();
                    
                    if (!String.IsNullOrEmpty(Aux_negProv.ServiciobuscaProv(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("Proveedor ya existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceProveedor.Proveedor new_proc = new ServiceProveedor.Proveedor();                       
                        new_proc.Idproveedor = this.txtIdProv.Text;
                        new_proc.Nombre_prov = this.txtNameProv.Text;
                        new_proc.Numero_prov = Convert.ToInt32(this.txtNumberProv.Text);

                        Boolean result = Aux_negProv.ServicioinsertarProveedor(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        this.proveedorTableAdapter.Fill(this.panaderiaDataSet.proveedor);
                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }

        }

        public void limpiar()
        {
            this.txtIdProv.Text = String.Empty;
            this.txtNameProv.Text = String.Empty;
            this.txtNumberProv.Text = String.Empty;
            this.txtIdProv.Focus();
            txtIdProv.ReadOnly = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProv.Text))
                {
                    MessageBox.Show("Por Favor seleccione o ingrese un ID EXISTENTE ", "Mensaje Sistema");
                    return;
                }
                else
                {
                    ServiceProveedor.WebServiceProveedorSoapClient Aux_negProv = new ServiceProveedor.WebServiceProveedorSoapClient();
                    
                    if (String.IsNullOrEmpty(Aux_negProv.ServiciobuscaProv(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("Proveedor NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else if (!String.IsNullOrEmpty(Aux_negProv.ServiciobuscaConcidencia(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("El Proveedor tiene uno o varios productos a su nombre, por lo tanto no se puede eliminar ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No se podra eliminar un proveedor si tiene un producto de este en bodega. ", "Mensaje Sistema");
                        var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar PARA SIEMPRE el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (confirmacion == DialogResult.Yes)
                        {                           
                            string iddeleted = this.txtIdProv.Text;
                            Aux_negProv.ServicioeliminarProv(iddeleted);
                            MessageBox.Show("Datos Eliminados Satisfactoriamente ", "Mensaje Sistema");
                            limpiar();
                            this.proveedorTableAdapter.Fill(this.panaderiaDataSet.proveedor);
                        }
                        else 
                        {
                            MessageBox.Show("Se a arrepentido justo a tiempo ", "Mensaje Sistema");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProv.Text) || String.IsNullOrEmpty(this.txtNameProv.Text) || String.IsNullOrEmpty(this.txtNumberProv.Text))
                {
                    MessageBox.Show("No se pueden dejar datos en blanco ", "Mensaje Sistema");
                    return;
                }
                else
                {
                    ServiceProveedor.WebServiceProveedorSoapClient Aux_negProv = new  ServiceProveedor.WebServiceProveedorSoapClient();
                    //NegocioProveedor Aux_negProv = new NegocioProveedor();
                    if (String.IsNullOrEmpty(Aux_negProv.ServiciobuscaProv(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("El ID del Proveedor NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else if (txtIdProv.Text.Length >= 7)
                    {
                        MessageBox.Show("El id debe tener como maximo 6 caracteres", "Mensaje Sistema");
                        return;
                    }
                    else if (txtNameProv.Text.Length >= 50)
                    {
                        MessageBox.Show("La cantidad de caracteres de Nombre excede el maximo ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceProveedor.Proveedor new_proc = new ServiceProveedor.Proveedor();
                       
                        new_proc.Idproveedor = this.txtIdProv.Text;
                        new_proc.Nombre_prov = this.txtNameProv.Text;
                        new_proc.Numero_prov = Convert.ToInt32(this.txtNumberProv.Text);

                        Aux_negProv.ServcioactualizarProv(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        limpiar();
                        this.proveedorTableAdapter.Fill(this.panaderiaDataSet.proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (btnList.Text == "Mostrar Lista")
            {
                btnList.Text = "Ocultar Lista";
            }
            else if (btnList.Text == "Ocultar Lista") { txtIdProv.ReadOnly = false; this.proveedorTableAdapter.Fill(this.panaderiaDataSet.proveedor); btnList.Text = "Mostrar Lista"; dataGridView1.Visible = false; }
            else { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                
                if (e.ColumnIndex == 0)
                {

                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" " + Nombre);
                    txtIdProv.Text = Nombre;
                    txtIdProv.ReadOnly = true;
                }
                else if (e.ColumnIndex == 1) {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" " + Nombre);
                    txtNameProv.Text = Nombre;
                    txtIdProv.ReadOnly = true;
                }
            }
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
