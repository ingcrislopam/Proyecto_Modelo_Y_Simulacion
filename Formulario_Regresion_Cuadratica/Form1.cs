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
using System.Windows.Forms.DataVisualization.Charting;
using Negocio.Gestiones;
using System.Drawing.Printing;

namespace Formulario_Regresion_Cuadratica
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
            txtX.Text = "";
            txtY.Text = "";
            txtPrimeraEcuacion.Text = "";
            txtSegundaEcuacion.Text = "";
            txtTerceraEcuacion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtNuevaEcuacion.Text = "";
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtX.Focus();
        }

        public void NuevaGrafica()
        {
            chtGrafica.Series.Clear();
            chtGrafica.Series.Add("y");
            chtGrafica.Series["y"].ChartType = SeriesChartType.Point;
            chtGrafica.Series["y"].BorderWidth = 4;
            chtGrafica.Series.Add("calculo");
            chtGrafica.Series["calculo"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["calculo"].BorderWidth = 4;
            chtGrafica.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtX.Text == "" || txtY.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_Cuadratica gestionCuadratica = new Gestion_Cuadratica();
                    gestionCuadratica.X = Convert.ToString(txtX.Text);
                    gestionCuadratica.Y = Convert.ToString(txtY.Text);
                    gestionCuadratica.Insertar();
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
            Gestion_Cuadratica gestionCuadratica = new Gestion_Cuadratica();
            if (gestionCuadratica.CantidadElementos() == 0)
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
                    Gestion_Cuadratica gestionCuadratica = new Gestion_Cuadratica();
                    gestionCuadratica.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionCuadratica.X = Convert.ToString(txtX.Text);
                    gestionCuadratica.Y = Convert.ToString(txtY.Text);
                    gestionCuadratica.Modificar();
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
                    Gestion_Cuadratica gestionCuadratica = new Gestion_Cuadratica();
                    gestionCuadratica.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionCuadratica.Eliminar();
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
            if (txtX.Text == "" || txtY.Text == "")
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
            RegresionCuadratica regresionCuadratica = new RegresionCuadratica();
            string cadenaX = "";
            string cadenaY = "";
            cadenaX = (Convert.ToString(txtX.Text) + "-").Trim();
            cadenaY = (Convert.ToString(txtY.Text) + "-").Trim();
            dtgResultado.DataSource = regresionCuadratica.MostrarResultado(cadenaX, cadenaY, txtPrimeraEcuacion, txtSegundaEcuacion, txtTerceraEcuacion, txtA, txtB, txtC, txtNuevaEcuacion, chtGrafica);
            chtGrafica.Visible = true;
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
