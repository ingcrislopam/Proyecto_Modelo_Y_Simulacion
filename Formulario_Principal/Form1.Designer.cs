namespace Formulario_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.distribucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCongruencialLineal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVariableAleatoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExponencial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPoisson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMonteCarlo = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioMovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCasoUno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCasoDos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlisamientoExponencial = new System.Windows.Forms.ToolStripMenuItem();
            this.regresionLinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLineal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCuadratica = new System.Windows.Forms.ToolStripMenuItem();
            this.simulacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAleatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFrecuencia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProyecto = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLineasDeEsperaCasoUno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLineasDeEsperaCasoDos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeLaVidaRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAImpresorasArregladas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAVentasDeImpresoras = new System.Windows.Forms.ToolStripMenuItem();
            this.pronosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPronosticoImpresorasArregladas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPronosticoVentasImpresoras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResultados = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVer = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribucionesToolStripMenuItem,
            this.simulacionToolStripMenuItem1,
            this.sistemaDeLaVidaRealToolStripMenuItem,
            this.contactoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // distribucionesToolStripMenuItem
            // 
            this.distribucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCongruencialLineal,
            this.tsmVariableAleatoria,
            this.tsmExponencial,
            this.tsmPoisson,
            this.tsmMonteCarlo,
            this.promedioMovilToolStripMenuItem,
            this.tsmAlisamientoExponencial,
            this.regresionLinealToolStripMenuItem});
            this.distribucionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("distribucionesToolStripMenuItem.Image")));
            this.distribucionesToolStripMenuItem.Name = "distribucionesToolStripMenuItem";
            this.distribucionesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.distribucionesToolStripMenuItem.Text = "Distribuciones";
            // 
            // tsmCongruencialLineal
            // 
            this.tsmCongruencialLineal.Image = ((System.Drawing.Image)(resources.GetObject("tsmCongruencialLineal.Image")));
            this.tsmCongruencialLineal.Name = "tsmCongruencialLineal";
            this.tsmCongruencialLineal.Size = new System.Drawing.Size(203, 22);
            this.tsmCongruencialLineal.Text = "Congruencial Lineal";
            this.tsmCongruencialLineal.Click += new System.EventHandler(this.tsmCongruencialLineal_Click);
            // 
            // tsmVariableAleatoria
            // 
            this.tsmVariableAleatoria.Image = ((System.Drawing.Image)(resources.GetObject("tsmVariableAleatoria.Image")));
            this.tsmVariableAleatoria.Name = "tsmVariableAleatoria";
            this.tsmVariableAleatoria.Size = new System.Drawing.Size(203, 22);
            this.tsmVariableAleatoria.Text = "Variable Aleatoria";
            this.tsmVariableAleatoria.Click += new System.EventHandler(this.tsmVariableAleatoria_Click);
            // 
            // tsmExponencial
            // 
            this.tsmExponencial.Image = ((System.Drawing.Image)(resources.GetObject("tsmExponencial.Image")));
            this.tsmExponencial.Name = "tsmExponencial";
            this.tsmExponencial.Size = new System.Drawing.Size(203, 22);
            this.tsmExponencial.Text = "Exponencial";
            this.tsmExponencial.Click += new System.EventHandler(this.tsmExponencial_Click);
            // 
            // tsmPoisson
            // 
            this.tsmPoisson.Image = ((System.Drawing.Image)(resources.GetObject("tsmPoisson.Image")));
            this.tsmPoisson.Name = "tsmPoisson";
            this.tsmPoisson.Size = new System.Drawing.Size(203, 22);
            this.tsmPoisson.Text = "Poisson";
            this.tsmPoisson.Click += new System.EventHandler(this.tsmPoisson_Click);
            // 
            // tsmMonteCarlo
            // 
            this.tsmMonteCarlo.Image = ((System.Drawing.Image)(resources.GetObject("tsmMonteCarlo.Image")));
            this.tsmMonteCarlo.Name = "tsmMonteCarlo";
            this.tsmMonteCarlo.Size = new System.Drawing.Size(203, 22);
            this.tsmMonteCarlo.Text = "MonteCarlo";
            this.tsmMonteCarlo.Click += new System.EventHandler(this.tsmMonteCarlo_Click);
            // 
            // promedioMovilToolStripMenuItem
            // 
            this.promedioMovilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCasoUno,
            this.tsmCasoDos});
            this.promedioMovilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("promedioMovilToolStripMenuItem.Image")));
            this.promedioMovilToolStripMenuItem.Name = "promedioMovilToolStripMenuItem";
            this.promedioMovilToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.promedioMovilToolStripMenuItem.Text = "Promedio Movil";
            // 
            // tsmCasoUno
            // 
            this.tsmCasoUno.Image = ((System.Drawing.Image)(resources.GetObject("tsmCasoUno.Image")));
            this.tsmCasoUno.Name = "tsmCasoUno";
            this.tsmCasoUno.Size = new System.Drawing.Size(125, 22);
            this.tsmCasoUno.Text = "Caso Uno";
            this.tsmCasoUno.Click += new System.EventHandler(this.tsmCasoUno_Click);
            // 
            // tsmCasoDos
            // 
            this.tsmCasoDos.Image = ((System.Drawing.Image)(resources.GetObject("tsmCasoDos.Image")));
            this.tsmCasoDos.Name = "tsmCasoDos";
            this.tsmCasoDos.Size = new System.Drawing.Size(125, 22);
            this.tsmCasoDos.Text = "Caso Dos";
            this.tsmCasoDos.Click += new System.EventHandler(this.tsmCasoDos_Click);
            // 
            // tsmAlisamientoExponencial
            // 
            this.tsmAlisamientoExponencial.Image = ((System.Drawing.Image)(resources.GetObject("tsmAlisamientoExponencial.Image")));
            this.tsmAlisamientoExponencial.Name = "tsmAlisamientoExponencial";
            this.tsmAlisamientoExponencial.Size = new System.Drawing.Size(203, 22);
            this.tsmAlisamientoExponencial.Text = "Alisamiento Exponencial";
            this.tsmAlisamientoExponencial.Click += new System.EventHandler(this.tsmAlisamientoExponencial_Click);
            // 
            // regresionLinealToolStripMenuItem
            // 
            this.regresionLinealToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLineal,
            this.tsmCuadratica});
            this.regresionLinealToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regresionLinealToolStripMenuItem.Image")));
            this.regresionLinealToolStripMenuItem.Name = "regresionLinealToolStripMenuItem";
            this.regresionLinealToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.regresionLinealToolStripMenuItem.Text = "Regresion";
            // 
            // tsmLineal
            // 
            this.tsmLineal.Image = ((System.Drawing.Image)(resources.GetObject("tsmLineal.Image")));
            this.tsmLineal.Name = "tsmLineal";
            this.tsmLineal.Size = new System.Drawing.Size(131, 22);
            this.tsmLineal.Text = "Lineal";
            this.tsmLineal.Click += new System.EventHandler(this.tsmLineal_Click);
            // 
            // tsmCuadratica
            // 
            this.tsmCuadratica.Image = ((System.Drawing.Image)(resources.GetObject("tsmCuadratica.Image")));
            this.tsmCuadratica.Name = "tsmCuadratica";
            this.tsmCuadratica.Size = new System.Drawing.Size(131, 22);
            this.tsmCuadratica.Text = "Cuadratica";
            this.tsmCuadratica.Click += new System.EventHandler(this.tsmCuadratica_Click);
            // 
            // simulacionToolStripMenuItem1
            // 
            this.simulacionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAleatorio,
            this.tsmFrecuencia,
            this.tsmProyecto,
            this.lineaToolStripMenuItem,
            this.tsmInventario});
            this.simulacionToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("simulacionToolStripMenuItem1.Image")));
            this.simulacionToolStripMenuItem1.Name = "simulacionToolStripMenuItem1";
            this.simulacionToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.simulacionToolStripMenuItem1.Text = "Simulacion";
            // 
            // tsmAleatorio
            // 
            this.tsmAleatorio.Image = ((System.Drawing.Image)(resources.GetObject("tsmAleatorio.Image")));
            this.tsmAleatorio.Name = "tsmAleatorio";
            this.tsmAleatorio.Size = new System.Drawing.Size(161, 22);
            this.tsmAleatorio.Text = "Aleatorio";
            this.tsmAleatorio.Click += new System.EventHandler(this.tsmAleatorio_Click);
            // 
            // tsmFrecuencia
            // 
            this.tsmFrecuencia.Image = ((System.Drawing.Image)(resources.GetObject("tsmFrecuencia.Image")));
            this.tsmFrecuencia.Name = "tsmFrecuencia";
            this.tsmFrecuencia.Size = new System.Drawing.Size(161, 22);
            this.tsmFrecuencia.Text = "Frecuencia";
            this.tsmFrecuencia.Click += new System.EventHandler(this.tsmFrecuencia_Click);
            // 
            // tsmProyecto
            // 
            this.tsmProyecto.Image = ((System.Drawing.Image)(resources.GetObject("tsmProyecto.Image")));
            this.tsmProyecto.Name = "tsmProyecto";
            this.tsmProyecto.Size = new System.Drawing.Size(161, 22);
            this.tsmProyecto.Text = "Actividades";
            this.tsmProyecto.Click += new System.EventHandler(this.tsmProyecto_Click);
            // 
            // lineaToolStripMenuItem
            // 
            this.lineaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLineasDeEsperaCasoUno,
            this.tsmLineasDeEsperaCasoDos});
            this.lineaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineaToolStripMenuItem.Image")));
            this.lineaToolStripMenuItem.Name = "lineaToolStripMenuItem";
            this.lineaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.lineaToolStripMenuItem.Text = "Lineas De Espera";
            // 
            // tsmLineasDeEsperaCasoUno
            // 
            this.tsmLineasDeEsperaCasoUno.Image = ((System.Drawing.Image)(resources.GetObject("tsmLineasDeEsperaCasoUno.Image")));
            this.tsmLineasDeEsperaCasoUno.Name = "tsmLineasDeEsperaCasoUno";
            this.tsmLineasDeEsperaCasoUno.Size = new System.Drawing.Size(125, 22);
            this.tsmLineasDeEsperaCasoUno.Text = "Caso Uno";
            this.tsmLineasDeEsperaCasoUno.Click += new System.EventHandler(this.tsmLineasDeEsperaCasoUno_Click);
            // 
            // tsmLineasDeEsperaCasoDos
            // 
            this.tsmLineasDeEsperaCasoDos.Image = ((System.Drawing.Image)(resources.GetObject("tsmLineasDeEsperaCasoDos.Image")));
            this.tsmLineasDeEsperaCasoDos.Name = "tsmLineasDeEsperaCasoDos";
            this.tsmLineasDeEsperaCasoDos.Size = new System.Drawing.Size(125, 22);
            this.tsmLineasDeEsperaCasoDos.Text = "Caso Dos";
            this.tsmLineasDeEsperaCasoDos.Click += new System.EventHandler(this.tsmLineasDeEsperaCasoDos_Click);
            // 
            // tsmInventario
            // 
            this.tsmInventario.Image = ((System.Drawing.Image)(resources.GetObject("tsmInventario.Image")));
            this.tsmInventario.Name = "tsmInventario";
            this.tsmInventario.Size = new System.Drawing.Size(161, 22);
            this.tsmInventario.Text = "Inventario";
            this.tsmInventario.Click += new System.EventHandler(this.tsmInventario_Click);
            // 
            // sistemaDeLaVidaRealToolStripMenuItem
            // 
            this.sistemaDeLaVidaRealToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatoriosToolStripMenuItem,
            this.pronosticoToolStripMenuItem,
            this.tsmResultados});
            this.sistemaDeLaVidaRealToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemaDeLaVidaRealToolStripMenuItem.Image")));
            this.sistemaDeLaVidaRealToolStripMenuItem.Name = "sistemaDeLaVidaRealToolStripMenuItem";
            this.sistemaDeLaVidaRealToolStripMenuItem.Size = new System.Drawing.Size(238, 20);
            this.sistemaDeLaVidaRealToolStripMenuItem.Text = "Sistema de la vida real - COMPUPRINT";
            // 
            // aleatoriosToolStripMenuItem
            // 
            this.aleatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAImpresorasArregladas,
            this.tsmAVentasDeImpresoras});
            this.aleatoriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aleatoriosToolStripMenuItem.Image")));
            this.aleatoriosToolStripMenuItem.Name = "aleatoriosToolStripMenuItem";
            this.aleatoriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aleatoriosToolStripMenuItem.Text = "Impresoras";
            // 
            // tsmAImpresorasArregladas
            // 
            this.tsmAImpresorasArregladas.Image = ((System.Drawing.Image)(resources.GetObject("tsmAImpresorasArregladas.Image")));
            this.tsmAImpresorasArregladas.Name = "tsmAImpresorasArregladas";
            this.tsmAImpresorasArregladas.Size = new System.Drawing.Size(118, 22);
            this.tsmAImpresorasArregladas.Text = "Arreglos";
            this.tsmAImpresorasArregladas.Click += new System.EventHandler(this.tsmAImpresorasArregladas_Click);
            // 
            // tsmAVentasDeImpresoras
            // 
            this.tsmAVentasDeImpresoras.Image = ((System.Drawing.Image)(resources.GetObject("tsmAVentasDeImpresoras.Image")));
            this.tsmAVentasDeImpresoras.Name = "tsmAVentasDeImpresoras";
            this.tsmAVentasDeImpresoras.Size = new System.Drawing.Size(118, 22);
            this.tsmAVentasDeImpresoras.Text = "Ventas";
            this.tsmAVentasDeImpresoras.Click += new System.EventHandler(this.tsmAVentasDeImpresoras_Click);
            // 
            // pronosticoToolStripMenuItem
            // 
            this.pronosticoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPronosticoImpresorasArregladas,
            this.tsmPronosticoVentasImpresoras});
            this.pronosticoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pronosticoToolStripMenuItem.Image")));
            this.pronosticoToolStripMenuItem.Name = "pronosticoToolStripMenuItem";
            this.pronosticoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pronosticoToolStripMenuItem.Text = "Pronosticos";
            // 
            // tsmPronosticoImpresorasArregladas
            // 
            this.tsmPronosticoImpresorasArregladas.Image = ((System.Drawing.Image)(resources.GetObject("tsmPronosticoImpresorasArregladas.Image")));
            this.tsmPronosticoImpresorasArregladas.Name = "tsmPronosticoImpresorasArregladas";
            this.tsmPronosticoImpresorasArregladas.Size = new System.Drawing.Size(118, 22);
            this.tsmPronosticoImpresorasArregladas.Text = "Arreglos";
            this.tsmPronosticoImpresorasArregladas.Click += new System.EventHandler(this.tsmPronosticoImpresorasArregladas_Click);
            // 
            // tsmPronosticoVentasImpresoras
            // 
            this.tsmPronosticoVentasImpresoras.Image = ((System.Drawing.Image)(resources.GetObject("tsmPronosticoVentasImpresoras.Image")));
            this.tsmPronosticoVentasImpresoras.Name = "tsmPronosticoVentasImpresoras";
            this.tsmPronosticoVentasImpresoras.Size = new System.Drawing.Size(118, 22);
            this.tsmPronosticoVentasImpresoras.Text = "Ventas";
            this.tsmPronosticoVentasImpresoras.Click += new System.EventHandler(this.tsmPronosticoVentasImpresoras_Click);
            // 
            // tsmResultados
            // 
            this.tsmResultados.Image = ((System.Drawing.Image)(resources.GetObject("tsmResultados.Image")));
            this.tsmResultados.Name = "tsmResultados";
            this.tsmResultados.Size = new System.Drawing.Size(152, 22);
            this.tsmResultados.Text = "Resultados";
            this.tsmResultados.Click += new System.EventHandler(this.tsmResultados_Click);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVer});
            this.contactoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactoToolStripMenuItem.Image")));
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.contactoToolStripMenuItem.Text = "Ayuda";
            // 
            // tsmVer
            // 
            this.tsmVer.Image = ((System.Drawing.Image)(resources.GetObject("tsmVer.Image")));
            this.tsmVer.Name = "tsmVer";
            this.tsmVer.Size = new System.Drawing.Size(91, 22);
            this.tsmVer.Text = "Ver";
            this.tsmVer.Click += new System.EventHandler(this.tsmVer_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tsmExit
            // 
            this.tsmExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmExit.Image")));
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(92, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(679, 365);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo y Simulación - Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem distribucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCongruencialLineal;
        private System.Windows.Forms.ToolStripMenuItem tsmVariableAleatoria;
        private System.Windows.Forms.ToolStripMenuItem tsmExponencial;
        private System.Windows.Forms.ToolStripMenuItem tsmPoisson;
        private System.Windows.Forms.ToolStripMenuItem tsmMonteCarlo;
        private System.Windows.Forms.ToolStripMenuItem promedioMovilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCasoUno;
        private System.Windows.Forms.ToolStripMenuItem tsmCasoDos;
        private System.Windows.Forms.ToolStripMenuItem tsmAlisamientoExponencial;
        private System.Windows.Forms.ToolStripMenuItem regresionLinealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLineal;
        private System.Windows.Forms.ToolStripMenuItem tsmCuadratica;
        private System.Windows.Forms.ToolStripMenuItem tsmVer;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem simulacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAleatorio;
        private System.Windows.Forms.ToolStripMenuItem lineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmFrecuencia;
        private System.Windows.Forms.ToolStripMenuItem tsmLineasDeEsperaCasoUno;
        private System.Windows.Forms.ToolStripMenuItem tsmLineasDeEsperaCasoDos;
        private System.Windows.Forms.ToolStripMenuItem tsmInventario;
        private System.Windows.Forms.ToolStripMenuItem tsmProyecto;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeLaVidaRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAImpresorasArregladas;
        private System.Windows.Forms.ToolStripMenuItem tsmAVentasDeImpresoras;
        private System.Windows.Forms.ToolStripMenuItem pronosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPronosticoImpresorasArregladas;
        private System.Windows.Forms.ToolStripMenuItem tsmPronosticoVentasImpresoras;
        private System.Windows.Forms.ToolStripMenuItem tsmResultados;
    }
}

