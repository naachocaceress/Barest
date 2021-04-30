using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            logiarse();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                logiarse();
            }
        }

        private void logiarse()
        {
            if (tboxUsuario.Text == "admin" && tboxContraseña.Text == "admin")
            {
                inicio m = new inicio();
                m.ShowDialog();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos, intenta de nuevo");
                tboxUsuario.Clear();
                tboxContraseña.Clear();
                tboxUsuario.Focus();
            }
        }

    }
}
