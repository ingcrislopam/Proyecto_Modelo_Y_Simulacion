using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmCongruencialLineal_Click(object sender, EventArgs e)
        {
            Formulario_Congruencial_Lineal.Form1 formularioCongruencialLineal = new Formulario_Congruencial_Lineal.Form1();
            formularioCongruencialLineal.Show();
        }

        private void tsmVariableAleatoria_Click(object sender, EventArgs e)
        {
            Formulario_Variable_Aleatoria.Form1 formularioVariableAleatoria = new Formulario_Variable_Aleatoria.Form1();
            formularioVariableAleatoria.Show();
        }

        private void tsmExponencial_Click(object sender, EventArgs e)
        {
            Formulario_Exponencial.Form1 formularioExponencial = new Formulario_Exponencial.Form1();
            formularioExponencial.Show();
        }

        private void tsmPoisson_Click(object sender, EventArgs e)
        {
            Formulario_Poisson.Form1 formularioPoisson = new Formulario_Poisson.Form1();
            formularioPoisson.Show();
        }

        private void tsmMonteCarlo_Click(object sender, EventArgs e)
        {
            Formulario_Monte_Carlo.Form1 formularioMonteCarlo = new Formulario_Monte_Carlo.Form1();
            formularioMonteCarlo.Show();
        }

        private void tsmCasoUno_Click(object sender, EventArgs e)
        {
            Formulario_Promedio_Movil.Form1 formularioPromedioMovil = new Formulario_Promedio_Movil.Form1();
            formularioPromedioMovil.Show();
        }

        private void tsmCasoDos_Click(object sender, EventArgs e)
        {
            Formulario_Promedio_Movil_Pronostico.Form1 formularioPromedioMovilPronostico = new Formulario_Promedio_Movil_Pronostico.Form1();
            formularioPromedioMovilPronostico.Show();
        }

        private void tsmAlisamientoExponencial_Click(object sender, EventArgs e)
        {
            Formulario_Alisamiento_Exponencial.Form1 formularioAlisamientoExponencial = new Formulario_Alisamiento_Exponencial.Form1();
            formularioAlisamientoExponencial.Show();
        }

        private void tsmLineal_Click(object sender, EventArgs e)
        {
            Formulario_Regresion_Lineal.Form1 formularioRegresionLineal = new Formulario_Regresion_Lineal.Form1();
            formularioRegresionLineal.Show();
        }

        private void tsmCuadratica_Click(object sender, EventArgs e)
        {
            Formulario_Regresion_Cuadratica.Form1 formularioRegresionCuadratica = new Formulario_Regresion_Cuadratica.Form1();
            formularioRegresionCuadratica.Show();
        }

        private void tsmVer_Click(object sender, EventArgs e)
        {
            Formulario_Ayuda.Form1 formularioAyuda = new Formulario_Ayuda.Form1();
            formularioAyuda.Show();
            //MessageBox.Show("Nombre: Cristhian Adrián López Mora, Curso: Quinto A, Materia: Modelo y Simulación");
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmAleatorio_Click(object sender, EventArgs e)
        {
            Formulario_Aleatorios.Form1 formularioAleatorios = new Formulario_Aleatorios.Form1();
            formularioAleatorios.Show();
        }

        private void tsmFrecuencia_Click(object sender, EventArgs e)
        {
            Formulario_Frecuencias.Form1 formularioFrecuencias = new Formulario_Frecuencias.Form1();
            formularioFrecuencias.Show();
        }

        private void tsmLineasDeEsperaCasoUno_Click(object sender, EventArgs e)
        {
            Formulario_Linea_De_Espera_Caso_Uno.Form1 formularioLineaDeEsperaCasoUno = new Formulario_Linea_De_Espera_Caso_Uno.Form1();
            formularioLineaDeEsperaCasoUno.Show();
        }

        private void tsmLineasDeEsperaCasoDos_Click(object sender, EventArgs e)
        {
            Formulario_Linea_De_Espera_Caso_Dos.Form1 formularioLineaDeEsperaCasoDos = new Formulario_Linea_De_Espera_Caso_Dos.Form1();
            formularioLineaDeEsperaCasoDos.Show();
        }

        private void tsmInventario_Click(object sender, EventArgs e)
        {
            Formulario_Politica_De_Inventario.Form1 formularioPoliticaDeInventario = new Formulario_Politica_De_Inventario.Form1();
            formularioPoliticaDeInventario.Show();
        }

        private void tsmProyecto_Click(object sender, EventArgs e)
        {
            Formulario_Proyecto.Form1 formularioProyecto = new Formulario_Proyecto.Form1();
            formularioProyecto.Show();
        }

        private void tsmAImpresorasArregladas_Click(object sender, EventArgs e)
        {
            Formulario_AleatorioImpresorasArregladas.Form1 formularioAleatorioImpresorasArregladas = new Formulario_AleatorioImpresorasArregladas.Form1();
            formularioAleatorioImpresorasArregladas.Show();
        }

        private void tsmAVentasDeImpresoras_Click(object sender, EventArgs e)
        {
            Formulario_AleatorioVentasImpresoras.Form1 formularioAleatorioVentasImpresoras = new Formulario_AleatorioVentasImpresoras.Form1();
            formularioAleatorioVentasImpresoras.Show();
        }

        private void tsmPronosticoImpresorasArregladas_Click(object sender, EventArgs e)
        {
            Formulario_PronosticoImpresorasArregladas.Form1 formularioPronosticoImpresorasArregladas = new Formulario_PronosticoImpresorasArregladas.Form1();
            formularioPronosticoImpresorasArregladas.Show();
        }

        private void tsmPronosticoVentasImpresoras_Click(object sender, EventArgs e)
        {
            Formulario_PronosticoVentasImpresoras.Form1 formularioPronosticoVentasImpresoras = new Formulario_PronosticoVentasImpresoras.Form1();
            formularioPronosticoVentasImpresoras.Show();
        }

        private void tsmResultados_Click(object sender, EventArgs e)
        {
            Formulario_Resultados.Form1 formularioResultados = new Formulario_Resultados.Form1();
            formularioResultados.Show();
        }

        
    }
}
