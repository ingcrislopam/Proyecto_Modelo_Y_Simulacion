namespace Formulario_Linea_De_Espera_Caso_Dos
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
            this.txtProbabilidadTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDemandaTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDTiempoEntreLlegada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProbabilidadTS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDemandaTS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDTiempoDeServicio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgTiempoEntreLlegada = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgTiempoDeServicio = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.cbbServicio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.cbbEntrada = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgResultadoFinal = new System.Windows.Forms.DataGridView();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoEntreLlegada)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoDeServicio)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoFinal)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1279, 25);
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
            this.groupBox1.Controls.Add(this.txtProbabilidadTL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDemandaTL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbDTiempoEntreLlegada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo entre llegada:";
            // 
            // txtProbabilidadTL
            // 
            this.txtProbabilidadTL.Enabled = false;
            this.txtProbabilidadTL.Location = new System.Drawing.Point(75, 48);
            this.txtProbabilidadTL.Name = "txtProbabilidadTL";
            this.txtProbabilidadTL.Size = new System.Drawing.Size(121, 20);
            this.txtProbabilidadTL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probabilidad:";
            // 
            // txtDemandaTL
            // 
            this.txtDemandaTL.Enabled = false;
            this.txtDemandaTL.Location = new System.Drawing.Point(262, 21);
            this.txtDemandaTL.Name = "txtDemandaTL";
            this.txtDemandaTL.Size = new System.Drawing.Size(131, 20);
            this.txtDemandaTL.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Demanda:";
            // 
            // cbbDTiempoEntreLlegada
            // 
            this.cbbDTiempoEntreLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDTiempoEntreLlegada.FormattingEnabled = true;
            this.cbbDTiempoEntreLlegada.Location = new System.Drawing.Point(75, 20);
            this.cbbDTiempoEntreLlegada.Name = "cbbDTiempoEntreLlegada";
            this.cbbDTiempoEntreLlegada.Size = new System.Drawing.Size(121, 21);
            this.cbbDTiempoEntreLlegada.TabIndex = 1;
            this.cbbDTiempoEntreLlegada.SelectionChangeCommitted += new System.EventHandler(this.cbbDTiempoEntreLlegada_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribucion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProbabilidadTS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDemandaTS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbDTiempoDeServicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 80);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo de servicio:";
            // 
            // txtProbabilidadTS
            // 
            this.txtProbabilidadTS.Enabled = false;
            this.txtProbabilidadTS.Location = new System.Drawing.Point(75, 46);
            this.txtProbabilidadTS.Name = "txtProbabilidadTS";
            this.txtProbabilidadTS.Size = new System.Drawing.Size(121, 20);
            this.txtProbabilidadTS.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Probabilidad:";
            // 
            // txtDemandaTS
            // 
            this.txtDemandaTS.Enabled = false;
            this.txtDemandaTS.Location = new System.Drawing.Point(262, 20);
            this.txtDemandaTS.Name = "txtDemandaTS";
            this.txtDemandaTS.Size = new System.Drawing.Size(131, 20);
            this.txtDemandaTS.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Demanda:";
            // 
            // cbbDTiempoDeServicio
            // 
            this.cbbDTiempoDeServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDTiempoDeServicio.FormattingEnabled = true;
            this.cbbDTiempoDeServicio.Location = new System.Drawing.Point(75, 19);
            this.cbbDTiempoDeServicio.Name = "cbbDTiempoDeServicio";
            this.cbbDTiempoDeServicio.Size = new System.Drawing.Size(121, 21);
            this.cbbDTiempoDeServicio.TabIndex = 1;
            this.cbbDTiempoDeServicio.SelectionChangeCommitted += new System.EventHandler(this.cbbDTiempoDeServicio_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Distribucion:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgTiempoEntreLlegada);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 200);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado tiempo entre llegada:";
            // 
            // dtgTiempoEntreLlegada
            // 
            this.dtgTiempoEntreLlegada.AllowUserToAddRows = false;
            this.dtgTiempoEntreLlegada.AllowUserToDeleteRows = false;
            this.dtgTiempoEntreLlegada.BackgroundColor = System.Drawing.Color.White;
            this.dtgTiempoEntreLlegada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTiempoEntreLlegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTiempoEntreLlegada.Location = new System.Drawing.Point(6, 19);
            this.dtgTiempoEntreLlegada.Name = "dtgTiempoEntreLlegada";
            this.dtgTiempoEntreLlegada.ReadOnly = true;
            this.dtgTiempoEntreLlegada.Size = new System.Drawing.Size(454, 175);
            this.dtgTiempoEntreLlegada.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgTiempoDeServicio);
            this.groupBox4.Location = new System.Drawing.Point(12, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 196);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado tiempo de servicio:";
            // 
            // dtgTiempoDeServicio
            // 
            this.dtgTiempoDeServicio.AllowUserToAddRows = false;
            this.dtgTiempoDeServicio.AllowUserToDeleteRows = false;
            this.dtgTiempoDeServicio.BackgroundColor = System.Drawing.Color.White;
            this.dtgTiempoDeServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTiempoDeServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTiempoDeServicio.Location = new System.Drawing.Point(6, 19);
            this.dtgTiempoDeServicio.Name = "dtgTiempoDeServicio";
            this.dtgTiempoDeServicio.ReadOnly = true;
            this.dtgTiempoDeServicio.Size = new System.Drawing.Size(454, 171);
            this.dtgTiempoDeServicio.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtServicio);
            this.groupBox5.Controls.Add(this.cbbServicio);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtEntrada);
            this.groupBox5.Controls.Add(this.cbbEntrada);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(484, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(778, 53);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aleatorios";
            // 
            // txtServicio
            // 
            this.txtServicio.Enabled = false;
            this.txtServicio.Location = new System.Drawing.Point(523, 21);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(238, 20);
            this.txtServicio.TabIndex = 8;
            // 
            // cbbServicio
            // 
            this.cbbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServicio.FormattingEnabled = true;
            this.cbbServicio.Location = new System.Drawing.Point(440, 21);
            this.cbbServicio.Name = "cbbServicio";
            this.cbbServicio.Size = new System.Drawing.Size(77, 21);
            this.cbbServicio.TabIndex = 7;
            this.cbbServicio.SelectionChangeCommitted += new System.EventHandler(this.cbbServicio_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Servicio:";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Location = new System.Drawing.Point(142, 21);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(238, 20);
            this.txtEntrada.TabIndex = 2;
            // 
            // cbbEntrada
            // 
            this.cbbEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEntrada.FormattingEnabled = true;
            this.cbbEntrada.Location = new System.Drawing.Point(59, 20);
            this.cbbEntrada.Name = "cbbEntrada";
            this.cbbEntrada.Size = new System.Drawing.Size(77, 21);
            this.cbbEntrada.TabIndex = 1;
            this.cbbEntrada.SelectionChangeCommitted += new System.EventHandler(this.cbbEntrada_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Entrada:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtgResultado);
            this.groupBox6.Location = new System.Drawing.Point(484, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(778, 286);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultado:";
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.AllowUserToDeleteRows = false;
            this.dtgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dtgResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(107, 19);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.ReadOnly = true;
            this.dtgResultado.Size = new System.Drawing.Size(571, 261);
            this.dtgResultado.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgResultadoFinal);
            this.groupBox7.Location = new System.Drawing.Point(484, 379);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(778, 282);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado final:";
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
            this.dtgResultadoFinal.Size = new System.Drawing.Size(766, 257);
            this.dtgResultadoFinal.TabIndex = 0;
            // 
            // printForm1
            // 
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtIdentificador);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Location = new System.Drawing.Point(12, 28);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(466, 53);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Datos:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(220, 22);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(51, 20);
            this.txtIdentificador.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Identificador:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1063, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Autor: Cristhian Adrián López Mora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 673);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linea De Espera Caso Dos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoEntreLlegada)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoDeServicio)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoFinal)).EndInit();
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
        private System.Windows.Forms.TextBox txtProbabilidadTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDemandaTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProbabilidadTS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDemandaTS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgTiempoEntreLlegada;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgTiempoDeServicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtgResultadoFinal;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIdentificador;
        public System.Windows.Forms.ComboBox cbbDTiempoEntreLlegada;
        public System.Windows.Forms.ComboBox cbbDTiempoDeServicio;
        public System.Windows.Forms.ComboBox cbbServicio;
        public System.Windows.Forms.ComboBox cbbEntrada;
        private System.Windows.Forms.Label label10;
    }
}

