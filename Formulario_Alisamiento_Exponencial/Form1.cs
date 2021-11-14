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

namespace Formulario_Alisamiento_Exponencial
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
            txtAlfa.Text = "";
            txtDemandas.Text = "";
            txtNuevasDemandas.Text = "";
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtAlfa.Focus();
        }

        public void NuevaGrafica()
        {
            chtGrafica.Series.Clear();
            chtGrafica.Series.Add("demanda");
            chtGrafica.Series["demanda"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["demanda"].BorderWidth = 4;
            chtGrafica.Series.Add("pronostico");
            chtGrafica.Series["pronostico"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["pronostico"].BorderWidth = 4;
            chtGrafica.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtAlfa.Text == "" || txtDemandas.Text == "" || txtNuevasDemandas.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_AlisamientoExponencial gestionAlisamientoExponencial = new Gestion_AlisamientoExponencial();
                    gestionAlisamientoExponencial.Alfa = Convert.ToString(txtAlfa.Text);
                    gestionAlisamientoExponencial.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionAlisamientoExponencial.NuevasDemandas = Convert.ToString(txtNuevasDemandas.Text);
                    gestionAlisamientoExponencial.Insertar();
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
            Gestion_AlisamientoExponencial gestionAlisamientoExponencial = new Gestion_AlisamientoExponencial();
            if (gestionAlisamientoExponencial.CantidadElementos() == 0)
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
                    Gestion_AlisamientoExponencial gestionAlisamientoExponencial = new Gestion_AlisamientoExponencial();
                    gestionAlisamientoExponencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionAlisamientoExponencial.Alfa = Convert.ToString(txtAlfa.Text);
                    gestionAlisamientoExponencial.Demandas = Convert.ToString(txtDemandas.Text);
                    gestionAlisamientoExponencial.NuevasDemandas = Convert.ToString(txtNuevasDemandas.Text);
                    gestionAlisamientoExponencial.Modificar();
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
                    Gestion_AlisamientoExponencial gestionAlisamientoExponencial = new Gestion_AlisamientoExponencial();
                    gestionAlisamientoExponencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionAlisamientoExponencial.Eliminar();
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
            if (txtAlfa.Text == "" || txtDemandas.Text == "" || txtNuevasDemandas.Text == "")
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
            AlisamientoExponencial alisamientoExponencial = new AlisamientoExponencial();
            string demandas = "";
            string nuevasDemandas = "";
            demandas = Convert.ToString(txtDemandas.Text) + "-";
            nuevasDemandas = Convert.ToString(txtNuevasDemandas.Text) + "-";
            dtgResultado.DataSource = alisamientoExponencial.MostrarResultado(demandas, nuevasDemandas, Convert.ToDouble(txtAlfa.Text), chtGrafica);
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
