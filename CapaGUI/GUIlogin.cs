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
    public partial class GUIlogin : Form
    {
        public GUIlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient svu = new ServiceVerificarUserPsw.WebServiceInicioSesionSoapClient();
            int verif = svu.GetUser(txtUsuario.Text, txtContra.Text);
            
            //Console.WriteLine("la contra es" + txtContra.Text);
            if (verif == 2)
            {
                this.Hide();
                GUImenu pProv = new GUImenu();
                pProv.ShowDialog();
            }
            else if (verif == 0) {
                MessageBox.Show("El usuario y contraseña no coinciden. reintenlo o comuniquese con el administrador para mas info ", "Mensaje Sistema");
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtContra.PasswordChar == '*')
                {
                    txtContra.PasswordChar = '\0';
                }
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }
    }
}
