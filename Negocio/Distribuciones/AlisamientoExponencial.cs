using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class AlisamientoExponencial
    {
        public void CrearFilas(string cadena, string nuevaCadena, DataTable tabla)
        {
            int n = 0;
            int nc = 0;
            int nf = 0;
            n = NumeroSimulaciones(cadena);
            nc = NumeroSimulaciones(nuevaCadena);
            nf = n + nc + 2;
            for (int fila = 0; fila < nf; fila++)
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
            for (int columna = 0; columna < 9; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("mes");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("demanda");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("estimacion alisada");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("estimacion doblemente alisada");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("interseccion");
                }
                if (columna == 5)
                {
                    tabla.Columns.Add("pendiente");
                }
                if (columna == 6)
                {
                    tabla.Columns.Add("pronostico");
                }
                if (columna == 7)
                {
                    tabla.Columns.Add("error");
                }
                if (columna == 8)
                {
                    tabla.Columns.Add("error alisado");
                }
            }
        }

        public void CrearProcedimientos(string cadena, string nuevaCadena, double alfa, DataTable tabla)
        {
            int n = 0;
            int nc = 0;
            int nf = 0;
            n = NumeroSimulaciones(cadena);
            nc = NumeroSimulaciones(nuevaCadena);
            nf = n + nc + 1;
            Base miBase = new Base();
            for (int columna = 0; columna < 9; columna++)
            {
                for (int fila = 0; fila < (nf+1); fila++)
                {
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
                        ColumnaDemanda(cadena, nuevaCadena, fila, columna, tabla);
                    }
                    if (columna == 2)
                    {
                        ColumnaEstimacionAlisada(cadena, nuevaCadena, fila, columna, alfa, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaEstimacionDoblementeAlisada(cadena, nuevaCadena, fila, columna, alfa, tabla);
                    }
                    if (columna == 4)
                    {
                        ColumnaInterseccion(cadena, nuevaCadena, fila, columna, tabla);
                    }
                    if (columna == 5)
                    {
                        ColumnaPendiente(cadena, nuevaCadena, fila, columna, tabla);
                    }
                    if (columna == 6)
                    {
                        ColumnaPronostico(fila, columna, tabla);
                    }
                    if (columna == 7)
                    {
                        ColumnaError(fila, columna, tabla);
                    }
                    if (columna == 8)
                    {
                        ColumnaErrorAlisado(fila, columna, alfa, tabla);
                    }
                }
            }
        }

        public void ColumnaDemanda(string cadena, string nuevaCadena, int fila, int columna, DataTable tabla)
        {
            int nf = 0;
            string ncadena = "";
            string ncadenaf = "";
            nf = NumeroSimulaciones(cadena);
            if (fila == 1)
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
            if (fila == (nf + 1))
            {
                for (int i = 0; i < nuevaCadena.Length; i++)
                {
                    if (Convert.ToString(nuevaCadena[i]) == "-")
                    {
                        ncadenaf = ncadenaf.Trim();
                        tabla.Rows[fila][columna] = ncadenaf;
                        fila = fila + 1;
                        ncadenaf = "";
                    }
                    else
                    {
                        ncadenaf = ncadenaf + Convert.ToString(nuevaCadena[i]);
                        ncadenaf = ncadenaf.Trim();
                    }
                }
            }
        }

        public void ColumnaEstimacionAlisada(string cadena, string nuevaCadena, int fila, int columna, double alfa, DataTable tabla) 
        {
            int n = 0;
            int nc = 0;
            int nf = 0;
            if (fila == 0)
            {
                double suma = 0;
                double promedio;
                n = NumeroSimulaciones(cadena);
                nc = NumeroSimulaciones(nuevaCadena);
                nf = n + nc;
                for (int i = 1; i < nf; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][columna - 1]);
                }
                promedio = suma / Convert.ToDouble(n);
                tabla.Rows[fila][columna] = promedio;
            }
            else 
            {
                
                n = NumeroSimulaciones(cadena);
                nc = NumeroSimulaciones(nuevaCadena);
                nf = n + nc + 1;
                if (fila == nf)
                {

                }
                else 
                {
                    double demanda = 0;
                    double estimacionAlisadaAnterior = 0;
                    double estimacionAlisada = 0;
                    demanda = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    estimacionAlisadaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                    estimacionAlisada = (alfa * demanda) + (1 - alfa) * estimacionAlisadaAnterior;
                    tabla.Rows[fila][columna] = estimacionAlisada;
                }
            }
            //110-95-90-120-115-85-60-80-110-135-120-80-
        }

        public void ColumnaEstimacionDoblementeAlisada(string cadena, string nuevaCadena, int fila, int columna, double alfa, DataTable tabla) 
        {
            double estimacionAlisada = 0;
            double estimacionDoblementeAlisadaAnterior = 0;
            double estimacionDoblementeAlisada = 0;
            if (fila == 0)
            {
                estimacionAlisada = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                tabla.Rows[fila][columna] = estimacionAlisada;
            }
            else
            {
                int n = 0;
                int nc = 0;
                int nf = 0;
                n = NumeroSimulaciones(cadena);
                nc = NumeroSimulaciones(nuevaCadena);
                nf = n + nc + 1;
                if (fila == nf)
                {

                }
                else
                {
                    estimacionAlisada = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    estimacionDoblementeAlisadaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                    estimacionDoblementeAlisada = alfa * (estimacionAlisada) + (1 - alfa) * estimacionDoblementeAlisadaAnterior;
                    tabla.Rows[fila][columna] = estimacionDoblementeAlisada;
                }
            }
        }

        public void ColumnaInterseccion(string cadena, string nuevaCadena, int fila, int columna, DataTable tabla) 
        {
            double estimacionAlisada = 0;
            double estimacionDoblementeAlisada = 0;
            double interseccion = 0;
            if (fila == 0)
            {
                
            }
            else
            {
                int n = 0;
                int nc = 0;
                int nf = 0;
                n = NumeroSimulaciones(cadena);
                nc = NumeroSimulaciones(nuevaCadena);
                nf = n + nc + 1;
                if (fila == nf)
                {

                }
                else
                {
                    estimacionAlisada = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    estimacionDoblementeAlisada = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    interseccion = (2 * estimacionAlisada) - estimacionDoblementeAlisada;
                    tabla.Rows[fila][columna] = interseccion;
                }
            }
        }

        public void ColumnaPendiente(string cadena, string nuevaCadena, int fila, int columna, DataTable tabla) 
        {
            double estimacionDoblementeAlisada = 0;
            double estimacionDoblementeAlisadaAnterior = 0;
            double pendiente = 0;
            if (fila == 0)
            {

            }
            else
            {
                int n = 0;
                int nc = 0;
                int nf = 0;
                n = NumeroSimulaciones(cadena);
                nc = NumeroSimulaciones(nuevaCadena);
                nf = n + nc + 1;
                if (fila == nf)
                {

                }
                else
                {
                    estimacionDoblementeAlisada = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    estimacionDoblementeAlisadaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna - 2]);
                    pendiente = estimacionDoblementeAlisada - estimacionDoblementeAlisadaAnterior;
                    tabla.Rows[fila][columna] = pendiente;
                }
            }
        }

        public void ColumnaPronostico(int fila, int columna, DataTable tabla) 
        {
            double estimacionAlisada = 0;
            double interseccionAnterior = 0;
            double pendienteAnterior = 0;
            double pronostico = 0;
            if (fila == 0)
            {

            }
            if (fila == 1) 
            {
                estimacionAlisada = Convert.ToDouble(tabla.Rows[fila - 1][columna - 4]);
                tabla.Rows[fila][columna] = estimacionAlisada;
            }
            if (fila > 1) 
            {
                interseccionAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna - 2]);
                pendienteAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna - 1]);
                pronostico = interseccionAnterior + pendienteAnterior;
                tabla.Rows[fila][columna] = pronostico;
            }
        }

        public void ColumnaError(int fila, int columna, DataTable tabla) 
        {
            if (fila == 0)
            {

            }
            else 
            {
                double pronostico = 0;
                double demanda = 0;
                double error = 0;
                pronostico = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                if (Convert.ToString(tabla.Rows[fila][columna - 6]) == "")
                {
                    demanda = 0;
                }
                else
                {
                    demanda = Convert.ToDouble(tabla.Rows[fila][columna - 6]);
                }
                error = pronostico - demanda;
                tabla.Rows[fila][columna] = error;
            }
        }

        public void ColumnaErrorAlisado(int fila, int columna, double alfa, DataTable tabla) 
        {
            double error = 0;
            double errorAlisadoAnterior = 0;
            double errorAlisado = 0;
            if (fila == 0) 
            {
 
            }
            if (fila == 1) 
            {
                error = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                errorAlisado = (alfa * error) + (1 - alfa) * errorAlisadoAnterior;
                tabla.Rows[fila][columna] = errorAlisado;
            }
            if (fila > 1) 
            {
                error = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                errorAlisadoAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                errorAlisado = (alfa * error) + (1 - alfa) * errorAlisadoAnterior;
                tabla.Rows[fila][columna] = errorAlisado;
            }
        }

        public void MostrarGrafica(string cadena, string nuevaCadena, DataTable tabla, Chart grafica)
        {
            int n = 0;
            int nc = 0;
            int nf = 0;
            int i = 0;
            int j = 0;
            double valorUno = 0;
            double valorDos = 0;
            n = NumeroSimulaciones(cadena);
            nc = NumeroSimulaciones(nuevaCadena);
            nf = n + nc + 1;
            for (i = 1; i < nf; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][1]);
                grafica.Series["demanda"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 1; j < nf; j++)
            {
                valorDos = Convert.ToDouble(tabla.Rows[j][6]);
                grafica.Series["pronostico"].Points.AddXY((j + 1), valorDos);
            }
        }

        public DataTable MostrarResultado(string cadena, string nuevaCadena, double alfa, Chart grafica)
        {
            //int n = 0;
            //n = NumeroSimulaciones(cadena);
            DataTable tabla = new DataTable();
            CrearFilas(cadena, nuevaCadena, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadena, nuevaCadena, alfa, tabla);
            MostrarGrafica(cadena, nuevaCadena, tabla, grafica);
            return tabla;
        }

    }
}
