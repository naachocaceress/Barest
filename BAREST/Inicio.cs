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
using BAREST.Ventas;
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

        private void BotonActivo(object senderBtn)
        {
            if (senderBtn != null)
            {
                BotonDesactivo();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.FromArgb(214, 155, 60);
                currentBtn.IconColor = Color.FromArgb(214, 155, 60);
            }
        }

        private void BotonDesactivo()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.FromArgb(241, 243, 244);
                currentBtn.IconColor = Color.FromArgb(241, 243, 244);
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

        public void showSubMenu(Panel subMenu)
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
                botonHiden.Text = ("       BAREST");
                turno.Text = ("          Turno");
                reservas.Text = ("          Reservas");
                caja.Text = ("          Caja");
                ventas.Text = ("          Ventas");
                compras.Text = ("          Compras");
                menu.Text = ("          Menu");
                stock.Text = ("          Stock");
                informes.Text = ("          Informes");
                personal.Text = ("          Personal");
                btnCliente.Text = ("          Cliente");
                config.Text = ("          Configuracion");
                salir.Text = ("          Salir");
            }
        }

        private void esconderMenu()
        {
            panelBotones.Width = 41;
            botonHiden.Text = ("");
            turno.Text = ("");
            reservas.Text = ("");
            caja.Text = ("");
            ventas.Text = ("");
            compras.Text = ("");
            menu.Text = ("");
            stock.Text = ("");
            informes.Text = ("");
            personal.Text = ("");
            btnCliente.Text = ("");
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
                botonHiden.Text = ("       BAREST");
                turno.Text = ("          Turno");
                reservas.Text = ("          Reservas");
                caja.Text = ("          Caja");
                ventas.Text = ("          Ventas");
                compras.Text = ("          Compras");
                menu.Text = ("          Menu");
                stock.Text = ("          Stock");
                informes.Text = ("          Informes");
                personal.Text = ("          Personal");
                btnCliente.Text = ("          Cliente");
                config.Text = ("          Configuracion");
                salir.Text = ("          Salir");
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
            Venta m = new Venta();
            m.Show();
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
            Compras.Compras m = new Compras.Compras();
            m.Show();
        }

        private void manejoStock_Click(object sender, EventArgs e)
        {
            esconderMenu();
            Stock.Stock m = new Stock.Stock();
            m.Show();
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

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            if (panelBotones.Width == 137)
            {
                panelBotones.Width = 41;
                botonHiden.Text = ("");
                turno.Text = ("");
                reservas.Text = ("");
                caja.Text = ("");
                ventas.Text = ("");
                compras.Text = ("");
                menu.Text = ("");
                stock.Text = ("");
                informes.Text = ("");
                personal.Text = ("");
                btnCliente.Text = ("");
                config.Text = ("");
                salir.Text = ("");
            }
            else
            {
                panelBotones.Width = 137;
                botonHiden.Text = ("       BAREST");
                turno.Text = ("          Turno");
                reservas.Text = ("          Reservas");
                caja.Text = ("          Caja");
                ventas.Text = ("          Ventas");
                compras.Text = ("          Compras");
                menu.Text = ("          Menu");
                stock.Text = ("          Stock");
                informes.Text = ("          Informes");
                personal.Text = ("          Personal");
                btnCliente.Text = ("          Cliente");
                config.Text = ("          Configuracion");
                salir.Text = ("          Salir");
            }
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            fechaLabel.Text = DateTime.Now.ToString("g");
        }

        //AGREGAR MESAS --------------------------------------------------------------------------

        private void mesas_Click(object sender, EventArgs e)
        {
            if (panel == 1)
            {
                if (panelPlano1.BackColor == Color.FromArgb(27, 111, 114))
                {
                    if (((Button)sender).BackColor == Color.FromArgb(217, 96, 78))
                    {
                        //ClaseCompartida.valor = 0;
                        Button boton = sender as Button;
                        Mesa1 m = new Mesa1();
                        ClaseCompartida.Mesa = boton.Name;
                        ClaseCompartida.mmm = 1;
                        m.ShowDialog();
                        if (ClaseCompartida.valor == 5)
                            ((Button)sender).BackColor = Color.FromArgb(0, 255, 255);
                    }
                    else if(((Button)sender).BackColor == Color.FromArgb(116, 199, 132))
                    {
                        ClaseCompartida.valor = 0;
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
                        else if (ClaseCompartida.valor == 5)
                            ((Button)sender).BackColor = Color.FromArgb(0, 255, 255);
                    }
                    else
                    {
                        if (((Button)sender).BackColor == Color.FromArgb(0, 255, 255))
                        {
                            Button boton = sender as Button;
                            Cobro m = new Cobro();
                            ClaseCompartida.Mesa = boton.Name;
                            ClaseCompartida.mmm = 1;
                            m.ShowDialog();
                            ((Button)sender).BackColor = Color.FromArgb(116, 199, 132);
                        }
                    }
                }
                else
                {
                    if (move == false)
                    {
                        ModoEditor n = new ModoEditor();
                        Button boton = sender as Button;

                        ClaseCompartida2.nombreM = boton.Name;
                        n.ShowDialog();

                        if (ClaseCompartida2.cancel == true)
                        {
                            ClaseCompartida2.cancel = false;
                            return;
                        }

                        if (ClaseCompartida2.check == true)
                        {
                            panelPlano1.Controls.Remove((Button)sender);
                            ClaseCompartida2.check = false;
                        }
                        else
                        {
                            boton.Name = ClaseCompartida2.nombreM2;
                            boton.Text = ClaseCompartida2.nombreM2;
                        }
                    }
                    move = false;
                    ClaseCompartida2.cancel = false;
                }
            }
            else
            //---------------------------------------------------------------------
                if(panel == 2)
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
                    else if (((Button)sender).BackColor == Color.FromArgb(116, 199, 132))
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
                        else if (ClaseCompartida.valor == 5)
                        {
                            ((Button)sender).BackColor = Color.FromArgb(0, 255, 255);
                        }
                    }
                    else
                    {
                        if (((Button)sender).BackColor == Color.FromArgb(0, 255, 255))
                        {
                            Button boton = sender as Button;
                            Cobro m = new Cobro();
                            ClaseCompartida.Mesa = boton.Name;
                            ClaseCompartida.mmm = 1;
                            m.ShowDialog();
                            ((Button)sender).BackColor = Color.FromArgb(116, 199, 132);
                        }
                    }
                }
                else
                {
                    if (move == false)
                    {
                        ModoEditor n = new ModoEditor();
                        Button boton = sender as Button;

                        ClaseCompartida2.nombreM = boton.Name;
                        n.ShowDialog();

                        if (ClaseCompartida2.cancel == true)
                        {
                            ClaseCompartida2.cancel = false;
                            return;
                        }

                        if (ClaseCompartida2.check == true)
                        {
                            panelPlano2.Controls.Remove((Button)sender);
                            ClaseCompartida2.check = false;
                        }
                        else
                        {
                            boton.Name = ClaseCompartida2.nombreM2;
                            boton.Text = ClaseCompartida2.nombreM2;
                        }
                    }
                    move = false;
                    ClaseCompartida2.cancel = false;
                }
            }
            else
                //---------------------------------------------------------------------
                if (panel == 3)
            {
                if (panelPlano3.BackColor == Color.FromArgb(27, 111, 114))
                {
                    if (((Button)sender).BackColor == Color.FromArgb(217, 96, 78))
                    {
                        Button boton = sender as Button;
                        Mesa1 m = new Mesa1();
                        ClaseCompartida.Mesa = boton.Name;
                        ClaseCompartida.mmm = 1;
                        m.ShowDialog();
                    }
                    else if (((Button)sender).BackColor == Color.FromArgb(116, 199, 132))
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
                        else if (ClaseCompartida.valor == 5)
                        {
                            ((Button)sender).BackColor = Color.FromArgb(0, 255, 255);
                        }
                    }
                    else
                    {
                        if (((Button)sender).BackColor == Color.FromArgb(0, 255, 255))
                        {
                            Button boton = sender as Button;
                            Cobro m = new Cobro();
                            ClaseCompartida.Mesa = boton.Name;
                            ClaseCompartida.mmm = 1;
                            m.ShowDialog();
                            ((Button)sender).BackColor = Color.FromArgb(116, 199, 132);
                        }
                    }
                }
                else
                {
                    if (move == false)
                    {
                        ModoEditor n = new ModoEditor();
                        Button boton = sender as Button;

                        ClaseCompartida2.nombreM = boton.Name;
                        n.ShowDialog();

                        if (ClaseCompartida2.cancel == true)
                        {
                            ClaseCompartida2.cancel = false;
                            return;
                        }

                        if (ClaseCompartida2.check == true)
                        {
                            panelPlano3.Controls.Remove((Button)sender);
                            ClaseCompartida2.check = false;
                        }
                        else
                        {
                            boton.Name = ClaseCompartida2.nombreM2;
                            boton.Text = ClaseCompartida2.nombreM2;
                        }
                    }
                    move = false;
                    ClaseCompartida2.cancel = false;
                }
            }
        }

        private void mesas_Click_Deli(object sender, EventArgs e)
        {
            if (panel == 1)
            {
                if (panelPlano1.BackColor == Color.FromArgb(27, 111, 114))
                {
                    if (((Button)sender).BackColor == Color.FromArgb(217, 96, 78))
                    {
                        Button boton = sender as Button;
                        DeliveryMesa m = new DeliveryMesa();
                        ClaseCompartida.Mesa = boton.Name;
                        //ClaseCompartida.mmm = 1;
                        m.ShowDialog();
                    }
                    else
                    {
                        Button boton = sender as Button;

                        DeliveryMesa m = new DeliveryMesa();
                        ClaseCompartida2.mesaD = boton.Name;

                        if (ClaseCompartida.usu == 0)
                            m.ShowDialog();
                        else
                        {
                            DeliveryMesa n = new DeliveryMesa();
                            n.ShowDialog();
                        }

                        if (ClaseCompartida.valor == 1)
                            ((Button)sender).BackColor = Color.FromArgb(217, 96, 78);
                    }
                }
                else
                {
                    if (move == false)
                    {
                        ModoEditor n = new ModoEditor();
                        Button boton = sender as Button;

                        ClaseCompartida2.nombreM = boton.Name;
                        n.ShowDialog();

                        if (ClaseCompartida2.cancel == true)
                        {
                            ClaseCompartida2.cancel = false;
                            return;
                        }

                        if (ClaseCompartida2.check == true)
                        {
                            panelPlano1.Controls.Remove((Button)sender);
                            ClaseCompartida2.check = false;
                        }
                        else
                        {
                            boton.Name = ClaseCompartida2.nombreM2;
                            boton.Text = ClaseCompartida2.nombreM2;
                        }
                    }
                    move = false;
                    ClaseCompartida2.cancel = false;
                }
            }
            else
                if (panel == 2)
            {
                if (panelPlano2.BackColor == Color.FromArgb(27, 111, 114))
                {
                    if (((Button)sender).BackColor == Color.FromArgb(217, 96, 78))
                    {
                        Button boton = sender as Button;
                        DeliveryMesa m = new DeliveryMesa();
                        ClaseCompartida.Mesa = boton.Name;
                        //ClaseCompartida.mmm = 1;
                        m.ShowDialog();
                    }
                    else
                    {
                        Button boton = sender as Button;

                        DeliveryMesa m = new DeliveryMesa();
                        //m.label7.Text = boton.Name;

                        if (ClaseCompartida.usu == 0)
                            m.ShowDialog();
                        else
                        {
                            DeliveryMesa n = new DeliveryMesa();
                            n.ShowDialog();
                        }

                        if (ClaseCompartida.valor == 1)
                            ((Button)sender).BackColor = Color.FromArgb(217, 96, 78);
                    }
                }
                else
                {
                    if (move == false)
                    {
                        ModoEditor n = new ModoEditor();
                        Button boton = sender as Button;

                        ClaseCompartida2.nombreM = boton.Name;
                        n.ShowDialog();

                        if (ClaseCompartida2.cancel == true)
                        {
                            ClaseCompartida2.cancel = false;
                            return;
                        }

                        if (ClaseCompartida2.check == true)
                        {
                            panelPlano1.Controls.Remove((Button)sender);
                            ClaseCompartida2.check = false;
                        }
                        else
                        {
                            boton.Name = ClaseCompartida2.nombreM2;
                            boton.Text = ClaseCompartida2.nombreM2;
                        }
                    }
                    move = false;
                    ClaseCompartida2.cancel = false;
                }
            }
            else
                if (panel == 3)
            {
                if (panelPlano3.BackColor == Color.FromArgb(27, 111, 114))
                {
                    if (((Button)sender).BackColor == Color.FromArgb(217, 96, 78))
                    {
                        Button boton = sender as Button;
                        DeliveryMesa m = new DeliveryMesa();
                        ClaseCompartida.Mesa = boton.Name;
                        //ClaseCompartida.mmm = 1;
                        m.ShowDialog();
                    }
                    else
                    {
                        Button boton = sender as Button;

                        DeliveryMesa m = new DeliveryMesa();
                        //m.label7.Text = boton.Name;

                        if (ClaseCompartida.usu == 0)
                            m.ShowDialog();
                        else
                        {
                            DeliveryMesa n = new DeliveryMesa();
                            n.ShowDialog();
                        }

                        if (ClaseCompartida.valor == 1)
                            ((Button)sender).BackColor = Color.FromArgb(217, 96, 78);
                    }
                }
                else
                {
                    if (move == false)
                    {
                        ModoEditor n = new ModoEditor();
                        Button boton = sender as Button;

                        ClaseCompartida2.nombreM = boton.Name;
                        n.ShowDialog();

                        if (ClaseCompartida2.cancel == true)
                        {
                            ClaseCompartida2.cancel = false;
                            return;
                        }

                        if (ClaseCompartida2.check == true)
                        {
                            panelPlano1.Controls.Remove((Button)sender);
                            ClaseCompartida2.check = false;
                        }
                        else
                        {
                            boton.Name = ClaseCompartida2.nombreM2;
                            boton.Text = ClaseCompartida2.nombreM2;
                        }
                    }
                    move = false;
                    ClaseCompartida2.cancel = false;
                }
            }
        }


        //MENU CONTEXTUAL --------------------------------------------------------------------------

        private Point MouseDownLocation;

        private void MesasEditor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        bool move = false;
        private void MesasEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (panelPlano1.BackColor == Color.Black || panelPlano2.BackColor == Color.Black || panelPlano3.BackColor == Color.Black)
            {
                Button boton = sender as Button;
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    boton.Left = e.X + boton.Left - MouseDownLocation.X;
                    boton.Top = e.Y + boton.Top - MouseDownLocation.Y;
                    move = true;
                }
            }
        }

        public static class ClaseCompartida2
        {
            public static string nombre = "";
            public static bool check = false, cancel = false, cancel2 = false, deli = false;
            public static string nombreM = "", nombreM2 = "", mesaD = "";
        }

        public int LocationX = 0, LocationY = 0;

        private void modoEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (panel == 1)
            {
                panelPlano1.BackColor = Color.Black;
                panelPlano2.BackColor = Color.FromArgb(27, 111, 115);
                panelPlano3.BackColor = Color.FromArgb(27, 111, 115);
                label11.Text = "PLANO DELIVERY (MODO EDITOR)";
            }
                else
            if (panel == 2)
            {
                panelPlano2.BackColor = Color.Black;
                panelPlano1.BackColor = Color.FromArgb(27, 111, 115);
                panelPlano3.BackColor = Color.FromArgb(27, 111, 115);
                label10.Text = "PLANO ADELANTE (MODO EDITOR)";
            }
            else
                if (panel == 3)
            {
                panelPlano3.BackColor = Color.Black;
                panelPlano1.BackColor = Color.FromArgb(27, 111, 115);
                panelPlano2.BackColor = Color.FromArgb(27, 111, 115);
                label12.Text = "PLANO JARDIN (MODO EDITOR)";
            }
        }

        private void salirDelModoEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPlano1.BackColor = Color.FromArgb(27, 111, 114);
            panelPlano2.BackColor = Color.FromArgb(27, 111, 114);
            panelPlano3.BackColor = Color.FromArgb(27, 111, 114);
            label11.Text = "PLANO DELIVERY";
            label10.Text = "PLANO ADELANTE";
            label12.Text = "PLANO JARDIN";
        }

        private void agregarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (panelPlano2.BackColor == Color.FromArgb(27, 111, 114) && panelPlano1.BackColor == Color.FromArgb(27, 111, 114) && panelPlano3.BackColor == Color.FromArgb(27, 111, 114))
            {
                modoEditorToolStripMenuItem.Visible = true;
                salirDelModoEditorToolStripMenuItem.Visible = false;
                agregarMesaToolStripMenuItem.Visible = false;
            }
            else
            {
                salirDelModoEditorToolStripMenuItem.Visible = true;
                agregarMesaToolStripMenuItem.Visible = true;
                modoEditorToolStripMenuItem.Visible = false;
            }

            LocationX = Cursor.Position.X;
            LocationY = Cursor.Position.Y;
        }

        int panel = 1; 

        private void panelPlano1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                panel = 1;
            }
        }

        private void panelPlano2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                panel = 2;
            }
        }

        private void panelPlano3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                panel = 3;
            }
        }

        private void config_Click(object sender, EventArgs e)
        {
            esconderMenu();
            //openChilForm(new Reservas());
            BotonActivo(sender);
            configuracion m = new configuracion();
            m.Show();
        }

        private void Add()
        {
            AgregarMesa n = new AgregarMesa();
            n.ShowDialog();

            if (ClaseCompartida2.cancel == true)
            {
                ClaseCompartida2.cancel = false;
                return;
            }

            if (panelPlano1.BackColor == Color.Black)
            {
                Button temp = new Button();

                temp.Height = 40;
                temp.Width = 40;
                temp.Location = new Point(LocationX - 342, LocationY - 473);
                temp.Text = ClaseCompartida2.nombre;
                temp.Name = ClaseCompartida2.nombre;
                temp.FlatStyle = FlatStyle.Flat;
                if (ClaseCompartida2.deli == false)
                {
                    temp.Click += mesas_Click; //DARLE EL METODO MESAS_CLICK
                    temp.BackColor = Color.FromArgb(116, 199, 132);
                }
                else
                {
                    temp.Click += mesas_Click_Deli; //DARLE EL METODO MESAS_CLICK
                    temp.BackColor = Color.FromArgb(214, 155, 60);
                    ClaseCompartida2.deli = false;
                }
                temp.MouseDown += MesasEditor_MouseDown;
                temp.MouseMove += MesasEditor_MouseMove;

                panelPlano1.Controls.Add(temp);
            }
            else
            if (panelPlano2.BackColor == Color.Black)
            {
                Button temp = new Button();

                temp.Height = 40;
                temp.Width = 40;
                temp.Location = new Point(LocationX - 197, LocationY - 52);
                temp.Text = ClaseCompartida2.nombre;
                temp.Name = ClaseCompartida2.nombre;
                temp.FlatStyle = FlatStyle.Flat;
                if (ClaseCompartida2.deli == false)
                {
                    temp.Click += mesas_Click; //DARLE EL METODO MESAS_CLICK
                    temp.BackColor = Color.FromArgb(116, 199, 132);
                }
                else
                {
                    temp.Click += mesas_Click_Deli; //DARLE EL METODO MESAS_CLICK
                    temp.BackColor = Color.FromArgb(214, 155, 60);
                    ClaseCompartida2.deli = false;
                }
                temp.MouseDown += MesasEditor_MouseDown;
                temp.MouseMove += MesasEditor_MouseMove;

                panelPlano2.Controls.Add(temp);
            }
            else
                if (panelPlano3.BackColor == Color.Black)
            {
                Button temp = new Button();

                temp.Height = 40;
                temp.Width = 40;
                temp.Location = new Point(LocationX - 652, LocationY - 337);
                temp.Text = ClaseCompartida2.nombre;
                temp.Name = ClaseCompartida2.nombre;
                temp.FlatStyle = FlatStyle.Flat;
                if (ClaseCompartida2.deli == false)
                {
                    temp.Click += mesas_Click; //DARLE EL METODO MESAS_CLICK
                    temp.BackColor = Color.FromArgb(116, 199, 132);
                }
                else
                {
                    temp.Click += mesas_Click_Deli; //DARLE EL METODO MESAS_CLICK
                    temp.BackColor = Color.FromArgb(214, 155, 60);
                    ClaseCompartida2.deli = false;
                }
                temp.MouseDown += MesasEditor_MouseDown;
                temp.MouseMove += MesasEditor_MouseMove;

                panelPlano3.Controls.Add(temp);
            }
        }
    }
}
