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

namespace Formulario_Politica_De_Inventario
{
    public partial class Formulario_Buscar : Form
    {
        public Formulario_Buscar()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Load(object sender, EventArgs e)
        {
            Gestion_PoliticaInventario gestionPoliticaDeInventario = new Gestion_PoliticaInventario();
            dtgDatos.DataSource = gestionPoliticaDeInventario.Buscar();
        }

        private void dtgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.txtIdentificador.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[0].Value);
            formulario.cbbDistribucion.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[1].Value);
            formulario.cbbTiempoDeEntrega.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[2].Value);
            formulario.cbbADistribucion.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[3].Value);
            formulario.cbbATiempoDeEntrega.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[4].Value);
            formulario.txtCantidadOrdenar.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[5].Value);
            formulario.txtPuntoDeReorden.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[6].Value);
            formulario.txtCostoPorFaltantes.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[7].Value);
            formulario.txtCostoDeMantenimiento.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[8].Value);
            formulario.txtCostoDeOrdenar.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[9].Value);
            formulario.txtInventarioInicial.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[10].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
