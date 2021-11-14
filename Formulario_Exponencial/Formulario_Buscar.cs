using Negocio.Gestiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Exponencial
{
    public partial class Formulario_Buscar : Form
    {
        public Formulario_Buscar()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Load(object sender, EventArgs e)
        {
            Gestion_Exponencial gestionExponencial = new Gestion_Exponencial();
            dtgDatos.DataSource = gestionExponencial.Buscar();
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
            formulario.txtLanda.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[7].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
