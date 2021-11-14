using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class MonteCarlo
    {
        public void CrearFilas(string cadena, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            for (int fila = 0; fila < (n + 1); fila++)
            {
                tabla.Rows.Add();
            }
        }

        public int NumeroSimulaciones(string cadena)
        {
            int simulaciones = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (Convert.ToString(cadena[i]) == "-")
                {
                    simulaciones = simulaciones + 1;
                }
            }
            return simulaciones;
        }

        public void CrearFilasSegundaTabla(int n, DataTable tabla)
        {
            for (int fila = 0; fila < n; fila++)
            {
                tabla.Rows.Add();
            }
        }

        public void CrearColumnas(DataTable tabla)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("n");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("demanda");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("ocurrencia");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("frecuencia");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("frecuencia acumulada");
                }
            }
        }

        public void CrearColumnasSegundaOpcion(DataTable tabla)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("demanda");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("ocurrencia");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("frecuencia");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("frecuencia acumulada");
                }
            }
        }

        public void CrearColumnasSegundaTabla(DataTable tabla)
        {
            for (int columna = 0; columna < 6; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("n");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("Xn");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("aXn+c");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("Xn+1");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("aleatorio");
                }
                if (columna == 5) 
                {
                    tabla.Columns.Add("demanda");
                }
            }
        }

        public void CrearProcedimientos(string cadena, string cadenaOcu, DataTable tabla)
        {
            int n = 0;
            int nf = 0;
            n = NumeroSimulaciones(cadena);
            nf = n;
            Base miBase = new Base();
            for (int columna = 0; columna < 9; columna++)
            {
                int i = 0;
                for (int fila = 0; fila < (nf + 1); fila++)
                {
                    i = i + 1;
                    if (columna == 0)
                    {
                        if (fila == nf)
                        {

                        }
                        else
                        {
                            miBase.ColumnaN(fila, columna, tabla);
                        }
                    }
                    if (columna == 1)
                    {
                        ColumnaDemanda(cadena, fila, columna, tabla);
                    }
                    if (columna == 2)
                    {
                        ColumnaOcurrencia(cadenaOcu, fila, columna, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaFrecuencia(cadenaOcu, i, fila, columna, tabla);
                    }
                    if (columna == 4)
                    {
                        ColumnaFrecuenciaAcumulada(cadenaOcu, fila, columna, tabla);
                    }
                }
            }
        }

        public void CrearProcedimientosSegundaTabla(string ocurrencias, int n, int m, int Xn, int a, int c, DataTable tabla, DataGridView dataG)
        {
            Base miBase = new Base();
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < 6; columna++)
                {
                    if (columna == 0) 
                    {
                        miBase.ColumnaN(fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        miBase.ColumnaXn(fila, columna, Xn, tabla);
                    }
                    if (columna == 2) 
                    {
                        miBase.ColumnaAxn(fila, columna, a, c, tabla);
                    }
                    if (columna == 3) 
                    {
                        miBase.ColumnaXnMasUno(fila, columna, m, tabla);
                    }
                    if (columna == 4) 
                    {
                        miBase.ColumnaRi(fila, columna, m, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaDemandaConAleatorios(ocurrencias, fila, columna, tabla, dataG);
                    }
                }
            }
        }

        public void CrearProcedimientosSegundaOpcion(string cadena, string cadenaOcu, DataTable tabla) 
        {
            int n = 0;
            int nf = 0;
            n = NumeroSimulaciones(cadena);
            nf = n;
            for (int columna = 0; columna < 4; columna++)
            {
                for (int fila = 0; fila < (nf + 1); fila++)
                {
                    if (columna == 0)
                    {
                        ColumnaDemanda(cadena, fila, columna, tabla);
                    }
                    if (columna == 1)
                    {
                        ColumnaOcurrencia(cadenaOcu, fila, columna, tabla);
                    }
                    if (columna == 2)
                    {
                        ColumnaFrecuenciaSegundaOpcion(fila, columna, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaFrecuenciaAcumuladaSegundaOpcion(cadenaOcu, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaDemanda(string cadena, int fila, int columna, DataTable tabla)
        {
            string ncadena = "";
            if (fila == 0)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (Convert.ToString(cadena[i]) == "-")
                    {
                        ncadena = ncadena.Trim();
                        tabla.Rows[fila][columna] = ncadena;
                        fila = fila + 1;
                        ncadena = "";
                    }
                    else
                    {
                        ncadena = ncadena + Convert.ToString(cadena[i]);
                        ncadena = ncadena.Trim();
                    }
                }
            }
        }

        public void ColumnaOcurrencia(string cadenaOcu, int fila, int columna, DataTable tabla)
        {
            string ncadena = "";
            int n = 0;
            n = NumeroSimulaciones(cadenaOcu);
            if (fila == 0)
            {
                for (int i = 0; i < cadenaOcu.Length; i++)
                {
                    if (Convert.ToString(cadenaOcu[i]) == "-")
                    {
                        ncadena = ncadena.Trim();
                        tabla.Rows[fila][columna] = ncadena;
                        fila = fila + 1;
                        ncadena = "";
                    }
                    else
                    {
                        ncadena = ncadena + Convert.ToString(cadenaOcu[i]);
                        ncadena = ncadena.Trim();
                    }
                }
            }
            if (fila == n) 
            {
                double suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                tabla.Rows[fila][columna] = suma;
            }
        }

        public void ColumnaFrecuencia(string cadenaOcu, int i, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            double suma = 0;
            double sumaFrecuencia = 0;
            double ocurrencia = 0;
            double frecuencia = 0;
            n = NumeroSimulaciones(cadenaOcu);
            if (fila == n)
            {
                for (int j = 0; j < n; j++)
                {
                    sumaFrecuencia = sumaFrecuencia + Convert.ToDouble(tabla.Rows[j][columna]);
                }
                tabla.Rows[fila][columna] = sumaFrecuencia;
            }
            else 
            {
                suma = Convert.ToDouble(tabla.Rows[n][columna - 1]);
                ocurrencia = Convert.ToDouble(tabla.Rows[n - i][columna - 1]);
                frecuencia = ocurrencia / suma;
                tabla.Rows[fila][columna] = frecuencia;
            }
        }

        public void ColumnaFrecuenciaSegundaOpcion(int fila, int columna, DataTable tabla) 
        {
            double frecuenciaAnterior = 0;
            double probabilidad = 0;
            double frecuencia = 0;
            if (fila == 0)
            {
                tabla.Rows[fila][columna] = 0;
            }
            else 
            {
                frecuenciaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                probabilidad = Convert.ToDouble(tabla.Rows[fila - 1][columna - 1]);
                frecuencia = probabilidad + frecuenciaAnterior;
                tabla.Rows[fila][columna] = frecuencia;
            }
        }

        public void ColumnaFrecuenciaAcumulada(string cadenaOcu, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaOcu);
            if (fila == n)
            {

            }
            else 
            {
                double frecuen = 0;
                double frecuenciaAcumuladaAnterior = 0;
                double frecuenciaAcumulada = 0;
                if (fila == 0)
                {
                    frecuen = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    frecuenciaAcumulada = frecuen;
                    tabla.Rows[fila][columna] = frecuenciaAcumulada;
                }
                else 
                {
                    frecuen = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    frecuenciaAcumuladaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                    frecuenciaAcumulada = frecuen + frecuenciaAcumuladaAnterior;
                    tabla.Rows[fila][columna] = frecuenciaAcumulada;
                }
            }
        }

        public void ColumnaFrecuenciaAcumuladaSegundaOpcion(string cadenaOcu, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            double frecuenciaAcumulada = 0;
            n = NumeroSimulaciones(cadenaOcu);
            if (fila == n) 
            {
 
            }
            else 
            {
                frecuenciaAcumulada = Convert.ToDouble(tabla.Rows[fila + 1][columna - 1]);
                tabla.Rows[fila][columna] = frecuenciaAcumulada;
            }
        }

        public void ColumnaDemandaConAleatorios(string ocurrencias, int fila, int columna, DataTable segundaTabla, DataGridView dataG) 
        {
            int n = 0;
            int contador = 0;
            double frecuenciaAcumulada = 0;
            double aleatorio = 0;
            double nuevoValor = 0;
            n = NumeroSimulaciones(ocurrencias);
            aleatorio = Convert.ToDouble(segundaTabla.Rows[fila][columna - 1]);
            for (int i = 0; i < n; i++)
            {
                frecuenciaAcumulada = Convert.ToDouble(dataG[4, i].Value);
                if (aleatorio > frecuenciaAcumulada) 
                {
                    contador = contador + 1;
                }
            }
            if (contador == 0)
            {
                nuevoValor = Convert.ToDouble(dataG[1, contador].Value);
                segundaTabla.Rows[fila][columna] = nuevoValor;
            }
            else 
            {
                nuevoValor = Convert.ToDouble(dataG[1, contador - 1].Value);
                segundaTabla.Rows[fila][columna] = nuevoValor;
            }
        }

        public void MostrarGraficaOcurrencias(string cadenaOcu, DataTable tabla, Chart graficaOcurrencias)
        {
            int i = 0;
            int n = 0;
            n = NumeroSimulaciones(cadenaOcu);
            double valor = 0;
            for (i = 0; i < n; i++)
            {
                valor = Convert.ToDouble(tabla.Rows[i][2]);
                graficaOcurrencias.Series["ocurrencias"].Points.AddXY((i + 1), valor);
            }
        }

        public void MostrarGraficaFrecuencias(string cadenaOcu, DataTable tabla, Chart graficaFrecuencia)
        {
            int i = 0;
            int n = 0;
            n = NumeroSimulaciones(cadenaOcu);
            double valor = 0;
            for (i = 0; i < n; i++)
            {
                valor = Convert.ToDouble(tabla.Rows[i][3]);
                graficaFrecuencia.Series["frecuencias"].Points.AddXY((i + 1), valor);
            }
        }

        public DataTable MostrarResultado(string cadena, string cadenaOcu, Chart graficaOcurrencias, Chart graficaFrecuencias)
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadena, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadena, cadenaOcu, tabla);
            MostrarGraficaOcurrencias(cadenaOcu, tabla, graficaOcurrencias);
            MostrarGraficaFrecuencias(cadenaOcu, tabla, graficaFrecuencias);
            return tabla;
        }

        public DataTable MostrarResultadoSegundaTabla(string ocurrencias, int n, int m, int Xn, int a, int c, DataGridView dataG)
        {
            DataTable segundaTabla = new DataTable();
            CrearFilasSegundaTabla(n, segundaTabla);
            CrearColumnasSegundaTabla(segundaTabla);
            CrearProcedimientosSegundaTabla(ocurrencias, n, m, Xn, a, c, segundaTabla, dataG);
            return segundaTabla;
        }

        public DataTable MostrarResultadoSegundaOpcion(string cadena, string cadenaOcu) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadena, tabla);
            CrearColumnasSegundaOpcion(tabla);
            CrearProcedimientosSegundaOpcion(cadena, cadenaOcu, tabla);
            return tabla;
        }
    }
}
