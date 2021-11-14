using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Distribuciones
{
    public class MonteCarloFinal
    {
        public void CrearFilas(string demanda, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(demanda);
            for (int fila = 0; fila < (n + 1); fila++)
            {
                tabla.Rows.Add();
            }
        }

        public int NumeroSimulaciones(string demanda)
        {
            int simulaciones = 0;
            for (int i = 0; i < demanda.Length; i++)
            {
                if (Convert.ToString(demanda[i]) == "-")
                {
                    simulaciones = simulaciones + 1;
                }
            }
            return simulaciones;
        }

        public void CrearColumnas(DataTable tabla)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                if (columna == 0) 
                {
                    tabla.Columns.Add("demanda");
                }
                if (columna == 1) 
                {
                    tabla.Columns.Add("probabilidad");
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

        public void CrearProcedimientos(string demanda, string probabilidad, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(demanda);
            for (int columna = 0; columna < 4; columna++)
            {
                for (int fila = 0; fila < (n + 1); fila++)
                {
                    if (columna == 0) 
                    {
                        ColumnaDistribucionYTiempoDeEntrega(demanda, fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        ColumnaDistribucionYTiempoDeEntrega(probabilidad, fila, columna, tabla);
                    }
                    if (columna == 2) 
                    {
                        ColumnaFrecuencia(demanda, fila, columna, tabla);
                    }
                    if (columna == 3) 
                    {
                        ColumnaFrecuenciaAcumulada(demanda, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaDistribucionYTiempoDeEntrega(string cadena, int fila, int columna, DataTable tabla)
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

        public void ColumnaFrecuencia(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            for (int i = 0; i < (n + 1); i++)
            {
                if (i == 0)
                {
                    tabla.Rows[i][columna] = 0;
                }
                else 
                {
                    double probabilidadAnterior = 0;
                    double frecuenciaAnterior = 0;
                    double frecuencia = 0;
                    probabilidadAnterior = Convert.ToDouble(tabla.Rows[i - 1][columna - 1]);
                    frecuenciaAnterior = Convert.ToDouble(tabla.Rows[i - 1][columna]);
                    frecuencia = probabilidadAnterior + frecuenciaAnterior;
                    tabla.Rows[i][columna] = frecuencia;
                }
            }
        }

        public void ColumnaFrecuenciaAcumulada(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            for (int i = 0; i < n; i++)
            {
                double frecuenciaSiguiente = 0;
                frecuenciaSiguiente = Convert.ToDouble(tabla.Rows[i + 1][columna - 1]);
                tabla.Rows[i][columna] = frecuenciaSiguiente;
            }
        }

        public DataTable MostrarResultado(string demanda, string probabilidad) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(demanda, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(demanda, probabilidad, tabla);
            return tabla;
        }
        
    }
}
