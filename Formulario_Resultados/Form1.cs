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
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace Formulario_Resultados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarArregladas(cbbArreglada);
            CargarVentas(cbbVenta);
        }

        private void CargarArregladas(ComboBox combo)
        {
            Gestion_PronosticosImpresorasArregladas gestionPronosticosArregladas = new Gestion_PronosticosImpresorasArregladas();
            combo.DataSource = gestionPronosticosArregladas.Buscar();
            combo.DisplayMember = "MesPronostico";
            combo.ValueMember = "ID";
        }

        private void CargarVentas(ComboBox combo)
        {
            Gestion_PronosticosVentasImpresoras gestionPronosticosVentasImpresoras = new Gestion_PronosticosVentasImpresoras();
            combo.DataSource = gestionPronosticosVentasImpresoras.Buscar();
            combo.DisplayMember = "MesPronostico";
            combo.ValueMember = "ID";
        }

        private void cbbArreglada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarArregladaDatos();
        }

        private void CargarArregladaDatos()
        {
            Gestion_PronosticosImpresorasArregladas gestionPronosticosImpresorasArregladas = new Gestion_PronosticosImpresorasArregladas();
            string identificador = "";
            identificador = Convert.ToString(cbbArreglada.SelectedValue);
            txtACantidad.Text = Convert.ToString(gestionPronosticosImpresorasArregladas.RetornarValor("CantidadVenta", identificador));
            txtATotal.Text = Convert.ToString(gestionPronosticosImpresorasArregladas.RetornarValor("Cobro", identificador));
        }

        private void cbbVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarVentaDatos();
        }

        private void CargarVentaDatos()
        {
            Gestion_PronosticosVentasImpresoras gestionPronosticosVentasImpresoras = new Gestion_PronosticosVentasImpresoras();
            string identificador = "";
            identificador = Convert.ToString(cbbVenta.SelectedValue);
            txtVCantidad.Text = Convert.ToString(gestionPronosticosVentasImpresoras.RetornarValor("CantidadVenta", identificador));
            txtVTotal.Text = Convert.ToString(gestionPronosticosVentasImpresoras.RetornarValor("Cobro", identificador));
        }

        private void MostrarGrafica(Chart grafica)
        {
            int i = 0;
            double total1 = 0;
            double total2 = 0;
            for (i = 0; i < 2; i++)
            {
                if (i == 0) 
                {
                    total1 = Convert.ToDouble(txtATotal.Text);
                    grafica.Series["total"].Points.AddXY((i + 1), total1);
                }
                if (i == 1) 
                {
                    total2 = Convert.ToDouble(txtVTotal.Text);
                    grafica.Series["total"].Points.AddXY((i + 1), total2);
                }
            }
        }

        private void tNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo() 
        {
            txtIdentificador.Text = "";
            cbbArreglada.SelectedIndex = 0;
            cbbVenta.SelectedIndex = 0;
            txtACantidad.Text = "";
            txtATotal.Text = "";
            txtVCantidad.Text = "";
            txtVTotal.Text = "";
            txtMayorIncidencia.Text = "";
            NuevaGrafica();
            txtGArreglos.Text = "";
            txtGventas.Text = "";
            txtGTotal.Text = "";
            txtOGTotalSueldoEmpleados.Text = "";
            txtOGTotalOtrosGastos.Text = "";
            txtSBTotalServiviosBasicos.Text = "";
            txtGFTotalGanancias.Text = "";
            txtGFTotalOtrosGastos.Text = "";
            txtGFServiciosBasicos.Text = "";
            txtGananciaFinal.Text = "";
        }

        public void NuevaGrafica()
        {
            chtIncidencia.Series.Clear();
            chtIncidencia.Series.Add("total");
            chtIncidencia.Series["total"].ChartType = SeriesChartType.Pie;
            chtIncidencia.Series["total"].BorderWidth = 1;
            chtIncidencia.Visible = false;
        }

        private void tInsertar_Click(object sender, EventArgs e)
        {
            if (txtGananciaFinal.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                try
                {
                    Gestion_Simulacion gestionSimulacion = new Gestion_Simulacion();
                    gestionSimulacion.IdArreglo = Convert.ToInt32(cbbArreglada.SelectedValue);
                    gestionSimulacion.IdVenta = Convert.ToInt32(cbbVenta.SelectedValue);
                    gestionSimulacion.Insertar();
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
            Gestion_Simulacion gestionSimulacion = new Gestion_Simulacion();
            if (gestionSimulacion.CantidadElementos() == 0)
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
                    Gestion_Simulacion gestionSimulacion = new Gestion_Simulacion();
                    gestionSimulacion.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionSimulacion.IdArreglo = Convert.ToInt32(cbbArreglada.SelectedValue);
                    gestionSimulacion.IdVenta = Convert.ToInt32(cbbVenta.SelectedValue);
                    gestionSimulacion.Modificar();
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
                    Gestion_Simulacion gestionSimulacion = new Gestion_Simulacion();
                    gestionSimulacion.ID = Convert.ToInt32(txtIdentificador.Text);
                    gestionSimulacion.Eliminar();
                    Nuevo();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void tCalcular_Click(object sender, EventArgs e)
        {
            if (txtACantidad.Text == "" || txtATotal.Text == "" || txtVCantidad.Text == "" || txtVTotal.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                Calcular();
            }
        }

        private void Calcular() 
        {
            NuevaGrafica();
            MostrarGrafica(chtIncidencia);
            double arreglos = 0;
            double ventas = 0;
            double mayor = 0;
            double costoArriendo = 0;
            double sueldoEmpleados = 0;
            double numeroEmpleados = 0;
            double totalSueldoEmpleados = 0;
            double luz = 0;
            double telefono = 0;
            double totalGanancias = 0;
            double totalOtrosGastos = 0;
            double totalServiciosBasicos = 0;
            arreglos = Convert.ToDouble(txtATotal.Text);
            ventas = Convert.ToDouble(txtVTotal.Text);
            mayor = arreglos;
            if (ventas > mayor)
            {
                txtMayorIncidencia.Text = "Ventas";
            }
            else
            {
                txtMayorIncidencia.Text = "Arreglos";
            }
            txtGArreglos.Text = Convert.ToString(arreglos);
            txtGventas.Text = Convert.ToString(ventas);
            txtGTotal.Text = Convert.ToString(arreglos + ventas);
            costoArriendo = Convert.ToDouble(txtOGCostoArriendo.Text);
            sueldoEmpleados = Convert.ToDouble(txtOGSueldoEmpleados.Text);
            numeroEmpleados = Convert.ToDouble(txtOGNumeroEmpleados.Text);
            txtOGTotalSueldoEmpleados.Text = Convert.ToString(sueldoEmpleados * numeroEmpleados);
            totalSueldoEmpleados = Convert.ToDouble(txtOGTotalSueldoEmpleados.Text);
            txtOGTotalOtrosGastos.Text = Convert.ToString(costoArriendo + totalSueldoEmpleados);
            luz = Convert.ToDouble(txtLuz.Text);
            telefono = Convert.ToDouble(txtTelefono.Text);
            txtSBTotalServiviosBasicos.Text = Convert.ToString(luz + telefono);
            totalGanancias = Convert.ToDouble(txtGTotal.Text);
            totalOtrosGastos = Convert.ToDouble(txtOGTotalOtrosGastos.Text);
            totalServiciosBasicos = Convert.ToDouble(txtSBTotalServiviosBasicos.Text);
            txtGFTotalGanancias.Text = Convert.ToString(totalGanancias);
            txtGFTotalOtrosGastos.Text = Convert.ToString(totalOtrosGastos);
            txtGFServiciosBasicos.Text = Convert.ToString(totalServiciosBasicos);
            txtGananciaFinal.Text = Convert.ToString(totalGanancias - totalOtrosGastos - totalServiciosBasicos);
            chtIncidencia.Visible = true;
        }

        private void tImprimir_Click(object sender, EventArgs e)
        {
            if (txtGananciaFinal.Text == "")
            {
                MessageBox.Show("No se puede realizar esta operación");
            }
            else 
            {
                Imprimir();
            }
        }

        private void Imprimir()
        {
            this.printForm1.PrintAction = PrintAction.PrintToPreview;
            this.printForm1.Print();
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtIdentificador.Text == "")
            {

            }
            else 
            {
                CargarArregladaDatos();
                CargarVentaDatos();
                Calcular();
            }
        }

    }
}
