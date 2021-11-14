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
using Negocio.Simulaciones;
using System.Drawing.Printing;

namespace Formulario_Linea_De_Espera_Caso_Dos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDistribucionYProbabilidad(cbbDTiempoEntreLlegada);
            CargarDistribucionYProbabilidad(cbbDTiempoDeServicio);
            CargarAletarorio(cbbEntrada);
            CargarAletarorio(cbbServicio);
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo() 
        {
            txtIdentificador.Text = "";
            cbbDTiempoEntreLlegada.SelectedIndex = 0;
            txtDemandaTL.Text = "";
            txtProbabilidadTL.Text = "";
            cbbDTiempoDeServicio.SelectedIndex = 0;
            txtDemandaTS.Text = "";
            txtProbabilidadTS.Text = "";
            cbbEntrada.SelectedIndex = 0;
            txtEntrada.Text = "";
            cbbServicio.SelectedIndex = 0;
            txtServicio.Text = "";
            dtgTiempoEntreLlegada.DataSource = "";
            dtgTiempoDeServicio.DataSource = "";
            dtgResultado.DataSource = "";
            dtgResultadoFinal.DataSource = "";
        }
        
        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtDemandaTL.Text=="" || txtProbabilidadTL.Text=="" || txtDemandaTS.Text=="" || txtProbabilidadTS.Text=="" || txtEntrada.Text=="" || txtServicio.Text=="")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_LineaDeEsperaCasoDos gestionLineaDeEsperaCasoDos = new Gestion_LineaDeEsperaCasoDos();
                    gestionLineaDeEsperaCasoDos.TiempoEntreLlegada = Convert.ToInt32(cbbDTiempoEntreLlegada.SelectedValue);
                    gestionLineaDeEsperaCasoDos.TiempoDeServicio = Convert.ToInt32(cbbDTiempoDeServicio.SelectedValue);
                    gestionLineaDeEsperaCasoDos.AleatorioEntrada = Convert.ToInt32(cbbEntrada.SelectedValue);
                    gestionLineaDeEsperaCasoDos.AleatorioServicio = Convert.ToInt32(cbbServicio.SelectedValue);
                    gestionLineaDeEsperaCasoDos.Insertar();
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
            Gestion_LineaDeEsperaCasoDos gestionLineaDeEsperaCasoDos = new Gestion_LineaDeEsperaCasoDos();
            if (gestionLineaDeEsperaCasoDos.CantidadElementos() == 0)
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
                    Gestion_LineaDeEsperaCasoDos gestionLineaDeEsperaCasoDos = new Gestion_LineaDeEsperaCasoDos();
                    gestionLineaDeEsperaCasoDos.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineaDeEsperaCasoDos.TiempoEntreLlegada = Convert.ToInt32(cbbDTiempoEntreLlegada.SelectedValue);
                    gestionLineaDeEsperaCasoDos.TiempoDeServicio = Convert.ToInt32(cbbDTiempoDeServicio.SelectedValue);
                    gestionLineaDeEsperaCasoDos.AleatorioEntrada = Convert.ToInt32(cbbEntrada.SelectedValue);
                    gestionLineaDeEsperaCasoDos.AleatorioServicio = Convert.ToInt32(cbbServicio.SelectedValue);
                    gestionLineaDeEsperaCasoDos.Modificar();
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
                    Gestion_LineaDeEsperaCasoDos gestionLineaDeEsperaCasoDos = new Gestion_LineaDeEsperaCasoDos();
                    gestionLineaDeEsperaCasoDos.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionLineaDeEsperaCasoDos.Eliminar();
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
            if (txtDemandaTL.Text == "" || txtProbabilidadTL.Text == "" || txtDemandaTS.Text == "" || txtProbabilidadTS.Text == "" || txtEntrada.Text == "" || txtServicio.Text == "") 
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
            Complemeto_Linea_De_Espera_Caso_Dos complementoLineaDeEsperaCasoDos = new Complemeto_Linea_De_Espera_Caso_Dos();
            LineaDeEsperaCasoDos lineaDeEsperaCasoDos = new LineaDeEsperaCasoDos();
            string entrada = "";
            string servicio = "";
            entrada = txtEntrada.Text + "-";
            servicio = txtServicio.Text + "-";
            dtgResultado.DataSource = complementoLineaDeEsperaCasoDos.MostrarResultado(entrada, servicio, dtgTiempoEntreLlegada, dtgTiempoDeServicio);
            dtgResultadoFinal.DataSource = lineaDeEsperaCasoDos.MostrarResultado(entrada, dtgResultado);
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {
            if (dtgResultadoFinal.RowCount == 0)
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
            if (dtgResultadoFinal.RowCount == 0)
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

        private void CargarDistribucionYProbabilidad(ComboBox combo)
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            combo.DataSource = gestionFrecuencias.Buscar();
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "ID";
        }

        private void CargarTiempoEntreLlegada() 
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaTL = "";
            string probabilidadTL = "";
            identificador = Convert.ToString(cbbDTiempoEntreLlegada.SelectedValue);
            txtDemandaTL.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidadTL.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaTL = txtDemandaTL.Text + "-";
            probabilidadTL = txtProbabilidadTL.Text + "-";
            dtgTiempoEntreLlegada.DataSource = monteCarloFinal.MostrarResultado(demandaTL, probabilidadTL);
        }

        private void CargarTiempoDeServicio() 
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaTS = "";
            string probabilidadTS = "";
            identificador = Convert.ToString(cbbDTiempoDeServicio.SelectedValue);
            txtDemandaTS.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidadTS.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaTS = txtDemandaTS.Text + "-";
            probabilidadTS = txtProbabilidadTS.Text + "-";
            dtgTiempoDeServicio.DataSource = monteCarloFinal.MostrarResultado(demandaTS, probabilidadTS);
        }

        private void cbbDTiempoEntreLlegada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarTiempoEntreLlegada();
        }

        private void cbbDTiempoDeServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarTiempoDeServicio();
        }

        private void CargarAletarorio(ComboBox combo)
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            combo.DataSource = gestionAleatorios.Buscar();
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "ID";
        }

        public void CargarAleatorioEntrada()
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            string identificador = "";
            identificador = Convert.ToString(cbbEntrada.SelectedValue);
            txtEntrada.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        public void CargarAleatorioServicio()
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            string identificador = "";
            identificador = Convert.ToString(cbbServicio.SelectedValue);
            txtServicio.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        private void cbbEntrada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioEntrada();
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
                CargarTiempoEntreLlegada();
                CargarTiempoDeServicio();
                CargarAleatorioEntrada();
                CargarAleatorioServicio();
                Calcular();
            }
        }
    }
}
