using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Simulaciones
{
    public class Complemeto_Linea_De_Espera_Caso_Dos
    {
        public void CrearFilas(string cadenaEntrada, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaEntrada);
            for (int fila = 0; fila < n; fila++)
            {
                tabla.Rows.Add();
            }
        }

        public int NumeroSimulaciones(string cadenaEntrada)
        {
            int simulaciones = 0;
            for (int i = 0; i < cadenaEntrada.Length; i++)
            {
                if (Convert.ToString(cadenaEntrada[i]) == "-")
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
                    tabla.Columns.Add("aleatorio entrada");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("x1");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("tiempo de llegada");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("aleatorio servicio");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("x2");
                }
            }
        }

        public void CrearProcedimientos(string cadenaEntrada, string cadenaServicio, DataGridView dataL, DataGridView dataS, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaEntrada);
            for (int columna = 0; columna < 5; columna++)
            {
                for (int fila = 0; fila < n; fila++)
                {
                    if (columna == 0) 
                    {
                        ColumnaAleatorioEntradaServicio(cadenaEntrada, fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        ColumnaXUnoYDos(fila, columna, dataL, tabla);
                    }
                    if (columna == 2) 
                    {
                        ColumnaTiempoDeLlegada(fila, columna, tabla);
                    }
                    if (columna == 3) 
                    {
                        ColumnaAleatorioEntradaServicio(cadenaServicio, fila, columna, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaXUnoYDos(fila, columna, dataS, tabla);
                    }
                }
            }
        }

        public void ColumnaAleatorioEntradaServicio(string cadena, int fila, int columna, DataTable tabla)
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

        public void ColumnaXUnoYDos(int fila, int columna, DataGridView dataG, DataTable tabla) 
        {
            int filas1 = 0;
            int contador = 0;
            double aleatorioDistri = 0;
            filas1 = dataG.Rows.Count;
            filas1 = filas1 - 1;
            aleatorioDistri = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
            for (int i = 0; i < filas1; i++)
            {
                double frecuencia = 0;
                double frecuenciaAcumulada = 0;
                frecuencia = Convert.ToDouble(dataG[2, i].Value);
                frecuenciaAcumulada = Convert.ToDouble(dataG[3, i].Value);
                if (aleatorioDistri > frecuencia && aleatorioDistri <= frecuenciaAcumulada)
                {
                    i = filas1;
                }
                else
                {
                    contador = contador + 1;
                }
            }
            double indice = 0;
            indice = Convert.ToDouble(dataG[0, contador].Value);
            tabla.Rows[fila][columna] = indice;
        }

        public void ColumnaTiempoDeLlegada(int fila, int columna, DataTable tabla) 
        {
            double xUno = 0;
            if (fila == 0) 
            {
                xUno = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                tabla.Rows[fila][columna] = xUno;
            }
            else 
            {
                double tiempoDeLLegadaAnterior = 0;
                double tiempoDeLlegada = 0;
                tiempoDeLLegadaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                xUno = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                tiempoDeLlegada = tiempoDeLLegadaAnterior + xUno;
                tabla.Rows[fila][columna] = tiempoDeLlegada;
            }
        }

        public DataTable MostrarResultado(string cadenaEntrada, string cadenaServicio, DataGridView dataL, DataGridView dataS) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadenaEntrada, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadenaEntrada, cadenaServicio, dataL, dataS, tabla);
            return tabla;
        }
    }
}
