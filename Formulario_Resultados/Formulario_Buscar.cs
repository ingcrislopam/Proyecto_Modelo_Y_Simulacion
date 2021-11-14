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

namespace Formulario_Resultados
{
    public partial class Formulario_Buscar : Form
    {
        public Formulario_Buscar()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Load(object sender, EventArgs e)
        {
            Gestion_Simulacion gestionSimulacion = new Gestion_Simulacion();
            dtgDatos.DataSource = gestionSimulacion.Buscar();
        }

        private void dtgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.txtIdentificador.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[0].Value);
            formulario.cbbArreglada.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[1].Value);
            formulario.cbbVenta.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[2].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
