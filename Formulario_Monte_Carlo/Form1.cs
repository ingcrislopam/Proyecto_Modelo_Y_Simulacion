using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Distribuciones;
using Negocio.Gestiones;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace Formulario_Monte_Carlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            txtIdentificador.Text = "";
            txtN.Text = "";
            txtM.Text = "";
            txtXn.Text = "";
            txtA.Text = "";
            txtC.Text = "";
            txtIdentificadorE.Text = "";
            txtDemandas.Text = "";
            txtOcurrencias.Text = "";
            dtgResultado.DataSource = "";
            dtgResultadoDos.DataSource = "";
            NuevaGrafica();
            txtDemandas.Focus();
        }

        public void NuevaGrafica()
        {
            chtGraficaOcurrencias.Series.Clear();
            chtGraficaFrecuencias.Series.Clear();
            chtGraficaOcurrencias.Series.Add("ocurrencias");
            chtGraficaOcurrencias.Series["ocurrencias"].ChartType = SeriesChartType.Spline;
            chtGraficaOcurrencias.Series["ocurrencias"].BorderWidth = 4;
            chtGraficaFrecuencias.Series.Add("frecuencias");
            chtGraficaFrecuencias.Series["frecuencias"].ChartType = SeriesChartType.Spline;
            chtGraficaFrecuencias.Series["frecuencias"].BorderWidth = 4;
            chtGraficaOcurrencias.Visible = false;
            chtGraficaFrecuencias.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "" || txtDemandas.Text == "" || txtOcurrencias.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
                    gestionMonteCarlo.IdCongruencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionMonteCarlo.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionMonteCarlo.Ocurrencias = Convert.ToString(txtOcurrencias.Text);
                    gestionMonteCarlo.Insertar();
                    Nuevo();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void tBuscar_Click(object sender, EventArgs e)
        {
            Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
            if (gestionMonteCarlo.CantidadElementos() == 0)
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                Formulario_Buscar formularioBuscar = new Formulario_Buscar();
                this.Hide();
                formularioBuscar.Show();
            } 
        }

        private void tModificar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "" || txtIdentificadorE.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
                    gestionMonteCarlo.ID = Convert.ToInt32(txtIdentificadorE.Text);
                    gestionMonteCarlo.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionMonteCarlo.Ocurrencias = Convert.ToString(txtOcurrencias.Text);
                    gestionMonteCarlo.Modificar();
                    Nuevo();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void tEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdentificadorE.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
                    gestionMonteCarlo.ID = Convert.ToInt32(txtIdentificadorE.Text);
                    gestionMonteCarlo.Eliminar();
                    Nuevo();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void tCalcular_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "" || txtM.Text == "" || txtXn.Text == "" || txtA.Text == "" || txtC.Text == "" || txtDemandas.Text == "" || txtOcurrencias.Text == "") 
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                Calcular();
            }
        }

        public void Calcular() 
        {
            NuevaGrafica();
            MonteCarlo monteCarlo = new MonteCarlo();
            string cadena = "";
            string cadenaOcu = "";
            cadena = Convert.ToString(txtDemandas.Text);
            cadenaOcu = Convert.ToString(txtOcurrencias.Text);
            cadena = cadena + "-";
            cadenaOcu = cadenaOcu + "-";
            dtgResultado.DataSource = monteCarlo.MostrarResultado(cadena, cadenaOcu, chtGraficaOcurrencias, chtGraficaFrecuencias);
            dtgResultadoDos.DataSource = monteCarlo.MostrarResultadoSegundaTabla(cadenaOcu, Convert.ToInt32(txtN.Text), Convert.ToInt32(txtM.Text), Convert.ToInt32(txtXn.Text), Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text), dtgResultado);
            chtGraficaOcurrencias.Visible = true;
            chtGraficaFrecuencias.Visible = true;
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            this.printForm1.PrintAction = PrintAction.PrintToPreview;
            this.printForm1.Print();
        }

        private void tExportar_Click(object sender, EventArgs e)
        {
            if (dtgResultado.RowCount == 0 || dtgResultadoDos.RowCount == 0)
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                Exportar exportar = new Exportar();
                exportar.ExportarDataGridViewExcel(dtgResultado);
            }
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCongruencial_Click(object sender, EventArgs e)
        {
            Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
            if (gestionCongruencial.CantidadElementos() == 0)
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                Formulario_Buscar_Congruencial formularioBuscarCongruencial = new Formulario_Buscar_Congruencial();
                this.Hide();
                formularioBuscarCongruencial.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificadorE.Text == "") 
            {
 
            }
            else 
            {
                Calcular();
            }
        }
    }
}
