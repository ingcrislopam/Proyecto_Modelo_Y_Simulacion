using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Simulaciones
{
    public class PromedioMovilDoble
    {
        public void CrearFilas(DataGridView dtg, DataTable tabla) 
        {
            int n = 0;
            n = dtg.RowCount;
            for (int i = 0; i < (n + 1); i++)
            {
                tabla.Rows.Add();
            }
        }

        public void CrearColumnas(DataTable tabla) 
        {
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) 
                {
                    tabla.Columns.Add("mes");
                }
                if (i == 1) 
                {
                    tabla.Columns.Add("cantidad o venta");
                }
                if (i == 2) 
                {
                    tabla.Columns.Add("cobro");
                }
                if (i == 3) 
                {
                    tabla.Columns.Add("simple (cantidad o venta)");
                }
                if (i == 4) 
                {
                    tabla.Columns.Add("simple (cobro)");
                }
                if (i == 5) 
                {
                    tabla.Columns.Add("doble (cantidad o venta)");
                }
                if (i == 6) 
                {
                    tabla.Columns.Add("doble (cobro)");
                }
            }
        }

        public void CrearProcedimientos(int evaluar, DataTable tabla, DataGridView dtg)
        {
            int n = 0;
            n = dtg.RowCount;
            for (int columna = 0; columna < 7; columna++)
            {
                for (int fila = 0; fila < (n + 1); fila++)
                {
                    if (columna == 0) 
                    {
                        ColumnaMes(fila, columna, tabla, dtg);
                    }
                    if (columna == 1) 
                    {
                        ColumnaCantidadOVenta(fila, columna, tabla, dtg);
                    }
                    if (columna == 2) 
                    {
                        ColumnaCobro(fila, columna, tabla, dtg);
                    }
                    if (columna == 3) 
                    {
                        ColumnaSimpleOVentaCantidad(fila, columna, evaluar, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaSimpleCobro(fila, columna, evaluar, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaDobleOVentaCantidad(fila, columna, evaluar, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaDobleCobro(fila, columna, evaluar, tabla);
                    }
                }
            }
        }

        public void ColumnaMes(int fila, int columna, DataTable tabla, DataGridView dtg) 
        {
            int n = 0;
            n = dtg.RowCount;
            if (fila == n)
            {

            }
            else 
            {
                string mes = "";
                mes = Convert.ToString(dtg[1, fila].Value);
                tabla.Rows[fila][columna] = mes;
            }
        }

        public void ColumnaCantidadOVenta(int fila, int columna, DataTable tabla, DataGridView dtg)
        {
            int n = 0;
            n = dtg.RowCount;
            if (fila == n)
            {

            }
            else
            {
                string cantidad = "";
                cantidad = Convert.ToString(dtg[2, fila].Value);
                tabla.Rows[fila][columna] = cantidad;
            }
        }

        public void ColumnaCobro(int fila, int columna, DataTable tabla, DataGridView dtg)
        {
            int n = 0;
            n = dtg.RowCount;
            if (fila == n)
            {

            }
            else
            {
                string cobro = "";
                cobro = Convert.ToString(dtg[3, fila].Value);
                tabla.Rows[fila][columna] = cobro;
            }
        }

        public void ColumnaSimpleOVentaCantidad(int fila, int columna, int evaluar, DataTable tabla) 
        {
            if (fila >= evaluar)
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluar;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 2]);
                }
                promedio = demandas / evaluar;
                tabla.Rows[fila][columna] = Math.Round(promedio, 0);
            }
        }

        public void ColumnaSimpleCobro(int fila, int columna, int evaluar, DataTable tabla)
        {
            if (fila >= evaluar)
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluar;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 2]);
                }
                promedio = demandas / evaluar;
                tabla.Rows[fila][columna] = Math.Round(promedio, 2);
            }
        }

        public void ColumnaDobleOVentaCantidad(int fila, int columna, int evaluar, DataTable tabla) 
        {
            double nuevoEvaluar = 0;
            nuevoEvaluar = evaluar * 2;
            if (fila >= nuevoEvaluar)
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluar;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 2]);
                }
                promedio = demandas / evaluar;
                tabla.Rows[fila][columna] = Math.Round(promedio, 0);
            }
        }

        public void ColumnaDobleCobro(int fila, int columna, int evaluar, DataTable tabla)
        {
            double nuevoEvaluar = 0;
            nuevoEvaluar = evaluar * 2;
            if (fila >= nuevoEvaluar)
            {
                int inicio = 0;
                double demandas = 0;
                double promedio;
                inicio = fila - evaluar;
                for (int i = inicio; i < fila; i++)
                {
                    demandas = demandas + Convert.ToDouble(tabla.Rows[i][columna - 2]);
                }
                promedio = demandas / evaluar;
                tabla.Rows[fila][columna] = Math.Round(promedio, 2);
            }
        }

        public void MostrarGrafica(DataTable tabla, Chart grafica, Chart grafica2, DataGridView dtg)
        {
            int i = 0;
            int n = 0;
            n = dtg.RowCount;
            double valor = 0;
            double valor2 = 0;
            for (i = 0; i < (n + 1); i++)
            {
                if (i == n) 
                {
                    valor = Convert.ToDouble(tabla.Rows[i][5]);
                    valor2 = Convert.ToDouble(tabla.Rows[i][6]);
                    grafica.Series["cantidad"].Points.AddXY((i + 1), valor);
                    grafica2.Series["costo"].Points.AddXY((i + 1), valor2);
                }
                else 
                {
                    valor = Convert.ToDouble(tabla.Rows[i][1]);
                    valor2 = Convert.ToDouble(tabla.Rows[i][2]);
                    grafica.Series["cantidad"].Points.AddXY((i + 1), valor);
                    grafica2.Series["costo"].Points.AddXY((i + 1), valor2);
                }
            }
        }

        public DataTable MostrarResultado(int evaluar, DataGridView dtg, Chart grafica, Chart grafica2) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(dtg, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(evaluar, tabla, dtg);
            MostrarGrafica(tabla, grafica, grafica2, dtg);
            return tabla;
        }


    }
}
