using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDTO;
using CapaNegocio;


namespace CapaGUI
{
    public partial class GUIProducto : Form
    {
        public GUIProducto()
        {
            InitializeComponent();
        }

        private void GUIProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.panaderiaDataSet.proveedor);
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetProducto.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.panaderiaDataSetProducto.producto);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtIDProducto.ReadOnly = false;
            try
            {

                ServiceVerificadorDatos.WebServiceVerificarDatosSoapClient sverif = new ServiceVerificadorDatos.WebServiceVerificarDatosSoapClient();
                string devuelta = sverif.VerificarDatosProducto(txtIDProducto.Text, txtPrecioUni.Text, txtCantidad.Text, txtDiasV.Text, txtIdProv.Text, txtTipoP.Text, txtCaracteristica.Text, txtMarca.Text);
                if (devuelta.Length > 2) 
                {
                    MessageBox.Show(" " + devuelta, "Mensaje Sistema");
                }
                else
                {
                   
                    ServiceProducto.WebServiceProductoSoapClient AuxNeg = new ServiceProducto.WebServiceProductoSoapClient();
                    if (!String.IsNullOrEmpty(AuxNeg.ServicebuscaProv(this.txtIDProducto.Text).Idproducto))
                    {
                        MessageBox.Show("Producto ya existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        
                          ServiceProducto.Producto new_proc = new ServiceProducto.Producto();
                        //Producto new_proc = new Producto();
                        new_proc.Idproducto = this.txtIDProducto.Text;
                        new_proc.Precio_unitario = Convert.ToInt32(this.txtPrecioUni.Text);
                        new_proc.Cantidad = Convert.ToInt32(this.txtCantidad.Text);
                        new_proc.Dias_vencimiento = Convert.ToInt32(this.txtDiasV.Text);
                        new_proc.Idproveedor = this.txtIdProv.Text;
                        new_proc.Tipo_producto = this.txtTipoP.Text;
                        new_proc.Caracteristica = this.txtCaracteristica.Text;
                        new_proc.Marca = this.txtMarca.Text;
                        AuxNeg.Serviceinsertarproducto(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        this.productoTableAdapter.Fill(this.panaderiaDataSetProducto.producto);
                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        } //Fin insertar

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    String Nombre = this.dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);
                    txtIdProv.Text = Nombre;
                    txtIdProv.ReadOnly = true;                       
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);
                    txtIdProv.Text = Nombre;
                    txtIdProv.ReadOnly = true;
                }
            }
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
                    ServiceProducto.WebServiceProductoSoapClient AuxNeg = new ServiceProducto.WebServiceProductoSoapClient();
                    if (String.IsNullOrEmpty(AuxNeg.ServicebuscaProv(this.txtIDProducto.Text).Idproducto))
                    {
                        MessageBox.Show("El PRODUCTO NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        //MessageBox.Show("No se podra eliminar un proveedor si tiene un producto de este en bodega. ", "Mensaje Sistema");
                        var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar PARA SIEMPRE el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (confirmacion == DialogResult.Yes)
                        {
                            string iddeleted = this.txtIDProducto.Text;
                            AuxNeg.ServiceeliminarProv(iddeleted);
                            MessageBox.Show("Datos Eliminados Satisfactoriamente ", "Mensaje Sistema");
                            limpiar();
                            this.productoTableAdapter.Fill(this.panaderiaDataSetProducto.producto);
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

        private void brnModificar_Click(object sender, EventArgs e)
        {
           
            try
            {

                ServiceVerificadorDatos.WebServiceVerificarDatosSoapClient sverif = new ServiceVerificadorDatos.WebServiceVerificarDatosSoapClient();
                string devuelta = sverif.VerificarDatosProducto(txtIDProducto.Text, txtPrecioUni.Text, txtCantidad.Text, txtDiasV.Text, txtIdProv.Text, txtTipoP.Text, txtCaracteristica.Text, txtMarca.Text);
                if (devuelta.Length > 2) 
                {
                    MessageBox.Show(" " + devuelta, "Mensaje Sistema");
                }
                else
                {
                    ServiceProducto.WebServiceProductoSoapClient AuxNeg = new ServiceProducto.WebServiceProductoSoapClient();
                    if (String.IsNullOrEmpty(AuxNeg.ServicebuscaProv(this.txtIDProducto.Text).Idproducto))
                    {
                        MessageBox.Show("El PRODUCTO NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceProducto.Producto new_proc = new ServiceProducto.Producto();
                        new_proc.Idproducto = this.txtIDProducto.Text;
                        new_proc.Precio_unitario = Convert.ToInt32(this.txtPrecioUni.Text);
                        new_proc.Cantidad = Convert.ToInt32(this.txtCantidad.Text);
                        new_proc.Dias_vencimiento = Convert.ToInt32(this.txtDiasV.Text);
                        new_proc.Idproveedor = this.txtIdProv.Text;
                        new_proc.Tipo_producto = this.txtTipoP.Text;
                        new_proc.Caracteristica = this.txtCaracteristica.Text;
                        new_proc.Marca = this.txtMarca.Text;

                        AuxNeg.ServiceactualizarProv(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        this.productoTableAdapter.Fill(this.panaderiaDataSetProducto.producto);
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
            this.txtIDProducto.Text = String.Empty;
            this.txtPrecioUni.Text = String.Empty;
            this.txtCantidad.Text = String.Empty;
            this.txtDiasV.Text = String.Empty;
            this.txtIdProv.Text = String.Empty;
            this.txtTipoP.Text = String.Empty;
            this.txtCaracteristica.Text = String.Empty;
            this.txtMarca.Text = String.Empty;
            this.txtIDProducto.Focus();
            txtIdProv.ReadOnly = false;
            txtIDProducto.ReadOnly = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    
                    int j = 8;
                    for (int i = 0; i < j; i++)
                    { 
                        Console.WriteLine(" el i " + i);
                        String Nombre = this.dataGridView1[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + Nombre);
                        if (i == 0) { txtIDProducto.Text = Nombre; txtIDProducto.ReadOnly = true; }
                        else if (i == 1) { txtPrecioUni.Text = Nombre; }
                        else if (i == 2) { txtCantidad.Text = Nombre; }
                        else if (i == 3) { txtDiasV.Text = Nombre; }
                        else if (i == 4) { txtIdProv.Text = Nombre; }
                        else if (i == 5) { txtTipoP.Text = Nombre; }
                        else if (i == 6) { txtCaracteristica.Text = Nombre; }
                        else if (i == 7) { txtMarca.Text = Nombre; }                                             
                    }  
                    
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);
                    txtIdProv.Text = Nombre;
                    txtIdProv.ReadOnly = true;
                }
            }
        }


        public void ocultar_mostrar_Lista()
        {
            if (btnMostrarL.Visible == true)
            {
                dataGridView2.Visible = false;
                btnOcultar.Visible = false;
            }
            else {
                btnMostrarL.Visible = false;
                dataGridView2.Visible = true;
                btnOcultar.Visible = true;
            }
        }
        private void btnMostrarL_Click(object sender, EventArgs e)
        {
            btnMostrarL.Visible = false;
            ocultar_mostrar_Lista();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            btnMostrarL.Visible = true;
            ocultar_mostrar_Lista();
            txtIdProv.ReadOnly = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (txtIDProducto.ReadOnly == true & txtIdProv.ReadOnly == true) {
                this.txtPrecioUni.Text = String.Empty;
                this.txtCantidad.Text = String.Empty;
                this.txtDiasV.Text = String.Empty;
                this.txtTipoP.Text = String.Empty;
                this.txtCaracteristica.Text = String.Empty;
                this.txtMarca.Text = String.Empty;
                this.txtIDProducto.Focus();
                txtIDProducto.ReadOnly = false;
                txtIdProv.ReadOnly = false;
            }
            else if (txtIDProducto.ReadOnly == true) {
                this.txtPrecioUni.Text = String.Empty;
                this.txtCantidad.Text = String.Empty;
                this.txtDiasV.Text = String.Empty;
                this.txtIdProv.Text = String.Empty;
                this.txtTipoP.Text = String.Empty;
                this.txtCaracteristica.Text = String.Empty;
                this.txtMarca.Text = String.Empty;
                this.txtIDProducto.Focus();
                txtIDProducto.ReadOnly = false;

            }
            else if (txtIdProv.ReadOnly == true) {
                this.txtIDProducto.Text = String.Empty;
                this.txtPrecioUni.Text = String.Empty;
                this.txtCantidad.Text = String.Empty;
                this.txtDiasV.Text = String.Empty;
                this.txtTipoP.Text = String.Empty;
                this.txtCaracteristica.Text = String.Empty;
                this.txtMarca.Text = String.Empty;
                this.txtIDProducto.Focus();
                txtIdProv.ReadOnly = false;
            }
            else { limpiar(); }
            
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
