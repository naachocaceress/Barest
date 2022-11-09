
namespace BAREST.Clientes
{
    partial class ingresarCliente
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
            this.agregarCliente = new FontAwesome.Sharp.IconButton();
            this.modificarCliente = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textNro = new System.Windows.Forms.TextBox();
            this.textDepto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textcalle = new System.Windows.Forms.TextBox();
            this.textdni = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textApe = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.agregarCliente);
            this.panel1.Controls.Add(this.modificarCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 50);
            this.panel1.TabIndex = 16;
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
            this.agregarCliente.Location = new System.Drawing.Point(121, 0);
            this.agregarCliente.Name = "agregarCliente";
            this.agregarCliente.Size = new System.Drawing.Size(141, 50);
            this.agregarCliente.TabIndex = 10;
            this.agregarCliente.Text = "       Confirmar";
            this.agregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarCliente.UseVisualStyleBackColor = true;
            this.agregarCliente.Click += new System.EventHandler(this.agregarCliente_Click);
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
            this.modificarCliente.Location = new System.Drawing.Point(262, 0);
            this.modificarCliente.Name = "modificarCliente";
            this.modificarCliente.Size = new System.Drawing.Size(110, 50);
            this.modificarCliente.TabIndex = 12;
            this.modificarCliente.Text = "      Cancelar";
            this.modificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarCliente.UseVisualStyleBackColor = true;
            this.modificarCliente.Click += new System.EventHandler(this.modificarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textNro);
            this.groupBox1.Controls.Add(this.textDepto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textcalle);
            this.groupBox1.Location = new System.Drawing.Point(36, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 130);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nro:";
            // 
            // textNro
            // 
            this.textNro.Location = new System.Drawing.Point(68, 97);
            this.textNro.Name = "textNro";
            this.textNro.Size = new System.Drawing.Size(51, 20);
            this.textNro.TabIndex = 7;
            // 
            // textDepto
            // 
            this.textDepto.Location = new System.Drawing.Point(200, 97);
            this.textDepto.Name = "textDepto";
            this.textDepto.Size = new System.Drawing.Size(73, 20);
            this.textDepto.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Depto/Piso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calle:";
            // 
            // textcalle
            // 
            this.textcalle.Location = new System.Drawing.Point(68, 20);
            this.textcalle.Name = "textcalle";
            this.textcalle.Size = new System.Drawing.Size(205, 20);
            this.textcalle.TabIndex = 6;
            // 
            // textdni
            // 
            this.textdni.Location = new System.Drawing.Point(104, 96);
            this.textdni.Name = "textdni";
            this.textdni.Size = new System.Drawing.Size(205, 20);
            this.textdni.TabIndex = 27;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(104, 137);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(205, 20);
            this.textTel.TabIndex = 26;
            // 
            // textApe
            // 
            this.textApe.Location = new System.Drawing.Point(104, 65);
            this.textApe.Name = "textApe";
            this.textApe.Size = new System.Drawing.Size(205, 20);
            this.textApe.TabIndex = 25;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(104, 30);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(205, 20);
            this.textNombre.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre: ";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(36, 319);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(52, 20);
            this.textid.TabIndex = 30;
            this.textid.Visible = false;
            // 
            // ingresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 405);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textdni);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textApe);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ingresarCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.ingresarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton agregarCliente;
        private FontAwesome.Sharp.IconButton modificarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textNro;
        private System.Windows.Forms.TextBox textDepto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcalle;
        private System.Windows.Forms.TextBox textdni;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textApe;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textid;
    }
}