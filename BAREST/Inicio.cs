using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BAREST
{
    public partial class inicio : Form
    {
        private IconButton currentBtn;
        public inicio()
        {
            InitializeComponent();
            customizeDesign();
        } 

        private void BotonActivo (object senderBtn)
        {
            if(senderBtn != null)
            {
                BotonDesactivo();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.FromArgb(214, 155, 60);
                currentBtn.IconColor = Color.FromArgb(214, 155, 60);
            }
        }

        private void BotonDesactivo ()
        {
            if(currentBtn != null)
            {
                currentBtn.ForeColor = Color.FromArgb(241, 243, 244 );
                currentBtn.IconColor = Color.FromArgb(241, 243, 244 );
            }
        }

        private void customizeDesign()
        {
            panelTurno.Visible = false;
            panelCaja.Visible = false;
            panelCompras.Visible = false;
            panelStock.Visible = false;
            panelPersonal.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelTurno.Visible == true)
                panelTurno.Visible = false;
            if (panelCaja.Visible == true)
                panelCaja.Visible = false;
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
            if (panelStock.Visible == true)
                panelStock.Visible = false;
            if (panelPersonal.Visible == true)
                panelPersonal.Visible = false;  
        }

        public void showSubMenu (Panel subMenu)
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
            hideSubMenu();
            if (panelBotones.Width == 137)
            {
                panelBotones.Width = 41;
                turno.Text = ("");
                caja.Text = ("");
                ventas.Text = ("");
                compras.Text = ("");
                menu.Text = ("");
                stock.Text = ("");
                informes.Text = ("");
                personal.Text = ("");
                config.Text = ("");
                salir.Text = ("");
            }
            else
            {
                panelBotones.Width = 137;
                turno.Text = ("       Iniciar Turno");
                caja.Text = ("       Caja");
                ventas.Text = ("       Ventas");
                compras.Text = ("       Compras");
                menu.Text = ("       Menu");
                stock.Text = ("       Stock");
                informes.Text = ("       Informes");
                personal.Text = ("       Personal");
                config.Text = ("       Configuracion");
                salir.Text = ("       Salir");
            }
        }

        private void esconderMenu()
        {
            panelBotones.Width = 41;
            turno.Text = ("");
            caja.Text = ("");
            ventas.Text = ("");
            compras.Text = ("");
            menu.Text = ("");
            stock.Text = ("");
            informes.Text = ("");
            personal.Text = ("");
            config.Text = ("");
            salir.Text = ("");
            hideSubMenu();
            panelTitulos.Height = 49;
        }

        private void mostrarMenu()
        {
            if (panelBotones.Width == 41)
            {
                panelBotones.Width = 137;
                turno.Text = ("       Iniciar Turno");
                caja.Text = ("       Caja");
                ventas.Text = ("       Ventas");
                compras.Text = ("       Compras");
                menu.Text = ("       Menu");
                stock.Text = ("       Stock");
                informes.Text = ("       Informes");
                personal.Text = ("       Personal");
                config.Text = ("       Configuracion");
                salir.Text = ("       Salir");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            mostrarMenu();
            hideSubMenu();
            showSubMenu(panelCaja);
            BotonActivo(sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            esconderMenu();
            BotonActivo(sender);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            BotonActivo(sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            esconderMenu();
            BotonActivo(sender);
        }

        private void compras_Click_1(object sender, EventArgs e)
        {
            mostrarMenu();
            hideSubMenu();
            showSubMenu(panelCompras);
            BotonActivo(sender);
        }

        private void inicioTurno_Click(object sender, EventArgs e)
        {
            mostrarMenu();
            hideSubMenu();
            showSubMenu(panelTurno);
            BotonActivo(sender);
        }


        private void button21_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            mostrarMenu();
            hideSubMenu();
            showSubMenu(panelStock);
            BotonActivo(sender);
        }

        private void personal_Click(object sender, EventArgs e)
        {
            mostrarMenu();
            hideSubMenu();
            showSubMenu(panelPersonal);
            BotonActivo(sender);
        }

        private void informes_Click(object sender, EventArgs e)
        {
            esconderMenu();
            BotonActivo(sender);
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void caja1_Click(object sender, EventArgs e)
        {
            esconderMenu();
            openChilForm(new Caja());
        }

        private void caja2_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void proveedores_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void estadoCompras_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void manejoStock_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void inventariosStock_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void categorias_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reservas_Click(object sender, EventArgs e)
        {
            esconderMenu();
            openChilForm(new Reservas());
            BotonActivo(sender);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            esconderMenu();
            BotonActivo(sender);
        }

        private void configuracion_Load(object sender, EventArgs e)
        {

        }

        private void usuarioText_Click(object sender, EventArgs e)
        {

        }
    }
}
