using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class PromedioMovilPronostico
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
            for (int columna = 0; columna < 6; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("trimestres");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("accion %");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("pronostico 1");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("pronostico 2");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("diferencia 1");
                }
                if (columna == 5)
                {
                    tabla.Columns.Add("diferencia 2");
                }
            }
        }

        public void CrearProcedimientos(string cadena, int evaluarUno, int evaluarDos, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            Base miBase = new Base();
            for (int fila = 0; fila < (n + 1); fila++)
            {
                for (int columna = 0; columna < 6; columna++)
                {
                    if (columna == 0)
                    {
                        miBase.ColumnaN(fila, columna, tabla);
                    }
                    if (columna == 1)
                    {
                        ColumnaAccion(cadena, fila, columna, tabla);
                    }
                    if (columna == 2)
                    {
                        ColumnaPronosticoUno(fila, columna, evaluarUno, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaPronosticoDos(fila, columna, evaluarDos, tabla);
                    }
                    if (columna == 4)
                    {
                        ColumnaDiferenciaUno(cadena, fila, columna, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaDiferenciaDos(cadena, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaAccion(string cadena, int fila, int columna, DataTable tabla)
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

        public void ColumnaPronosticoUno(int fila, int columna, int evaluarUno, DataTable tabla)
        {
            if (fila >= evaluarUno)
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluarUno;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 1]);
                }
                promedio = demandas / evaluarUno;
                tabla.Rows[fila][columna] = promedio;
            }
        }

        public void ColumnaPronosticoDos(int fila, int columna, int evaluarDos, DataTable tabla)
        {
            if (fila >= evaluarDos)
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluarDos;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 2]);
                }
                promedio = demandas / evaluarDos;
                tabla.Rows[fila][columna] = promedio;
            }
        }

        public void ColumnaDiferenciaUno(string cadena, int fila, int columna, DataTable tabla)
        {
            double accion = 0;
            double pronostico = 0;
            double diferencia = 0;
            if (Convert.ToString(tabla.Rows[fila][columna - 3]) == "")
            {

            }
            else 
            {
                accion = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                if (Convert.ToString(tabla.Rows[fila][columna - 2]) == "")
                {
                    pronostico = 0;
                    diferencia = accion - pronostico;
                    tabla.Rows[fila][columna] = diferencia;
                }
                else
                {
                    pronostico = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    diferencia = accion - pronostico;
                    tabla.Rows[fila][columna] = diferencia;
                }
            }
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {
                tabla.Rows[fila][columna] = Sumatoria(n, fila, columna, tabla);
            }
        }

        public void ColumnaDiferenciaDos(string cadena, int fila, int columna, DataTable tabla)
        {
            double accion = 0;
            double pronostico = 0;
            double diferencia = 0;
            if (Convert.ToString(tabla.Rows[fila][columna - 4]) == "")
            {

            }
            else
            {
                accion = Convert.ToDouble(tabla.Rows[fila][columna - 4]);
                if (Convert.ToString(tabla.Rows[fila][columna - 2]) == "")
                {
                    pronostico = 0;
                    diferencia = accion - pronostico;
                    tabla.Rows[fila][columna] = diferencia;
                }
                else
                {
                    pronostico = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    diferencia = accion - pronostico;
                    tabla.Rows[fila][columna] = diferencia;
                }
            }
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n)
            {
                tabla.Rows[fila][columna] = Sumatoria(n, fila, columna, tabla);
            }
        }

        public double Sumatoria(int n, int fila, int columna, DataTable tabla)
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + Convert.ToDouble(tabla.Rows[i][columna]);
            }
            return suma;
        }

        public void MostrarGraficaUno(int n, DataTable tabla, Chart graficaUno)
        {
            int i = 0;
            int j = 0;
            double valorUno = 0;
            double valorDos = 0;
            for (i = 0; i < n; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][1]);
                graficaUno.Series["accion"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 0; j < n; j++)
            {
                if (Convert.ToString(tabla.Rows[j][2]) == "")
                {

                }
                else
                {
                    valorDos = Convert.ToDouble(tabla.Rows[j][2]);
                    graficaUno.Series["pronostico 1"].Points.AddXY((j + 1), valorDos);
                }

            }
        }

        public void MostrarGraficaDos(int n, DataTable tabla, Chart graficaDos)
        {
            int i = 0;
            int j = 0;
            double valorUno = 0;
            double valorDos = 0;
            for (i = 0; i < n; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][1]);
                graficaDos.Series["accion"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 0; j < n; j++)
            {
                if (Convert.ToString(tabla.Rows[j][3]) == "")
                {

                }
                else
                {
                    valorDos = Convert.ToDouble(tabla.Rows[j][3]);
                    graficaDos.Series["pronostico 2"].Points.AddXY((j + 1), valorDos);
                }

            }
        }

        public DataTable MostrarResultado(string cadena, int evaluarUno, int evaluarDos, Chart graficaUno, Chart graficaDos)
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            DataTable tabla = new DataTable();
            CrearFilas(cadena, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadena, evaluarUno, evaluarDos, tabla);
            MostrarGraficaUno(n, tabla, graficaUno);
            MostrarGraficaDos(n, tabla, graficaDos);
            return tabla;
        }
    }
}
