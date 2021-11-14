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
    public class RegresionCuadratica
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
            for (int columna = 0; columna < 9; columna++)
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
                    tabla.Columns.Add("(x^3)");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("(x^4)");
                }
                if (columna == 5)
                {
                    tabla.Columns.Add("xy");
                }
                if (columna == 6) 
                {
                    tabla.Columns.Add("(x^2)y");
                }
                if (columna == 7) 
                {
                    tabla.Columns.Add("(y^2)");
                }
                if (columna == 8) 
                {
                    tabla.Columns.Add("calculos");
                }
            }
        }

        public void CrearProcedimientos(string cadenaX, string cadenaY, TextBox txtEcu1, TextBox txtEcu2, TextBox txtEcu3,TextBox txta0, TextBox txta1, TextBox txta2, TextBox txtF, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaX);
            for (int columna = 0; columna < 9; columna++)
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
                        ColumanXAlCuadrado(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 3)
                    {
                        ColumnaXAlCubo(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 4)
                    {
                        ColumnaXAlaCuarta(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 5)
                    {
                        ColumnaXPorY(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaXAlCuadradoPorY(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaYAlCuadrado(cadenaX, fila, columna, tabla);
                    }
                    if (columna == 8) 
                    {
                        ColumnaCalculo(cadenaX, fila, columna, txtEcu1, txtEcu2, txtEcu3, txta0, txta1, txta2, txtF, tabla);
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
                double x = 0;
                double xAlCuadrado = 0;
                x = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                xAlCuadrado = Math.Pow(x, 2);
                tabla.Rows[fila][columna] = xAlCuadrado;
            }
        }

        public void ColumnaXAlCubo(string cadenaX, int fila, int columna, DataTable tabla) 
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
                double x = 0;
                double xAlCubo = 0;
                x = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                xAlCubo = Math.Pow(x, 3);
                tabla.Rows[fila][columna] = xAlCubo;
            }
        }

        public void ColumnaXAlaCuarta(string cadenaX, int fila, int columna, DataTable tabla) 
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
                double x = 0;
                double xAlaCuarta = 0;
                x = Convert.ToDouble(tabla.Rows[fila][columna - 4]);
                xAlaCuarta = Math.Pow(x, 4);
                tabla.Rows[fila][columna] = xAlaCuarta;
            }
        }

        public void ColumnaXPorY(string cadenaX, int fila, int columna, DataTable tabla)
        {
            int n = 0;
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
                x = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                y = Convert.ToDouble(tabla.Rows[fila][columna - 4]);
                xPorY = x * y;
                tabla.Rows[fila][columna] = xPorY;
            }
        }

        public void ColumnaXAlCuadradoPorY(string cadenaX, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            double xAlCuadrado = 0;
            double y = 0;
            double xAlCuadradoPorY = 0;
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
                xAlCuadrado = Convert.ToDouble(tabla.Rows[fila][columna - 4]);
                y = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                xAlCuadradoPorY = xAlCuadrado * y;
                tabla.Rows[fila][columna] = xAlCuadradoPorY;
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
                y = Convert.ToDouble(tabla.Rows[fila][columna - 6]);
                yAlCuadrado = Math.Pow(y, 2);
                tabla.Rows[fila][columna] = yAlCuadrado;
            }
        }

        public void ColumnaCalculo(string cadenaX, int fila, int columna, TextBox txtEcu1, TextBox txtEcu2, TextBox txtEcu3, TextBox txta0, TextBox txta1, TextBox txta2, TextBox txtF, DataTable tabla) 
        {
            int n = 0;
            double sumatoriaX = 0;
            double sumatoriaY = 0;
            double sumatoriaXAlCuadrado = 0;
            double sumatoriaXAlCubo = 0;
            double sumatoriaXAlaCuarta = 0;
            double sumatoriaXPorY = 0;
            double sumatoriaXAlCuadradoPorY = 0;
            double valor1 = 0;
            double valor2 = 0;
            double valor3 = 0;
            double valor4 = 0;
            double valor5 = 0;
            double valor6 = 0;
            double valor7 = 0;
            double b = 0;
            double c = 0;
            double a = 0;
            n = NumeroSimulaciones(cadenaX);
            sumatoriaX = Convert.ToDouble(tabla.Rows[n][columna - 8]);
            sumatoriaY = Convert.ToDouble(tabla.Rows[n][columna - 7]);
            sumatoriaXAlCuadrado = Convert.ToDouble(tabla.Rows[n][columna - 6]);
            sumatoriaXAlCubo = Convert.ToDouble(tabla.Rows[n][columna - 5]);
            sumatoriaXAlaCuarta = Convert.ToDouble(tabla.Rows[n][columna - 4]);
            sumatoriaXPorY = Convert.ToDouble(tabla.Rows[n][columna - 3]);
            sumatoriaXAlCuadradoPorY = Convert.ToDouble(tabla.Rows[n][columna - 2]);
            txtEcu1.Text = ("" + n + "a0+" + sumatoriaX + "a1+" + sumatoriaXAlCuadrado + "a2=" + sumatoriaY + "").Trim();
            txtEcu2.Text = ("" + sumatoriaX + "a0+" + sumatoriaXAlCuadrado + "a1+" + sumatoriaXAlCubo + "a2=" + sumatoriaXPorY + "").Trim();
            txtEcu3.Text = ("" + sumatoriaXAlCuadrado + "a0+" + sumatoriaXAlCubo + "a1+" + sumatoriaXAlaCuarta + "a2=" + sumatoriaXAlCuadradoPorY + "").Trim();
            valor1 = (sumatoriaXPorY - ((sumatoriaX * sumatoriaY) / n));
            valor2 = (sumatoriaXAlaCuarta - ((Math.Pow(sumatoriaXAlCuadrado, 2)) / n));
            valor3 = (sumatoriaXAlCuadradoPorY - ((sumatoriaXAlCuadrado * sumatoriaY) / n));
            valor4 = (sumatoriaXAlCubo - ((sumatoriaXAlCuadrado * sumatoriaX) / n));
            valor5 = (sumatoriaXAlCuadrado - ((Math.Pow(sumatoriaX, 2)) / n));
            valor6 = valor2;
            valor7 = Math.Pow(valor4, 2);
            b = ((valor1 * valor2) - (valor3 * valor4)) / ((valor5 * valor6) - valor7);
            valor1 = 0;
            valor2 = 0;
            valor3 = 0;
            valor4 = 0;
            valor5 = 0;
            valor6 = 0;
            valor7 = 0;
            b = Math.Round(b, 4);
            valor1 = (sumatoriaXAlCuadrado - ((Math.Pow(sumatoriaX, 2)) / n));
            valor2 = (sumatoriaXAlCuadradoPorY - ((sumatoriaXAlCuadrado * sumatoriaY) / n));
            valor3 = (sumatoriaXAlCubo - ((sumatoriaXAlCuadrado * sumatoriaX) / n));
            valor4 = (sumatoriaXPorY - ((sumatoriaX * sumatoriaY) / n));
            valor5 = valor1;
            valor6 = (sumatoriaXAlaCuarta - ((Math.Pow(sumatoriaXAlCuadrado, 2)) / n));
            valor7 = Math.Pow(valor3, 2);
            c = ((valor1 * valor2) - (valor3 * valor4)) / ((valor5 * valor6) - valor7);
            c = Math.Round(c, 4);
            if (b >= 0 && c >= 0) 
            {
                a = (sumatoriaY - (b * sumatoriaX) - (c * sumatoriaXAlCuadrado)) / n;
                txtF.Text = ("" + Math.Round(a, 4) + "+" + b + "(x)+" + c + "(x^2)").Trim();
            }
            if (b >= 0 && c < 0) 
            {
                double c1 = 0;
                a = (sumatoriaY - (b * sumatoriaX) + ((c * -1) * sumatoriaXAlCuadrado)) / n;
                c1 = c;
                c1 = c1 * -1;
                txtF.Text = ("" + Math.Round(a, 4) + "+" + b + "(x)-" + c1 + "(x^2)").Trim();
            }
            if (b < 0 && c >= 0) 
            {
                double b1;
                a = (sumatoriaY + ((b * -1) * sumatoriaX) - (c * sumatoriaXAlCuadrado)) / n;
                b1 = b;
                b1 = b1 * -1;
                txtF.Text = ("" + Math.Round(a, 4) + "-" + b1 + "(x)+" + c + "(x^2)").Trim();
            }
            if (b < 0 && c < 0) 
            {
                double b1 = 0;
                double c1 = 0;
                a = (sumatoriaY + ((b * -1) * sumatoriaX) + ((c * -1) * sumatoriaXAlCuadrado)) / n;
                b1 = b;
                b1 = b1 * -1;
                c1 = c;
                c1 = c1 * -1;
                txtF.Text = ("" + Math.Round(a, 4) + "-" + b1 + "(x)-" + c1 + "(x^2)").Trim();
            }
            a = Math.Round(a, 4);
            txta0.Text = ("" + a + "").Trim();
            txta1.Text = ("" + b + "").Trim();
            txta2.Text = ("" + c + "").Trim();
            if (fila == n)
            {

            }
            else
            {
                double x = 0;
                double calculo = 0;
                x = Convert.ToDouble(tabla.Rows[fila][columna - 8]);
                if (b >= 0 && c >= 0) 
                {
                    calculo = a + (b * x) + (c * Math.Pow(x, 2));
                    tabla.Rows[fila][columna] = calculo;
                }
                if (b >= 0 && c < 0) 
                {
                    c = c * -1;
                    calculo = a + (b * x) - (c * Math.Pow(x, 2));
                    tabla.Rows[fila][columna] = calculo;
                }
                if (b < 0 && c >= 0) 
                {
                    b = b * -1;
                    calculo = a - (b * x) + (c * Math.Pow(x, 2));
                    tabla.Rows[fila][columna] = calculo;
                }
                if (b < 0 && c < 0) 
                {
                    b = b * -1;
                    c = c * -1;
                    calculo = a - (b * x) - (c * Math.Pow(x, 2));
                    tabla.Rows[fila][columna] = calculo;
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
                if (Convert.ToString(tabla.Rows[j][8]) == "")
                {

                }
                else
                {
                    valorDos = Convert.ToDouble(tabla.Rows[j][8]);
                    grafica.Series["calculo"].Points.AddXY((j + 1), valorDos);
                }
            }
        }

        public DataTable MostrarResultado(string cadenaX, string cadenaY, TextBox txtEcu1, TextBox txtEcu2, TextBox txtEcu3, TextBox txta0, TextBox txta1, TextBox txta2, TextBox txtF, Chart grafica)
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadenaX, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadenaX, cadenaY, txtEcu1, txtEcu2, txtEcu3, txta0, txta1, txta2, txtF, tabla);
            MostrarGrafica(cadenaX, tabla, grafica);
            return tabla;
        }

    }
}
