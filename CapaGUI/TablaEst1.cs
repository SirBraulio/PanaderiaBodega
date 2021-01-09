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
    public partial class TablaEst1 : Form
    {
        public TablaEst1()
        {
            InitializeComponent();
        }

        private void TablaEst1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetProducto.producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.est1(this.panaderiaDataSetProducto.producto);
            //NegocioProducto auxNegocio = new NegocioProducto();
            ServiceProducto.WebServiceProductoSoapClient auxNew = new ServiceProducto.WebServiceProductoSoapClient();
            this.dataGridView1.DataSource = auxNew.ServiceGetConsultaProducto();
            this.dataGridView1.DataMember = "producto";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
