using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class PromedioMovil
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
                    tabla.Columns.Add("pronostico");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("diferencia");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("diferencia cuadrado");
                }
            }
        }

        public void CrearProcedimientos(string cadena, int evaluar, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            Base miBase = new Base();
            for (int fila = 0; fila < (n + 1); fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    if (columna == 0)
                    {
                        if (fila == n) 
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
                        ColumnaPronostico(fila, columna, evaluar, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaDiferencia(fila, columna, tabla);
                    }
                    if (columna == 4)
                    {
                        ColumnaDiferenciaCuadrado(fila, columna, tabla);
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
                        ncadena=ncadena.Trim();
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

        public void ColumnaPronostico(int fila, int columna, int evaluar, DataTable tabla) 
        {
            
            if (fila >= evaluar) 
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluar;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 1]);
                }
                promedio = demandas / evaluar;
                tabla.Rows[fila][columna] = promedio;
            }
        }

        public void ColumnaDiferencia(int fila, int columna, DataTable tabla) 
        {
            double demanda = 0;
            double promedio = 0;
            double diferencia = 0;
            if (Convert.ToString(tabla.Rows[fila][columna - 2]) == "") 
            {
                demanda = 0;
            }
            else 
            {
                demanda = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
            }
            if (Convert.ToString(tabla.Rows[fila][columna-1]) == "")
            {
                promedio = 0;
                diferencia = demanda - promedio;
                tabla.Rows[fila][columna] = diferencia;
            }
            else 
            {
                promedio = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                diferencia = demanda - promedio;
                tabla.Rows[fila][columna] = diferencia;
            }
        }

        public void ColumnaDiferenciaCuadrado(int fila, int columna, DataTable tabla) 
        {
            double diferencia = 0;
            double diferenciaCuadrado = 0;
            diferencia = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
            diferenciaCuadrado = Math.Pow(diferencia, 2);
            tabla.Rows[fila][columna] = diferenciaCuadrado;
        }

        public void MostrarGrafica(int n, DataTable tabla, Chart grafica)
        {
            int i = 0;
            int j = 0;
            double valorUno = 0;
            double valorDos = 0;
            for (i = 0; i < n; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][1]);
                grafica.Series["demanda"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 0; j < n; j++)
            {
                if (Convert.ToString(tabla.Rows[j][2]) == "")
                {

                }
                else 
                {
                    valorDos = Convert.ToDouble(tabla.Rows[j][2]);
                    grafica.Series["promedio"].Points.AddXY((j + 1), valorDos);
                }
            }
        }

        public DataTable MostrarResultado(string cadena, int evaluar, Chart grafica)
        {
            int n=0;
            n=NumeroSimulaciones(cadena);
            DataTable tabla = new DataTable();
            CrearFilas(cadena, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadena, evaluar, tabla);
            MostrarGrafica(n, tabla, grafica);
            return tabla;
        }

    }
}
