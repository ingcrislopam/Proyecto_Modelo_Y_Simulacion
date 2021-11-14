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

namespace Formulario_Frecuencias
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
            txtNombre.Text = "";
            txtDemandas.Text = "";
            txtProbabilidad.Text = "";
            txtNombre.Focus();
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
                gestionFrecuencias.Nombre = Convert.ToString(txtNombre.Text);
                gestionFrecuencias.CadenaDemandas = Convert.ToString(txtDemandas.Text);
                gestionFrecuencias.CadenaProbabilidad = Convert.ToString(txtProbabilidad.Text);
                gestionFrecuencias.Insertar();
                Nuevo();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tBuscar_Click(object sender, EventArgs e)
        {
            Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
            if (gestionFrecuencias.CantidadElementos() == 0)
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
            try
            {
                Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
                gestionFrecuencias.ID = Convert.ToInt32(txtIdentificador.Text);
                gestionFrecuencias.Nombre = Convert.ToString(txtNombre.Text);
                gestionFrecuencias.CadenaDemandas = Convert.ToString(txtDemandas.Text);
                gestionFrecuencias.CadenaProbabilidad = Convert.ToString(txtProbabilidad.Text);
                gestionFrecuencias.Modificar();
                Nuevo();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Gestion_Frecuencias gestionFrecuencias = new Gestion_Frecuencias();
                gestionFrecuencias.ID = Convert.ToInt32(txtIdentificador.Text);
                gestionFrecuencias.Eliminar();
                Nuevo();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
