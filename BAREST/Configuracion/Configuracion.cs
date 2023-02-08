using BAREST.Configuracion;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            if (senderBtn != null)
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
        //internal static object Usuarios;

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

        private void Reservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(214, 155, 60));
            openChilForm(new ReservasConfig());
        }

        private void acercaDe_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(214, 155, 60));
            openChilForm(new Acerca_de());
        }
    }
}
