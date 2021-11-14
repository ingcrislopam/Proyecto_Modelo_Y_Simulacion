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
using Negocio.Distribuciones;
using System.Drawing.Printing;

namespace Formulario_Linea_De_Espera_Un_Canal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarAletarorio(cbbId1);
            CargarAletarorio(cbbId2);
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo() 
        {
            cbbId1.SelectedIndex = 0;
            cbbId2.SelectedIndex = 0;
            txtN1.Text = "";
            txtN2.Text = "";
            txtM1.Text = "";
            txtM2.Text = "";
            txtXn1.Text = "";
            txtXn2.Text = "";
            txtA1.Text = "";
            txtA2.Text = "";
            txtC1.Text = "";
            txtC2.Text = "";
            txtIdentificador.Text = "";
            txtMediaEntreLlegada.Text = "";
            txtMediaDeServicio.Text = "";
            dtgResultado1.DataSource = "";
            dtgResultado2.DataSource = "";
            dtgResultadoFinal.DataSource = "";
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text == "" || txtN2.Text == "" || txtMediaEntreLlegada.Text == "" || txtMediaDeServicio.Text == "") 
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_LineaEsperaUnCanal gestionLineaEsperaUnCanal = new Gestion_LineaEsperaUnCanal();
                    gestionLineaEsperaUnCanal.IdLlegada = Convert.ToInt32(cbbId1.SelectedValue);
                    gestionLineaEsperaUnCanal.IdServicio = Convert.ToInt32(cbbId2.SelectedValue);
                    gestionLineaEsperaUnCanal.MediaTiempoEntreLlegada = txtMediaEntreLlegada.Text;
                    gestionLineaEsperaUnCanal.MediaTiempoDeServicio = txtMediaDeServicio.Text;
                    gestionLineaEsperaUnCanal.Insertar();
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
            Gestion_LineaEsperaUnCanal gestionLineaEsperaUnCanal = new Gestion_LineaEsperaUnCanal();
            if (gestionLineaEsperaUnCanal.CantidadElementos() == 0) 
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
                    Gestion_LineaEsperaUnCanal gestionLineaEsperaUnCanal = new Gestion_LineaEsperaUnCanal();
                    gestionLineaEsperaUnCanal.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineaEsperaUnCanal.IdLlegada = Convert.ToInt32(cbbId1.SelectedValue);
                    gestionLineaEsperaUnCanal.IdServicio = Convert.ToInt32(cbbId2.SelectedValue);
                    gestionLineaEsperaUnCanal.MediaTiempoEntreLlegada = txtMediaEntreLlegada.Text;
                    gestionLineaEsperaUnCanal.MediaTiempoDeServicio = txtMediaDeServicio.Text;
                    gestionLineaEsperaUnCanal.Modificar();
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
                    Gestion_LineaEsperaUnCanal gestionLineaEsperaUnCanal = new Gestion_LineaEsperaUnCanal();
                    gestionLineaEsperaUnCanal.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineaEsperaUnCanal.Eliminar();
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
            if (txtN1.Text == "" || txtN2.Text == "" || txtMediaEntreLlegada.Text == "" || txtMediaDeServicio.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                if (txtN1.Text == txtN2.Text) 
                {
                    Calcular();
                }
                else 
                {
                    MessageBox.Show("No se puede realizar esta operación");
                }
            }
        }

        public void Calcular() 
        {
            LineasDeEsperaUnCanal lineasDeEsperaUnCanal = new LineasDeEsperaUnCanal();
            dtgResultadoFinal.DataSource = lineasDeEsperaUnCanal.MostrarResultado(Convert.ToInt32(txtN1.Text), Convert.ToDouble(txtMediaEntreLlegada.Text), Convert.ToDouble(txtMediaDeServicio.Text), dtgResultado1, dtgResultado2);
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
            if (dtgResultadoFinal.RowCount == 0)
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                Exportar exportar = new Exportar();
                exportar.ExportarDataGridViewExcel(dtgResultadoFinal);
            }
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarAletarorio(ComboBox combo) 
        {
            Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
            combo.DataSource = gestionCongruencial.Buscar();
            combo.DisplayMember = "Aletarorio #"+"ID";
            combo.ValueMember = "ID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "") 
            {
 
            }
            else 
            {
                CargarAleatorioUno();
                CargarAleatorioDos();
                Calcular();
            }
        }

        private void cbbId1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioUno();
        }

        public void CargarAleatorioUno() 
        {
            Gestion_LineaEsperaUnCanal gestionLineaEsperaUnCanal = new Gestion_LineaEsperaUnCanal();
            CongruencialLineal congruencialLineal = new CongruencialLineal();
            string identificador = "";
            identificador = Convert.ToString(cbbId1.SelectedValue);
            txtN1.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("N", identificador));
            txtM1.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("M", identificador));
            txtXn1.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("Xn", identificador));
            txtA1.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("A", identificador));
            txtC1.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("C", identificador));
            dtgResultado1.DataSource = congruencialLineal.MostrarResultadoSegundaOpcion(Convert.ToInt32(txtN1.Text), Convert.ToInt32(txtM1.Text), Convert.ToInt32(txtXn1.Text), Convert.ToInt32(txtA1.Text), Convert.ToInt32(txtC1.Text));
        }

        private void cbbId2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioDos();
        }

        public void CargarAleatorioDos() 
        {
            Gestion_LineaEsperaUnCanal gestionLineaEsperaUnCanal = new Gestion_LineaEsperaUnCanal();
            CongruencialLineal congruencialLineal = new CongruencialLineal();
            string identificador = "";
            identificador = Convert.ToString(cbbId2.SelectedValue);
            txtN2.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("N", identificador));
            txtM2.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("M", identificador));
            txtXn2.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("Xn", identificador));
            txtA2.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("A", identificador));
            txtC2.Text = Convert.ToString(gestionLineaEsperaUnCanal.RetornarValor("C", identificador));
            dtgResultado2.DataSource = congruencialLineal.MostrarResultadoSegundaOpcion(Convert.ToInt32(txtN2.Text), Convert.ToInt32(txtM2.Text), Convert.ToInt32(txtXn2.Text), Convert.ToInt32(txtA2.Text), Convert.ToInt32(txtC2.Text));
        }
    }
}
