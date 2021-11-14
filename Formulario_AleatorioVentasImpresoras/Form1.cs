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

namespace Formulario_AleatorioVentasImpresoras
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

        private void Nuevo()
        {
            txtIdentificador.Text = "";
            txtMes.Text = "";
            txtAleatorioCantidad.Text = "";
            txtAleatorioCobro.Text = "";
            txtMes.Focus();
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtMes.Text == "" || txtAleatorioCantidad.Text == "" || txtAleatorioCobro.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else
            {
                try
                {
                    Gestion_AleatoriosVentasImpresoras gestionAleatoriosVentasImpresoras = new Gestion_AleatoriosVentasImpresoras();
                    gestionAleatoriosVentasImpresoras.Mes = Convert.ToString(txtMes.Text);
                    gestionAleatoriosVentasImpresoras.Cantidad = Convert.ToString(txtAleatorioCantidad.Text);
                    gestionAleatoriosVentasImpresoras.Cobro = Convert.ToString(txtAleatorioCobro.Text);
                    gestionAleatoriosVentasImpresoras.Insertar();
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
            Gestion_AleatoriosVentasImpresoras gestionAleatoriosVentasImpresoras = new Gestion_AleatoriosVentasImpresoras();
            if (gestionAleatoriosVentasImpresoras.CantidadElementos() == 0)
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
                    Gestion_AleatoriosVentasImpresoras gestionAleatoriosVentasImpresoras = new Gestion_AleatoriosVentasImpresoras();
                    gestionAleatoriosVentasImpresoras.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionAleatoriosVentasImpresoras.Mes = Convert.ToString(txtMes.Text);
                    gestionAleatoriosVentasImpresoras.Cantidad = Convert.ToString(txtAleatorioCantidad.Text);
                    gestionAleatoriosVentasImpresoras.Cobro = Convert.ToString(txtAleatorioCobro.Text);
                    gestionAleatoriosVentasImpresoras.Modificar();
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
                    Gestion_AleatoriosVentasImpresoras gestionAleatoriosVentasImpresoras = new Gestion_AleatoriosVentasImpresoras();
                    gestionAleatoriosVentasImpresoras.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionAleatoriosVentasImpresoras.Eliminar();
                    Nuevo();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
