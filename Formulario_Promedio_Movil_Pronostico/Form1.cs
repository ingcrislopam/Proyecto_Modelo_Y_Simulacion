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

namespace Formulario_Promedio_Movil_Pronostico
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
            txtDemandas.Text = "";
            txtEvaluarUno.Text = "";
            txtEvaluarDos.Text = "";
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtDemandas.Focus();
        }

        public void NuevaGrafica()
        {
            chtGraficaUno.Series.Clear();
            chtGraficaDos.Series.Clear();
            chtGraficaUno.Series.Add("accion");
            chtGraficaUno.Series["accion"].ChartType = SeriesChartType.Spline;
            chtGraficaUno.Series["accion"].BorderWidth = 4;
            chtGraficaUno.Series.Add("pronostico 1");
            chtGraficaUno.Series["pronostico 1"].ChartType = SeriesChartType.Spline;
            chtGraficaUno.Series["pronostico 1"].BorderWidth = 4;
            chtGraficaDos.Series.Add("accion");
            chtGraficaDos.Series["accion"].ChartType = SeriesChartType.Spline;
            chtGraficaDos.Series["accion"].BorderWidth = 4;
            chtGraficaDos.Series.Add("pronostico 2");
            chtGraficaDos.Series["pronostico 2"].ChartType = SeriesChartType.Spline;
            chtGraficaDos.Series["pronostico 2"].BorderWidth = 4;
            chtGraficaUno.Visible = false;
            chtGraficaDos.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtDemandas.Text == "" || txtEvaluarUno.Text == "" || txtEvaluarDos.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_PromedioMovilPronostico gestionPromedioMovilPronostico = new Gestion_PromedioMovilPronostico();
                    gestionPromedioMovilPronostico.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionPromedioMovilPronostico.EvaluarUno = Convert.ToInt32(txtEvaluarUno.Text);
                    gestionPromedioMovilPronostico.EvaluarDos = Convert.ToInt32(txtEvaluarDos.Text);
                    gestionPromedioMovilPronostico.Insertar();
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
            Gestion_PromedioMovilPronostico gestionPromedioMovilPronostico = new Gestion_PromedioMovilPronostico();
            if (gestionPromedioMovilPronostico.CantidadElementos() == 0)
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
            if (txtIdentificador.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_PromedioMovilPronostico gestionPromedioMovilPronostico = new Gestion_PromedioMovilPronostico();
                    gestionPromedioMovilPronostico.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPromedioMovilPronostico.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionPromedioMovilPronostico.EvaluarUno = Convert.ToInt32(txtEvaluarUno.Text);
                    gestionPromedioMovilPronostico.EvaluarDos = Convert.ToInt32(txtEvaluarDos.Text);
                    gestionPromedioMovilPronostico.Modificar();
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
            if (txtIdentificador.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_PromedioMovilPronostico gestionPromedioMovilPronostico = new Gestion_PromedioMovilPronostico();
                    gestionPromedioMovilPronostico.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPromedioMovilPronostico.Eliminar();
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
            if (txtDemandas.Text == "" || txtEvaluarUno.Text == "" || txtEvaluarDos.Text == "")
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
            PromedioMovilPronostico promedioMovilPronostico = new PromedioMovilPronostico();
            string demandas = "";
            demandas = Convert.ToString(txtDemandas.Text) + "-";
            dtgResultado.DataSource = promedioMovilPronostico.MostrarResultado(demandas, Convert.ToInt32(txtEvaluarUno.Text), Convert.ToInt32(txtEvaluarDos.Text), chtGraficaUno, chtGraficaDos);
            chtGraficaUno.Visible = true;
            chtGraficaDos.Visible = true;
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public void Imprimir()
        {
            this.printForm1.PrintAction = PrintAction.PrintToPreview;
            this.printForm1.Print();
        }

        private void tExportar_Click(object sender, EventArgs e)
        {
            if (dtgResultado.RowCount == 0)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "") 
            {
 
            }
            else 
            {
                Calcular();
            }
        }
    }
}
