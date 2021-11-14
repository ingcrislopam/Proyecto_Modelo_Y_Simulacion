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

namespace Formulario_Variable_Aleatoria
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
            txtPrimerParametro.Text = "";
            txtSegundoParametro.Text = "";
            txtFuncion.Text = "";
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtN.Focus();
        }

        public void NuevaGrafica()
        {
            chtGrafica.Series.Clear();
            chtGrafica.Series.Add("funcion");
            chtGrafica.Series["funcion"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["funcion"].BorderWidth = 4;
            chtGrafica.Series.Add("integrar");
            chtGrafica.Series["integrar"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["integrar"].BorderWidth = 4;
            chtGrafica.Series.Add("inversa");
            chtGrafica.Series["inversa"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["inversa"].BorderWidth = 4;
            chtGrafica.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "" || txtPrimerParametro.Text == "" || txtSegundoParametro.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_Aleatorio gestionAleatorio = new Gestion_Aleatorio();
                    gestionAleatorio.IdCongruencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionAleatorio.PrimerParametro = Convert.ToString(txtPrimerParametro.Text);
                    gestionAleatorio.SegundoParametro = Convert.ToString(txtSegundoParametro.Text);
                    if (Convert.ToDouble(txtPrimerParametro.Text) == 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtSegundoParametro.Text) == 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) >= 0 && Convert.ToDouble(txtSegundoParametro.Text) >= 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)+" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) >= 0 && Convert.ToDouble(txtSegundoParametro.Text) < 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) < 0 && Convert.ToDouble(txtSegundoParametro.Text) >= 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)+" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) < 0 && Convert.ToDouble(txtSegundoParametro.Text) < 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    //gestionAleatorio.Funcion = ("" + Convert.ToString(txtPrimerParametro.Text) + "" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    gestionAleatorio.Funcion = Convert.ToString(txtFuncion.Text);
                    gestionAleatorio.Insertar();
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
            Gestion_Aleatorio gestionAleatorio = new Gestion_Aleatorio();
            if (gestionAleatorio.CantidadElementos() == 0)
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
                    Gestion_Aleatorio gestionAleatorio = new Gestion_Aleatorio();
                    gestionAleatorio.ID = Convert.ToInt32(txtIdentificadorE.Text);
                    gestionAleatorio.PrimerParametro = Convert.ToString(txtPrimerParametro.Text);
                    gestionAleatorio.SegundoParametro = Convert.ToString(txtSegundoParametro.Text);
                    if (Convert.ToDouble(txtPrimerParametro.Text) == 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtSegundoParametro.Text) == 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) >= 0 && Convert.ToDouble(txtSegundoParametro.Text) >= 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)+" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) >= 0 && Convert.ToDouble(txtSegundoParametro.Text) < 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) < 0 && Convert.ToDouble(txtSegundoParametro.Text) >= 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)+" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    if (Convert.ToDouble(txtPrimerParametro.Text) < 0 && Convert.ToDouble(txtSegundoParametro.Text) < 0)
                    {
                        txtFuncion.Text = ("" + Convert.ToString(txtPrimerParametro.Text) + "(x)" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    }
                    //gestionAleatorio.Funcion = ("" + Convert.ToString(txtPrimerParametro.Text) + "" + Convert.ToString(txtSegundoParametro.Text) + "").Trim();
                    gestionAleatorio.Funcion = Convert.ToString(txtFuncion.Text);
                    gestionAleatorio.Modificar();
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
                    Gestion_Aleatorio gestionAleatorio = new Gestion_Aleatorio();
                    gestionAleatorio.ID = Convert.ToInt32(txtIdentificadorE.Text);
                    gestionAleatorio.Eliminar();
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
            if (txtN.Text == "" || txtM.Text == "" || txtXn.Text == "" || txtA.Text == "" || txtC.Text == "" || txtPrimerParametro.Text == "" || txtSegundoParametro.Text == "")
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
            string primerPar = "";
            string segundoPar = "";
            string funcion = "";
            primerPar = Convert.ToString(txtPrimerParametro.Text);
            segundoPar = Convert.ToString(txtSegundoParametro.Text);

            if (Convert.ToDouble(primerPar) == 0)
            {
                funcion = ("" + Convert.ToString(segundoPar) + "").Trim();
            }
            if (Convert.ToDouble(segundoPar) == 0)
            {
                funcion = ("" + Convert.ToString(primerPar) + "(x)").Trim();
            }
            if (Convert.ToDouble(primerPar) >= 0 && Convert.ToDouble(segundoPar) >= 0)
            {
                funcion = ("" + Convert.ToString(primerPar) + "(x)+" + Convert.ToString(segundoPar) + "").Trim();
            }
            if (Convert.ToDouble(primerPar) >= 0 && Convert.ToDouble(segundoPar) < 0)
            {
                funcion = ("" + Convert.ToString(primerPar) + "(x)" + Convert.ToString(segundoPar) + "").Trim();
            }
            if (Convert.ToDouble(primerPar) < 0 && Convert.ToDouble(segundoPar) >= 0)
            {
                funcion = ("" + Convert.ToString(primerPar) + "(x)+" + Convert.ToString(segundoPar) + "").Trim();
            }
            if (Convert.ToDouble(primerPar) < 0 && Convert.ToDouble(segundoPar) < 0)
            {
                funcion = ("" + Convert.ToString(primerPar) + "(x)" + Convert.ToString(segundoPar) + "").Trim();
            }
            //funcion = ("" + primerPar + "(x)" + segundoPar + "");
            txtFuncion.Text = funcion.Trim();
            VariableAleatoria variableAleatoria = new VariableAleatoria();
            dtgResultado.DataSource = variableAleatoria.MostrarResultado(Convert.ToInt32(txtN.Text), Convert.ToInt32(txtM.Text), Convert.ToInt32(txtXn.Text), Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text), primerPar, segundoPar, chtGrafica);
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
