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

namespace Formulario_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDistribucion(cbbActividad1);
            CargarDistribucion(cbbActividad2);
            CargarDistribucion(cbbActividad3);
            CargarDistribucion(cbbActividad4);
            CargarAletarorio(cbbAleatorio);
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo() 
        {
            cbbActividad1.SelectedIndex = 0;
            cbbActividad2.SelectedIndex = 0;
            cbbActividad3.SelectedIndex = 0;
            cbbActividad4.SelectedIndex = 0;
            cbbAleatorio.SelectedIndex = 0;
            txtIdentificador.Text = "";
            txtDemanda1.Text = "";
            txtProbabilidad1.Text = "";
            txtDemanda2.Text = "";
            txtProbabilidad2.Text = "";
            txtDemanda3.Text = "";
            txtProbabilidad3.Text = "";
            txtDemanda4.Text = "";
            txtProbabilidad4.Text = "";
            txtLlegada.Text = "";
            dtgResultado1.DataSource = "";
            dtgResultado2.DataSource = "";
            dtgResultado3.DataSource = "";
            dtgResultado4.DataSource = "";
            dtgResultado.DataSource = "";
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtDemanda1.Text == "" || txtProbabilidad1.Text == "" || txtDemanda2.Text == "" || txtProbabilidad2.Text == "" || txtDemanda3.Text == "" || txtProbabilidad3.Text == "" || txtDemanda4.Text == "" || txtProbabilidad4.Text == "" || txtLlegada.Text == "") 
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_Proyecto gestionProyecto = new Gestion_Proyecto();
                    gestionProyecto.IdActividadUno = Convert.ToInt32(cbbActividad1.SelectedValue);
                    gestionProyecto.IdActividadDos = Convert.ToInt32(cbbActividad2.SelectedValue);
                    gestionProyecto.IdActividadTres = Convert.ToInt32(cbbActividad3.SelectedValue);
                    gestionProyecto.IdActividadCuatro = Convert.ToInt32(cbbActividad4.SelectedValue);
                    gestionProyecto.IdAleatorio = Convert.ToInt32(cbbAleatorio.SelectedValue);
                    gestionProyecto.Insertar();
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
            Gestion_Proyecto gestionProyecto = new Gestion_Proyecto();
            if (gestionProyecto.CantidadElementos() == 0)
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
                    Gestion_Proyecto gestionProyecto = new Gestion_Proyecto();
                    gestionProyecto.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionProyecto.IdActividadUno = Convert.ToInt32(cbbActividad1.SelectedValue);
                    gestionProyecto.IdActividadDos = Convert.ToInt32(cbbActividad2.SelectedValue);
                    gestionProyecto.IdActividadTres = Convert.ToInt32(cbbActividad3.SelectedValue);
                    gestionProyecto.IdActividadCuatro = Convert.ToInt32(cbbActividad4.SelectedValue);
                    gestionProyecto.IdAleatorio = Convert.ToInt32(cbbAleatorio.SelectedValue);
                    gestionProyecto.Modificar();
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
                    Gestion_Proyecto gestionProyecto = new Gestion_Proyecto();
                    gestionProyecto.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionProyecto.Eliminar();
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
            if (txtDemanda1.Text == "" || txtProbabilidad1.Text == "" || txtDemanda2.Text == "" || txtProbabilidad2.Text == "" || txtDemanda3.Text == "" || txtProbabilidad3.Text == "" || txtDemanda4.Text == "" || txtProbabilidad4.Text == "" || txtLlegada.Text == "")
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
            Proyecto proyecto = new Proyecto();
            string cadena = "";
            cadena = txtLlegada.Text + "-";
            dtgResultado.DataSource = proyecto.MostrarResultado(cadena, dtgResultado1, dtgResultado2, dtgResultado3, dtgResultado4);
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

        private void CargarDistribucion(ComboBox combo)
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            combo.DataSource = gestionFrecuencias.Buscar();
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "ID";
        }

        private void CargarActividad1()
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaTL = "";
            string probabilidadTL = "";
            identificador = Convert.ToString(cbbActividad1.SelectedValue);
            txtDemanda1.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidad1.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaTL = txtDemanda1.Text + "-";
            probabilidadTL = txtProbabilidad1.Text + "-";
            dtgResultado1.DataSource = monteCarloFinal.MostrarResultado(demandaTL, probabilidadTL);
        }

        private void CargarActividad2()
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaTL = "";
            string probabilidadTL = "";
            identificador = Convert.ToString(cbbActividad2.SelectedValue);
            txtDemanda2.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidad2.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaTL = txtDemanda2.Text + "-";
            probabilidadTL = txtProbabilidad2.Text + "-";
            dtgResultado2.DataSource = monteCarloFinal.MostrarResultado(demandaTL, probabilidadTL);
        }

        private void CargarActividad3()
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaTL = "";
            string probabilidadTL = "";
            identificador = Convert.ToString(cbbActividad3.SelectedValue);
            txtDemanda3.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidad3.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaTL = txtDemanda3.Text + "-";
            probabilidadTL = txtProbabilidad3.Text + "-";
            dtgResultado3.DataSource = monteCarloFinal.MostrarResultado(demandaTL, probabilidadTL);
        }

        private void CargarActividad4()
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            MonteCarloFinal monteCarloFinal = new MonteCarloFinal();
            string identificador = "";
            string demandaTL = "";
            string probabilidadTL = "";
            identificador = Convert.ToString(cbbActividad4.SelectedValue);
            txtDemanda4.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaDemandas", identificador));
            txtProbabilidad4.Text = Convert.ToString(gestionFrecuencias.RetornarValor("CadenaProbabilidad", identificador));
            demandaTL = txtDemanda4.Text + "-";
            probabilidadTL = txtProbabilidad4.Text + "-";
            dtgResultado4.DataSource = monteCarloFinal.MostrarResultado(demandaTL, probabilidadTL);
        }

        private void cbbActividad1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarActividad1();
        }

        private void cbbActividad2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarActividad2();
        }

        private void cbbActividad3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarActividad3();
        }

        private void cbbActividad4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarActividad4();
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
            identificador = Convert.ToString(cbbAleatorio.SelectedValue);
            txtLlegada.Text = Convert.ToString(gestionAleatorios.RetornarValor("CadenaAleatorios", identificador));
        }

        private void cbbAleatorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAleatorioEntrada();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "")
            {

            }
            else 
            {
                CargarActividad1();
                CargarActividad2();
                CargarActividad3();
                CargarActividad4();
                CargarAleatorioEntrada();
                Calcular();
            }
        }


    }
}
