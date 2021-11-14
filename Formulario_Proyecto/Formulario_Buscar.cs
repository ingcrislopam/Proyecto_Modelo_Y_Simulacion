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

namespace Formulario_Proyecto
{
    public partial class Formulario_Buscar : Form
    {
        public Formulario_Buscar()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Load(object sender, EventArgs e)
        {
            Gestion_Proyecto gestionProyecto = new Gestion_Proyecto();
            dtgDatos.DataSource = gestionProyecto.Buscar();
        }

        private void dtgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.txtIdentificador.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[0].Value);
            formulario.cbbActividad1.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[1].Value);
            formulario.cbbActividad2.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[2].Value);
            formulario.cbbActividad3.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[3].Value);
            formulario.cbbActividad4.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[4].Value);
            formulario.cbbAleatorio.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[5].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
