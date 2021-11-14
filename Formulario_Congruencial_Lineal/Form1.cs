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
using System.Drawing.Printing;
using Microsoft.VisualBasic.PowerPacks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formulario_Congruencial_Lineal
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
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtN.Focus();
        }

        public void NuevaGrafica() 
        {
            chtGrafica.Series.Clear();
            chtGrafica.Series.Add("congruencial");
            chtGrafica.Series["congruencial"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["congruencial"].BorderWidth = 4;
            chtGrafica.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "" || txtM.Text == "" || txtXn.Text == "" || txtA.Text == "" || txtC.Text == "") 
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
                    gestionCongruencial.N = Convert.ToInt32(txtN.Text);
                    gestionCongruencial.M = Convert.ToInt32(txtM.Text);
                    gestionCongruencial.Xn = Convert.ToInt32(txtXn.Text);
                    gestionCongruencial.A = Convert.ToInt32(txtA.Text);
                    gestionCongruencial.C = Convert.ToInt32(txtC.Text);
                    gestionCongruencial.Insertar();
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
            Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
            if (gestionCongruencial.CantidadElementos() == 0) 
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
                    Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
                    gestionCongruencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionCongruencial.N = Convert.ToInt32(txtN.Text);
                    gestionCongruencial.M = Convert.ToInt32(txtM.Text);
                    gestionCongruencial.Xn = Convert.ToInt32(txtXn.Text);
                    gestionCongruencial.A = Convert.ToInt32(txtA.Text);
                    gestionCongruencial.C = Convert.ToInt32(txtC.Text);
                    gestionCongruencial.Modificar();
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
                    Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
                    gestionCongruencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionCongruencial.Eliminar();
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
            if (txtN.Text == "" || txtM.Text == "" || txtXn.Text == "" || txtA.Text == "" || txtC.Text == "") 
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
            CongruencialLineal congruencialLineal = new CongruencialLineal();
            dtgResultado.DataSource = congruencialLineal.MostrarResultado(Convert.ToInt32(txtN.Text), Convert.ToInt32(txtM.Text), Convert.ToInt32(txtXn.Text), Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text), chtGrafica);
            chtGrafica.Visible = true;
        }

        private void Imprimir() 
        {
            this.printForm1.PrintAction = PrintAction.PrintToPreview;
            this.printForm1.Print();
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
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
