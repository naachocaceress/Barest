
namespace BAREST
{
    partial class Caja
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
            this.upReservas = new System.Windows.Forms.Panel();
            this.cajaTitulo = new System.Windows.Forms.Label();
            this.upReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // upReservas
            // 
            this.upReservas.Controls.Add(this.cajaTitulo);
            this.upReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.upReservas.Location = new System.Drawing.Point(0, 0);
            this.upReservas.Name = "upReservas";
            this.upReservas.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.upReservas.Size = new System.Drawing.Size(947, 26);
            this.upReservas.TabIndex = 7;
            // 
            // cajaTitulo
            // 
            this.cajaTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cajaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaTitulo.Location = new System.Drawing.Point(0, 0);
            this.cajaTitulo.Name = "cajaTitulo";
            this.cajaTitulo.Size = new System.Drawing.Size(942, 26);
            this.cajaTitulo.TabIndex = 6;
            this.cajaTitulo.Text = "Caja";
            this.cajaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cajaTitulo.Click += new System.EventHandler(this.cajaTitulo_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 601);
            this.Controls.Add(this.upReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.upReservas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upReservas;
        private System.Windows.Forms.Label cajaTitulo;
    }
}