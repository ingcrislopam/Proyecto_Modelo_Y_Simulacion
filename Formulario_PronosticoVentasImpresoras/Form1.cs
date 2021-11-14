using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Gestiones;
using Negocio.Simulaciones;
using System.Drawing.Printing;
using Negocio.Distribuciones;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formulario_PronosticoVentasImpresoras
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

        private void Nuevo()
        {
            txtIdentificador.Text = "";
            txtNombre.Text = "";
            txtCantidadVenta.Text = "";
            txtCobro.Text = "";
            txtEvaluar.Text = "";
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtNombre.Focus();
        }

        public void NuevaGrafica()
        {
            chtGraficaCantidad.Series.Clear();
            chtGraficaCantidad.Series.Add("cantidad");
            chtGraficaCantidad.Series["cantidad"].ChartType = SeriesChartType.Spline;
            chtGraficaCantidad.Series["cantidad"].BorderWidth = 4;
            chtGraficaCosto.Series.Clear();
            chtGraficaCosto.Series.Add("costo");
            chtGraficaCosto.Series["costo"].ChartType = SeriesChartType.Spline;
            chtGraficaCosto.Series["costo"].BorderWidth = 4;
            chtGraficaCantidad.Visible = false;
            chtGraficaCosto.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCantidadVenta.Text == "" || txtCobro.Text == "" || txtEvaluar.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_PronosticosVentasImpresoras gestionPronosticosVentasImpresoras = new Gestion_PronosticosVentasImpresoras();
                    gestionPronosticosVentasImpresoras.MesPronostico = Convert.ToString(txtNombre.Text);
                    gestionPronosticosVentasImpresoras.CantidadVenta = Convert.ToString(txtCantidadVenta.Text);
                    gestionPronosticosVentasImpresoras.Cobro = Convert.ToString(txtCobro.Text);
                    gestionPronosticosVentasImpresoras.Evaluar = Convert.ToString(txtEvaluar.Text);
                    gestionPronosticosVentasImpresoras.Insertar();
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
            Gestion_PronosticosVentasImpresoras gestionPronosticosVentasImpresoras = new Gestion_PronosticosVentasImpresoras();
            if (gestionPronosticosVentasImpresoras.CantidadElementos() == 0)
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
                    Gestion_PronosticosVentasImpresoras gestionPronosticosVentasImpresoras = new Gestion_PronosticosVentasImpresoras();
                    gestionPronosticosVentasImpresoras.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPronosticosVentasImpresoras.MesPronostico = Convert.ToString(txtNombre.Text);
                    gestionPronosticosVentasImpresoras.CantidadVenta = Convert.ToString(txtCantidadVenta.Text);
                    gestionPronosticosVentasImpresoras.Cobro = Convert.ToString(txtCobro.Text);
                    gestionPronosticosVentasImpresoras.Evaluar = Convert.ToString(txtEvaluar.Text);
                    gestionPronosticosVentasImpresoras.Modificar();
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
                    Gestion_PronosticosVentasImpresoras gestionPronosticosVentasImpresoras = new Gestion_PronosticosVentasImpresoras();
                    gestionPronosticosVentasImpresoras.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPronosticosVentasImpresoras.Eliminar();
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
            if (txtNombre.Text == "" || txtEvaluar.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                Calcular();
            }
        }

        private void Calcular() 
        {
            PromedioMovilDoble promedioMovilDoble = new PromedioMovilDoble();
            int evaluar = 0;
            int n = 0;
            evaluar = Convert.ToInt32(txtEvaluar.Text);
            n = dtgCantidadYCobros.RowCount;
            dtgResultado.DataSource = promedioMovilDoble.MostrarResultado(evaluar, dtgCantidadYCobros, chtGraficaCantidad, chtGraficaCosto);
            txtCantidadVenta.Text = Convert.ToString(dtgResultado[5, n].Value);
            txtCobro.Text = Convert.ToString(dtgResultado[6, n].Value);
            chtGraficaCantidad.Visible = true;
            chtGraficaCosto.Visible = true;
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {
            if (dtgResultado.RowCount == 0)
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                Imprimir();
            }
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
            Gestion_AleatoriosVentasImpresoras gestionAleatoriosVentasImpresoras = new Gestion_AleatoriosVentasImpresoras();
            dtgCantidadYCobros.DataSource = gestionAleatoriosVentasImpresoras.Buscar();
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
