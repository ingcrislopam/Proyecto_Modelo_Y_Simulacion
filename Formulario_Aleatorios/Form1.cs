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

namespace Formulario_Aleatorios
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
            txtAleatorios.Text = "";
            txtNombre.Focus();
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
                gestionAleatorios.Nombre = Convert.ToString(txtNombre.Text);
                gestionAleatorios.CadenaAleatorios = Convert.ToString(txtAleatorios.Text);
                gestionAleatorios.Insertar();
                Nuevo();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tBuscar_Click(object sender, EventArgs e)
        {
            Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
            if (gestionAleatorios.CantidadElementos() == 0)
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
                Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
                gestionAleatorios.ID = Convert.ToInt32(txtIdentificador.Text);
                gestionAleatorios.Nombre = Convert.ToString(txtNombre.Text);
                gestionAleatorios.CadenaAleatorios = Convert.ToString(txtAleatorios.Text);
                gestionAleatorios.Modificar();
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
                Gestion_Aleatorios gestionAleatorios = new Gestion_Aleatorios();
                gestionAleatorios.ID = Convert.ToInt32(txtIdentificador.Text);
                gestionAleatorios.Eliminar();
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
