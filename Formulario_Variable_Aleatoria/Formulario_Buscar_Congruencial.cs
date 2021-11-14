﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Gestiones;

namespace Formulario_Variable_Aleatoria
{
    public partial class Formulario_Buscar_Congruencial : Form
    {
        public Formulario_Buscar_Congruencial()
        {
            InitializeComponent();
        }

        private void Formulario_Buscar_Congruencial_Load(object sender, EventArgs e)
        {
            Gestion_Aleatorio gestionAleatorio = new Gestion_Aleatorio();
            dtgDatosCongruencial.DataSource = gestionAleatorio.BuscarCongruencial();
        }

        private void dtgDatosCongruencial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.txtIdentificador.Text = Convert.ToString(this.dtgDatosCongruencial.Rows[e.RowIndex].Cells[0].Value);
            formulario.txtN.Text = Convert.ToString(this.dtgDatosCongruencial.Rows[e.RowIndex].Cells[1].Value);
            formulario.txtM.Text = Convert.ToString(this.dtgDatosCongruencial.Rows[e.RowIndex].Cells[2].Value);
            formulario.txtXn.Text = Convert.ToString(this.dtgDatosCongruencial.Rows[e.RowIndex].Cells[3].Value);
            formulario.txtA.Text = Convert.ToString(this.dtgDatosCongruencial.Rows[e.RowIndex].Cells[4].Value);
            formulario.txtC.Text = Convert.ToString(this.dtgDatosCongruencial.Rows[e.RowIndex].Cells[5].Value);
            this.Hide();
            formulario.Show();
        }
    }
}
