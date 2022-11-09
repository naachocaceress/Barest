
namespace BAREST.Configuracion
{
    partial class CLIENTE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.agregarCliente = new FontAwesome.Sharp.IconButton();
            this.EliminarCliente = new FontAwesome.Sharp.IconButton();
            this.modificarCliente = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.agregarCliente);
            this.panel1.Controls.Add(this.EliminarCliente);
            this.panel1.Controls.Add(this.modificarCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 50);
            this.panel1.TabIndex = 15;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 50);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "       Clientes";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // agregarCliente
            // 
            this.agregarCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregarCliente.FlatAppearance.BorderSize = 0;
            this.agregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.agregarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarCliente.IconSize = 30;
            this.agregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarCliente.Location = new System.Drawing.Point(134, 0);
            this.agregarCliente.Name = "agregarCliente";
            this.agregarCliente.Size = new System.Drawing.Size(100, 50);
            this.agregarCliente.TabIndex = 10;
            this.agregarCliente.Text = "       Agregar";
            this.agregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarCliente.UseVisualStyleBackColor = true;
            this.agregarCliente.Click += new System.EventHandler(this.agregarCliente_Click);
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarCliente.FlatAppearance.BorderSize = 0;
            this.EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarCliente.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.EliminarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarCliente.IconSize = 30;
            this.EliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarCliente.Location = new System.Drawing.Point(234, 0);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(100, 50);
            this.EliminarCliente.TabIndex = 11;
            this.EliminarCliente.Text = "       Eliminar";
            this.EliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarCliente.UseVisualStyleBackColor = true;
            this.EliminarCliente.Click += new System.EventHandler(this.EliminarCliente_Click);
            // 
            // modificarCliente
            // 
            this.modificarCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.modificarCliente.FlatAppearance.BorderSize = 0;
            this.modificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarCliente.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.modificarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificarCliente.IconSize = 30;
            this.modificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarCliente.Location = new System.Drawing.Point(334, 0);
            this.modificarCliente.Name = "modificarCliente";
            this.modificarCliente.Size = new System.Drawing.Size(110, 50);
            this.modificarCliente.TabIndex = 12;
            this.modificarCliente.Text = "       Modificar";
            this.modificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarCliente.UseVisualStyleBackColor = true;
            this.modificarCliente.Click += new System.EventHandler(this.modificarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 240);
            this.dataGridView1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.textBusqueda);
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 31);
            this.panel2.TabIndex = 17;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(31, 6);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(202, 20);
            this.textBusqueda.TabIndex = 0;
            // 
            // CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CLIENTE";
            this.ShowIcon = false;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton agregarCliente;
        private FontAwesome.Sharp.IconButton EliminarCliente;
        private FontAwesome.Sharp.IconButton modificarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBusqueda;
    }
}