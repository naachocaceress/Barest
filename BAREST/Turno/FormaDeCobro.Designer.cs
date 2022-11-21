
namespace BAREST.Turno
{
    partial class FormaDeCobro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textEfectivo = new System.Windows.Forms.TextBox();
            this.textTransf = new System.Windows.Forms.TextBox();
            this.textTarjeta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textResumen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarMenulista = new FontAwesome.Sharp.IconButton();
            this.EliminarInsu = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.agregarMenulista);
            this.panel1.Controls.Add(this.EliminarInsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 50);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Efectivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transferencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarjeta:";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(52, 8);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 10;
            // 
            // textEfectivo
            // 
            this.textEfectivo.Location = new System.Drawing.Point(84, 20);
            this.textEfectivo.Name = "textEfectivo";
            this.textEfectivo.Size = new System.Drawing.Size(100, 20);
            this.textEfectivo.TabIndex = 11;
            this.textEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEfectivo_KeyPress);
            // 
            // textTransf
            // 
            this.textTransf.Location = new System.Drawing.Point(84, 54);
            this.textTransf.Name = "textTransf";
            this.textTransf.Size = new System.Drawing.Size(100, 20);
            this.textTransf.TabIndex = 12;
            this.textTransf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTransf_KeyPress);
            // 
            // textTarjeta
            // 
            this.textTarjeta.Location = new System.Drawing.Point(84, 89);
            this.textTarjeta.Name = "textTarjeta";
            this.textTarjeta.Size = new System.Drawing.Size(100, 20);
            this.textTarjeta.TabIndex = 13;
            this.textTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTarjeta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resumen:";
            // 
            // textResumen
            // 
            this.textResumen.Location = new System.Drawing.Point(110, 188);
            this.textResumen.Name = "textResumen";
            this.textResumen.Size = new System.Drawing.Size(100, 20);
            this.textResumen.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEfectivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textTransf);
            this.groupBox1.Controls.Add(this.textTarjeta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medios de cobro";
            // 
            // agregarMenulista
            // 
            this.agregarMenulista.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregarMenulista.FlatAppearance.BorderSize = 0;
            this.agregarMenulista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarMenulista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarMenulista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarMenulista.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.agregarMenulista.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.agregarMenulista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarMenulista.IconSize = 30;
            this.agregarMenulista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarMenulista.Location = new System.Drawing.Point(23, 0);
            this.agregarMenulista.Name = "agregarMenulista";
            this.agregarMenulista.Size = new System.Drawing.Size(100, 50);
            this.agregarMenulista.TabIndex = 11;
            this.agregarMenulista.Text = "       Cobrar";
            this.agregarMenulista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarMenulista.UseVisualStyleBackColor = true;
            this.agregarMenulista.Click += new System.EventHandler(this.agregarMenulista_Click);
            // 
            // EliminarInsu
            // 
            this.EliminarInsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.EliminarInsu.FlatAppearance.BorderSize = 0;
            this.EliminarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarInsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.EliminarInsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.EliminarInsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarInsu.IconSize = 30;
            this.EliminarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.Location = new System.Drawing.Point(123, 0);
            this.EliminarInsu.Name = "EliminarInsu";
            this.EliminarInsu.Size = new System.Drawing.Size(100, 50);
            this.EliminarInsu.TabIndex = 12;
            this.EliminarInsu.Text = "       Cancelar";
            this.EliminarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.UseVisualStyleBackColor = true;
            this.EliminarInsu.Click += new System.EventHandler(this.EliminarInsu_Click);
            // 
            // FormaDeCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textResumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaDeCobro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de cobro";
            this.Load += new System.EventHandler(this.FormaDeCobro_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton agregarMenulista;
        private FontAwesome.Sharp.IconButton EliminarInsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textEfectivo;
        private System.Windows.Forms.TextBox textTransf;
        private System.Windows.Forms.TextBox textTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textResumen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}