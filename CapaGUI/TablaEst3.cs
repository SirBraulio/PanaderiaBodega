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
    public partial class TablaEst3 : Form
    {
        public TablaEst3()
        {
            InitializeComponent();
        }

        private void TablaEst3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'panaderiaDataSetClientes.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.panaderiaDataSetClientes.cliente);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
