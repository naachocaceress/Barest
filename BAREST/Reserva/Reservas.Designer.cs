
namespace BAREST
{
    partial class Reservas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaReservas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAnteriorMes = new System.Windows.Forms.Button();
            this.btnActualMes = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnEstadisticas = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRes = new FontAwesome.Sharp.IconButton();
            this.btnEliminarRes = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAnuRecu = new FontAwesome.Sharp.IconButton();
            this.limiteReservas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnAgregarRes);
            this.panel1.Controls.Add(this.btnEliminarRes);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAnuRecu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 50);
            this.panel1.TabIndex = 1;
            // 
            // tablaReservas
            // 
            this.tablaReservas.AllowUserToAddRows = false;
            this.tablaReservas.AllowUserToDeleteRows = false;
            this.tablaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.PAX,
            this.Hora,
            this.Fecha,
            this.lugar,
            this.NumeroTel,
            this.Comentarios,
            this.Estado});
            this.tablaReservas.Location = new System.Drawing.Point(12, 208);
            this.tablaReservas.Name = "tablaReservas";
            this.tablaReservas.ReadOnly = true;
            this.tablaReservas.Size = new System.Drawing.Size(924, 249);
            this.tablaReservas.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // PAX
            // 
            this.PAX.HeaderText = "PAX";
            this.PAX.Name = "PAX";
            this.PAX.ReadOnly = true;
            this.PAX.Width = 50;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 85;
            // 
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // NumeroTel
            // 
            this.NumeroTel.HeaderText = "Telefono";
            this.NumeroTel.Name = "NumeroTel";
            this.NumeroTel.ReadOnly = true;
            this.NumeroTel.Width = 110;
            // 
            // Comentarios
            // 
            this.Comentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(436, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(104, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(53, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.BackColor = System.Drawing.Color.Transparent;
            this.fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.ForeColor = System.Drawing.Color.Black;
            this.fechaLabel.Location = new System.Drawing.Point(12, 9);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(86, 16);
            this.fechaLabel.TabIndex = 12;
            this.fechaLabel.Text = "aa/bb/cccc";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAnteriorMes
            // 
            this.btnAnteriorMes.Location = new System.Drawing.Point(325, 63);
            this.btnAnteriorMes.Name = "btnAnteriorMes";
            this.btnAnteriorMes.Size = new System.Drawing.Size(83, 23);
            this.btnAnteriorMes.TabIndex = 14;
            this.btnAnteriorMes.Text = "ANTERIOR";
            this.btnAnteriorMes.UseVisualStyleBackColor = true;
            this.btnAnteriorMes.Click += new System.EventHandler(this.btnAnteriorMes_Click);
            // 
            // btnActualMes
            // 
            this.btnActualMes.Location = new System.Drawing.Point(325, 103);
            this.btnActualMes.Name = "btnActualMes";
            this.btnActualMes.Size = new System.Drawing.Size(83, 23);
            this.btnActualMes.TabIndex = 15;
            this.btnActualMes.Text = "ACTUAL";
            this.btnActualMes.UseVisualStyleBackColor = true;
            this.btnActualMes.Click += new System.EventHandler(this.btnActualMes_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(325, 144);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(83, 23);
            this.btnHoy.TabIndex = 16;
            this.btnHoy.Text = "HOY";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnEstadisticas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstadisticas.IconSize = 30;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(100, 0);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(121, 50);
            this.btnEstadisticas.TabIndex = 5;
            this.btnEstadisticas.Text = "       Estadisticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnImprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(0, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 50);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "       Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAgregarRes
            // 
            this.btnAgregarRes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarRes.FlatAppearance.BorderSize = 0;
            this.btnAgregarRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAgregarRes.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregarRes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAgregarRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRes.IconSize = 30;
            this.btnAgregarRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRes.Location = new System.Drawing.Point(510, 0);
            this.btnAgregarRes.Name = "btnAgregarRes";
            this.btnAgregarRes.Size = new System.Drawing.Size(100, 50);
            this.btnAgregarRes.TabIndex = 2;
            this.btnAgregarRes.Text = "       Agregar";
            this.btnAgregarRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRes.UseVisualStyleBackColor = true;
            this.btnAgregarRes.Click += new System.EventHandler(this.btnAgregarRes_Click);
            // 
            // btnEliminarRes
            // 
            this.btnEliminarRes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminarRes.FlatAppearance.BorderSize = 0;
            this.btnEliminarRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEliminarRes.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnEliminarRes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEliminarRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRes.IconSize = 30;
            this.btnEliminarRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRes.Location = new System.Drawing.Point(610, 0);
            this.btnEliminarRes.Name = "btnEliminarRes";
            this.btnEliminarRes.Size = new System.Drawing.Size(100, 50);
            this.btnEliminarRes.TabIndex = 7;
            this.btnEliminarRes.Text = "       Eliminar";
            this.btnEliminarRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRes.UseVisualStyleBackColor = true;
            this.btnEliminarRes.Click += new System.EventHandler(this.btnEliminarRes_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(710, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 50);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "       Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnuRecu
            // 
            this.btnAnuRecu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnuRecu.FlatAppearance.BorderSize = 0;
            this.btnAnuRecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuRecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuRecu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAnuRecu.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnAnuRecu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAnuRecu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnuRecu.IconSize = 30;
            this.btnAnuRecu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnuRecu.Location = new System.Drawing.Point(820, 0);
            this.btnAnuRecu.Name = "btnAnuRecu";
            this.btnAnuRecu.Size = new System.Drawing.Size(122, 50);
            this.btnAnuRecu.TabIndex = 4;
            this.btnAnuRecu.Text = "       Anular o      \r\n       Recuperar";
            this.btnAnuRecu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnuRecu.UseVisualStyleBackColor = true;
            this.btnAnuRecu.Click += new System.EventHandler(this.btnAnuRecu_Click);
            // 
            // limiteReservas
            // 
            this.limiteReservas.AutoSize = true;
            this.limiteReservas.BackColor = System.Drawing.Color.Transparent;
            this.limiteReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limiteReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.limiteReservas.Location = new System.Drawing.Point(749, 9);
            this.limiteReservas.Name = "limiteReservas";
            this.limiteReservas.Size = new System.Drawing.Size(187, 16);
            this.limiteReservas.TabIndex = 17;
            this.limiteReservas.Text = "Limite de reservas de hoy\r\n";
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(942, 513);
            this.Controls.Add(this.limiteReservas);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.btnActualMes);
            this.Controls.Add(this.btnAnteriorMes);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tablaReservas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarRes;
        private FontAwesome.Sharp.IconButton btnAnuRecu;
        private System.Windows.Forms.DataGridView tablaReservas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAnteriorMes;
        private System.Windows.Forms.Button btnActualMes;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnEstadisticas;
        private FontAwesome.Sharp.IconButton btnEliminarRes;
        private System.Windows.Forms.Label limiteReservas;
    }
}