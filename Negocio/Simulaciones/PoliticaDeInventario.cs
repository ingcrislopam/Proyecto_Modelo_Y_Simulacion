using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Simulaciones
{
    public class PoliticaDeInventario
    {
        public void CrearFilas(string cadenaAleatorios, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaAleatorios);
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
            for (int columna = 0; columna < 12; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("semana");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("aleatorio distribucion");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("demanda");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("pedido");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("inventario inicial");
                }
                if (columna == 5)
                {
                    tabla.Columns.Add("inventario final");
                }
                if (columna == 6)
                {
                    tabla.Columns.Add("costo por faltante");
                }
                if (columna == 7)
                {
                    tabla.Columns.Add("costo mantenimiento");
                }
                if (columna == 8)
                {
                    tabla.Columns.Add("costo ordenar");
                }
                if (columna == 9)
                {
                    tabla.Columns.Add("aleatorio tiempo entrega");
                }
                if (columna == 10)
                {
                    tabla.Columns.Add("tiempo entrega");
                }
                if (columna == 11)
                {
                    tabla.Columns.Add("fecha entrega");
                }
            }
        }

        public void CrearProcedimientos(string aleatorioDistribucion, string aleatorioTiempoDeEntrega, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            for (int columna = 0; columna < 12; columna++)
            {
                for (int fila = 0; fila < (n + 1); fila++)
                {
                    if (columna == 1) 
                    {
                        ColumnaAleatorioDistribucionYTiempoDeEntrega(aleatorioDistribucion, fila, columna, tabla);
                    }
                    if (columna == 9) 
                    {
                        ColumnaAleatorioDistribucionYTiempoDeEntrega(aleatorioTiempoDeEntrega, fila, columna, tabla);
                    }
                }
            }
        }

        public void CrearProcedimientosFaltantes(string aleatorioDistribucion, double cantidadOrdenar, double puntoDeReorden, double costoPorFaltante, double costoMantenimiento, double costoOrdenar, double inventarioInicial, DataGridView dataD, DataGridView dataT, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            for (int fila = 0; fila < (n + 1); fila++)
            {
                for (int columna = 0; columna < 12; columna++)
                {
                    if (columna == 0) 
                    {
                        ColumnaSemana(aleatorioDistribucion, fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {

                    }
                    if (columna == 2) 
                    {
                        ColumnaDemandaYTiempoDeEntrega(aleatorioDistribucion, fila, columna, dataD, tabla);
                    }
                    if (columna == 3) 
                    {
                        ColumnaPedido(aleatorioDistribucion, fila, columna, cantidadOrdenar, puntoDeReorden, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaInventarioInicial(aleatorioDistribucion, fila, columna, inventarioInicial, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaInventarioFinal(aleatorioDistribucion, fila, columna, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaCostoPorFaltante(aleatorioDistribucion, fila, columna, costoPorFaltante, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaCostoMantenimiento(aleatorioDistribucion, fila, columna, costoMantenimiento, tabla);
                    }
                    if (columna == 8) 
                    {
                        ColumnaCostoOrdenar(aleatorioDistribucion, fila, columna, cantidadOrdenar, costoOrdenar, tabla);
                    }
                    if (columna == 10) 
                    {
                        ColumnaDemandaYTiempoDeEntrega(aleatorioDistribucion, fila, columna, dataT, tabla);
                    }
                    if (columna == 11) 
                    {
                        ColumnaFechaDeEntrega(aleatorioDistribucion, fila, columna, tabla);
                    }
                }

            }
        }

        public void ColumnaSemana(string aleatorioDistribucion, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {

            }
            else 
            {
                tabla.Rows[fila][columna] = fila + 1;
            }
        }

        public void ColumnaAleatorioDistribucionYTiempoDeEntrega(string cadena, int fila, int columna, DataTable tabla)
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

        public void ColumnaDemandaYTiempoDeEntrega(string aleatorioDistribucion, int fila, int columna, DataGridView dataG, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n) 
            {
                
            }
            else 
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
        }

        public void ColumnaPedido(string aleatorioDistribucion, int fila, int columna, double cantidadOrdenar, double puntoDeReorden, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {

            }
            else
            {
                if (fila == 0)
                {
                    tabla.Rows[fila][columna] = 0;
                }
                else
                {
                    int contador = 0;
                    double semana = 0;
                    double fechaEntrega = 0;
                    double inventarioFinal = 0;
                    double pedido = 0;
                    semana = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                    for (int i = 0; i < fila; i++)
                    {
                        fechaEntrega = Convert.ToDouble(tabla.Rows[i][columna + 8]);
                        if (semana == fechaEntrega)
                        {
                            contador = contador + 1;
                        }
                        else
                        {

                        }
                    }
                    inventarioFinal = Convert.ToDouble(tabla.Rows[fila - 1][columna + 2]);
                    if (contador > 0 && inventarioFinal <= puntoDeReorden)
                    {
                        pedido = contador * cantidadOrdenar;
                        tabla.Rows[fila][columna] = pedido;
                    }
                    else
                    {
                        tabla.Rows[fila][columna] = 0;
                    }
                }
            }
        }

        public void ColumnaInventarioInicial(string aleatorioDistribucion, int fila, int columna, double inventarioInicial, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {

            }
            else
            {
                double inventarioFinal = 0;
                if (fila == 0)
                {
                    tabla.Rows[fila][columna] = inventarioInicial;
                }
                else
                {
                    inventarioFinal = Convert.ToDouble(tabla.Rows[fila - 1][columna + 1]);
                    tabla.Rows[fila][columna] = inventarioFinal;
                }
            }
        }

        public void ColumnaInventarioFinal(string aleatorioDistribucion, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            double inventarioInicial = 0;
            double pedido = 0;
            double demanda = 0;
            double inventarioFinal = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {

            }
            else
            {
                inventarioInicial = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                pedido = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                demanda = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                inventarioFinal = (inventarioInicial + pedido) - demanda;
                if (inventarioFinal < 0)
                {
                    tabla.Rows[fila][columna] = 0;
                }
                else
                {
                    tabla.Rows[fila][columna] = inventarioFinal;
                }
            }
        }

        public void ColumnaCostoPorFaltante(string aleatorioDistribucion, int fila, int columna, double costoPorFaltante, DataTable tabla) 
        {
            int n = 0;
            double inventarioInicial = 0;
            double pedido = 0;
            double demanda = 0;
            double inventarioFinal = 0;
            double faltante = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {
                tabla.Rows[fila][columna] = Sumatoria(n, fila, columna, tabla);
            }
            else
            {
                inventarioInicial = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                pedido = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                demanda = Convert.ToDouble(tabla.Rows[fila][columna - 4]);
                inventarioFinal = (inventarioInicial + pedido) - demanda;
                if (inventarioFinal > 0)
                {
                    tabla.Rows[fila][columna] = 0;
                }
                else
                {
                    inventarioFinal = inventarioFinal * -1;
                    faltante = inventarioFinal * costoPorFaltante;
                    tabla.Rows[fila][columna] = faltante;
                }
            }
        }

        public void ColumnaCostoMantenimiento(string aleatorioDistribucion, int fila, int columna, double costoMantenimiento, DataTable tabla) 
        {
            int n = 0;
            double inventarioFinal = 0;
            double mantenimiento = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {
                tabla.Rows[fila][columna] = Sumatoria(n, fila, columna, tabla);
            }
            else
            {
                inventarioFinal = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                mantenimiento = inventarioFinal * costoMantenimiento;
                tabla.Rows[fila][columna] = mantenimiento;
            }
        }

        public void ColumnaCostoOrdenar(string aleatorioDistribucion, int fila, int columna, double cantidadOrdenar, double costoOrdenar, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {
                tabla.Rows[fila][columna] = Sumatoria(n, fila, columna, tabla);
            }
            else
            {
                double pedido = 0;
                pedido = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                if (pedido == 0)
                {
                    tabla.Rows[fila][columna] = 0;
                }
                else
                {
                    pedido = pedido / cantidadOrdenar;
                    tabla.Rows[fila][columna] = pedido * costoOrdenar;
                }
            }
        }

        public double Sumatoria(int n, int fila, int columna, DataTable tabla)
        {
            double sumatoria = 0;
            for (int i = 0; i < n; i++)
            {
                sumatoria = sumatoria + Convert.ToDouble(tabla.Rows[i][columna]);
            }
            return sumatoria;
        }

        public void ColumnaFechaDeEntrega(string aleatorioDistribucion, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(aleatorioDistribucion);
            if (fila == n)
            {

            }
            else 
            {
                double tiempoDeEntrega = 0;
                double semana = 0;
                double fechaDeEntrega = 0;
                tiempoDeEntrega = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                semana = Convert.ToDouble(tabla.Rows[fila][columna - 11]);
                fechaDeEntrega = tiempoDeEntrega + semana;
                tabla.Rows[fila][columna] = fechaDeEntrega;
            }
        }

        public DataTable MostrarResultado(string aleatorioDistribucion, string aleatorioTiempoDeEntrega, double cantidadOrdenar, double puntoDeReorden, double costoPorFaltante, double costoMantenimiento, double costoOrdenar, double inventarioInicial, DataGridView dataD, DataGridView dataT) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(aleatorioDistribucion, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(aleatorioDistribucion, aleatorioTiempoDeEntrega, tabla);
            CrearProcedimientosFaltantes(aleatorioDistribucion, cantidadOrdenar, puntoDeReorden, costoPorFaltante, costoMantenimiento, costoOrdenar, inventarioInicial, dataD, dataT, tabla);
            return tabla;
        }
    }
}
