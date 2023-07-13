
namespace BAREST.Cajas
{
    partial class IngresarMonto
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
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmar = new FontAwesome.Sharp.IconButton();
            this.EliminarInsu = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igresar gastos varios";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(97, 52);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(170, 22);
            this.txtConcepto.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.confirmar);
            this.panel1.Controls.Add(this.EliminarInsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 50);
            this.panel1.TabIndex = 48;
            // 
            // confirmar
            // 
            this.confirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.confirmar.FlatAppearance.BorderSize = 0;
            this.confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.confirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.confirmar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.confirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmar.IconSize = 30;
            this.confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmar.Location = new System.Drawing.Point(108, 0);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(109, 50);
            this.confirmar.TabIndex = 9;
            this.confirmar.Text = "       Confirmar";
            this.confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
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
            this.EliminarInsu.Location = new System.Drawing.Point(217, 0);
            this.EliminarInsu.Name = "EliminarInsu";
            this.EliminarInsu.Size = new System.Drawing.Size(100, 50);
            this.EliminarInsu.TabIndex = 10;
            this.EliminarInsu.Text = "       Cancelar";
            this.EliminarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.UseVisualStyleBackColor = true;
            this.EliminarInsu.Click += new System.EventHandler(this.EliminarInsu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(97, 91);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(170, 22);
            this.txtMonto.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Concepto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 140);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja chica";
            // 
            // IngresarMonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 214);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IngresarMonto";
            this.ShowIcon = false;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.IngresarMonto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton confirmar;
        private FontAwesome.Sharp.IconButton EliminarInsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}