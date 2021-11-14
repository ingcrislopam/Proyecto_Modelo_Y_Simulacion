using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Simulaciones
{
    public class LineaDeEsperaCasoDos
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
            for (int columna = 0; columna < 7; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("llegada");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("tiempo de llegada");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("tiempo de entrada");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("tiempo de servicio");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("tiempo de salida");
                }
                if (columna == 5)
                {
                    tabla.Columns.Add("tiempo de espera");
                }
                if (columna == 6)
                {
                    tabla.Columns.Add("longitud de la cola");
                }
            }
        }

        public void CrearProcedimientos(string cadena, DataGridView dtgResultado, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            for (int fila = 0; fila < (n + 1); fila++)
            {
                for (int columna = 0; columna < 7; columna++)
                {
                    if (columna == 0)
                    {
                        ColumnaLlegada(cadena, fila, columna, tabla);
                    }
                    if (columna == 1)
                    {
                        ColumnaTiempoDeLlegada(cadena, fila, columna, dtgResultado, tabla);
                    }
                    if (columna == 2)
                    {
                        ColumnaTiempoDeEntrada(cadena, fila, columna, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaTiempoDeServicio(cadena, fila, columna, dtgResultado, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaTiempoDeSalida(cadena, fila, columna, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaTiempoDeEspera(cadena, fila, columna, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaLongitudDeLaCola(cadena, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaLlegada(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {

            }
            else 
            {
                tabla.Rows[fila][columna] = fila + 1;
            }
        }

        public void ColumnaTiempoDeEntrada(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {

            }
            else 
            {
                if (fila == 0) 
                {
                    double tiempoDeLlegada = 0;
                    tiempoDeLlegada = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    tabla.Rows[fila][columna] = tiempoDeLlegada;
                }
                else 
                {
                    double tiempoDeEntradaAnterior = 0;
                    double tiempoDeServicioAnterior = 0;
                    double tiempoDeEntrada = 0;
                    tiempoDeEntradaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                    tiempoDeServicioAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna + 1]);
                    tiempoDeEntrada = tiempoDeEntradaAnterior + tiempoDeServicioAnterior;
                    tabla.Rows[fila][columna] = tiempoDeEntrada;
                }
            }
        }

        public void ColumnaTiempoDeLlegada(string cadena, int fila, int columna, DataGridView dtgResultado, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {

            }
            else 
            {
                double tiempoDeLLegada = 0;
                tiempoDeLLegada = Convert.ToDouble(dtgResultado[2, fila].Value);
                tabla.Rows[fila][columna] = tiempoDeLLegada;
            }
        }

        public void ColumnaTiempoDeServicio(string cadena, int fila, int columna, DataGridView dtgResultado, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n)
            {

            }
            else
            {
                double tiempoDeServicio = 0;
                tiempoDeServicio = Convert.ToDouble(dtgResultado[4, fila].Value);
                tabla.Rows[fila][columna] = tiempoDeServicio;
            }
        }

        public void ColumnaTiempoDeSalida(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {

            }
            else 
            {
                double tiempoDeEntrada = 0;
                double tiempoDeServicio = 0;
                double tiempoDeSalida = 0;
                tiempoDeEntrada = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                tiempoDeServicio = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                tiempoDeSalida = tiempoDeEntrada + tiempoDeServicio;
                tabla.Rows[fila][columna] = tiempoDeSalida;
            }
        }

        public void ColumnaTiempoDeEspera(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {
                double suma = 0;
                double promedio = 0;
                for (int i = 0; i < n; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][5]);
                }
                promedio = suma / n;
                tabla.Rows[fila][columna] = promedio;
            }
            else 
            {
                double tiempoDeEntrada = 0;
                double tiempoDeLlegada = 0;
                double tiempoDeEspera = 0;
                tiempoDeEntrada = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                tiempoDeLlegada = Convert.ToDouble(tabla.Rows[fila][columna - 4]);
                tiempoDeEspera = tiempoDeEntrada - tiempoDeLlegada;
                tabla.Rows[fila][columna] = tiempoDeEspera;
            }
        }

        public void ColumnaLongitud(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            int contador = 0;
            double llegada = 0;
            double salida = 0;
            double longitudColaAnterior = 0;
            n = NumeroSimulaciones(cadena);
            if (fila == n) 
            {
                double suma = 0;
                double promedio = 0;
                for (int i = 0; i < n; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][6]);
                }
                promedio = suma / n;
                tabla.Rows[fila][columna] = promedio;
            }
            else 
            {
                if (fila == 0) 
                {
                    llegada = Convert.ToDouble(tabla.Rows[fila][1]);
                    salida = Convert.ToDouble(tabla.Rows[fila][4]);
                    if (llegada >= salida) 
                    {
                        contador = contador + 1;
                        tabla.Rows[fila][columna] = contador;
                    }
                    else 
                    {
                        contador = 0;
                        tabla.Rows[fila][columna] = contador;
                    }
                }
                else 
                {
                    if (fila == 1) 
                    {
                        longitudColaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][6]);
                        llegada = Convert.ToDouble(tabla.Rows[fila][1]);
                        salida = Convert.ToDouble(tabla.Rows[fila - 1][4]);
                        if (llegada < salida) 
                        {
                            longitudColaAnterior = longitudColaAnterior + 1;
                            tabla.Rows[fila][columna] = longitudColaAnterior;
                        }
                        else 
                        {
                            tabla.Rows[fila][columna] = longitudColaAnterior;
                        }
                    }
                    else 
                    {
                        for (int i = 0; i < fila; i++)
                        {
                            contador = contador + Convert.ToInt32(tabla.Rows[i][6]);
                        }
                        contador = contador - 1;
                        llegada = Convert.ToDouble(tabla.Rows[fila][1]);
                        salida = Convert.ToDouble(tabla.Rows[contador][4]);
                        if (llegada < salida) 
                        {
                            longitudColaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][6]);
                            longitudColaAnterior = longitudColaAnterior + 1;
                            tabla.Rows[fila][columna] = longitudColaAnterior;
                        }
                        else 
                        {
                            longitudColaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][6]);
                            tabla.Rows[fila][columna] = longitudColaAnterior;
                        }
                    }
                }
            }
        }

        public void ColumnaLongitudDeLaCola(string cadena, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            if (n == fila) 
            {
                double suma = 0;
                double promedio = 0;
                for (int i = 0; i < n; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                promedio = suma / n;
                tabla.Rows[fila][columna] = promedio;
            }
            else 
            {
                double tiempoDeLLegada = 0;
                double tiempoDeSalida = 0;
                double longitudDeLaCola = 0;
                int contador = 0;
                for (int i = 0; i < (fila + 1); i++)
                {
                    tiempoDeLLegada = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                    tiempoDeSalida = Convert.ToDouble(tabla.Rows[i][columna - 2]);
                    if (tiempoDeLLegada < tiempoDeSalida)
                    {
                        
                    }
                    else 
                    {
                        contador = contador + 1;
                    }
                }
                longitudDeLaCola = fila - contador;
                if (fila == 0) 
                {

                }
                else 
                {
                    if (longitudDeLaCola == 0)
                    {
                        longitudDeLaCola = 1;
                    }
                }
                tabla.Rows[fila][columna] = longitudDeLaCola;
            }
        }

        public DataTable MostrarResultado(string cadena, DataGridView dtgResultado) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadena, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadena, dtgResultado, tabla);
            return tabla;
        }
    }
}
