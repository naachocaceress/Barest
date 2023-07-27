namespace BAREST
{
    partial class Menu
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
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnInsertar = new FontAwesome.Sharp.IconButton();
            this.EliminarInsu = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaRubro = new System.Windows.Forms.DataGridView();
            this.Rubros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarRubro = new System.Windows.Forms.Button();
            this.agregarRubro = new System.Windows.Forms.Button();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaArticulos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textnomM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPrecioM = new System.Windows.Forms.TextBox();
            this.textDescM = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bfoto = new System.Windows.Forms.Button();
            this.comborubroMenu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.GroupBox();
            this.textId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Nota.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.EliminarInsu);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnguardar
            // 
            this.btnguardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 30;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(359, 0);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(110, 50);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "       Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 50);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "       Carta";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnInsertar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnInsertar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertar.IconSize = 30;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(469, 0);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 50);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "       Agregar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.agregarInsu_Click);
            // 
            // EliminarInsu
            // 
            this.EliminarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarInsu.FlatAppearance.BorderSize = 0;
            this.EliminarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.EliminarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarInsu.IconSize = 30;
            this.EliminarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.Location = new System.Drawing.Point(579, 0);
            this.EliminarInsu.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarInsu.Name = "EliminarInsu";
            this.EliminarInsu.Size = new System.Drawing.Size(110, 50);
            this.EliminarInsu.TabIndex = 11;
            this.EliminarInsu.Text = "       Eliminar";
            this.EliminarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.UseVisualStyleBackColor = true;
            this.EliminarInsu.Click += new System.EventHandler(this.EliminarInsu_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(689, 0);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 50);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "       Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.modificarInsu_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaRubro);
            this.groupBox1.Controls.Add(this.eliminarRubro);
            this.groupBox1.Controls.Add(this.agregarRubro);
            this.groupBox1.Controls.Add(this.textRubro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(594, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(191, 245);
            this.groupBox1.TabIndex = 3;
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
            this.tablaRubro.Location = new System.Drawing.Point(17, 62);
            this.tablaRubro.Margin = new System.Windows.Forms.Padding(4);
            this.tablaRubro.Name = "tablaRubro";
            this.tablaRubro.ReadOnly = true;
            this.tablaRubro.Size = new System.Drawing.Size(157, 139);
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
            this.eliminarRubro.Location = new System.Drawing.Point(99, 209);
            this.eliminarRubro.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarRubro.Name = "eliminarRubro";
            this.eliminarRubro.Size = new System.Drawing.Size(75, 28);
            this.eliminarRubro.TabIndex = 8;
            this.eliminarRubro.Text = "Eliminar";
            this.eliminarRubro.UseVisualStyleBackColor = true;
            this.eliminarRubro.Click += new System.EventHandler(this.eliminarRubro_Click);
            // 
            // agregarRubro
            // 
            this.agregarRubro.Location = new System.Drawing.Point(16, 209);
            this.agregarRubro.Margin = new System.Windows.Forms.Padding(4);
            this.agregarRubro.Name = "agregarRubro";
            this.agregarRubro.Size = new System.Drawing.Size(75, 28);
            this.agregarRubro.TabIndex = 7;
            this.agregarRubro.Text = "Agregar";
            this.agregarRubro.UseVisualStyleBackColor = true;
            this.agregarRubro.Click += new System.EventHandler(this.agregarRubro_Click);
            // 
            // textRubro
            // 
            this.textRubro.Location = new System.Drawing.Point(17, 34);
            this.textRubro.Margin = new System.Windows.Forms.Padding(4);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(134, 20);
            this.textRubro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // tablaArticulos
            // 
            this.tablaArticulos.AllowUserToAddRows = false;
            this.tablaArticulos.AllowUserToDeleteRows = false;
            this.tablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulos,
            this.precio});
            this.tablaArticulos.Location = new System.Drawing.Point(345, 13);
            this.tablaArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaArticulos.Name = "tablaArticulos";
            this.tablaArticulos.ReadOnly = true;
            this.tablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaArticulos.Size = new System.Drawing.Size(223, 252);
            this.tablaArticulos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // textnomM
            // 
            this.textnomM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomM.Location = new System.Drawing.Point(16, 35);
            this.textnomM.Margin = new System.Windows.Forms.Padding(4);
            this.textnomM.Name = "textnomM";
            this.textnomM.Size = new System.Drawing.Size(156, 20);
            this.textnomM.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio:";
            // 
            // textPrecioM
            // 
            this.textPrecioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioM.Location = new System.Drawing.Point(16, 199);
            this.textPrecioM.Margin = new System.Windows.Forms.Padding(4);
            this.textPrecioM.Name = "textPrecioM";
            this.textPrecioM.Size = new System.Drawing.Size(94, 20);
            this.textPrecioM.TabIndex = 4;
            this.textPrecioM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecioM_KeyPress);
            // 
            // textDescM
            // 
            this.textDescM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescM.Location = new System.Drawing.Point(16, 88);
            this.textDescM.Margin = new System.Windows.Forms.Padding(4);
            this.textDescM.Multiline = true;
            this.textDescM.Name = "textDescM";
            this.textDescM.Size = new System.Drawing.Size(181, 25);
            this.textDescM.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BAREST.Properties.Resources.imagenmenu1;
            this.pictureBox1.Location = new System.Drawing.Point(219, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // bfoto
            // 
            this.bfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfoto.Location = new System.Drawing.Point(219, 155);
            this.bfoto.Margin = new System.Windows.Forms.Padding(4);
            this.bfoto.Name = "bfoto";
            this.bfoto.Size = new System.Drawing.Size(107, 27);
            this.bfoto.TabIndex = 5;
            this.bfoto.Text = "Foto";
            this.bfoto.UseVisualStyleBackColor = true;
            this.bfoto.Click += new System.EventHandler(this.bfoto_Click);
            // 
            // comborubroMenu
            // 
            this.comborubroMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborubroMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborubroMenu.FormattingEnabled = true;
            this.comborubroMenu.Location = new System.Drawing.Point(16, 139);
            this.comborubroMenu.Margin = new System.Windows.Forms.Padding(4);
            this.comborubroMenu.Name = "comborubroMenu";
            this.comborubroMenu.Size = new System.Drawing.Size(123, 21);
            this.comborubroMenu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rubro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(180, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(147, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(118, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Articulos
            // 
            this.Articulos.FillWeight = 101.5228F;
            this.Articulos.HeaderText = "Articulo";
            this.Articulos.Name = "Articulos";
            this.Articulos.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.FillWeight = 98.47717F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Las casillas marcadas con asteriscos (*), son obligatorias!";
            // 
            // Nota
            // 
            this.Nota.Controls.Add(this.label9);
            this.Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota.Location = new System.Drawing.Point(16, 229);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(310, 36);
            this.Nota.TabIndex = 33;
            this.Nota.TabStop = false;
            this.Nota.Text = "Nota";
            // 
            // textId
            // 
            this.textId.AutoSize = true;
            this.textId.ForeColor = System.Drawing.SystemColors.Control;
            this.textId.Location = new System.Drawing.Point(231, 199);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(52, 16);
            this.textId.TabIndex = 34;
            this.textId.Text = "label10";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 333);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comborubroMenu);
            this.Controls.Add(this.bfoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textDescM);
            this.Controls.Add(this.textPrecioM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnomM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaArticulos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Nota.ResumeLayout(false);
            this.Nota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnInsertar;
        private FontAwesome.Sharp.IconButton EliminarInsu;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubros;
        private System.Windows.Forms.Button eliminarRubro;
        private System.Windows.Forms.Button agregarRubro;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnomM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPrecioM;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textDescM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bfoto;
        private System.Windows.Forms.ComboBox comborubroMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Nota;
        private System.Windows.Forms.Label textId;
    }
}