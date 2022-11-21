
namespace BAREST.Ventas
{
    partial class Venta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textMesa = new System.Windows.Forms.TextBox();
            this.buscarMesaBTN = new FontAwesome.Sharp.IconPictureBox();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEfect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTransf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTarj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMesaBTN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mesa,
            this.Cantidad,
            this.Detalles,
            this.Total,
            this.Efectivo,
            this.Transferencia,
            this.Tarjeta});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buscarMesaBTN);
            this.panel1.Controls.Add(this.textMesa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa:";
            // 
            // textMesa
            // 
            this.textMesa.Location = new System.Drawing.Point(57, 22);
            this.textMesa.Name = "textMesa";
            this.textMesa.Size = new System.Drawing.Size(100, 20);
            this.textMesa.TabIndex = 1;
            // 
            // buscarMesaBTN
            // 
            this.buscarMesaBTN.BackColor = System.Drawing.Color.Green;
            this.buscarMesaBTN.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buscarMesaBTN.IconColor = System.Drawing.Color.White;
            this.buscarMesaBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscarMesaBTN.IconSize = 20;
            this.buscarMesaBTN.Location = new System.Drawing.Point(154, 22);
            this.buscarMesaBTN.Name = "buscarMesaBTN";
            this.buscarMesaBTN.Size = new System.Drawing.Size(22, 20);
            this.buscarMesaBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buscarMesaBTN.TabIndex = 2;
            this.buscarMesaBTN.TabStop = false;
            this.buscarMesaBTN.Click += new System.EventHandler(this.buscarMesaBTN_Click);
            // 
            // Mesa
            // 
            this.Mesa.FillWeight = 50F;
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            this.Mesa.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Efectivo
            // 
            this.Efectivo.HeaderText = "Efectivo";
            this.Efectivo.Name = "Efectivo";
            // 
            // Transferencia
            // 
            this.Transferencia.HeaderText = "Transferencia";
            this.Transferencia.Name = "Transferencia";
            // 
            // Tarjeta
            // 
            this.Tarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTarj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textTransf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textEfect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(206, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de forma de cobro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Efectivo:";
            // 
            // textEfect
            // 
            this.textEfect.Location = new System.Drawing.Point(58, 17);
            this.textEfect.Name = "textEfect";
            this.textEfect.Size = new System.Drawing.Size(100, 20);
            this.textEfect.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transf.:";
            // 
            // textTransf
            // 
            this.textTransf.Location = new System.Drawing.Point(216, 17);
            this.textTransf.Name = "textTransf";
            this.textTransf.Size = new System.Drawing.Size(100, 20);
            this.textTransf.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarjeta:";
            // 
            // textTarj
            // 
            this.textTarj.Location = new System.Drawing.Point(377, 17);
            this.textTarj.Name = "textTarj";
            this.textTarj.Size = new System.Drawing.Size(100, 20);
            this.textTarj.TabIndex = 5;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Venta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes de Ventas";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMesaBTN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textMesa;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox buscarMesaBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textTarj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTransf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEfect;
        private System.Windows.Forms.Label label2;
    }
}