using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Simulaciones
{
    public class Proyecto
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
            for (int columna = 0; columna < 3; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("actividad");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("aleatorio");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("tiempo de actividad");
                }
            }
        }

        public void CrearProcedimientos(string cadena, DataGridView dataG1, DataGridView dataG2, DataGridView dataG3, DataGridView dataG4, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < (n + 1); fila++)
                {
                    if (columna == 0)
                    {
                        ColumnaActividad(cadena, fila, columna, tabla);
                    }
                    if (columna == 1)
                    {
                        ColumnaAleatorio(cadena, fila, columna, tabla);
                    }
                    if (columna == 2)
                    {
                        ColumnaTiempoDeActividad(cadena, fila, columna, dataG1, dataG2, dataG3, dataG4, tabla);
                    }
                }
            }
        }

        public void ColumnaActividad(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {
                tabla.Rows[fila][columna] = "total";
            }
            else 
            {
                tabla.Rows[fila][columna] = "actividad " + (fila + 1) + "";
            }
        }

        public void ColumnaAleatorio(string cadena, int fila, int columna, DataTable tabla)
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

        public void ColumnaTiempoDeActividad(string cadena, int fila, int columna, DataGridView dataG1, DataGridView dataG2, DataGridView dataG3, DataGridView dataG4, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {
                double suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][2]);
                }
                tabla.Rows[fila][columna] = suma;
            }
            else 
            {
                if (fila == 0) 
                {
                    ColumnaActividadUnoYDosYTresYCuatro(fila, columna, dataG1, tabla);
                }
                if (fila == 1) 
                {
                    ColumnaActividadUnoYDosYTresYCuatro(fila, columna, dataG2, tabla);
                }
                if (fila == 2) 
                {
                    ColumnaActividadUnoYDosYTresYCuatro(fila, columna, dataG3, tabla);
                }
                if (fila == 3) 
                {
                    ColumnaActividadUnoYDosYTresYCuatro(fila, columna, dataG4, tabla);
                }
            }
        }

        public void ColumnaActividadUnoYDosYTresYCuatro(int fila, int columna, DataGridView dataG, DataTable tabla)
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

        public DataTable MostrarResultado(string cadena, DataGridView dataG1, DataGridView dataG2, DataGridView dataG3, DataGridView dataG4) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadena, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadena, dataG1, dataG2, dataG3, dataG4, tabla);
            return tabla;
        }
    }
}
