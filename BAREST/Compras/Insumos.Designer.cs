
namespace BAREST.Compras
{
    partial class Insumos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaRubro = new System.Windows.Forms.DataGridView();
            this.Rubros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarRubro = new System.Windows.Forms.Button();
            this.agregarRubro = new System.Windows.Forms.Button();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescInsumo = new System.Windows.Forms.TextBox();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCant = new System.Windows.Forms.TextBox();
            this.tablaArticulos = new System.Windows.Forms.DataGridView();
            this.Articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultarInsumos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboProveedor = new System.Windows.Forms.ComboBox();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.guardarModifi = new System.Windows.Forms.Button();
            this.agregarInsu = new FontAwesome.Sharp.IconButton();
            this.EliminarInsu = new FontAwesome.Sharp.IconButton();
            this.modificarInsu = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.agregarInsu);
            this.panel1.Controls.Add(this.EliminarInsu);
            this.panel1.Controls.Add(this.modificarInsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaRubro);
            this.groupBox1.Controls.Add(this.eliminarRubro);
            this.groupBox1.Controls.Add(this.agregarRubro);
            this.groupBox1.Controls.Add(this.textRubro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(420, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rubros";
            // 
            // tablaRubro
            // 
            this.tablaRubro.AllowUserToAddRows = false;
            this.tablaRubro.AllowUserToDeleteRows = false;
            this.tablaRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rubros});
            this.tablaRubro.Location = new System.Drawing.Point(31, 81);
            this.tablaRubro.Name = "tablaRubro";
            this.tablaRubro.ReadOnly = true;
            this.tablaRubro.Size = new System.Drawing.Size(151, 148);
            this.tablaRubro.TabIndex = 4;
            // 
            // Rubros
            // 
            this.Rubros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rubros.HeaderText = "Rubros";
            this.Rubros.Name = "Rubros";
            this.Rubros.ReadOnly = true;
            // 
            // eliminarRubro
            // 
            this.eliminarRubro.Location = new System.Drawing.Point(122, 243);
            this.eliminarRubro.Name = "eliminarRubro";
            this.eliminarRubro.Size = new System.Drawing.Size(75, 23);
            this.eliminarRubro.TabIndex = 10;
            this.eliminarRubro.Text = "Eliminar";
            this.eliminarRubro.UseVisualStyleBackColor = true;
            this.eliminarRubro.Click += new System.EventHandler(this.eliminarRubro_Click);
            // 
            // agregarRubro
            // 
            this.agregarRubro.Location = new System.Drawing.Point(17, 243);
            this.agregarRubro.Name = "agregarRubro";
            this.agregarRubro.Size = new System.Drawing.Size(75, 23);
            this.agregarRubro.TabIndex = 9;
            this.agregarRubro.Text = "Agregar";
            this.agregarRubro.UseVisualStyleBackColor = true;
            this.agregarRubro.Click += new System.EventHandler(this.agregarRubro_Click);
            // 
            // textRubro
            // 
            this.textRubro.Location = new System.Drawing.Point(31, 46);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(151, 20);
            this.textRubro.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // textDescInsumo
            // 
            this.textDescInsumo.Location = new System.Drawing.Point(32, 38);
            this.textDescInsumo.Name = "textDescInsumo";
            this.textDescInsumo.Size = new System.Drawing.Size(181, 20);
            this.textDescInsumo.TabIndex = 1;
            // 
            // comboRubro
            // 
            this.comboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(92, 151);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(121, 21);
            this.comboRubro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidad de medida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // textCant
            // 
            this.textCant.Location = new System.Drawing.Point(148, 106);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(65, 20);
            this.textCant.TabIndex = 3;
            // 
            // tablaArticulos
            // 
            this.tablaArticulos.AllowUserToAddRows = false;
            this.tablaArticulos.AllowUserToDeleteRows = false;
            this.tablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulos});
            this.tablaArticulos.Location = new System.Drawing.Point(268, 33);
            this.tablaArticulos.Name = "tablaArticulos";
            this.tablaArticulos.ReadOnly = true;
            this.tablaArticulos.Size = new System.Drawing.Size(132, 217);
            this.tablaArticulos.TabIndex = 11;
            // 
            // Articulos
            // 
            this.Articulos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Articulos.HeaderText = "Articulos";
            this.Articulos.Name = "Articulos";
            this.Articulos.ReadOnly = true;
            // 
            // consultarInsumos
            // 
            this.consultarInsumos.Location = new System.Drawing.Point(47, 257);
            this.consultarInsumos.Name = "consultarInsumos";
            this.consultarInsumos.Size = new System.Drawing.Size(150, 25);
            this.consultarInsumos.TabIndex = 7;
            this.consultarInsumos.Text = "Consultar Insumos";
            this.consultarInsumos.UseVisualStyleBackColor = true;
            this.consultarInsumos.Click += new System.EventHandler(this.consultarInsumos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Proveedor:";
            // 
            // comboProveedor
            // 
            this.comboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.Location = new System.Drawing.Point(92, 199);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(121, 21);
            this.comboProveedor.TabIndex = 5;
            // 
            // textUnidad
            // 
            this.textUnidad.Location = new System.Drawing.Point(34, 105);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.Size = new System.Drawing.Size(91, 20);
            this.textUnidad.TabIndex = 2;
            // 
            // guardarModifi
            // 
            this.guardarModifi.Location = new System.Drawing.Point(81, 227);
            this.guardarModifi.Name = "guardarModifi";
            this.guardarModifi.Size = new System.Drawing.Size(75, 23);
            this.guardarModifi.TabIndex = 6;
            this.guardarModifi.Text = "Guardar";
            this.guardarModifi.UseVisualStyleBackColor = true;
            this.guardarModifi.Click += new System.EventHandler(this.guardarModifi_Click);
            // 
            // agregarInsu
            // 
            this.agregarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregarInsu.FlatAppearance.BorderSize = 0;
            this.agregarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarInsu.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.agregarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarInsu.IconSize = 30;
            this.agregarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarInsu.Location = new System.Drawing.Point(352, 0);
            this.agregarInsu.Name = "agregarInsu";
            this.agregarInsu.Size = new System.Drawing.Size(100, 50);
            this.agregarInsu.TabIndex = 11;
            this.agregarInsu.Text = "       Agregar";
            this.agregarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarInsu.UseVisualStyleBackColor = true;
            this.agregarInsu.Click += new System.EventHandler(this.agregarInsu_Click);
            // 
            // EliminarInsu
            // 
            this.EliminarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarInsu.FlatAppearance.BorderSize = 0;
            this.EliminarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.EliminarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarInsu.IconSize = 30;
            this.EliminarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.Location = new System.Drawing.Point(452, 0);
            this.EliminarInsu.Name = "EliminarInsu";
            this.EliminarInsu.Size = new System.Drawing.Size(100, 50);
            this.EliminarInsu.TabIndex = 12;
            this.EliminarInsu.Text = "       Eliminar";
            this.EliminarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.UseVisualStyleBackColor = true;
            this.EliminarInsu.Click += new System.EventHandler(this.EliminarInsu_Click);
            // 
            // modificarInsu
            // 
            this.modificarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.modificarInsu.FlatAppearance.BorderSize = 0;
            this.modificarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarInsu.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.modificarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.modificarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificarInsu.IconSize = 30;
            this.modificarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarInsu.Location = new System.Drawing.Point(552, 0);
            this.modificarInsu.Name = "modificarInsu";
            this.modificarInsu.Size = new System.Drawing.Size(110, 50);
            this.modificarInsu.TabIndex = 13;
            this.modificarInsu.Text = "       Modificar";
            this.modificarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarInsu.UseVisualStyleBackColor = true;
            this.modificarInsu.Click += new System.EventHandler(this.modificarInsu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(662, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guardarModifi);
            this.Controls.Add(this.textUnidad);
            this.Controls.Add(this.comboProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.consultarInsumos);
            this.Controls.Add(this.tablaArticulos);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboRubro);
            this.Controls.Add(this.textDescInsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Insumos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.Insumos_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubros;
        private System.Windows.Forms.Button eliminarRubro;
        private System.Windows.Forms.Button agregarRubro;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDescInsumo;
        private System.Windows.Forms.ComboBox comboRubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCant;
        private FontAwesome.Sharp.IconButton agregarInsu;
        private FontAwesome.Sharp.IconButton EliminarInsu;
        private FontAwesome.Sharp.IconButton modificarInsu;
        private System.Windows.Forms.DataGridView tablaArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulos;
        private System.Windows.Forms.Button consultarInsumos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboProveedor;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.Button guardarModifi;
        private System.Windows.Forms.Button button1;
    }
}