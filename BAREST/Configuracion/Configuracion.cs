using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAREST.Configuracion;
using FontAwesome.Sharp;

namespace BAREST
{
    public partial class configuracion : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public configuracion()
        { 
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 48);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        { 
            if (currentBtn != null)
            {
                leftBorderBtn.BackColor = Color.FromArgb(214, 155, 60);
                leftBorderBtn.Visible = false;
            }
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

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(214, 155, 60));
            openChilForm(new Usuarios());
        }

        private void disenioBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(214, 155, 60));
            openChilForm(new Diseño());
        }

        private void acercaDe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(214, 155, 60));
            openChilForm(new Acerca_de());
        }

        private void Reservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(214, 155, 60));
            openChilForm(new ReservasConfig());
        }
    }
}
