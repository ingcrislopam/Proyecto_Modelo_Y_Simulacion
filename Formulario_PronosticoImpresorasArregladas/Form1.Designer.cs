namespace Formulario_PronosticoImpresorasArregladas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tNuevo = new System.Windows.Forms.ToolStripButton();
            this.tInsertar = new System.Windows.Forms.ToolStripButton();
            this.tBuscar = new System.Windows.Forms.ToolStripButton();
            this.tModificar = new System.Windows.Forms.ToolStripButton();
            this.tEliminar = new System.Windows.Forms.ToolStripButton();
            this.tCalcular = new System.Windows.Forms.ToolStripButton();
            this.tImprimir = new System.Windows.Forms.ToolStripButton();
            this.tExportar = new System.Windows.Forms.ToolStripButton();
            this.tSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEvaluar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.txtCobro = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCantidadYCobros = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chtGraficaCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chtGraficaCosto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCantidadYCobros)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficaCantidad)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficaCosto)).BeginInit();
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
            this.tCalcular,
            this.tImprimir,
            this.tExportar,
            this.tSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1293, 25);
            this.toolStrip1.TabIndex = 5;
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
            // tCalcular
            // 
            this.tCalcular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tCalcular.Image = ((System.Drawing.Image)(resources.GetObject("tCalcular.Image")));
            this.tCalcular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tCalcular.Name = "tCalcular";
            this.tCalcular.Size = new System.Drawing.Size(23, 22);
            this.tCalcular.Text = "Calcular";
            this.tCalcular.Click += new System.EventHandler(this.tCalcular_Click);
            // 
            // tImprimir
            // 
            this.tImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tImprimir.Image")));
            this.tImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tImprimir.Name = "tImprimir";
            this.tImprimir.Size = new System.Drawing.Size(23, 22);
            this.tImprimir.Text = "Imprimir";
            this.tImprimir.Click += new System.EventHandler(this.tImprimir_Click);
            // 
            // tExportar
            // 
            this.tExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tExportar.Image = ((System.Drawing.Image)(resources.GetObject("tExportar.Image")));
            this.tExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tExportar.Name = "tExportar";
            this.tExportar.Size = new System.Drawing.Size(23, 22);
            this.tExportar.Text = "Exportar";
            this.tExportar.Click += new System.EventHandler(this.tExportar_Click);
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
            this.groupBox1.Controls.Add(this.txtEvaluar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCantidadVenta);
            this.groupBox1.Controls.Add(this.txtCobro);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdentificador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // txtEvaluar
            // 
            this.txtEvaluar.Location = new System.Drawing.Point(186, 60);
            this.txtEvaluar.Name = "txtEvaluar";
            this.txtEvaluar.Size = new System.Drawing.Size(50, 20);
            this.txtEvaluar.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Evaluar:";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Enabled = false;
            this.txtCantidadVenta.Location = new System.Drawing.Point(421, 27);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(50, 20);
            this.txtCantidadVenta.TabIndex = 2;
            // 
            // txtCobro
            // 
            this.txtCobro.Enabled = false;
            this.txtCobro.Location = new System.Drawing.Point(79, 60);
            this.txtCobro.Name = "txtCobro";
            this.txtCobro.Size = new System.Drawing.Size(50, 20);
            this.txtCobro.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad o venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(79, 27);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(50, 20);
            this.txtIdentificador.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cobro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCantidadYCobros);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 346);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidades y cobros:";
            // 
            // dtgCantidadYCobros
            // 
            this.dtgCantidadYCobros.AllowUserToAddRows = false;
            this.dtgCantidadYCobros.AllowUserToDeleteRows = false;
            this.dtgCantidadYCobros.BackgroundColor = System.Drawing.Color.White;
            this.dtgCantidadYCobros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCantidadYCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCantidadYCobros.Location = new System.Drawing.Point(9, 19);
            this.dtgCantidadYCobros.Name = "dtgCantidadYCobros";
            this.dtgCantidadYCobros.ReadOnly = true;
            this.dtgCantidadYCobros.Size = new System.Drawing.Size(471, 321);
            this.dtgCantidadYCobros.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgResultado);
            this.groupBox3.Location = new System.Drawing.Point(504, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 368);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.AllowUserToDeleteRows = false;
            this.dtgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dtgResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(6, 19);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.ReadOnly = true;
            this.dtgResultado.Size = new System.Drawing.Size(765, 338);
            this.dtgResultado.TabIndex = 0;
            // 
            // printForm1
            // 
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chtGraficaCantidad);
            this.groupBox4.Location = new System.Drawing.Point(504, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 266);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gráfica cantidad de impresoras con pronóstico";
            // 
            // chtGraficaCantidad
            // 
            chartArea3.Name = "ChartArea1";
            this.chtGraficaCantidad.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtGraficaCantidad.Legends.Add(legend3);
            this.chtGraficaCantidad.Location = new System.Drawing.Point(6, 19);
            this.chtGraficaCantidad.Name = "chtGraficaCantidad";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "cantidad";
            this.chtGraficaCantidad.Series.Add(series3);
            this.chtGraficaCantidad.Size = new System.Drawing.Size(369, 241);
            this.chtGraficaCantidad.TabIndex = 0;
            this.chtGraficaCantidad.Text = "chart1";
            this.chtGraficaCantidad.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chtGraficaCosto);
            this.groupBox5.Location = new System.Drawing.Point(891, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 266);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gráfica costo de impresoras con pronóstico";
            // 
            // chtGraficaCosto
            // 
            chartArea4.Name = "ChartArea1";
            this.chtGraficaCosto.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtGraficaCosto.Legends.Add(legend4);
            this.chtGraficaCosto.Location = new System.Drawing.Point(6, 19);
            this.chtGraficaCosto.Name = "chtGraficaCosto";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "costo";
            this.chtGraficaCosto.Series.Add(series4);
            this.chtGraficaCosto.Size = new System.Drawing.Size(369, 241);
            this.chtGraficaCosto.TabIndex = 11;
            this.chtGraficaCosto.Text = "chart2";
            this.chtGraficaCosto.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1077, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Autor: Cristhian Adrián López Mora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 680);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pronostico impresoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCantidadYCobros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficaCantidad)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficaCosto)).EndInit();
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
        private System.Windows.Forms.ToolStripButton tCalcular;
        private System.Windows.Forms.ToolStripButton tImprimir;
        private System.Windows.Forms.ToolStripButton tExportar;
        private System.Windows.Forms.ToolStripButton tSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgCantidadYCobros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIdentificador;
        public System.Windows.Forms.TextBox txtCobro;
        public System.Windows.Forms.TextBox txtCantidadVenta;
        public System.Windows.Forms.TextBox txtEvaluar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficaCosto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficaCantidad;
        private System.Windows.Forms.Label label8;
    }
}

