using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAREST.Turno;
using FontAwesome.Sharp;
using static BAREST.Mesa1;

namespace BAREST
{
    public partial class inicio : Form
    {
        private IconButton currentBtn;
        public inicio()
        {
            InitializeComponent();
            customizeDesign();
            panelPlano1.Visible = false;
            panelPlano2.Visible = false;
            panelPlano3.Visible = false;
            panelAyudaVisual.Visible = false;
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
            configuracion m = new configuracion();
            m.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
                BotonActivo(sender);
            }
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
            Compras.Insumos m = new Compras.Insumos();
            m.Show();
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

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere iniciar turno?", "Inicio de turno", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                panelPlano1.Visible = true;
                panelPlano2.Visible = true;
                panelPlano3.Visible = true;
                panelAyudaVisual.Visible = true;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            esconderMenu();
            ClaseCompartida.comanda = 0;
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere cerrar el turno?", "Cierre de turno", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                panelPlano1.Visible = false;
                panelPlano2.Visible = false;
                panelPlano3.Visible = false;
                panelAyudaVisual.Visible = false;
            }
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
            Compras.Proveedores m = new Compras.Proveedores();
            m.Show();
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

        private void reservas_Click(object sender, EventArgs e)
        {
            esconderMenu();
            //openChilForm(new Reservas());
            BotonActivo(sender);
            Reservas m = new Reservas();
            m.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            esconderMenu();
            BotonActivo(sender);
            // openChilForm(new Menu());
            Menu m = new Menu();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
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
                botonHiden.Text = ("");
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
                botonHiden.Text = ("       BAREST");
            }
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            fechaLabel.Text = DateTime.Now.ToString("g");
        }

        private void mesas_Click(object sender, EventArgs e)
        {
            if (panelPlano2.BackColor == Color.FromArgb(27, 111, 114))
            {
                if (((Button)sender).BackColor == Color.FromArgb(217, 96, 78))
                {
                    Button boton = sender as Button;
                    Mesa1 m = new Mesa1();
                    ClaseCompartida.Mesa = boton.Name;
                    ClaseCompartida.mmm = 1;
                    m.ShowDialog();
                }
                else
                {
                    Button boton = sender as Button;

                    turno.Mozo m = new turno.Mozo();
                    m.label7.Text = boton.Name;

                    if (ClaseCompartida.usu == 0)
                        m.ShowDialog();
                    else
                    {
                        Mesa1 n = new Mesa1();
                        n.ShowDialog();
                    }

                    if (ClaseCompartida.valor == 1)
                        ((Button)sender).BackColor = Color.FromArgb(217, 96, 78);
                }
            }
            else
            {
                ModoEditor n = new ModoEditor();
                n.ShowDialog();
            }
        }

        //MENU CONTEXTUAL --------------------------------------------------------------------------

        private void menuContextualPanel()
        {
            ContextMenu cm = new ContextMenu();

            MenuItem mi1 = new MenuItem("Agregar Mesa");
            mi1.Click += AgregarMesa;
            MenuItem mi2 = new MenuItem("Modo editor");
            mi2.Click += ModoEditor;

            cm.MenuItems.Add(mi1);
            cm.MenuItems.Add(mi2);

            panelPlano2.ContextMenu = cm;
        }

        private void menuContextualPanel2()
        {
            ContextMenu cm = new ContextMenu();

            MenuItem mi1 = new MenuItem("Salir de modo editor");
            mi1.Click += SalirMEditor;

            cm.MenuItems.Add(mi1);

            panelPlano2.ContextMenu = cm;
        }

        private void SalirMEditor(object sender, EventArgs e)
        {
            panelPlano2.BackColor = Color.FromArgb(27, 111, 114);
        }

        private void ModoEditor(object sender, EventArgs e)
        {
            panelPlano2.BackColor = Color.Black;
        }

        private void AgregarMesa(object sender, EventArgs e)
        {
            AgregarMesa n = new AgregarMesa();
            n.ShowDialog();

            Button temp = new Button();

            temp.Height = 40;
            temp.Width = 40;
            temp.Location = new Point(LocationX - 220, LocationY - 80);
            temp.BackColor = Color.FromArgb(116, 199, 132);
            temp.Text = ClaseCompartida2.nombre;
            temp.Name = ClaseCompartida2.nombre;
            temp.FlatStyle = FlatStyle.Flat;
            temp.Click += mesas_Click; //DARLE EL METODO MESAS_CLICK

            panelPlano2.Controls.Add(temp);
        }

        public static class ClaseCompartida2
        {
            public static string nombre = "";
        }

        public int LocationX = 0, LocationY = 0;

        private void panelPlano2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (panelPlano2.BackColor == Color.FromArgb(27, 111, 114))
                {
                    LocationX = Cursor.Position.X;
                    LocationY = Cursor.Position.Y;
                    menuContextualPanel();
                }
                else
                {
                    menuContextualPanel2();
                }
            }
        }
    }
}
