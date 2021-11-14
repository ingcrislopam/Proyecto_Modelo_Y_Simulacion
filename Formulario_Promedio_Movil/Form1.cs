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

namespace Formulario_Promedio_Movil
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
            txtEvaluar.Text = "";
            txtDemandas.Focus();
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtDemandas.Focus();
        }

        public void NuevaGrafica()
        {
            chtGrafica.Series.Clear();
            chtGrafica.Series.Add("demanda");
            chtGrafica.Series["demanda"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["demanda"].BorderWidth = 4;
            chtGrafica.Series.Add("promedio");
            chtGrafica.Series["promedio"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["promedio"].BorderWidth = 4;
            chtGrafica.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtDemandas.Text == "" || txtEvaluar.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_PromedioMovil gestionPromedioMovil = new Gestion_PromedioMovil();
                    gestionPromedioMovil.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionPromedioMovil.Evaluar = Convert.ToInt32(txtEvaluar.Text);
                    gestionPromedioMovil.Insertar();
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
            Gestion_PromedioMovil gestionPromedioMovil = new Gestion_PromedioMovil();
            if (gestionPromedioMovil.CantidadElementos() == 0)
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
                    Gestion_PromedioMovil gestionPromedioMovil = new Gestion_PromedioMovil();
                    gestionPromedioMovil.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPromedioMovil.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionPromedioMovil.Evaluar = Convert.ToInt32(txtEvaluar.Text);
                    gestionPromedioMovil.Modificar();
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
                    Gestion_PromedioMovil gestionPromedioMovil = new Gestion_PromedioMovil();
                    gestionPromedioMovil.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPromedioMovil.Eliminar();
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
            if (txtDemandas.Text == "" || txtEvaluar.Text == "")
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
            PromedioMovil promedioMovil = new PromedioMovil();
            string demandas = "";
            demandas = Convert.ToString(txtDemandas.Text) + "-";
            dtgResultado.DataSource = promedioMovil.MostrarResultado(demandas, Convert.ToInt32(txtEvaluar.Text), chtGrafica);
            chtGrafica.Visible = true;
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
