using CapaNegocio;
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
    public partial class GUImenu : Form
    {
        public GUImenu()
        {
            InitializeComponent();
        }

        private void GUImenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetProducto.producto' Puede moverla o quitarla según sea necesario.

            ServiceVenta.WebServiceVentaSoapClient obVenta = new ServiceVenta.WebServiceVentaSoapClient();
            labelClientesNoRegistrados.Text = " Hay un total de " + obVenta.ServiceGetVentasSinCliente() + " ventas sin un Cliente asociado.";
            estsumatotal.Text = " En total deberia haber en caja una suma de $" + obVenta.ServiceGetSumaTotaldeVentas()+ ".";

            ServiceProducto.WebServiceProductoSoapClient obtest = new ServiceProducto.WebServiceProductoSoapClient();
            txtWarning.Text = obtest.ServiceGetMinDiasV() + " Dias para que el producto con " + obtest.GetName(obtest.ServiceGetMinDiasV()) + " venza.";
            int canti = obtest.ServiceGetProductMasVendido().Cantidad;
            int masv = obtest.ServiceGetProductMasVendido().Dias_vencimiento;
            string nombre = obtest.ServiceGetProductMasVendido().Tipo_producto;
            string idprod = obtest.ServiceGetProductMasVendido().Idproducto;
            //2da estadistica
            int suma = obtest.ServiceGetClienteConMasCompras().Cantidad;
            string nombre2 = obtest.ServiceGetClienteConMasCompras().Tipo_producto;
            string rutcliente = obtest.ServiceGetClienteConMasCompras().Caracteristica;
            int idcliente = obtest.ServiceGetClienteConMasCompras().Precio_unitario;
            labelCantidadMin.Text = "el producto mas comprado es "+ nombre + " de id " + idprod + " con una cantidad de " + canti + " ventas y "+ masv +" unidades vendidas";
            labelClientesxVentas.Text = " El cliente con mas compras es  nombre: "+ nombre2 +" RUT: "+  rutcliente + " con " + suma +  " compras, su id de cliente es " + idcliente;
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

        private void txtDiasV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void txtWarning_Click(object sender, EventArgs e)
        {

        }

        private void irANuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIVentas pProducto = new GUIVentas();
            pProducto.ShowDialog();
        }

        private void est1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.productoTableAdapter.est1(this.panaderiaDataSetProducto.producto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaEst1 pProducto = new TablaEst1();
            pProducto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaEst2 pProducto = new TablaEst2();
            pProducto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TablaEst3 pProducto = new TablaEst3();
            pProducto.ShowDialog();
        }
    }
}
