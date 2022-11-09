
namespace BAREST.Compras
{
    partial class Proveedores
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
            this.agregarProveedor = new FontAwesome.Sharp.IconButton();
            this.EliminarProv = new FontAwesome.Sharp.IconButton();
            this.modificarProveedor = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tablaProveedores = new System.Windows.Forms.DataGridView();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textcuit = new System.Windows.Forms.TextBox();
            this.textEmpresa = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textcalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textNro = new System.Windows.Forms.TextBox();
            this.textDepto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guardarModifi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.agregarProveedor);
            this.panel1.Controls.Add(this.EliminarProv);
            this.panel1.Controls.Add(this.modificarProveedor);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 50);
            this.panel1.TabIndex = 1;
            // 
            // agregarProveedor
            // 
            this.agregarProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregarProveedor.FlatAppearance.BorderSize = 0;
            this.agregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarProveedor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.agregarProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarProveedor.IconSize = 30;
            this.agregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProveedor.Location = new System.Drawing.Point(352, 0);
            this.agregarProveedor.Name = "agregarProveedor";
            this.agregarProveedor.Size = new System.Drawing.Size(100, 50);
            this.agregarProveedor.TabIndex = 14;
            this.agregarProveedor.Text = "       Agregar";
            this.agregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProveedor.UseVisualStyleBackColor = true;
            this.agregarProveedor.Click += new System.EventHandler(this.agregarInsu_Click);
            // 
            // EliminarProv
            // 
            this.EliminarProv.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarProv.FlatAppearance.BorderSize = 0;
            this.EliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarProv.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.EliminarProv.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarProv.IconSize = 30;
            this.EliminarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarProv.Location = new System.Drawing.Point(452, 0);
            this.EliminarProv.Name = "EliminarProv";
            this.EliminarProv.Size = new System.Drawing.Size(100, 50);
            this.EliminarProv.TabIndex = 15;
            this.EliminarProv.Text = "       Eliminar";
            this.EliminarProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarProv.UseVisualStyleBackColor = true;
            this.EliminarProv.Click += new System.EventHandler(this.EliminarInsu_Click);
            // 
            // modificarProveedor
            // 
            this.modificarProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.modificarProveedor.FlatAppearance.BorderSize = 0;
            this.modificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarProveedor.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.modificarProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificarProveedor.IconSize = 30;
            this.modificarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarProveedor.Location = new System.Drawing.Point(552, 0);
            this.modificarProveedor.Name = "modificarProveedor";
            this.modificarProveedor.Size = new System.Drawing.Size(110, 50);
            this.modificarProveedor.TabIndex = 16;
            this.modificarProveedor.Text = "       Modificar";
            this.modificarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarProveedor.UseVisualStyleBackColor = true;
            this.modificarProveedor.Click += new System.EventHandler(this.modificarInsu_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(140, 50);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "       Proveedores";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // tablaProveedores
            // 
            this.tablaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.Telefono});
            this.tablaProveedores.Location = new System.Drawing.Point(414, 12);
            this.tablaProveedores.Name = "tablaProveedores";
            this.tablaProveedores.Size = new System.Drawing.Size(236, 207);
            this.tablaProveedores.TabIndex = 2;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // textcuit
            // 
            this.textcuit.Location = new System.Drawing.Point(15, 28);
            this.textcuit.Name = "textcuit";
            this.textcuit.Size = new System.Drawing.Size(153, 20);
            this.textcuit.TabIndex = 1;
            // 
            // textEmpresa
            // 
            this.textEmpresa.Location = new System.Drawing.Point(15, 77);
            this.textEmpresa.Name = "textEmpresa";
            this.textEmpresa.Size = new System.Drawing.Size(153, 20);
            this.textEmpresa.TabIndex = 2;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(15, 133);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(150, 20);
            this.textTel.TabIndex = 3;
            // 
            // textcalle
            // 
            this.textcalle.Location = new System.Drawing.Point(9, 41);
            this.textcalle.Name = "textcalle";
            this.textcalle.Size = new System.Drawing.Size(170, 20);
            this.textcalle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CUIT/CUIL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista de productos:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Importar Archivo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textNro);
            this.groupBox1.Controls.Add(this.textDepto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textcalle);
            this.groupBox1.Location = new System.Drawing.Point(193, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 130);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nro:";
            // 
            // textNro
            // 
            this.textNro.Location = new System.Drawing.Point(9, 97);
            this.textNro.Name = "textNro";
            this.textNro.Size = new System.Drawing.Size(51, 20);
            this.textNro.TabIndex = 7;
            // 
            // textDepto
            // 
            this.textDepto.Location = new System.Drawing.Point(91, 97);
            this.textDepto.Name = "textDepto";
            this.textDepto.Size = new System.Drawing.Size(73, 20);
            this.textDepto.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Depto/Piso:";
            // 
            // guardarModifi
            // 
            this.guardarModifi.Location = new System.Drawing.Point(223, 173);
            this.guardarModifi.Name = "guardarModifi";
            this.guardarModifi.Size = new System.Drawing.Size(122, 23);
            this.guardarModifi.TabIndex = 19;
            this.guardarModifi.Text = "Guardar";
            this.guardarModifi.UseVisualStyleBackColor = true;
            this.guardarModifi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 283);
            this.Controls.Add(this.guardarModifi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textEmpresa);
            this.Controls.Add(this.textcuit);
            this.Controls.Add(this.tablaProveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Proveedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton agregarProveedor;
        private FontAwesome.Sharp.IconButton EliminarProv;
        private FontAwesome.Sharp.IconButton modificarProveedor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView tablaProveedores;
        private System.Windows.Forms.TextBox textcuit;
        private System.Windows.Forms.TextBox textEmpresa;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textcalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNro;
        private System.Windows.Forms.TextBox textDepto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button guardarModifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}