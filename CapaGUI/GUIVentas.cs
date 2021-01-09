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
    public partial class GUIVentas : Form
    {
        public GUIVentas()
        {
            InitializeComponent();
            txtIdProducto.ReadOnly = true;
            txtPrecioP.ReadOnly = true;
        }
        private void verificarlacantidad() 
        {
            ServiceProducto.WebServiceProductoSoapClient new_proc = new ServiceProducto.WebServiceProductoSoapClient();
            int cantidadbsd = new_proc.ServiceGetCantidadP(txtIdProducto.Text);
            int cantGUI = Convert.ToInt32(txtCantidad.Text);
            if (cantidadbsd < cantGUI)
            {
                MessageBox.Show("Error la cantidad excede la cantidad del stock: " + cantidadbsd, "Mensaje Sistema");
            }
            else
            {
                MessageBox.Show("Valor dentro del stock", "Mensaje Sistema");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            verificarlacantidad();
        }

        private void GUIVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetVenta.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.FillBy(this.panaderiaDataSetVenta.venta);
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetProducto.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.panaderiaDataSetProducto.producto);

        }
        private void limpiar() 
        {
            txtIdProducto.Text = String.Empty;
            txtRutCliente.Text = String.Empty;
            txtPrecioP.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtPagarxProducto.Text = String.Empty;
            txtTotalApagar.Text = String.Empty;
            txtPagaCon.Text = String.Empty;
            txtVuelto.Text = String.Empty;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {

                    int j = 3;
                    for (int i = 0; i < j; i++)
                    {
                        Console.WriteLine(" el i " + i);
                        String Nombre = this.dataGridView1[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + Nombre);
                        if (i == 0) {  }
                        else if (i == 1) { txtIdProducto.Text = Nombre;  }
                        else if (i == 2) { txtPrecioP.Text = Nombre; }
                        
                    }

                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }

        private void btnMostrarL_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (btnMostrarL.Text == "Mostrar Lista Productos")
            {
                btnMostrarL.Text = "Ocultar Lista";
            }
            else if (btnMostrarL.Text == "Ocultar Lista") { btnMostrarL.Text = "Mostrar Lista Productos"; dataGridView1.Visible = false; }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProducto.Text) || String.IsNullOrEmpty(this.txtCantidad.Text) || String.IsNullOrEmpty(this.txtPagarxProducto.Text))
                {
                    MessageBox.Show("No se pueden dejar datos en blanco ", "Mensaje Sistema");
                    return;
                }
                ServiceProducto.WebServiceProductoSoapClient new_procc = new ServiceProducto.WebServiceProductoSoapClient();
                int cantidadbsd = new_procc.ServiceGetCantidadP(txtIdProducto.Text);
                int cantGUI = Convert.ToInt32(txtCantidad.Text);
                int resta = cantidadbsd - cantGUI;
                if (cantidadbsd < cantGUI)
                {
                    MessageBox.Show("Error la cantidad excede la cantidad del stock: " + cantidadbsd, "Mensaje Sistema");
                    return;
                }
                else
                {
                    new_procc.ServiceSetCantidadP(txtIdProducto.Text, resta);
                    txtRutCliente.ReadOnly = true;
                    ServiceVenta.WebServiceVentaSoapClient Aux_negProv = new ServiceVenta.WebServiceVentaSoapClient();
                    ServiceVenta.Venta new_proc = new ServiceVenta.Venta();   
                    new_proc.Idproducto = this.txtIdProducto.Text;
                    if (String.IsNullOrEmpty(this.txtRutCliente.Text)){
                        new_proc.Rutcliente = null;
                    }
                    new_proc.Rutcliente = this.txtRutCliente.Text;
                    new_proc.Cantidad = Convert.ToInt32(this.txtCantidad.Text);
                    new_proc.Total = Convert.ToInt32(this.txtPagarxProducto.Text);
                    new_proc.Diferenciador = 0;

                    Aux_negProv.Serviceinsertarproducto(new_proc);
                    //MessageBox.Show("V ", "Mensaje Sistema");
                    txtIdProducto.Text = String.Empty;
                    txtPrecioP.Text = String.Empty;
                    txtCantidad.Text = String.Empty;
                    txtPagarxProducto.Text = String.Empty;
                    this.ventaTableAdapter.FillBy(this.panaderiaDataSetVenta.venta);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int preciop;
                int canti;
                if (String.IsNullOrEmpty(this.txtCantidad.Text) && String.IsNullOrEmpty(this.txtPrecioP.Text))
                {
                    canti = 0;
                    preciop = 0;
                    txtPagarxProducto.Text = "" + preciop * canti;
                }
                else if (String.IsNullOrEmpty(this.txtPrecioP.Text))
                { preciop = 0; canti = Convert.ToInt32(this.txtCantidad.Text); txtPagarxProducto.Text = "" + preciop * canti; }
                else if (String.IsNullOrEmpty(this.txtCantidad.Text))
                {  canti = 0; preciop = Convert.ToInt32(this.txtCantidad.Text); txtPagarxProducto.Text = "" + preciop * canti; }
                else
                {
                    preciop = Convert.ToInt32(this.txtPrecioP.Text);
                    canti = Convert.ToInt32(this.txtCantidad.Text);
                    txtPagarxProducto.Text = "" + preciop * canti;

                }
                
            }
            catch { }
            
        }

        private void txtPrecioP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int preciop;
                int canti;
                if (String.IsNullOrEmpty(this.txtCantidad.Text) && String.IsNullOrEmpty(this.txtPrecioP.Text))
                {
                    canti = 0;
                    preciop = 0;
                    txtPagarxProducto.Text = "" + preciop * canti;
                }
                else if (String.IsNullOrEmpty(this.txtPrecioP.Text))
                { preciop = 0; canti = Convert.ToInt32(this.txtCantidad.Text); txtPagarxProducto.Text = "" + preciop * canti; }
                else if (String.IsNullOrEmpty(this.txtCantidad.Text))
                { canti = 0; preciop = Convert.ToInt32(this.txtCantidad.Text); txtPagarxProducto.Text = "" + preciop * canti; }
                else
                {
                    preciop = Convert.ToInt32(this.txtPrecioP.Text);
                    canti = Convert.ToInt32(this.txtCantidad.Text);
                    txtPagarxProducto.Text = "" + preciop * canti;

                }

            }
            catch { }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ventaTableAdapter.FillBy(this.panaderiaDataSetVenta.venta);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void pasarde0a1() {
            ServiceVenta.WebServiceVentaSoapClient Aux_negProv = new ServiceVenta.WebServiceVentaSoapClient();
            ServiceVenta.Venta new_proc = new ServiceVenta.Venta();
            new_proc.Diferenciador = 1;
            Aux_negProv.ServiceActulizarVent(new_proc);
        }
        private int obtenerSUM()
        {
            ServiceVenta.WebServiceVentaSoapClient Aux_negProv = new ServiceVenta.WebServiceVentaSoapClient();
            
            return Aux_negProv.ServiceGetSum();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceCliente.WebServiceClienteSoapClient aux = new ServiceCliente.WebServiceClienteSoapClient();
                if (String.IsNullOrEmpty(aux.ServicebuscaCliente(this.txtRutCliente.Text).Rutcliente))
                {
                    var confirmacion = MessageBox.Show("¿Desea agregar un nuevo cliente ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (confirmacion == DialogResult.Yes)
                    {
                        GUIAdminClientes pProducto = new GUIAdminClientes();
                        pProducto.ShowDialog();
                    }
                    txtRutCliente.ReadOnly = false;
                    pasarde0a1();
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                    this.ventaTableAdapter.FillBy(this.panaderiaDataSetVenta.venta);
                    //dataGridView2.Visible = false;
                    limpiar();
                }
                else
                {
                    int cantbsd = aux.ServicebuscaCliente(this.txtRutCliente.Text).Cant_compras;
                    int newsuma = cantbsd + 1;
                    aux.ServiceActualizarCompreasCliente(this.txtRutCliente.Text, newsuma);
                    //MessageBox.Show("Cliente SI existe ", "Mensaje Sistema");
                    txtRutCliente.ReadOnly = false;
                    pasarde0a1();
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                    this.ventaTableAdapter.FillBy(this.panaderiaDataSetVenta.venta);
                    //dataGridView2.Visible = false;
                    limpiar();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ventaTableAdapter.FillBy1(this.panaderiaDataSetVenta.venta);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtPagaCon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalp;
                int pagacon;
                if (String.IsNullOrEmpty(this.txtTotalApagar.Text) && String.IsNullOrEmpty(this.txtPagaCon.Text))
                {
                    totalp = 0;
                    pagacon = 0;
                    
                }
                else if (String.IsNullOrEmpty(this.txtTotalApagar.Text))
                { totalp = 0; pagacon = Convert.ToInt32(this.txtPagaCon.Text);}
                else if (String.IsNullOrEmpty(this.txtPagaCon.Text))
                { pagacon = 0; totalp = Convert.ToInt32(this.txtTotalApagar.Text); }
                else
                {
                    totalp = Convert.ToInt32(txtTotalApagar.Text);
                    pagacon = Convert.ToInt32(txtPagaCon.Text);
                    

                }
                int vuelto =  pagacon - totalp;
                txtVuelto.Text = "" + vuelto;
            }
            catch { }
            
        }

        private void btnCalcularTotalAP_Click(object sender, EventArgs e)
        {
            txtTotalApagar.Text = "" + obtenerSUM();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            
            ServiceCliente.WebServiceClienteSoapClient aux = new ServiceCliente.WebServiceClienteSoapClient();
            if (String.IsNullOrEmpty(aux.ServicebuscaCliente(this.txtRutCliente.Text).Rutcliente))
            {
                var confirmacion = MessageBox.Show("¿Desea agregar un nuevo cliente ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirmacion == DialogResult.Yes)
                {
                    GUIAdminClientes pProducto = new GUIAdminClientes();
                    pProducto.ShowDialog();
                } 
            }
            else {
                MessageBox.Show("Cliente SI existe ", "Mensaje Sistema");
                return;
            }
        }
        //menu
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
