namespace Formulario_Politica_De_Inventario
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
            this.tCalcular = new System.Windows.Forms.ToolStripButton();
            this.tImprimir = new System.Windows.Forms.ToolStripButton();
            this.tExportar = new System.Windows.Forms.ToolStripButton();
            this.tSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProbabilidadD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDemandaD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDistribucion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProbabilidadT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDemandaT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTiempoDeEntrega = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgDistribucion = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgTiempoDeEntrega = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtInventarioInicial = new System.Windows.Forms.TextBox();
            this.txtCostoDeMantenimiento = new System.Windows.Forms.TextBox();
            this.txtCostoPorFaltantes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCostoDeOrdenar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPuntoDeReorden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadOrdenar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAleatoriosT = new System.Windows.Forms.TextBox();
            this.cbbATiempoDeEntrega = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAleatoriosD = new System.Windows.Forms.TextBox();
            this.cbbADistribucion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDistribucion)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoDeEntrega)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.groupBox8.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1261, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.groupBox1.Controls.Add(this.txtProbabilidadD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDemandaD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbDistribucion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribución:";
            // 
            // txtProbabilidadD
            // 
            this.txtProbabilidadD.Enabled = false;
            this.txtProbabilidadD.Location = new System.Drawing.Point(472, 28);
            this.txtProbabilidadD.Name = "txtProbabilidadD";
            this.txtProbabilidadD.Size = new System.Drawing.Size(131, 20);
            this.txtProbabilidadD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probabilidad:";
            // 
            // txtDemandaD
            // 
            this.txtDemandaD.Enabled = false;
            this.txtDemandaD.Location = new System.Drawing.Point(262, 28);
            this.txtDemandaD.Name = "txtDemandaD";
            this.txtDemandaD.Size = new System.Drawing.Size(131, 20);
            this.txtDemandaD.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Demanda:";
            // 
            // cbbDistribucion
            // 
            this.cbbDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDistribucion.FormattingEnabled = true;
            this.cbbDistribucion.Location = new System.Drawing.Point(75, 27);
            this.cbbDistribucion.Name = "cbbDistribucion";
            this.cbbDistribucion.Size = new System.Drawing.Size(121, 21);
            this.cbbDistribucion.TabIndex = 1;
            this.cbbDistribucion.SelectionChangeCommitted += new System.EventHandler(this.cbbDistribucion_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribucion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProbabilidadT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDemandaT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbTiempoDeEntrega);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(632, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 62);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo de entrega:";
            // 
            // txtProbabilidadT
            // 
            this.txtProbabilidadT.Enabled = false;
            this.txtProbabilidadT.Location = new System.Drawing.Point(472, 28);
            this.txtProbabilidadT.Name = "txtProbabilidadT";
            this.txtProbabilidadT.Size = new System.Drawing.Size(131, 20);
            this.txtProbabilidadT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Probabilidad:";
            // 
            // txtDemandaT
            // 
            this.txtDemandaT.Enabled = false;
            this.txtDemandaT.Location = new System.Drawing.Point(262, 28);
            this.txtDemandaT.Name = "txtDemandaT";
            this.txtDemandaT.Size = new System.Drawing.Size(131, 20);
            this.txtDemandaT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Demanda:";
            // 
            // cbbTiempoDeEntrega
            // 
            this.cbbTiempoDeEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTiempoDeEntrega.FormattingEnabled = true;
            this.cbbTiempoDeEntrega.Location = new System.Drawing.Point(75, 27);
            this.cbbTiempoDeEntrega.Name = "cbbTiempoDeEntrega";
            this.cbbTiempoDeEntrega.Size = new System.Drawing.Size(121, 21);
            this.cbbTiempoDeEntrega.TabIndex = 1;
            this.cbbTiempoDeEntrega.SelectionChangeCommitted += new System.EventHandler(this.cbbTiempoDeEntrega_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Distribucion:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgDistribucion);
            this.groupBox3.Location = new System.Drawing.Point(12, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 191);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado distribución:";
            // 
            // dtgDistribucion
            // 
            this.dtgDistribucion.AllowUserToAddRows = false;
            this.dtgDistribucion.AllowUserToDeleteRows = false;
            this.dtgDistribucion.BackgroundColor = System.Drawing.Color.White;
            this.dtgDistribucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDistribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDistribucion.Location = new System.Drawing.Point(6, 19);
            this.dtgDistribucion.Name = "dtgDistribucion";
            this.dtgDistribucion.ReadOnly = true;
            this.dtgDistribucion.Size = new System.Drawing.Size(602, 166);
            this.dtgDistribucion.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgTiempoDeEntrega);
            this.groupBox4.Location = new System.Drawing.Point(632, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(617, 191);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado tiempo de entrega:";
            // 
            // dtgTiempoDeEntrega
            // 
            this.dtgTiempoDeEntrega.AllowUserToAddRows = false;
            this.dtgTiempoDeEntrega.AllowUserToDeleteRows = false;
            this.dtgTiempoDeEntrega.BackgroundColor = System.Drawing.Color.White;
            this.dtgTiempoDeEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTiempoDeEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTiempoDeEntrega.Location = new System.Drawing.Point(6, 19);
            this.dtgTiempoDeEntrega.Name = "dtgTiempoDeEntrega";
            this.dtgTiempoDeEntrega.ReadOnly = true;
            this.dtgTiempoDeEntrega.Size = new System.Drawing.Size(602, 166);
            this.dtgTiempoDeEntrega.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtInventarioInicial);
            this.groupBox5.Controls.Add(this.txtCostoDeMantenimiento);
            this.groupBox5.Controls.Add(this.txtCostoPorFaltantes);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtCostoDeOrdenar);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtPuntoDeReorden);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtCantidadOrdenar);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(614, 83);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos:";
            // 
            // txtInventarioInicial
            // 
            this.txtInventarioInicial.Location = new System.Drawing.Point(394, 51);
            this.txtInventarioInicial.Name = "txtInventarioInicial";
            this.txtInventarioInicial.Size = new System.Drawing.Size(40, 20);
            this.txtInventarioInicial.TabIndex = 11;
            // 
            // txtCostoDeMantenimiento
            // 
            this.txtCostoDeMantenimiento.Location = new System.Drawing.Point(568, 25);
            this.txtCostoDeMantenimiento.Name = "txtCostoDeMantenimiento";
            this.txtCostoDeMantenimiento.Size = new System.Drawing.Size(40, 20);
            this.txtCostoDeMantenimiento.TabIndex = 7;
            // 
            // txtCostoPorFaltantes
            // 
            this.txtCostoPorFaltantes.Location = new System.Drawing.Point(394, 25);
            this.txtCostoPorFaltantes.Name = "txtCostoPorFaltantes";
            this.txtCostoPorFaltantes.Size = new System.Drawing.Size(40, 20);
            this.txtCostoPorFaltantes.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Inventario inicial:";
            // 
            // txtCostoDeOrdenar
            // 
            this.txtCostoDeOrdenar.Location = new System.Drawing.Point(245, 51);
            this.txtCostoDeOrdenar.Name = "txtCostoDeOrdenar";
            this.txtCostoDeOrdenar.Size = new System.Drawing.Size(40, 20);
            this.txtCostoDeOrdenar.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Costo de ordenar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Costo de mantenimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Costo por faltantes:";
            // 
            // txtPuntoDeReorden
            // 
            this.txtPuntoDeReorden.Location = new System.Drawing.Point(245, 25);
            this.txtPuntoDeReorden.Name = "txtPuntoDeReorden";
            this.txtPuntoDeReorden.Size = new System.Drawing.Size(40, 20);
            this.txtPuntoDeReorden.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Punto de reorden:";
            // 
            // txtCantidadOrdenar
            // 
            this.txtCantidadOrdenar.Location = new System.Drawing.Point(102, 25);
            this.txtCantidadOrdenar.Name = "txtCantidadOrdenar";
            this.txtCantidadOrdenar.Size = new System.Drawing.Size(40, 20);
            this.txtCantidadOrdenar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cantidad ordenar:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAleatoriosT);
            this.groupBox6.Controls.Add(this.cbbATiempoDeEntrega);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txtAleatoriosD);
            this.groupBox6.Controls.Add(this.cbbADistribucion);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(632, 351);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(617, 83);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Aleatorios:";
            // 
            // txtAleatoriosT
            // 
            this.txtAleatoriosT.Enabled = false;
            this.txtAleatoriosT.Location = new System.Drawing.Point(234, 56);
            this.txtAleatoriosT.Name = "txtAleatoriosT";
            this.txtAleatoriosT.Size = new System.Drawing.Size(374, 20);
            this.txtAleatoriosT.TabIndex = 5;
            // 
            // cbbATiempoDeEntrega
            // 
            this.cbbATiempoDeEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbATiempoDeEntrega.FormattingEnabled = true;
            this.cbbATiempoDeEntrega.Location = new System.Drawing.Point(107, 55);
            this.cbbATiempoDeEntrega.Name = "cbbATiempoDeEntrega";
            this.cbbATiempoDeEntrega.Size = new System.Drawing.Size(121, 21);
            this.cbbATiempoDeEntrega.TabIndex = 4;
            this.cbbATiempoDeEntrega.SelectionChangeCommitted += new System.EventHandler(this.cbbATiempoDeEntrega_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Tiempo de entrega:";
            // 
            // txtAleatoriosD
            // 
            this.txtAleatoriosD.Enabled = false;
            this.txtAleatoriosD.Location = new System.Drawing.Point(234, 26);
            this.txtAleatoriosD.Name = "txtAleatoriosD";
            this.txtAleatoriosD.Size = new System.Drawing.Size(374, 20);
            this.txtAleatoriosD.TabIndex = 2;
            // 
            // cbbADistribucion
            // 
            this.cbbADistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbADistribucion.FormattingEnabled = true;
            this.cbbADistribucion.Location = new System.Drawing.Point(107, 25);
            this.cbbADistribucion.Name = "cbbADistribucion";
            this.cbbADistribucion.Size = new System.Drawing.Size(121, 21);
            this.cbbADistribucion.TabIndex = 1;
            this.cbbADistribucion.SelectionChangeCommitted += new System.EventHandler(this.cbbADistribucion_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Distribución:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgResultado);
            this.groupBox7.Location = new System.Drawing.Point(12, 440);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1237, 236);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado:";
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
            this.dtgResultado.Size = new System.Drawing.Size(1225, 211);
            this.dtgResultado.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtIdentificador);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Location = new System.Drawing.Point(12, 28);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(614, 52);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Datos:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(79, 19);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(117, 20);
            this.txtIdentificador.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Identificador:";
            // 
            // printForm1
            // 
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 688);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
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
            this.Text = "Politica de inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDistribucion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoDeEntrega)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
        private System.Windows.Forms.TextBox txtProbabilidadD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDemandaD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProbabilidadT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDemandaT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgDistribucion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgTiempoDeEntrega;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAleatoriosD;
        private System.Windows.Forms.TextBox txtAleatoriosT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label15;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        public System.Windows.Forms.ComboBox cbbDistribucion;
        public System.Windows.Forms.ComboBox cbbTiempoDeEntrega;
        public System.Windows.Forms.TextBox txtPuntoDeReorden;
        public System.Windows.Forms.TextBox txtCantidadOrdenar;
        public System.Windows.Forms.TextBox txtInventarioInicial;
        public System.Windows.Forms.TextBox txtCostoDeOrdenar;
        public System.Windows.Forms.TextBox txtCostoDeMantenimiento;
        public System.Windows.Forms.TextBox txtCostoPorFaltantes;
        public System.Windows.Forms.ComboBox cbbADistribucion;
        public System.Windows.Forms.ComboBox cbbATiempoDeEntrega;
        public System.Windows.Forms.TextBox txtIdentificador;
    }
}

