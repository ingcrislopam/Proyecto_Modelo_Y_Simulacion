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

namespace Formulario_Monte_Carlo
{
    public partial class Formulario_Buscar : Form
    {
        public Formulario_Buscar()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Load(object sender, EventArgs e)
        {
            Gestion_MonteCarlo gestionMonteCarlo = new Gestion_MonteCarlo();
            dtgDatos.DataSource = gestionMonteCarlo.Buscar();
        }

        private void dtgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.txtIdentificador.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[0].Value);
            formulario.txtN.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[1].Value);
            formulario.txtM.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[2].Value);
            formulario.txtXn.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[3].Value);
            formulario.txtA.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[4].Value);
            formulario.txtC.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[5].Value);
            formulario.txtIdentificadorE.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[6].Value);
            formulario.txtDemandas.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[7].Value);
            formulario.txtOcurrencias.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[8].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
