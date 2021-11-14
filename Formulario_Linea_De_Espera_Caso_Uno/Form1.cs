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
using Negocio.Distribuciones;
using System.Drawing.Printing;

namespace Formulario_Linea_De_Espera_Caso_Uno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarAletarorio(cbbLlegada);
            CargarAletarorio(cbbServicio);
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo() 
        {
            txtIdentificador.Text = "";
            cbbLlegada.SelectedIndex = 0;
            cbbServicio.SelectedIndex = 0;
            txtLlegada.Text = "";
            txtServicio.Text = "";
            txtTiempoEntreLlegada.Text = "";
            txtTiempoDeServicio.Text = "";
            dtgResultado.DataSource = "";
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtLlegada.Text == "" || txtServicio.Text == "" || txtTiempoEntreLlegada.Text == "" || txtTiempoDeServicio.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_LineaDeEsperaCasoUno gestionLineaDeEsperaCasoUno = new Gestion_LineaDeEsperaCasoUno();
                    gestionLineaDeEsperaCasoUno.Llegada = Convert.ToInt32(cbbLlegada.SelectedValue);
                    gestionLineaDeEsperaCasoUno.Servicio = Convert.ToInt32(cbbServicio.SelectedValue);
                    gestionLineaDeEsperaCasoUno.TiempoEntreLlegada = Convert.ToString(txtTiempoEntreLlegada.Text);
                    gestionLineaDeEsperaCasoUno.TiempoDeServicio = Convert.ToString(txtTiempoDeServicio.Text);
                    gestionLineaDeEsperaCasoUno.Insertar();
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
            Gestion_LineaDeEsperaCasoUno gestionLineaDeEsperaCasoUno = new Gestion_LineaDeEsperaCasoUno();
            if (gestionLineaDeEsperaCasoUno.CantidadElementos() == 0)
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
                    Gestion_LineaDeEsperaCasoUno gestionLineaDeEsperaCasoUno = new Gestion_LineaDeEsperaCasoUno();
                    gestionLineaDeEsperaCasoUno.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineaDeEsperaCasoUno.Llegada = Convert.ToInt32(cbbLlegada.SelectedValue);
                    gestionLineaDeEsperaCasoUno.Servicio = Convert.ToInt32(cbbServicio.SelectedValue);
                    gestionLineaDeEsperaCasoUno.TiempoEntreLlegada = Convert.ToString(txtTiempoEntreLlegada.Text);
                    gestionLineaDeEsperaCasoUno.TiempoDeServicio = Convert.ToString(txtTiempoDeServicio.Text);
                    gestionLineaDeEsperaCasoUno.Modificar();
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
                    Gestion_LineaDeEsperaCasoUno gestionLineaDeEsperaCasoUno = new Gestion_LineaDeEsperaCasoUno();
                    gestionLineaDeEsperaCasoUno.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineaDeEsperaCasoUno.Eliminar();
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
            if (txtLlegada.Text == "" || txtServicio.Text == "" || txtTiempoEntreLlegada.Text == "" || txtTiempoDeServicio.Text == "") 
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
            string llegada = "";
            string servicio = "";
            double tiempoEntreLlegada = 0;
            double tiempoDeServicio = 0;
            llegada = txtLlegada.Text + "-";
            servicio = txtServicio.Text + "-";
            tiempoEntreLlegada = Convert.ToDouble(txtTiempoEntreLlegada.Text);
            tiempoDeServicio = Convert.ToDouble(txtTiempoDeServicio.Text);
            LineaDeEsperaCasoUno lineaDeEsperaCasoUno = new LineaDeEsperaCasoUno();
            dtgResultado.DataSource = lineaDeEsperaCasoUno.MostrarResultado(llegada, servicio, tiempoEntreLlegada, tiempoDeServicio);
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

        private void CargarAletarorio(ComboBox combo)
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            combo.DataSource = gestionAleatorios.Buscar();
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "ID";
        }

        public void CargarAleatorioLlegada()
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            string identificador = "";
            identificador = Convert.ToString(cbbLlegada.SelectedValue);
            txtLlegada.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        public void CargarAleatorioServicio() 
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            string identificador = "";
            identificador = Convert.ToString(cbbServicio.SelectedValue);
            txtServicio.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        private void cbbLlegada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioLlegada();
        }

        private void cbbServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioServicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "")
            {

            }
            else 
            {
                CargarAleatorioLlegada();
                CargarAleatorioServicio();
                Calcular();
            }
        }
    }
}
