namespace BAREST.Compras
{
    partial class ListaCompras
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
            this.dataListaCompras = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaCompras
            // 
            this.dataListaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.IdProveedor,
            this.idInsumo,
            this.cantidad,
            this.espec,
            this.fecha});
            this.dataListaCompras.Location = new System.Drawing.Point(12, 12);
            this.dataListaCompras.Name = "dataListaCompras";
            this.dataListaCompras.Size = new System.Drawing.Size(839, 437);
            this.dataListaCompras.TabIndex = 0;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "Nro Compra";
            this.idCompra.Name = "idCompra";
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "Proveedor";
            this.IdProveedor.Name = "IdProveedor";
            // 
            // idInsumo
            // 
            this.idInsumo.HeaderText = "Insumo";
            this.idInsumo.Name = "idInsumo";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // espec
            // 
            this.espec.HeaderText = "especificacion";
            this.espec.Name = "espec";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // ListaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.dataListaCompras);
            this.Name = "ListaCompras";
            this.Text = "ListaCompras";
            this.Load += new System.EventHandler(this.ListaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn espec;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}