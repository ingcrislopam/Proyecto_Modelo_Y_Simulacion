using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class RegresionLineal
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
                    tabla.Columns.Add("x");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("y");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("(x^2)");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("xy");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("(y^2)");
                }
                if (columna == 5) 
                {
                    tabla.Columns.Add("recta");
                }
            }
        }

        public void CrearProcedimientos(string cadenaX, string cadenaY, TextBox txtE1, TextBox txtE2, TextBox txta0, TextBox txta1, TextBox txtFuncion, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaX);
            for (int columna = 0; columna < 6; columna++)
            {
                for (int fila = 0; fila < (n + 1); fila++)
                {
                    if (columna == 0) 
                    {
                        ColumnaXeY(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        ColumnaXeY(cadenaY, fila, columna, tabla);
                    }
                    if (columna == 2) 
                    {
                        ColumanXAlCuadrado(cadenaX ,fila, columna, tabla);
                    }
                    if (columna == 3) 
                    {
                        ColumnaXPorY(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaYAlCuadrado(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaRecta(cadenaX, fila, columna, txtE1, txtE2, txta0, txta1, txtFuncion, tabla);
                    }
                }
            }
        }

        public void ColumnaXeY(string cadena, int fila, int columna, DataTable tabla)
        {
            int n = 0;
            string ncadena = "";
            double sumatoria = 0;
            n = NumeroSimulaciones(cadena);
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
            if (fila == n)
            {
                for (int i = 0; i < n; i++)
                {
                    sumatoria = sumatoria + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                tabla.Rows[fila][columna] = sumatoria;
            }
        }

        public void ColumanXAlCuadrado(string cadenaX, int fila, int columna, DataTable tabla) 
        {
            int n=0;
            double sumatoria = 0;
            n = NumeroSimulaciones(cadenaX);
            if (fila == n) 
            {
                for (int i = 0; i < n; i++)
                {
                    sumatoria = sumatoria + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                tabla.Rows[fila][columna] = sumatoria;
            }
            else 
            {
                double x = 0;
                double xAlCuadrado = 0;
                x = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                xAlCuadrado = Math.Pow(x, 2);
                tabla.Rows[fila][columna] = xAlCuadrado;
            }
        }

        public void ColumnaXPorY(string cadenaX, int fila, int columna, DataTable tabla) 
        {
            int n=0;
            double x = 0;
            double y = 0;
            double xPorY = 0;
            double sumatoria = 0;
            n = NumeroSimulaciones(cadenaX);
            if (fila == n) 
            {
                for (int i = 0; i < n; i++)
                {
                    sumatoria = sumatoria + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                tabla.Rows[fila][columna] = sumatoria;
            }
            else 
            {
                x = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                y = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                xPorY = x * y;
                tabla.Rows[fila][columna] = xPorY;
            }
        }

        public void ColumnaYAlCuadrado(string cadenaX, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            double sumatoria = 0;
            n = NumeroSimulaciones(cadenaX);
            if (fila == n)
            {
                for (int i = 0; i < n; i++)
                {
                    sumatoria = sumatoria + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                tabla.Rows[fila][columna] = sumatoria;
            }
            else
            {
                double y = 0;
                double yAlCuadrado = 0;
                y = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                yAlCuadrado = Math.Pow(y, 2);
                tabla.Rows[fila][columna] = yAlCuadrado;
            }
        }

        public void ColumnaRecta(string cadenaX, int fila, int columna, TextBox txtE1, TextBox txtE2, TextBox txta0, TextBox txta1, TextBox txtFuncion, DataTable tabla) 
        {
            int n = 0;
            double sumatoriaX = 0;
            double sumatoriaY = 0;
            double sumatoriaXAlCuadrado = 0;
            double sumatoriaXPorY = 0;
            double aCero = 0;
            double aUno = 0;
            n = NumeroSimulaciones(cadenaX);
            sumatoriaX = Convert.ToDouble(tabla.Rows[n][columna - 5]);
            sumatoriaY = Convert.ToDouble(tabla.Rows[n][columna - 4]);
            sumatoriaXAlCuadrado = Convert.ToDouble(tabla.Rows[n][columna - 3]);
            sumatoriaXPorY = Convert.ToDouble(tabla.Rows[n][columna - 2]);
            txtE1.Text = ("" + n + "a0+" + sumatoriaX + "a1=" + sumatoriaY + "").Trim();
            txtE2.Text = ("" + sumatoriaX + "a0+" + sumatoriaXAlCuadrado + "a1=" + sumatoriaXPorY + "").Trim();
            aCero = ((sumatoriaY * sumatoriaXAlCuadrado) - (sumatoriaX * sumatoriaXPorY)) / ((n * sumatoriaXAlCuadrado) - Math.Pow(sumatoriaX, 2));
            aCero = Math.Round(aCero, 2);
            aUno = ((n * sumatoriaXPorY) - (sumatoriaX * sumatoriaY)) / ((n * sumatoriaXAlCuadrado) - Math.Pow(sumatoriaX, 2));
            aUno = Math.Round(aUno, 2);
            txta0.Text = ("" + aCero + "").Trim();
            txta1.Text = ("" + aUno + "").Trim();
            if (fila == n)
            {

            }
            else 
            {
                double x = 0;
                double recta = 0;
                x = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                if (aUno < 0)
                {
                    txtFuncion.Text = ("" + aCero + "-" + aUno + "(x)").Trim();
                    aUno = aUno * -1;
                    recta = aCero - (aUno * x);
                    tabla.Rows[fila][columna] = recta;
                }
                else 
                {
                    txtFuncion.Text = ("" + aCero + "+" + aUno + "(x)").Trim();
                    recta = aCero + (aUno * x);
                    tabla.Rows[fila][columna] = recta;
                }
            }
        }

        public void MostrarGrafica(string cadenaX, DataTable tabla, Chart grafica)
        {
            int n = 0;
            int i = 0;
            int j = 0;
            double valorUno = 0;
            double valorDos = 0;
            n = NumeroSimulaciones(cadenaX);
            for (i = 0; i < n; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][1]);
                grafica.Series["y"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 0; j < n; j++)
            {
                if (Convert.ToString(tabla.Rows[j][5]) == "")
                {

                }
                else
                {
                    valorDos = Convert.ToDouble(tabla.Rows[j][5]);
                    grafica.Series["recta"].Points.AddXY((j + 1), valorDos);
                }
            }
        }

        public DataTable MostrarResultado(string cadenaX, string cadenaY, TextBox txtE1, TextBox txtE2, TextBox txta0, TextBox txta1, TextBox txtFuncion, Chart grafica)
        {
            //int n = 0;
            //n = NumeroSimulaciones(cadena);
            DataTable tabla = new DataTable();
            CrearFilas(cadenaX, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadenaX, cadenaY, txtE1, txtE2, txta0, txta1, txtFuncion, tabla);
            MostrarGrafica(cadenaX, tabla, grafica);
            return tabla;
        }

    }
}
