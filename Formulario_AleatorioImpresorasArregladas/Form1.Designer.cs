namespace Formulario_AleatorioImpresorasArregladas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tNuevo = new System.Windows.Forms.ToolStripButton();
            this.tInsertar = new System.Windows.Forms.ToolStripButton();
            this.tBuscar = new System.Windows.Forms.ToolStripButton();
            this.tModificar = new System.Windows.Forms.ToolStripButton();
            this.tEliminar = new System.Windows.Forms.ToolStripButton();
            this.tSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAleatorioCobro = new System.Windows.Forms.TextBox();
            this.txtAleatorioCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tNuevo,
            this.tInsertar,
            this.tBuscar,
            this.tModificar,
            this.tEliminar,
            this.tSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // tNuevo
            // 
            this.tNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tNuevo.Image")));
            this.tNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tNuevo.Name = "tNuevo";
            this.tNuevo.Size = new System.Drawing.Size(23, 22);
            this.tNuevo.Text = "Nuevo";
            this.tNuevo.Click += new System.EventHandler(this.tNuevo_Click);
            // 
            // tInsertar
            // 
            this.tInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tInsertar.Image = ((System.Drawing.Image)(resources.GetObject("tInsertar.Image")));
            this.tInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tInsertar.Name = "tInsertar";
            this.tInsertar.Size = new System.Drawing.Size(23, 22);
            this.tInsertar.Text = "Insertar";
            this.tInsertar.Click += new System.EventHandler(this.tInsertar_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tBuscar.Image")));
            this.tBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(23, 22);
            this.tBuscar.Text = "Buscar";
            this.tBuscar.Click += new System.EventHandler(this.tBuscar_Click);
            // 
            // tModificar
            // 
            this.tModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tModificar.Image = ((System.Drawing.Image)(resources.GetObject("tModificar.Image")));
            this.tModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tModificar.Name = "tModificar";
            this.tModificar.Size = new System.Drawing.Size(23, 22);
            this.tModificar.Text = "Modificar";
            this.tModificar.Click += new System.EventHandler(this.tModificar_Click);
            // 
            // tEliminar
            // 
            this.tEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tEliminar.Image")));
            this.tEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tEliminar.Name = "tEliminar";
            this.tEliminar.Size = new System.Drawing.Size(23, 22);
            this.tEliminar.Text = "Eliminar";
            this.tEliminar.Click += new System.EventHandler(this.tEliminar_Click);
            // 
            // tSalir
            // 
            this.tSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSalir.Image = ((System.Drawing.Image)(resources.GetObject("tSalir.Image")));
            this.tSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSalir.Name = "tSalir";
            this.tSalir.Size = new System.Drawing.Size(23, 22);
            this.tSalir.Text = "Salir";
            this.tSalir.Click += new System.EventHandler(this.tSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAleatorioCobro);
            this.groupBox1.Controls.Add(this.txtAleatorioCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdentificador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(420, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 120);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(6, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 120);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(420, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 120);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(6, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 120);
            this.panel1.TabIndex = 18;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(200, 19);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(126, 20);
            this.txtMes.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Mes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Costo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad:";
            // 
            // txtAleatorioCobro
            // 
            this.txtAleatorioCobro.Location = new System.Drawing.Point(290, 280);
            this.txtAleatorioCobro.Name = "txtAleatorioCobro";
            this.txtAleatorioCobro.Size = new System.Drawing.Size(52, 20);
            this.txtAleatorioCobro.TabIndex = 7;
            // 
            // txtAleatorioCantidad
            // 
            this.txtAleatorioCantidad.Location = new System.Drawing.Point(290, 124);
            this.txtAleatorioCantidad.Name = "txtAleatorioCantidad";
            this.txtAleatorioCantidad.Size = new System.Drawing.Size(52, 20);
            this.txtAleatorioCantidad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cobro por arreglo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de impresoras";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(91, 19);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(52, 20);
            this.txtIdentificador.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Autor: Cristhian Adrián López Mora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresoras arregladas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tNuevo;
        private System.Windows.Forms.ToolStripButton tInsertar;
        private System.Windows.Forms.ToolStripButton tBuscar;
        private System.Windows.Forms.ToolStripButton tModificar;
        private System.Windows.Forms.ToolStripButton tEliminar;
        private System.Windows.Forms.ToolStripButton tSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtIdentificador;
        public System.Windows.Forms.TextBox txtAleatorioCobro;
        public System.Windows.Forms.TextBox txtAleatorioCantidad;
        public System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

