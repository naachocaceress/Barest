
namespace BAREST
{
    partial class Mesa1
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
            this.btnComanda = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.agregarMenulista = new FontAwesome.Sharp.IconButton();
            this.EliminarComanda = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textIdComanda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmarComanda = new System.Windows.Forms.Button();
            this.labelmozo = new System.Windows.Forms.Label();
            this.labelmesa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textComensal = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnComanda);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.agregarMenulista);
            this.panel1.Controls.Add(this.EliminarComanda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnComanda
            // 
            this.btnComanda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComanda.FlatAppearance.BorderSize = 0;
            this.btnComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnComanda.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnComanda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnComanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComanda.IconSize = 30;
            this.btnComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComanda.Location = new System.Drawing.Point(83, 0);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(100, 50);
            this.btnComanda.TabIndex = 14;
            this.btnComanda.Text = "      Comanda";
            this.btnComanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Visible = false;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(100, 50);
            this.iconButton3.TabIndex = 13;
            this.iconButton3.Text = "       Control";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // agregarMenulista
            // 
            this.agregarMenulista.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregarMenulista.FlatAppearance.BorderSize = 0;
            this.agregarMenulista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarMenulista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarMenulista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarMenulista.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.agregarMenulista.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarMenulista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarMenulista.IconSize = 30;
            this.agregarMenulista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarMenulista.Location = new System.Drawing.Point(183, 0);
            this.agregarMenulista.Name = "agregarMenulista";
            this.agregarMenulista.Size = new System.Drawing.Size(100, 50);
            this.agregarMenulista.TabIndex = 11;
            this.agregarMenulista.Text = "       Agregar";
            this.agregarMenulista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarMenulista.UseVisualStyleBackColor = true;
            this.agregarMenulista.Click += new System.EventHandler(this.agregarMenulista_Click);
            // 
            // EliminarComanda
            // 
            this.EliminarComanda.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarComanda.FlatAppearance.BorderSize = 0;
            this.EliminarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarComanda.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.EliminarComanda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarComanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarComanda.IconSize = 30;
            this.EliminarComanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarComanda.Location = new System.Drawing.Point(283, 0);
            this.EliminarComanda.Name = "EliminarComanda";
            this.EliminarComanda.Size = new System.Drawing.Size(100, 50);
            this.EliminarComanda.TabIndex = 12;
            this.EliminarComanda.Text = "       Eliminar";
            this.EliminarComanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarComanda.UseVisualStyleBackColor = true;
            this.EliminarComanda.Click += new System.EventHandler(this.EliminarComanda_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.textIdComanda);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ConfirmarComanda);
            this.panel2.Controls.Add(this.labelmozo);
            this.panel2.Controls.Add(this.labelmesa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 52);
            this.panel2.TabIndex = 2;
            // 
            // textIdComanda
            // 
            this.textIdComanda.Location = new System.Drawing.Point(237, 13);
            this.textIdComanda.Name = "textIdComanda";
            this.textIdComanda.Size = new System.Drawing.Size(50, 22);
            this.textIdComanda.TabIndex = 11;
            this.textIdComanda.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAREST.Properties.Resources.Vidon_bar;
            this.pictureBox1.Location = new System.Drawing.Point(152, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmarComanda
            // 
            this.ConfirmarComanda.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmarComanda.Cursor = System.Windows.Forms.Cursors.No;
            this.ConfirmarComanda.Location = new System.Drawing.Point(310, 9);
            this.ConfirmarComanda.Name = "ConfirmarComanda";
            this.ConfirmarComanda.Size = new System.Drawing.Size(61, 31);
            this.ConfirmarComanda.TabIndex = 4;
            this.ConfirmarComanda.Text = "Cerrar";
            this.ConfirmarComanda.UseVisualStyleBackColor = false;
            this.ConfirmarComanda.Click += new System.EventHandler(this.ConfirmarComanda_Click);
            // 
            // labelmozo
            // 
            this.labelmozo.AutoSize = true;
            this.labelmozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmozo.Location = new System.Drawing.Point(60, 30);
            this.labelmozo.Name = "labelmozo";
            this.labelmozo.Size = new System.Drawing.Size(23, 16);
            this.labelmozo.TabIndex = 3;
            this.labelmozo.Text = "---";
            // 
            // labelmesa
            // 
            this.labelmesa.AutoSize = true;
            this.labelmesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmesa.Location = new System.Drawing.Point(60, 9);
            this.labelmesa.Name = "labelmesa";
            this.labelmesa.Size = new System.Drawing.Size(23, 16);
            this.labelmesa.TabIndex = 2;
            this.labelmesa.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "MOZO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MESA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidades,
            this.Detalles,
            this.precioUnitario,
            this.precioTotal,
            this.idMesa});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(359, 244);
            this.dataGridView1.TabIndex = 3;
            // 
            // cantidades
            // 
            this.cantidades.HeaderText = "Cant.";
            this.cantidades.Name = "cantidades";
            this.cantidades.ReadOnly = true;
            this.cantidades.Width = 50;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Width = 130;
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "P.Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.Width = 60;
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioTotal.HeaderText = "P.Total";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            // 
            // idMesa
            // 
            this.idMesa.HeaderText = "IdMesa";
            this.idMesa.Name = "idMesa";
            this.idMesa.ReadOnly = true;
            this.idMesa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(271, 362);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 22);
            this.textTotal.TabIndex = 1;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(12, 76);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(65, 16);
            this.labelBuscar.TabIndex = 6;
            this.labelBuscar.Text = "Cantidad:";
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(83, 73);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(148, 22);
            this.textBuscar.TabIndex = 1;
            this.textBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Comensales:";
            // 
            // textComensal
            // 
            this.textComensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComensal.Location = new System.Drawing.Point(100, 362);
            this.textComensal.Name = "textComensal";
            this.textComensal.Size = new System.Drawing.Size(50, 22);
            this.textComensal.TabIndex = 4;
            this.textComensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(296, 67);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(341, 67);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(30, 30);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Visible = false;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // Mesa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 449);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textComensal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mesa1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.Mesa1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton agregarMenulista;
        private FontAwesome.Sharp.IconButton EliminarComanda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelmozo;
        public System.Windows.Forms.Label labelmesa;
        private System.Windows.Forms.Button ConfirmarComanda;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textComensal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnComanda;
        private System.Windows.Forms.TextBox textIdComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMesa;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}