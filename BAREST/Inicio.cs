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
    public partial class configuracion : Form
    {
        public configuracion()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelVentas.Visible = false;
            panelCompras.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelVentas.Visible==true)
                panelVentas.Visible = false;
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
        }

        private void showSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panelBotones.Visible == true)
                panelBotones.Visible = false;
            else
            {
                panelBotones.Visible = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Caja m = new Caja();
            m.ShowDialog();
            hideSubMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentas);
        }

        private void compras_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelCompras);
        }

        private void inicioTurno_Click(object sender, EventArgs e)
        {
            if (panelBotones.Visible == true)
                panelBotones.Visible = false;
            else
            {
                panelBotones.Visible = true;
            }
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
