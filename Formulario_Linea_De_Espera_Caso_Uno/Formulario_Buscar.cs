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

namespace Formulario_Linea_De_Espera_Caso_Uno
{
    public partial class Formulario_Buscar : Form
    {
        public Formulario_Buscar()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Load(object sender, EventArgs e)
        {
            Gestion_LineaDeEsperaCasoUno gestionLineaDeEsperaCasoUno = new Gestion_LineaDeEsperaCasoUno();
            dtgDatos.DataSource = gestionLineaDeEsperaCasoUno.Buscar();
        }

        private void dtgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.txtIdentificador.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[0].Value);
            formulario.cbbLlegada.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[1].Value);
            formulario.cbbServicio.SelectedValue = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[2].Value);
            formulario.txtTiempoEntreLlegada.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[3].Value);
            formulario.txtTiempoDeServicio.Text = Convert.ToString(this.dtgDatos.Rows[e.RowIndex].Cells[4].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
