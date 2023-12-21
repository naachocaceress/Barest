
namespace BAREST.Compras
{
    partial class Compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataCompras = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlista = new FontAwesome.Sharp.IconButton();
            this.Confirmar = new FontAwesome.Sharp.IconButton();
            this.Cancelar = new FontAwesome.Sharp.IconButton();
            this.Imprimir = new FontAwesome.Sharp.IconButton();
            this.comboInsumo = new System.Windows.Forms.ComboBox();
            this.comboProv = new System.Windows.Forms.ComboBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEspecificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insumo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataCompras);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // dataCompras
            // 
            this.dataCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.idProveedor,
            this.idInsumo,
            this.cantidad,
            this.espec,
            this.fecha});
            this.dataCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCompras.Location = new System.Drawing.Point(3, 18);
            this.dataCompras.Name = "dataCompras";
            this.dataCompras.Size = new System.Drawing.Size(895, 213);
            this.dataCompras.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.Imprimir);
            this.panel1.Controls.Add(this.btnlista);
            this.panel1.Controls.Add(this.Confirmar);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 50);
            this.panel1.TabIndex = 49;
            // 
            // btnlista
            // 
            this.btnlista.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnlista.FlatAppearance.BorderSize = 0;
            this.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnlista.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnlista.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnlista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlista.IconSize = 30;
            this.btnlista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlista.Location = new System.Drawing.Point(0, 0);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(84, 50);
            this.btnlista.TabIndex = 9;
            this.btnlista.Text = "       Lista";
            this.btnlista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Confirmar.FlatAppearance.BorderSize = 0;
            this.Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Confirmar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Confirmar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Confirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Confirmar.IconSize = 30;
            this.Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmar.Location = new System.Drawing.Point(715, 0);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(109, 50);
            this.Confirmar.TabIndex = 7;
            this.Confirmar.Text = "       Agregar";
            this.Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Cancelar.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.Cancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cancelar.IconSize = 30;
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.Location = new System.Drawing.Point(824, 0);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 50);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "       Eliminar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.Imprimir.FlatAppearance.BorderSize = 0;
            this.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Imprimir.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.Imprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Imprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Imprimir.IconSize = 30;
            this.Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir.Location = new System.Drawing.Point(84, 0);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(100, 50);
            this.Imprimir.TabIndex = 6;
            this.Imprimir.Text = "       Imprimir";
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // comboInsumo
            // 
            this.comboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInsumo.FormattingEnabled = true;
            this.comboInsumo.Location = new System.Drawing.Point(93, 53);
            this.comboInsumo.Name = "comboInsumo";
            this.comboInsumo.Size = new System.Drawing.Size(132, 24);
            this.comboInsumo.TabIndex = 52;
            // 
            // comboProv
            // 
            this.comboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProv.FormattingEnabled = true;
            this.comboProv.Location = new System.Drawing.Point(93, 14);
            this.comboProv.Name = "comboProv";
            this.comboProv.Size = new System.Drawing.Size(132, 21);
            this.comboProv.TabIndex = 53;
            // 
            // textCantidad
            // 
            this.textCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.Location = new System.Drawing.Point(93, 96);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(67, 22);
            this.textCantidad.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cantidad";
            // 
            // textEspecificacion
            // 
            this.textEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEspecificacion.Location = new System.Drawing.Point(402, 12);
            this.textEspecificacion.Multiline = true;
            this.textEspecificacion.Name = "textEspecificacion";
            this.textEspecificacion.Size = new System.Drawing.Size(257, 106);
            this.textEspecificacion.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Especificacion  :";
            // 
            // idCompra
            // 
            this.idCompra.FillWeight = 48.66751F;
            this.idCompra.HeaderText = "Nro";
            this.idCompra.Name = "idCompra";
            // 
            // idProveedor
            // 
            this.idProveedor.FillWeight = 97.33503F;
            this.idProveedor.HeaderText = "Proveedor";
            this.idProveedor.Name = "idProveedor";
            // 
            // idInsumo
            // 
            this.idInsumo.FillWeight = 97.33503F;
            this.idInsumo.HeaderText = "Insumo";
            this.idInsumo.Name = "idInsumo";
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 65.98985F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // espec
            // 
            this.espec.FillWeight = 146.0025F;
            this.espec.HeaderText = "Especificacion";
            this.espec.Name = "espec";
            // 
            // fecha
            // 
            this.fecha.FillWeight = 97.33503F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEspecificacion);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboProv);
            this.Controls.Add(this.comboInsumo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Compras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataCompras;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Imprimir;
        private FontAwesome.Sharp.IconButton Confirmar;
        private FontAwesome.Sharp.IconButton Cancelar;
        private System.Windows.Forms.ComboBox comboInsumo;
        private System.Windows.Forms.ComboBox comboProv;
        private FontAwesome.Sharp.IconButton btnlista;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEspecificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn espec;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}