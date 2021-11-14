namespace Formulario_Linea_De_Espera_Un_Canal
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
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtXn1 = new System.Windows.Forms.TextBox();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbId1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtXn2 = new System.Windows.Forms.TextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbId2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMediaDeServicio = new System.Windows.Forms.TextBox();
            this.txtMediaEntreLlegada = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgResultado1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgResultado2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtgResultadoFinal = new System.Windows.Forms.DataGridView();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoFinal)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1332, 25);
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
            this.groupBox1.Controls.Add(this.txtC1);
            this.groupBox1.Controls.Add(this.txtA1);
            this.groupBox1.Controls.Add(this.txtXn1);
            this.groupBox1.Controls.Add(this.txtM1);
            this.groupBox1.Controls.Add(this.txtN1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbId1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada:";
            // 
            // txtC1
            // 
            this.txtC1.Enabled = false;
            this.txtC1.Location = new System.Drawing.Point(92, 167);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(51, 20);
            this.txtC1.TabIndex = 23;
            // 
            // txtA1
            // 
            this.txtA1.Enabled = false;
            this.txtA1.Location = new System.Drawing.Point(92, 141);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(51, 20);
            this.txtA1.TabIndex = 22;
            // 
            // txtXn1
            // 
            this.txtXn1.Enabled = false;
            this.txtXn1.Location = new System.Drawing.Point(92, 115);
            this.txtXn1.Name = "txtXn1";
            this.txtXn1.Size = new System.Drawing.Size(51, 20);
            this.txtXn1.TabIndex = 21;
            // 
            // txtM1
            // 
            this.txtM1.Enabled = false;
            this.txtM1.Location = new System.Drawing.Point(92, 89);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(51, 20);
            this.txtM1.TabIndex = 20;
            // 
            // txtN1
            // 
            this.txtN1.Enabled = false;
            this.txtN1.Location = new System.Drawing.Point(92, 63);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(51, 20);
            this.txtN1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Xn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "m:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "# simulaciones:";
            // 
            // cbbId1
            // 
            this.cbbId1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbId1.FormattingEnabled = true;
            this.cbbId1.Location = new System.Drawing.Point(79, 19);
            this.cbbId1.Name = "cbbId1";
            this.cbbId1.Size = new System.Drawing.Size(64, 21);
            this.cbbId1.TabIndex = 13;
            this.cbbId1.SelectionChangeCommitted += new System.EventHandler(this.cbbId1_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "identificador:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtC2);
            this.groupBox2.Controls.Add(this.txtA2);
            this.groupBox2.Controls.Add(this.txtXn2);
            this.groupBox2.Controls.Add(this.txtM2);
            this.groupBox2.Controls.Add(this.txtN2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbbId2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicio:";
            // 
            // txtC2
            // 
            this.txtC2.Enabled = false;
            this.txtC2.Location = new System.Drawing.Point(92, 167);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(51, 20);
            this.txtC2.TabIndex = 23;
            // 
            // txtA2
            // 
            this.txtA2.Enabled = false;
            this.txtA2.Location = new System.Drawing.Point(92, 141);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(51, 20);
            this.txtA2.TabIndex = 22;
            // 
            // txtXn2
            // 
            this.txtXn2.Enabled = false;
            this.txtXn2.Location = new System.Drawing.Point(92, 115);
            this.txtXn2.Name = "txtXn2";
            this.txtXn2.Size = new System.Drawing.Size(51, 20);
            this.txtXn2.TabIndex = 21;
            // 
            // txtM2
            // 
            this.txtM2.Enabled = false;
            this.txtM2.Location = new System.Drawing.Point(92, 89);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(51, 20);
            this.txtM2.TabIndex = 20;
            // 
            // txtN2
            // 
            this.txtN2.Enabled = false;
            this.txtN2.Location = new System.Drawing.Point(92, 63);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(51, 20);
            this.txtN2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "c:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "a:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Xn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "m:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "# simulaciones:";
            // 
            // cbbId2
            // 
            this.cbbId2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbId2.FormattingEnabled = true;
            this.cbbId2.Location = new System.Drawing.Point(79, 19);
            this.cbbId2.Name = "cbbId2";
            this.cbbId2.Size = new System.Drawing.Size(64, 21);
            this.cbbId2.TabIndex = 13;
            this.cbbId2.SelectionChangeCommitted += new System.EventHandler(this.cbbId2_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "identificador:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMediaDeServicio);
            this.groupBox5.Controls.Add(this.txtMediaEntreLlegada);
            this.groupBox5.Controls.Add(this.txtIdentificador);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(12, 436);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 109);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos:";
            // 
            // txtMediaDeServicio
            // 
            this.txtMediaDeServicio.Location = new System.Drawing.Point(92, 79);
            this.txtMediaDeServicio.Name = "txtMediaDeServicio";
            this.txtMediaDeServicio.Size = new System.Drawing.Size(51, 20);
            this.txtMediaDeServicio.TabIndex = 21;
            // 
            // txtMediaEntreLlegada
            // 
            this.txtMediaEntreLlegada.Location = new System.Drawing.Point(92, 53);
            this.txtMediaEntreLlegada.Name = "txtMediaEntreLlegada";
            this.txtMediaEntreLlegada.Size = new System.Drawing.Size(51, 20);
            this.txtMediaEntreLlegada.TabIndex = 20;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(92, 27);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(51, 20);
            this.txtIdentificador.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "media servicio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "media llegada:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "identificador:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgResultado1);
            this.groupBox3.Location = new System.Drawing.Point(167, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 198);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado Llegada:";
            // 
            // dtgResultado1
            // 
            this.dtgResultado1.AllowUserToAddRows = false;
            this.dtgResultado1.AllowUserToDeleteRows = false;
            this.dtgResultado1.BackgroundColor = System.Drawing.Color.White;
            this.dtgResultado1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgResultado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado1.Location = new System.Drawing.Point(6, 19);
            this.dtgResultado1.Name = "dtgResultado1";
            this.dtgResultado1.ReadOnly = true;
            this.dtgResultado1.Size = new System.Drawing.Size(563, 173);
            this.dtgResultado1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgResultado2);
            this.groupBox4.Location = new System.Drawing.Point(748, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 198);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado Servicio:";
            // 
            // dtgResultado2
            // 
            this.dtgResultado2.AllowUserToAddRows = false;
            this.dtgResultado2.AllowUserToDeleteRows = false;
            this.dtgResultado2.BackgroundColor = System.Drawing.Color.White;
            this.dtgResultado2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgResultado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado2.Location = new System.Drawing.Point(6, 19);
            this.dtgResultado2.Name = "dtgResultado2";
            this.dtgResultado2.ReadOnly = true;
            this.dtgResultado2.Size = new System.Drawing.Size(560, 173);
            this.dtgResultado2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtgResultadoFinal);
            this.groupBox6.Location = new System.Drawing.Point(210, 232);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1078, 344);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultado:";
            // 
            // dtgResultadoFinal
            // 
            this.dtgResultadoFinal.AllowUserToAddRows = false;
            this.dtgResultadoFinal.AllowUserToDeleteRows = false;
            this.dtgResultadoFinal.BackgroundColor = System.Drawing.Color.White;
            this.dtgResultadoFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgResultadoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultadoFinal.Location = new System.Drawing.Point(6, 19);
            this.dtgResultadoFinal.Name = "dtgResultadoFinal";
            this.dtgResultadoFinal.ReadOnly = true;
            this.dtgResultadoFinal.Size = new System.Drawing.Size(1066, 319);
            this.dtgResultadoFinal.TabIndex = 0;
            // 
            // printForm1
            // 
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1108, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Autor: Cristhian Adrián López Mora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 588);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linea De Espera Con Un Canal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoFinal)).EndInit();
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
        public System.Windows.Forms.TextBox txtC1;
        public System.Windows.Forms.TextBox txtA1;
        public System.Windows.Forms.TextBox txtXn1;
        public System.Windows.Forms.TextBox txtM1;
        public System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtC2;
        public System.Windows.Forms.TextBox txtA2;
        public System.Windows.Forms.TextBox txtXn2;
        public System.Windows.Forms.TextBox txtM2;
        public System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txtMediaDeServicio;
        public System.Windows.Forms.TextBox txtMediaEntreLlegada;
        public System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgResultado1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgResultado2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dtgResultadoFinal;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        public System.Windows.Forms.ComboBox cbbId1;
        public System.Windows.Forms.ComboBox cbbId2;
        private System.Windows.Forms.Label label13;
    }
}

