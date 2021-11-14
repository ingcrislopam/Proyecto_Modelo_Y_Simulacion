namespace Formulario_Regresion_Lineal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chtGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRecta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtSegundaEcuacion = new System.Windows.Forms.TextBox();
            this.txtPrimeraEcuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafica)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(953, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.txtIdentificador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Identificador:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(92, 90);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(136, 20);
            this.txtY.TabIndex = 8;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(92, 64);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(136, 20);
            this.txtX.TabIndex = 7;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(171, 38);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(57, 20);
            this.txtIdentificador.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgResultado);
            this.groupBox2.Location = new System.Drawing.Point(258, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 297);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado:";
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
            this.dtgResultado.Size = new System.Drawing.Size(671, 272);
            this.dtgResultado.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chtGrafica);
            this.groupBox3.Location = new System.Drawing.Point(258, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 240);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfica:";
            // 
            // chtGrafica
            // 
            chartArea2.Name = "ChartArea1";
            this.chtGrafica.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtGrafica.Legends.Add(legend2);
            this.chtGrafica.Location = new System.Drawing.Point(6, 19);
            this.chtGrafica.Name = "chtGrafica";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "y";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "recta";
            this.chtGrafica.Series.Add(series3);
            this.chtGrafica.Series.Add(series4);
            this.chtGrafica.Size = new System.Drawing.Size(671, 215);
            this.chtGrafica.TabIndex = 0;
            this.chtGrafica.Text = "chart1";
            this.chtGrafica.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRecta);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtA2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtA1);
            this.groupBox4.Controls.Add(this.txtSegundaEcuacion);
            this.groupBox4.Controls.Add(this.txtPrimeraEcuacion);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 240);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ecuación generada:";
            // 
            // txtRecta
            // 
            this.txtRecta.Enabled = false;
            this.txtRecta.Location = new System.Drawing.Point(123, 144);
            this.txtRecta.Name = "txtRecta";
            this.txtRecta.Size = new System.Drawing.Size(105, 20);
            this.txtRecta.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ecuación encontrada:";
            // 
            // txtA2
            // 
            this.txtA2.Enabled = false;
            this.txtA2.Location = new System.Drawing.Point(171, 116);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(57, 20);
            this.txtA2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "A1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "1 ecuación:";
            // 
            // txtA1
            // 
            this.txtA1.Enabled = false;
            this.txtA1.Location = new System.Drawing.Point(171, 90);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(57, 20);
            this.txtA1.TabIndex = 8;
            // 
            // txtSegundaEcuacion
            // 
            this.txtSegundaEcuacion.Enabled = false;
            this.txtSegundaEcuacion.Location = new System.Drawing.Point(75, 64);
            this.txtSegundaEcuacion.Name = "txtSegundaEcuacion";
            this.txtSegundaEcuacion.Size = new System.Drawing.Size(153, 20);
            this.txtSegundaEcuacion.TabIndex = 7;
            // 
            // txtPrimeraEcuacion
            // 
            this.txtPrimeraEcuacion.Enabled = false;
            this.txtPrimeraEcuacion.Location = new System.Drawing.Point(75, 38);
            this.txtPrimeraEcuacion.Name = "txtPrimeraEcuacion";
            this.txtPrimeraEcuacion.Size = new System.Drawing.Size(153, 20);
            this.txtPrimeraEcuacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "A0:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "2 ecuación:";
            // 
            // printForm1
            // 
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(737, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Autor: Cristhian Adrián López Mora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 583);
            this.Controls.Add(this.label9);
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
            this.Text = "Regresión Lineal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafica)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtY;
        public System.Windows.Forms.TextBox txtX;
        public System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafica;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtA1;
        public System.Windows.Forms.TextBox txtSegundaEcuacion;
        public System.Windows.Forms.TextBox txtPrimeraEcuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtA2;
        public System.Windows.Forms.TextBox txtRecta;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Label label9;
    }
}

