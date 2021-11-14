using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Distribuciones
{
    public class PoliticaInventario
    {
        public void CrearFilas(int n, DataTable tabla) 
        {
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

        public void CrearProcedimientos(string demandas, string demandas2, int n, double cantidadOrdenar, double puntoDeReorden, double costoPorFaltante, double costoMantenimiento, double costoOrdenar, double inventarioInicial, DataTable tabla, DataGridView dataG1, DataGridView dataG2, DataGridView dataG1M, DataGridView dataG2M) 
        {
            for (int fila = 0; fila < (n + 1); fila++)
            {
                for (int columna = 0; columna < 12; columna++)
                {
                    if (columna == 0)
                    {
                        ColumnaSemana(n, fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        ColumnaAleatorioDistribucionOTiempo(n, fila, columna, tabla, dataG1);
                    }
                    if (columna == 2) 
                    {
                        ColumnaDemanda(demandas, n, fila, columna, tabla, dataG1M);
                    }
                    if (columna == 3) 
                    {
                        ColumnaPedido(n, fila, columna, cantidadOrdenar, puntoDeReorden, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaInventarioInicial(n, fila, columna, inventarioInicial, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaInventarioFinal(n, fila, columna, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaCostoPorFaltante(n, fila, columna, costoPorFaltante, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaCostoMantenimiento(n, fila, columna, costoMantenimiento, tabla);
                    }
                    if (columna == 8) 
                    {
                        ColumnaCostoOrdenar(n, fila, columna, cantidadOrdenar, costoOrdenar, tabla);
                    }
                    if (columna == 9) 
                    {
                        ColumnaAleatorioDistribucionOTiempo(n, fila, columna, tabla, dataG2);
                    }
                    if (columna == 10) 
                    {
                        ColumnaTiempoDeEntrega(demandas2, n, fila, columna, tabla, dataG2M);
                    }
                    if (columna == 11) 
                    {
                        ColumnaFechaEntrega(n, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaSemana(int n, int fila, int columna, DataTable tabla) 
        {
            if (fila == n)
            {

            }
            else 
            {
                tabla.Rows[fila][columna] = fila + 1;
            }
        }

        public void ColumnaAleatorioDistribucionOTiempo(int n, int fila, int columna, DataTable tabla, DataGridView dataG) 
        {
            double aleatorio = 0;
            if (fila == n)
            {

            }
            else 
            {
                aleatorio = Convert.ToDouble(dataG[4, fila].Value);
                tabla.Rows[fila][columna] = Math.Round(aleatorio, 3);
            }
        }

        public void ColumnaDemanda(string demandas, int n, int fila, int columna, DataTable tabla, DataGridView dataG1M) 
        {
            if (fila == n)
            {

            }
            else 
            {
                int hasta = 0;
                int contador = 0;
                double aleatorioD = 0;
                aleatorioD = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                hasta = NumeroSimulaciones(demandas);
                for (int i = 0; i < hasta; i++)
                {
                    double frecuencia = 0;
                    double acumulada = 0;
                    frecuencia = Convert.ToDouble(dataG1M[2, i].Value);
                    acumulada = Convert.ToDouble(dataG1M[3, i].Value);
                    if (aleatorioD >= frecuencia && aleatorioD < acumulada)
                    {
                        i = hasta;
                    }
                    else 
                    {
                        contador = contador + 1;
                    }
                }
                tabla.Rows[fila][columna] = contador + 1;
            }
        }

        public void ColumnaPedido(int n, int fila, int columna, double cantidadOrdenar, double puntoDeReorden, DataTable tabla) 
        {
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

        public void ColumnaInventarioInicial(int n, int fila, int columna, double inventarioInicial, DataTable tabla) 
        {
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

        public void ColumnaInventarioFinal(int n, int fila, int columna, DataTable tabla) 
        {
            double inventarioInicial = 0;
            double pedido = 0;
            double demanda = 0;
            double inventarioFinal = 0;
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

        public double Sumatoria(int n, int fila, int columna, DataTable tabla) 
        {
            double sumatoria = 0;
            for (int i = 0; i < n; i++)
            {
                sumatoria = sumatoria + Convert.ToDouble(tabla.Rows[i][columna]);
            }
            return sumatoria;
        }

        public void ColumnaCostoPorFaltante(int n, int fila, int columna, double costoPorFaltante, DataTable tabla) 
        {
            double inventarioInicial = 0;
            double pedido = 0;
            double demanda = 0;
            double inventarioFinal = 0;
            double faltante = 0;
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

        public void ColumnaCostoMantenimiento(int n, int fila, int columna, double costoMantenimiento, DataTable tabla) 
        {
            double inventarioFinal = 0;
            double mantenimiento = 0;
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

        public void ColumnaCostoOrdenar(int n, int fila, int columna, double cantidadOrdenar, double costoOrdenar, DataTable tabla) 
        {
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

        public void ColumnaTiempoDeEntrega(string demandas2, int n, int fila, int columna, DataTable tabla, DataGridView dataG2M) 
        {
            if (fila == n)
            {

            }
            else
            {
                int hasta = 0;
                int contador = 0;
                double aleatorioD = 0;
                aleatorioD = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                hasta = NumeroSimulaciones(demandas2);
                for (int i = 0; i < hasta; i++)
                {
                    double frecuencia = 0;
                    double acumulada = 0;
                    frecuencia = Convert.ToDouble(dataG2M[2, i].Value);
                    acumulada = Convert.ToDouble(dataG2M[3, i].Value);
                    if (aleatorioD >= frecuencia && aleatorioD < acumulada)
                    {
                        i = hasta;
                    }
                    else
                    {
                        contador = contador + 1;
                    }
                }
                tabla.Rows[fila][columna] = contador + 1;
            }
        }

        public void ColumnaFechaEntrega(int n, int fila, int columna, DataTable tabla) 
        {
            if (fila == n)
            {

            }
            else 
            {
                double semana = 0;
                double tiempoDeEntrega = 0;
                double fechaDeEntrega = 0;
                semana = Convert.ToDouble(tabla.Rows[fila][columna - 11]);
                tiempoDeEntrega = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                fechaDeEntrega = semana + tiempoDeEntrega;
                tabla.Rows[fila][columna] = fechaDeEntrega;
            }
        }

        public DataTable MostrarResultado(string demandas, string demandas2, int n, double cantidadOrdenar, double puntoDeReorden, double costoPorFaltante, double costoMantenimiento, double costoOrdenar, double inventarioInicial, DataGridView dataG1, DataGridView dataG2, DataGridView dataG1M, DataGridView dataG2M) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(n, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(demandas, demandas2, n, cantidadOrdenar, puntoDeReorden, costoPorFaltante, costoMantenimiento, costoOrdenar, inventarioInicial, tabla, dataG1, dataG2, dataG1M, dataG2M);
            return tabla;
        }
    }
}
