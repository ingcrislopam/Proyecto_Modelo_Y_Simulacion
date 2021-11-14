﻿using System;
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

namespace Formulario_Exponencial
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
            txtLanda.Text = "";
            dtgResultado.DataSource = "";
            NuevaGrafica();
            txtN.Focus();
        }

        public void NuevaGrafica()
        {
            chtGrafica.Series.Clear();
            chtGrafica.Series.Add("ri");
            chtGrafica.Series["ri"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["ri"].BorderWidth = 4;
            chtGrafica.Series.Add("t");
            chtGrafica.Series["t"].ChartType = SeriesChartType.Spline;
            chtGrafica.Series["t"].BorderWidth = 4;
            chtGrafica.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "" || txtLanda.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_Exponencial gestionExponencial = new Gestion_Exponencial();
                    gestionExponencial.IDCongruencial.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionExponencial.Landa = Convert.ToDouble(txtLanda.Text);
                    gestionExponencial.Insertar();
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
            Gestion_Exponencial gestionExponencial = new Gestion_Exponencial();
            if (gestionExponencial.CantidadElementos() == 0) 
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
                    Gestion_Exponencial gestionExponencial = new Gestion_Exponencial();
                    gestionExponencial.ID = Convert.ToInt32(txtIdentificadorE.Text);
                    gestionExponencial.Landa = Convert.ToDouble(txtLanda.Text);
                    gestionExponencial.Modificar();
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
                    Gestion_Exponencial gestionExponencial = new Gestion_Exponencial();
                    gestionExponencial.ID = Convert.ToInt32(txtIdentificadorE.Text);
                    gestionExponencial.Eliminar();
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
            if (txtN.Text == "" || txtM.Text == "" || txtXn.Text == "" || txtA.Text == "" || txtC.Text == "" || txtLanda.Text == "") 
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
            Exponencial exponencial = new Exponencial();
            dtgResultado.DataSource = exponencial.MostrarResultado(Convert.ToInt32(txtN.Text), Convert.ToInt32(txtM.Text), Convert.ToInt32(txtXn.Text), Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text), Convert.ToDouble(txtLanda.Text), chtGrafica);
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
