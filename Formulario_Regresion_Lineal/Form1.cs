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

namespace Formulario_Regresion_Lineal
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
            txtA1.Text = "";
            txtA2.Text = "";
            txtRecta.Text = "";
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
            chtGrafica.Series.Add("recta");
            chtGrafica.Series["recta"].ChartType = SeriesChartType.Line;
            chtGrafica.Series["recta"].BorderWidth = 4;
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
                    Gestion_Lineal gestionLineal = new Gestion_Lineal();
                    gestionLineal.X = Convert.ToString(txtX.Text);
                    gestionLineal.Y = Convert.ToString(txtY.Text);
                    gestionLineal.Insertar();
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
            Gestion_Lineal gestionLineal = new Gestion_Lineal();
            if (gestionLineal.CantidadElementos() == 0)
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
                    Gestion_Lineal gestionLineal = new Gestion_Lineal();
                    gestionLineal.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineal.X = Convert.ToString(txtX.Text);
                    gestionLineal.Y = Convert.ToString(txtY.Text);
                    gestionLineal.Modificar();
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
                    Gestion_Lineal gestionLineal = new Gestion_Lineal();
                    gestionLineal.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineal.Eliminar();
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
            RegresionLineal regresionLineal = new RegresionLineal();
            string cadenaX = "";
            string cadenaY = "";
            cadenaX = (Convert.ToString(txtX.Text) + "-").Trim();
            cadenaY = (Convert.ToString(txtY.Text) + "-").Trim();
            dtgResultado.DataSource = regresionLineal.MostrarResultado(cadenaX, cadenaY, txtPrimeraEcuacion, txtSegundaEcuacion, txtA1, txtA2, txtRecta, chtGrafica);
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
