﻿namespace BAREST
{
    partial class inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.config = new FontAwesome.Sharp.IconButton();
            this.informes = new FontAwesome.Sharp.IconButton();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.categorias = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.personal = new FontAwesome.Sharp.IconButton();
            this.panelStock = new System.Windows.Forms.Panel();
            this.inventariosStock = new System.Windows.Forms.Button();
            this.manejoStock = new System.Windows.Forms.Button();
            this.stock = new FontAwesome.Sharp.IconButton();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.estadoCompras = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.proveedores = new System.Windows.Forms.Button();
            this.compras = new FontAwesome.Sharp.IconButton();
            this.ventas = new FontAwesome.Sharp.IconButton();
            this.menu = new FontAwesome.Sharp.IconButton();
            this.panelCaja = new System.Windows.Forms.Panel();
            this.cajaSocios = new System.Windows.Forms.Button();
            this.caja2 = new System.Windows.Forms.Button();
            this.caja1 = new System.Windows.Forms.Button();
            this.caja = new FontAwesome.Sharp.IconButton();
            this.reservas = new FontAwesome.Sharp.IconButton();
            this.panelTurno = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.iniciar = new System.Windows.Forms.Button();
            this.salir = new FontAwesome.Sharp.IconButton();
            this.turno = new FontAwesome.Sharp.IconButton();
            this.panelTitulos = new System.Windows.Forms.Panel();
            this.botonHiden = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panelCaja.SuspendLayout();
            this.panelTurno.SuspendLayout();
            this.panelTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelContenedor.BackgroundImage = global::BAREST.Properties.Resources.El_lugar_de_la_buena_vida;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1112, 640);
            this.panelContenedor.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fechaLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(826, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 640);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(29, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Totales:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.fechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.fechaLabel.Location = new System.Drawing.Point(118, 37);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(95, 13);
            this.fechaLabel.TabIndex = 7;
            this.fechaLabel.Text = "aa/bb/cccc dd:ee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cerrados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(155)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Abiertos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BAREST.Properties.Resources.Banner_Vidon_3;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panelBotones
            // 
            this.panelBotones.AutoScroll = true;
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.panelBotones.Controls.Add(this.config);
            this.panelBotones.Controls.Add(this.informes);
            this.panelBotones.Controls.Add(this.panelPersonal);
            this.panelBotones.Controls.Add(this.personal);
            this.panelBotones.Controls.Add(this.panelStock);
            this.panelBotones.Controls.Add(this.stock);
            this.panelBotones.Controls.Add(this.panelCompras);
            this.panelBotones.Controls.Add(this.compras);
            this.panelBotones.Controls.Add(this.ventas);
            this.panelBotones.Controls.Add(this.menu);
            this.panelBotones.Controls.Add(this.panelCaja);
            this.panelBotones.Controls.Add(this.caja);
            this.panelBotones.Controls.Add(this.reservas);
            this.panelBotones.Controls.Add(this.panelTurno);
            this.panelBotones.Controls.Add(this.salir);
            this.panelBotones.Controls.Add(this.turno);
            this.panelBotones.Controls.Add(this.panelTitulos);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(137, 640);
            this.panelBotones.TabIndex = 1;
            // 
            // config
            // 
            this.config.Dock = System.Windows.Forms.DockStyle.Top;
            this.config.FlatAppearance.BorderSize = 0;
            this.config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.config.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.config.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.config.IconSize = 30;
            this.config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.config.Location = new System.Drawing.Point(0, 785);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(120, 35);
            this.config.TabIndex = 8;
            this.config.Text = "       Configuracion";
            this.config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // informes
            // 
            this.informes.Dock = System.Windows.Forms.DockStyle.Top;
            this.informes.FlatAppearance.BorderSize = 0;
            this.informes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.informes.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.informes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.informes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.informes.IconSize = 30;
            this.informes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informes.Location = new System.Drawing.Point(0, 750);
            this.informes.Name = "informes";
            this.informes.Size = new System.Drawing.Size(120, 35);
            this.informes.TabIndex = 11;
            this.informes.Text = "       Informes";
            this.informes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informes.UseVisualStyleBackColor = true;
            this.informes.Click += new System.EventHandler(this.informes_Click);
            // 
            // panelPersonal
            // 
            this.panelPersonal.Controls.Add(this.categorias);
            this.panelPersonal.Controls.Add(this.button2);
            this.panelPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPersonal.Location = new System.Drawing.Point(0, 680);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(120, 70);
            this.panelPersonal.TabIndex = 12;
            // 
            // categorias
            // 
            this.categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorias.FlatAppearance.BorderSize = 0;
            this.categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.categorias.Location = new System.Drawing.Point(0, 35);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(120, 35);
            this.categorias.TabIndex = 2;
            this.categorias.Text = "       Categorias";
            this.categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorias.UseVisualStyleBackColor = true;
            this.categorias.Click += new System.EventHandler(this.categorias_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "       Empleados";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personal
            // 
            this.personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.personal.FlatAppearance.BorderSize = 0;
            this.personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.personal.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.personal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.personal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.personal.IconSize = 30;
            this.personal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personal.Location = new System.Drawing.Point(0, 645);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(120, 35);
            this.personal.TabIndex = 10;
            this.personal.Text = "       Personal";
            this.personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personal.UseVisualStyleBackColor = true;
            this.personal.Click += new System.EventHandler(this.personal_Click);
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.inventariosStock);
            this.panelStock.Controls.Add(this.manejoStock);
            this.panelStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStock.Location = new System.Drawing.Point(0, 575);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(120, 70);
            this.panelStock.TabIndex = 11;
            // 
            // inventariosStock
            // 
            this.inventariosStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventariosStock.FlatAppearance.BorderSize = 0;
            this.inventariosStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventariosStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.inventariosStock.Location = new System.Drawing.Point(0, 35);
            this.inventariosStock.Name = "inventariosStock";
            this.inventariosStock.Size = new System.Drawing.Size(120, 35);
            this.inventariosStock.TabIndex = 2;
            this.inventariosStock.Text = "       Inventarios";
            this.inventariosStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventariosStock.UseVisualStyleBackColor = true;
            this.inventariosStock.Click += new System.EventHandler(this.inventariosStock_Click);
            // 
            // manejoStock
            // 
            this.manejoStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.manejoStock.FlatAppearance.BorderSize = 0;
            this.manejoStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manejoStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.manejoStock.Location = new System.Drawing.Point(0, 0);
            this.manejoStock.Name = "manejoStock";
            this.manejoStock.Size = new System.Drawing.Size(120, 35);
            this.manejoStock.TabIndex = 1;
            this.manejoStock.Text = "       Manejo de Stock";
            this.manejoStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manejoStock.UseVisualStyleBackColor = true;
            this.manejoStock.Click += new System.EventHandler(this.manejoStock_Click);
            // 
            // stock
            // 
            this.stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.stock.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.stock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stock.IconSize = 30;
            this.stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock.Location = new System.Drawing.Point(0, 540);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(120, 35);
            this.stock.TabIndex = 11;
            this.stock.Text = "       Stock";
            this.stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock.UseVisualStyleBackColor = true;
            this.stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // panelCompras
            // 
            this.panelCompras.Controls.Add(this.estadoCompras);
            this.panelCompras.Controls.Add(this.button21);
            this.panelCompras.Controls.Add(this.proveedores);
            this.panelCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompras.Location = new System.Drawing.Point(0, 435);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(120, 105);
            this.panelCompras.TabIndex = 6;
            // 
            // estadoCompras
            // 
            this.estadoCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.estadoCompras.FlatAppearance.BorderSize = 0;
            this.estadoCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadoCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.estadoCompras.Location = new System.Drawing.Point(0, 70);
            this.estadoCompras.Name = "estadoCompras";
            this.estadoCompras.Size = new System.Drawing.Size(120, 35);
            this.estadoCompras.TabIndex = 3;
            this.estadoCompras.Text = "       Estado ";
            this.estadoCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estadoCompras.UseVisualStyleBackColor = true;
            this.estadoCompras.Click += new System.EventHandler(this.estadoCompras_Click);
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Top;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.button21.Location = new System.Drawing.Point(0, 35);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 35);
            this.button21.TabIndex = 2;
            this.button21.Text = "       Insumos";
            this.button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // proveedores
            // 
            this.proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.proveedores.FlatAppearance.BorderSize = 0;
            this.proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.proveedores.Location = new System.Drawing.Point(0, 0);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(120, 35);
            this.proveedores.TabIndex = 1;
            this.proveedores.Text = "       Proveedores";
            this.proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedores.UseVisualStyleBackColor = true;
            this.proveedores.Click += new System.EventHandler(this.proveedores_Click);
            // 
            // compras
            // 
            this.compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.compras.FlatAppearance.BorderSize = 0;
            this.compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.compras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.compras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.compras.IconSize = 30;
            this.compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compras.Location = new System.Drawing.Point(0, 400);
            this.compras.Name = "compras";
            this.compras.Size = new System.Drawing.Size(120, 35);
            this.compras.TabIndex = 6;
            this.compras.Text = "       Compras";
            this.compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compras.UseVisualStyleBackColor = true;
            this.compras.Click += new System.EventHandler(this.compras_Click_1);
            // 
            // ventas
            // 
            this.ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ventas.FlatAppearance.BorderSize = 0;
            this.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ventas.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ventas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ventas.IconSize = 30;
            this.ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventas.Location = new System.Drawing.Point(0, 365);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(120, 35);
            this.ventas.TabIndex = 5;
            this.ventas.Text = "       Ventas";
            this.ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.menu.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.menu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu.IconSize = 30;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(0, 330);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(120, 35);
            this.menu.TabIndex = 7;
            this.menu.Text = "       Menu";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panelCaja
            // 
            this.panelCaja.Controls.Add(this.cajaSocios);
            this.panelCaja.Controls.Add(this.caja2);
            this.panelCaja.Controls.Add(this.caja1);
            this.panelCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaja.Location = new System.Drawing.Point(0, 225);
            this.panelCaja.Name = "panelCaja";
            this.panelCaja.Size = new System.Drawing.Size(120, 105);
            this.panelCaja.TabIndex = 2;
            // 
            // cajaSocios
            // 
            this.cajaSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.cajaSocios.FlatAppearance.BorderSize = 0;
            this.cajaSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cajaSocios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.cajaSocios.Location = new System.Drawing.Point(0, 70);
            this.cajaSocios.Name = "cajaSocios";
            this.cajaSocios.Size = new System.Drawing.Size(120, 35);
            this.cajaSocios.TabIndex = 4;
            this.cajaSocios.Text = "       Caja Socios";
            this.cajaSocios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cajaSocios.UseVisualStyleBackColor = true;
            this.cajaSocios.Click += new System.EventHandler(this.button1_Click);
            // 
            // caja2
            // 
            this.caja2.Dock = System.Windows.Forms.DockStyle.Top;
            this.caja2.FlatAppearance.BorderSize = 0;
            this.caja2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caja2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.caja2.Location = new System.Drawing.Point(0, 35);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(120, 35);
            this.caja2.TabIndex = 4;
            this.caja2.Text = "       Caja Mayor";
            this.caja2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caja2.UseVisualStyleBackColor = true;
            this.caja2.Click += new System.EventHandler(this.caja2_Click);
            // 
            // caja1
            // 
            this.caja1.Dock = System.Windows.Forms.DockStyle.Top;
            this.caja1.FlatAppearance.BorderSize = 0;
            this.caja1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caja1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.caja1.Location = new System.Drawing.Point(0, 0);
            this.caja1.Name = "caja1";
            this.caja1.Size = new System.Drawing.Size(120, 35);
            this.caja1.TabIndex = 3;
            this.caja1.Text = "       Caja Chica";
            this.caja1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caja1.UseVisualStyleBackColor = true;
            this.caja1.Click += new System.EventHandler(this.caja1_Click);
            // 
            // caja
            // 
            this.caja.Dock = System.Windows.Forms.DockStyle.Top;
            this.caja.FlatAppearance.BorderSize = 0;
            this.caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.caja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.caja.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.caja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.caja.IconSize = 30;
            this.caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caja.Location = new System.Drawing.Point(0, 190);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(120, 35);
            this.caja.TabIndex = 3;
            this.caja.Text = "       Caja";
            this.caja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caja.UseVisualStyleBackColor = true;
            this.caja.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // reservas
            // 
            this.reservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservas.FlatAppearance.BorderSize = 0;
            this.reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.reservas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.reservas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.reservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reservas.IconSize = 30;
            this.reservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservas.Location = new System.Drawing.Point(0, 155);
            this.reservas.Name = "reservas";
            this.reservas.Size = new System.Drawing.Size(120, 35);
            this.reservas.TabIndex = 8;
            this.reservas.Text = "       Reservas";
            this.reservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservas.UseVisualStyleBackColor = true;
            this.reservas.Click += new System.EventHandler(this.reservas_Click);
            // 
            // panelTurno
            // 
            this.panelTurno.Controls.Add(this.cerrar);
            this.panelTurno.Controls.Add(this.iniciar);
            this.panelTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTurno.Location = new System.Drawing.Point(0, 85);
            this.panelTurno.Name = "panelTurno";
            this.panelTurno.Size = new System.Drawing.Size(120, 70);
            this.panelTurno.TabIndex = 3;
            // 
            // cerrar
            // 
            this.cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.cerrar.Location = new System.Drawing.Point(0, 35);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(120, 35);
            this.cerrar.TabIndex = 4;
            this.cerrar.Text = "       Cerrar Turno";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // iniciar
            // 
            this.iniciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iniciar.FlatAppearance.BorderSize = 0;
            this.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.iniciar.Location = new System.Drawing.Point(0, 0);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(120, 35);
            this.iniciar.TabIndex = 3;
            this.iniciar.Text = "       Iniciar Turno";
            this.iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // salir
            // 
            this.salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.salir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.salir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salir.IconSize = 30;
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.Location = new System.Drawing.Point(0, 820);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(120, 35);
            this.salir.TabIndex = 9;
            this.salir.Text = "       Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // turno
            // 
            this.turno.Dock = System.Windows.Forms.DockStyle.Top;
            this.turno.FlatAppearance.BorderSize = 0;
            this.turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.turno.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.turno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.turno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.turno.IconSize = 30;
            this.turno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turno.Location = new System.Drawing.Point(0, 50);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(120, 35);
            this.turno.TabIndex = 4;
            this.turno.Text = "       Turno";
            this.turno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turno.UseVisualStyleBackColor = true;
            this.turno.Click += new System.EventHandler(this.inicioTurno_Click);
            // 
            // panelTitulos
            // 
            this.panelTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.panelTitulos.Controls.Add(this.botonHiden);
            this.panelTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulos.Location = new System.Drawing.Point(0, 0);
            this.panelTitulos.Name = "panelTitulos";
            this.panelTitulos.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelTitulos.Size = new System.Drawing.Size(120, 50);
            this.panelTitulos.TabIndex = 0;
            // 
            // botonHiden
            // 
            this.botonHiden.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonHiden.FlatAppearance.BorderSize = 0;
            this.botonHiden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonHiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonHiden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.botonHiden.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.botonHiden.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.botonHiden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonHiden.IconSize = 30;
            this.botonHiden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonHiden.Location = new System.Drawing.Point(0, 3);
            this.botonHiden.Name = "botonHiden";
            this.botonHiden.Size = new System.Drawing.Size(120, 47);
            this.botonHiden.TabIndex = 5;
            this.botonHiden.Text = "       BAREST";
            this.botonHiden.UseVisualStyleBackColor = true;
            this.botonHiden.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(155)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(80, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(155)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(80, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(155)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(80, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(132)))), ((int)(((byte)(68)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(103, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "|";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1112, 640);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.configuracion_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelPersonal.ResumeLayout(false);
            this.panelStock.ResumeLayout(false);
            this.panelCompras.ResumeLayout(false);
            this.panelCaja.ResumeLayout(false);
            this.panelTurno.ResumeLayout(false);
            this.panelTitulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelTitulos;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Button estadoCompras;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button proveedores;
        private FontAwesome.Sharp.IconButton caja;
        private FontAwesome.Sharp.IconButton turno;
        private FontAwesome.Sharp.IconButton ventas;
        private FontAwesome.Sharp.IconButton compras;
        private FontAwesome.Sharp.IconButton config;
        private FontAwesome.Sharp.IconButton salir;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelCaja;
        private System.Windows.Forms.Button caja2;
        private System.Windows.Forms.Button caja1;
        private FontAwesome.Sharp.IconButton personal;
        private FontAwesome.Sharp.IconButton stock;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Button inventariosStock;
        private System.Windows.Forms.Button manejoStock;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Button categorias;
        private System.Windows.Forms.Button button2;
        private FontAwesome.Sharp.IconButton informes;
        private FontAwesome.Sharp.IconButton menu;
        private FontAwesome.Sharp.IconButton reservas;
        private System.Windows.Forms.Panel panelTurno;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button cajaSocios;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton botonHiden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}