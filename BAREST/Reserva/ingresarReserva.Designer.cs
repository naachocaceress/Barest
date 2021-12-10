
namespace BAREST
{
    partial class ingresarReserva
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textHora = new System.Windows.Forms.TextBox();
            this.textPosicion = new System.Windows.Forms.TextBox();
            this.textcant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textcom = new System.Windows.Forms.TextBox();
            this.confirmar = new FontAwesome.Sharp.IconButton();
            this.EliminarInsu = new FontAwesome.Sharp.IconButton();
            this.notificacion = new System.Windows.Forms.Panel();
            this.cerrarLbl = new System.Windows.Forms.Label();
            this.notiLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.notificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.confirmar);
            this.panel1.Controls.Add(this.EliminarInsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 50);
            this.panel1.TabIndex = 47;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(15, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(146, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(15, 139);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(146, 20);
            this.textTelefono.TabIndex = 3;
            // 
            // textHora
            // 
            this.textHora.Location = new System.Drawing.Point(198, 139);
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(63, 20);
            this.textHora.TabIndex = 7;
            // 
            // textPosicion
            // 
            this.textPosicion.Location = new System.Drawing.Point(284, 25);
            this.textPosicion.Name = "textPosicion";
            this.textPosicion.Size = new System.Drawing.Size(72, 20);
            this.textPosicion.TabIndex = 5;
            this.textPosicion.TextChanged += new System.EventHandler(this.textPosicion_TextChanged);
            // 
            // textcant
            // 
            this.textcant.Location = new System.Drawing.Point(198, 25);
            this.textcant.Name = "textcant";
            this.textcant.Size = new System.Drawing.Size(55, 20);
            this.textcant.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "PAX:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Mesa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Apellido:";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(15, 81);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(146, 20);
            this.textApellido.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Comentarios:";
            // 
            // textcom
            // 
            this.textcom.Location = new System.Drawing.Point(15, 194);
            this.textcom.Multiline = true;
            this.textcom.Name = "textcom";
            this.textcom.Size = new System.Drawing.Size(381, 53);
            this.textcom.TabIndex = 8;
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
            this.confirmar.Location = new System.Drawing.Point(198, 0);
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
            this.EliminarInsu.Location = new System.Drawing.Point(307, 0);
            this.EliminarInsu.Name = "EliminarInsu";
            this.EliminarInsu.Size = new System.Drawing.Size(100, 50);
            this.EliminarInsu.TabIndex = 10;
            this.EliminarInsu.Text = "       Cancelar";
            this.EliminarInsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarInsu.UseVisualStyleBackColor = true;
            this.EliminarInsu.Click += new System.EventHandler(this.EliminarInsu_Click);
            // 
            // notificacion
            // 
            this.notificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(105)))));
            this.notificacion.Controls.Add(this.notiLbl);
            this.notificacion.Controls.Add(this.cerrarLbl);
            this.notificacion.Location = new System.Drawing.Point(28, 232);
            this.notificacion.Name = "notificacion";
            this.notificacion.Size = new System.Drawing.Size(354, 29);
            this.notificacion.TabIndex = 63;
            // 
            // cerrarLbl
            // 
            this.cerrarLbl.AutoSize = true;
            this.cerrarLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.cerrarLbl.Location = new System.Drawing.Point(5, 5);
            this.cerrarLbl.Name = "cerrarLbl";
            this.cerrarLbl.Size = new System.Drawing.Size(15, 16);
            this.cerrarLbl.TabIndex = 0;
            this.cerrarLbl.Text = "x";
            this.cerrarLbl.Click += new System.EventHandler(this.cerrarLbl_Click);
            // 
            // notiLbl
            // 
            this.notiLbl.AutoSize = true;
            this.notiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notiLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.notiLbl.Location = new System.Drawing.Point(26, 6);
            this.notiLbl.Name = "notiLbl";
            this.notiLbl.Size = new System.Drawing.Size(151, 15);
            this.notiLbl.TabIndex = 1;
            this.notiLbl.Text = "Ya hay reservas en \'sector\'";
            // 
            // ingresarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 305);
            this.Controls.Add(this.notificacion);
            this.Controls.Add(this.textcom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textcant);
            this.Controls.Add(this.textPosicion);
            this.Controls.Add(this.textHora);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ingresarReserva";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva reserva";
            this.Load += new System.EventHandler(this.ingresarReserva_Load);
            this.panel1.ResumeLayout(false);
            this.notificacion.ResumeLayout(false);
            this.notificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton confirmar;
        private FontAwesome.Sharp.IconButton EliminarInsu;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textHora;
        private System.Windows.Forms.TextBox textPosicion;
        private System.Windows.Forms.TextBox textcant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textcom;
        private System.Windows.Forms.Panel notificacion;
        private System.Windows.Forms.Label notiLbl;
        private System.Windows.Forms.Label cerrarLbl;
    }
}