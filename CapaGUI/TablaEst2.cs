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
    public partial class TablaEst2 : Form
    {
        public TablaEst2()
        {
            InitializeComponent();
        }

        private void TablaEst2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetVenta.venta' Puede moverla o quitarla según sea necesario.
            //this.ventaTableAdapter.Fill(this.panaderiaDataSetVenta.venta);
            ServiceVenta.WebServiceVentaSoapClient auxNew = new ServiceVenta.WebServiceVentaSoapClient();
            this.dataGridView1.DataSource = auxNew.ServiceGetConsultaVenta();
            this.dataGridView1.DataMember = "venta";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
