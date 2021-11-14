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

namespace Formulario_Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarAletarorio(cbbId1);
            CargarAletarorio(cbbId2);
            CargarMonteCarlo(cbbId1M);
            CargarMonteCarlo(cbbId2M);
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tInsertar_Click(object sender, EventArgs e)
        {

        }

        private void tBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tModificar_Click(object sender, EventArgs e)
        {

        }

        private void tEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tCalcular_Click(object sender, EventArgs e)
        {
            PoliticaInventario politicaInventario = new PoliticaInventario();
            string demandas = "";
            string demandas2 = "";
            demandas = txtDemandas1.Text + "-";
            demandas2 = txtDemandas2.Text + "-";
            dtgResultado.DataSource = politicaInventario.MostrarResultado(demandas, demandas2, Convert.ToInt32(txtN1.Text), Convert.ToDouble(txtCantidadOrdenar.Text), Convert.ToDouble(txtPuntoDeReorden.Text), Convert.ToDouble(txtCostosPorFaltantes.Text), Convert.ToDouble(txtCostoMantenimiento.Text), Convert.ToDouble(txtCostoOrdenar.Text), Convert.ToDouble(txtInventarioInicial.Text), dtgResultado1, dtgResultado2, dtgResultado1M, dtgResultado2M);
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {

        }

        private void tExportar_Click(object sender, EventArgs e)
        {

        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarAletarorio(ComboBox combo)
        {
            Gestion_Congruencial gestionCongruencial = new Gestion_Congruencial();
            combo.DataSource = gestionCongruencial.Buscar();
            combo.DisplayMember = "Aletarorio #" + "ID";
            combo.ValueMember = "ID";
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

        private void cbbId1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioUno();
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

        private void cbbId2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioDos();
        }

        public void CargarMonteCarlo(ComboBox combo) 
        {
            Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
            combo.DataSource = gestionMonteCarlo.BuscarMonteCarlo();
            combo.DisplayMember = "ID";
            combo.ValueMember = "ID";
        }

        public void CargarMonteCarloUno() 
        {
            Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
            MonteCarlo monteCarlo = new MonteCarlo();
            string identificador = "";
            string demandas = "";
            string ocurrencias = "";
            identificador = Convert.ToString(cbbId1M.SelectedValue);
            txtDemandas1.Text = Convert.ToString(gestionMonteCarlo.RetornarValor("Demandas", identificador));
            txtOcurrencias1.Text = Convert.ToString(gestionMonteCarlo.RetornarValor("Ocurrencias", identificador));
            demandas = txtDemandas1.Text + "-";
            ocurrencias = txtOcurrencias1.Text + "-";
            dtgResultado1M.DataSource = monteCarlo.MostrarResultadoSegundaOpcion(demandas, ocurrencias);
        }

        private void cbbId1M_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarMonteCarloUno();
        }

        public void CargarMonteCarloDos() 
        {
            Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
            MonteCarlo monteCarlo = new MonteCarlo();
            string identificador = "";
            string demandas = "";
            string ocurrencias = "";
            identificador = Convert.ToString(cbbId2M.SelectedValue);
            txtDemandas2.Text = Convert.ToString(gestionMonteCarlo.RetornarValor("Demandas", identificador));
            txtOcurrencias2.Text = Convert.ToString(gestionMonteCarlo.RetornarValor("Ocurrencias", identificador));
            demandas = txtDemandas2.Text + "-";
            ocurrencias = txtOcurrencias2.Text + "-";
            dtgResultado2M.DataSource = monteCarlo.MostrarResultadoSegundaOpcion(demandas, ocurrencias);
        }

        private void cbbId2M_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarMonteCarloDos();
        }
    }
}
