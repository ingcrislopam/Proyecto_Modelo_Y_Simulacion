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

namespace Formulario_Politica_De_Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDistribucionYProbabilidad(cbbDistribucion);
            CargarDistribucionYProbabilidad(cbbTiempoDeEntrega);
            CargarAleatorios(cbbADistribucion);
            CargarAleatorios(cbbATiempoDeEntrega);
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo() 
        {
            txtIdentificador.Text = "";
            cbbDistribucion.SelectedIndex = 0;
            cbbTiempoDeEntrega.SelectedIndex = 0;
            cbbADistribucion.SelectedIndex = 0;
            cbbATiempoDeEntrega.SelectedIndex = 0;
            txtDemandaD.Text = "";
            txtProbabilidadD.Text = "";
            txtDemandaT.Text = "";
            txtProbabilidadT.Text = "";
            txtAleatoriosD.Text = "";
            txtAleatoriosT.Text = "";
            txtCantidadOrdenar.Text = "";
            txtPuntoDeReorden.Text = "";
            txtCostoPorFaltantes.Text = "";
            txtCostoDeMantenimiento.Text = "";
            txtCostoDeOrdenar.Text = "";
            txtInventarioInicial.Text = "";
            dtgDistribucion.DataSource = "";
            dtgTiempoDeEntrega.DataSource = "";
            dtgResultado.DataSource = "";
            cbbDistribucion.Focus();
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtDemandaD.Text == "" || txtProbabilidadD.Text == "" || txtDemandaT.Text == "" || txtProbabilidadT.Text == "" || txtAleatoriosD.Text == "" || txtAleatoriosT.Text == "" || txtCantidadOrdenar.Text == "" || txtPuntoDeReorden.Text == "" || txtCostoPorFaltantes.Text == "" || txtCostoDeMantenimiento.Text == "" || txtCostoDeOrdenar.Text == "" || txtInventarioInicial.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_PoliticaInventario gestionPoliticaDeInventario = new Gestion_PoliticaInventario();
                    gestionPoliticaDeInventario.Distribucion = Convert.ToInt32(cbbDistribucion.SelectedValue);
                    gestionPoliticaDeInventario.TiempoDeEntrega = Convert.ToInt32(cbbTiempoDeEntrega.SelectedValue);
                    gestionPoliticaDeInventario.AleatorioDistribucion = Convert.ToInt32(cbbADistribucion.SelectedValue);
                    gestionPoliticaDeInventario.AleatorioTiempoDeEntrega = Convert.ToInt32(cbbATiempoDeEntrega.SelectedValue);
                    gestionPoliticaDeInventario.CantidadOrdenar = Convert.ToString(txtCantidadOrdenar.Text);
                    gestionPoliticaDeInventario.PuntoDeReorden = Convert.ToString(txtPuntoDeReorden.Text);
                    gestionPoliticaDeInventario.CostoPorFaltantes = Convert.ToString(txtCostoPorFaltantes.Text);
                    gestionPoliticaDeInventario.CostoMantenimiento = Convert.ToString(txtCostoDeMantenimiento.Text);
                    gestionPoliticaDeInventario.CostoDeOrdenar = Convert.ToString(txtCostoDeOrdenar.Text);
                    gestionPoliticaDeInventario.InventarioInicial = Convert.ToString(txtInventarioInicial.Text);
                    gestionPoliticaDeInventario.Insertar();
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
            Gestion_PoliticaInventario gestionPoliticaDeInventario = new Gestion_PoliticaInventario();
            if (gestionPoliticaDeInventario.CantidadElementos() == 0)
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
                    Gestion_PoliticaInventario gestionPoliticaDeInventario = new Gestion_PoliticaInventario();
                    gestionPoliticaDeInventario.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPoliticaDeInventario.Distribucion = Convert.ToInt32(cbbDistribucion.SelectedValue);
                    gestionPoliticaDeInventario.TiempoDeEntrega = Convert.ToInt32(cbbTiempoDeEntrega.SelectedValue);
                    gestionPoliticaDeInventario.AleatorioDistribucion = Convert.ToInt32(cbbADistribucion.SelectedValue);
                    gestionPoliticaDeInventario.AleatorioTiempoDeEntrega = Convert.ToInt32(cbbATiempoDeEntrega.SelectedValue);
                    gestionPoliticaDeInventario.CantidadOrdenar = Convert.ToString(txtCantidadOrdenar.Text);
                    gestionPoliticaDeInventario.PuntoDeReorden = Convert.ToString(txtPuntoDeReorden.Text);
                    gestionPoliticaDeInventario.CostoPorFaltantes = Convert.ToString(txtCostoPorFaltantes.Text);
                    gestionPoliticaDeInventario.CostoMantenimiento = Convert.ToString(txtCostoDeMantenimiento.Text);
                    gestionPoliticaDeInventario.CostoDeOrdenar = Convert.ToString(txtCostoDeOrdenar.Text);
                    gestionPoliticaDeInventario.InventarioInicial = Convert.ToString(txtInventarioInicial.Text);
                    gestionPoliticaDeInventario.Modificar();
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
                    Gestion_PoliticaInventario gestionPoliticaDeInventario = new Gestion_PoliticaInventario();
                    gestionPoliticaDeInventario.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionPoliticaDeInventario.Eliminar();
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
            if (txtDemandaD.Text == "" || txtProbabilidadD.Text == "" || txtDemandaT.Text == "" || txtProbabilidadT.Text == "" || txtAleatoriosD.Text == "" || txtAleatoriosT.Text == "" || txtCantidadOrdenar.Text == "" || txtPuntoDeReorden.Text == "" || txtCostoPorFaltantes.Text == "" || txtCostoDeMantenimiento.Text == "" || txtCostoDeOrdenar.Text == "" || txtInventarioInicial.Text == "")
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
            PoliticaDeInventario politicaDeInventario = new PoliticaDeInventario();
            string aleatorioDistribucion = "";
            string aleatorioTiempoDeEntrega = "";
            double cantidadOrdenar = 0;
            double puntoDeReorden = 0;
            double costoPorFaltantes = 0;
            double costoMantenimiento = 0;
            double costoOrdenar = 0;
            double inventarioInicial = 0;
            aleatorioDistribucion = txtAleatoriosD.Text + "-";
            aleatorioTiempoDeEntrega = txtAleatoriosT.Text + "-";
            cantidadOrdenar = Convert.ToDouble(txtCantidadOrdenar.Text);
            puntoDeReorden = Convert.ToDouble(txtPuntoDeReorden.Text);
            costoPorFaltantes = Convert.ToDouble(txtCostoPorFaltantes.Text);
            costoMantenimiento = Convert.ToDouble(txtCostoDeMantenimiento.Text);
            costoOrdenar = Convert.ToDouble(txtCostoDeOrdenar.Text);
            inventarioInicial = Convert.ToDouble(txtInventarioInicial.Text);
            dtgResultado.DataSource = politicaDeInventario.MostrarResultado(aleatorioDistribucion, aleatorioTiempoDeEntrega, cantidadOrdenar, puntoDeReorden, costoPorFaltantes, costoMantenimiento, costoOrdenar, inventarioInicial, dtgDistribucion, dtgTiempoDeEntrega);
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

        private void CargarDistribucionYProbabilidad(ComboBox combo)
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            combo.DataSource = gestionFrecuencias.Buscar();
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "ID";
        }

        private void CargarAleatorios(ComboBox combo)
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            combo.DataSource = gestionAleatorios.Buscar();
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "ID";
        }

        public void CargarDistribucion()
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaD = "";
            string probabilidadD = "";
            identificador = Convert.ToString(cbbDistribucion.SelectedValue);
            txtDemandaD.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidadD.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaD = txtDemandaD.Text + "-";
            probabilidadD = txtProbabilidadD.Text + "-";
            dtgDistribucion.DataSource = monteCarloFinal.MostrarResultado(demandaD, probabilidadD);
        }

        public void CargarTiempoDeEntrega()
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaT = "";
            string probabilidadT = "";
            identificador = Convert.ToString(cbbTiempoDeEntrega.SelectedValue);
            txtDemandaT.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidadT.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaT = txtDemandaT.Text + "-";
            probabilidadT = txtProbabilidadT.Text + "-";
            dtgTiempoDeEntrega.DataSource = monteCarloFinal.MostrarResultado(demandaT, probabilidadT);
        }

        public void CargarAleatorioDistribucion()
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            string identificador = "";
            identificador = Convert.ToString(cbbADistribucion.SelectedValue);
            txtAleatoriosD.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        public void CargarAleatorioTiempoDeEntrega()
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            string identificador = "";
            identificador = Convert.ToString(cbbATiempoDeEntrega.SelectedValue);
            txtAleatoriosT.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        private void cbbDistribucion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDistribucion();
        }

        private void cbbTiempoDeEntrega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarTiempoDeEntrega();
        }

        private void cbbADistribucion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioDistribucion();
        }

        private void cbbATiempoDeEntrega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioTiempoDeEntrega();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "")
            {

            }
            else 
            {
                CargarDistribucion();
                CargarTiempoDeEntrega();
                CargarAleatorioDistribucion();
                CargarAleatorioTiempoDeEntrega();
                Calcular();
            }
        }
    }
}
