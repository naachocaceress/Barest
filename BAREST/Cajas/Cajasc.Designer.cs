
namespace BAREST.Cajas
{
    partial class Cajasc
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
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Inicio                            3000");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Ajustes de caja", new System.Windows.Forms.TreeNode[] {
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Mas inicio                    2000");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Aporte de caja grande", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Retiro                            1000");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Ajustes de caja", new System.Windows.Forms.TreeNode[] {
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Farmacia                       2000");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Gastos varios", new System.Windows.Forms.TreeNode[] {
            treeNode55});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.decajachica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.decajagrande = new System.Windows.Forms.Button();
            this.ajustedecajaingreso = new System.Windows.Forms.Button();
            this.Ingreso = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gastosvarios = new System.Windows.Forms.Button();
            this.acajachica = new System.Windows.Forms.Button();
            this.ajustedecajaengreso = new System.Windows.Forms.Button();
            this.acajagrande = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnEstadisticas = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnAgregarRes = new FontAwesome.Sharp.IconButton();
            this.btnEliminarRes = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Ingreso.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.decajachica);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.decajagrande);
            this.panel3.Controls.Add(this.ajustedecajaingreso);
            this.panel3.Controls.Add(this.Ingreso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 400);
            this.panel3.TabIndex = 6;
            // 
            // decajachica
            // 
            this.decajachica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decajachica.Location = new System.Drawing.Point(216, 366);
            this.decajachica.Name = "decajachica";
            this.decajachica.Size = new System.Drawing.Size(155, 28);
            this.decajachica.TabIndex = 4;
            this.decajachica.Text = "Aporte de caja chica";
            this.decajachica.UseVisualStyleBackColor = true;
            this.decajachica.Click += new System.EventHandler(this.decajachica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo de caja";
            // 
            // decajagrande
            // 
            this.decajagrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decajagrande.Location = new System.Drawing.Point(29, 366);
            this.decajagrande.Name = "decajagrande";
            this.decajagrande.Size = new System.Drawing.Size(155, 28);
            this.decajagrande.TabIndex = 5;
            this.decajagrande.Text = "Aporte de caja grande";
            this.decajagrande.UseVisualStyleBackColor = true;
            this.decajagrande.Click += new System.EventHandler(this.decajagrande_Click);
            // 
            // ajustedecajaingreso
            // 
            this.ajustedecajaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajustedecajaingreso.Location = new System.Drawing.Point(123, 332);
            this.ajustedecajaingreso.Name = "ajustedecajaingreso";
            this.ajustedecajaingreso.Size = new System.Drawing.Size(155, 28);
            this.ajustedecajaingreso.TabIndex = 4;
            this.ajustedecajaingreso.Text = "Ajustes de caja";
            this.ajustedecajaingreso.UseVisualStyleBackColor = true;
            this.ajustedecajaingreso.Click += new System.EventHandler(this.ajustedecajaingreso_Click);
            // 
            // Ingreso
            // 
            this.Ingreso.Controls.Add(this.label2);
            this.Ingreso.Controls.Add(this.textBox3);
            this.Ingreso.Controls.Add(this.treeView2);
            this.Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingreso.Location = new System.Drawing.Point(3, 4);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Size = new System.Drawing.Size(392, 284);
            this.Ingreso.TabIndex = 3;
            this.Ingreso.TabStop = false;
            this.Ingreso.Text = "Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(285, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.Location = new System.Drawing.Point(6, 21);
            this.treeView2.Name = "treeView2";
            treeNode49.Name = "Nodo3";
            treeNode49.Text = "Inicio                            3000";
            treeNode50.Name = "Nodo0";
            treeNode50.Text = "Ajustes de caja";
            treeNode51.Name = "Farmacia";
            treeNode51.Text = "Mas inicio                    2000";
            treeNode52.Name = "Nodo1";
            treeNode52.Text = "Aporte de caja grande";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode52});
            this.treeView2.Size = new System.Drawing.Size(379, 257);
            this.treeView2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.gastosvarios);
            this.panel2.Controls.Add(this.acajachica);
            this.panel2.Controls.Add(this.ajustedecajaengreso);
            this.panel2.Controls.Add(this.acajagrande);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gastosvarios
            // 
            this.gastosvarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gastosvarios.Location = new System.Drawing.Point(26, 332);
            this.gastosvarios.Name = "gastosvarios";
            this.gastosvarios.Size = new System.Drawing.Size(155, 28);
            this.gastosvarios.TabIndex = 0;
            this.gastosvarios.Text = "Gastos varios";
            this.gastosvarios.UseVisualStyleBackColor = true;
            this.gastosvarios.Click += new System.EventHandler(this.gastosvarios_Click);
            // 
            // acajachica
            // 
            this.acajachica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acajachica.Location = new System.Drawing.Point(217, 366);
            this.acajachica.Name = "acajachica";
            this.acajachica.Size = new System.Drawing.Size(155, 28);
            this.acajachica.TabIndex = 3;
            this.acajachica.Text = "Retiros a caja chica";
            this.acajachica.UseVisualStyleBackColor = true;
            this.acajachica.Click += new System.EventHandler(this.acajachica_Click);
            // 
            // ajustedecajaengreso
            // 
            this.ajustedecajaengreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajustedecajaengreso.Location = new System.Drawing.Point(217, 332);
            this.ajustedecajaengreso.Name = "ajustedecajaengreso";
            this.ajustedecajaengreso.Size = new System.Drawing.Size(155, 28);
            this.ajustedecajaengreso.TabIndex = 1;
            this.ajustedecajaengreso.Text = "Ajustes de caja";
            this.ajustedecajaengreso.UseVisualStyleBackColor = true;
            this.ajustedecajaengreso.Click += new System.EventHandler(this.ajustedecajaengreso_Click);
            // 
            // acajagrande
            // 
            this.acajagrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acajagrande.Location = new System.Drawing.Point(26, 366);
            this.acajagrande.Name = "acajagrande";
            this.acajagrande.Size = new System.Drawing.Size(155, 28);
            this.acajagrande.TabIndex = 2;
            this.acajagrande.Text = "Retiros a caja grande";
            this.acajagrande.UseVisualStyleBackColor = true;
            this.acajagrande.Click += new System.EventHandler(this.acajagrande_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(285, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(6, 21);
            this.treeView1.Name = "treeView1";
            treeNode53.Name = "Nodo3";
            treeNode53.Text = "Retiro                            1000";
            treeNode54.Name = "Nodo0";
            treeNode54.Text = "Ajustes de caja";
            treeNode55.Name = "Farmacia";
            treeNode55.Text = "Farmacia                       2000";
            treeNode56.Name = "Nodo1";
            treeNode56.Text = "Gastos varios";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode56});
            this.treeView1.Size = new System.Drawing.Size(379, 257);
            this.treeView1.TabIndex = 2;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEstadisticas.IconChar = FontAwesome.Sharp.IconChar.PieChart;
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
            // 
            // btnAgregarRes
            // 
            this.btnAgregarRes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarRes.FlatAppearance.BorderSize = 0;
            this.btnAgregarRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAgregarRes.IconChar = FontAwesome.Sharp.IconChar.Vault;
            this.btnAgregarRes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnAgregarRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarRes.IconSize = 30;
            this.btnAgregarRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRes.Location = new System.Drawing.Point(546, 0);
            this.btnAgregarRes.Name = "btnAgregarRes";
            this.btnAgregarRes.Size = new System.Drawing.Size(129, 50);
            this.btnAgregarRes.TabIndex = 2;
            this.btnAgregarRes.Text = "        Caja Grande";
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
            this.btnEliminarRes.IconChar = FontAwesome.Sharp.IconChar.Vault;
            this.btnEliminarRes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnEliminarRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarRes.IconSize = 30;
            this.btnEliminarRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRes.Location = new System.Drawing.Point(675, 0);
            this.btnEliminarRes.Name = "btnEliminarRes";
            this.btnEliminarRes.Size = new System.Drawing.Size(125, 50);
            this.btnEliminarRes.TabIndex = 7;
            this.btnEliminarRes.Text = "        Caja Chica";
            this.btnEliminarRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRes.UseVisualStyleBackColor = true;
            this.btnEliminarRes.Click += new System.EventHandler(this.btnEliminarRes_Click);
            // 
            // Cajasc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cajasc";
            this.ShowIcon = false;
            this.Text = "Caja socios";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Ingreso.ResumeLayout(false);
            this.Ingreso.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEstadisticas;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnAgregarRes;
        private FontAwesome.Sharp.IconButton btnEliminarRes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button decajachica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decajagrande;
        private System.Windows.Forms.Button ajustedecajaingreso;
        private System.Windows.Forms.GroupBox Ingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gastosvarios;
        private System.Windows.Forms.Button acajachica;
        private System.Windows.Forms.Button ajustedecajaengreso;
        private System.Windows.Forms.Button acajagrande;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView treeView1;
    }
}