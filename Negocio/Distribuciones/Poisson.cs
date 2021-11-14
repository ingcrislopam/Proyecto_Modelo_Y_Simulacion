using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class Poisson
    {
        public void CrearFilas(int n, DataTable tabla)
        {
            for (int fila = 0; fila < n; fila++)
            {
                tabla.Rows.Add();
            }
        }

        public void CrearColumnas(DataTable tabla)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("n");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("Xn");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("aXn+c");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("Xn+1");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("ri");
                }
                if (columna == 5) 
                {
                    tabla.Columns.Add(" ");
                }
                if (columna == 6) 
                {
                    tabla.Columns.Add("poisson");
                }
                if (columna == 7) 
                {
                    tabla.Columns.Add("acumulada");
                }
            }
        }

        public void CrearProcedimientos(int n, int m, int Xn, int a, int c, double landa, DataTable tabla)
        {
            Base miBase = new Base();
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    if (columna == 0) 
                    {
                        miBase.ColumnaN(fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        miBase.ColumnaXn(fila, columna, Xn, tabla);
                    }
                    if (columna == 2) 
                    {
                        miBase.ColumnaAxn(fila, columna, a, c, tabla);
                    }
                    if (columna == 3) 
                    {
                        miBase.ColumnaXnMasUno(fila, columna, m, tabla);
                    }
                    if (columna == 4) 
                    {
                        miBase.ColumnaRi(fila, columna, m, tabla);
                    }
                    if (columna == 5) 
                    {

                    }
                    if (columna == 6) 
                    {
                        ColumnaPoisson(fila, columna, landa, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaAcumulada(fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaPoisson(int fila, int columna, double landa, DataTable tabla) 
        {
            double ri = 0;
            double numerador = 0;
            double denominador = 0;
            double poisson = 0;
            ri = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
            numerador = (Math.Pow(landa, ri)) * (Math.Pow(2.718, (landa * -1)));
            denominador = 1;
            poisson = numerador / denominador;
            tabla.Rows[fila][columna] = poisson;
        }

        public void ColumnaAcumulada(int fila, int columna, DataTable tabla) 
        {
            double valorUno = 0;
            double valorDos = 0;
            double acumulada = 0;
            if (fila == 0) 
            {
                valorUno = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                acumulada = valorUno;
                tabla.Rows[fila][columna] = acumulada;
            }
            else 
            {
                valorUno = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                valorDos = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                acumulada = valorUno + valorDos;
                tabla.Rows[fila][columna] = acumulada;
            }
        }

        public void MostrarGrafica(int n, DataTable tabla, Chart grafica)
        {
            int i = 0;
            int j = 0;
            double valorUno = 0;
            double valorDos = 0;
            for (i = 0; i < n; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][7]);
                grafica.Series["acumulada"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 0; j < n; j++)
            {
                valorDos = Convert.ToDouble(tabla.Rows[j][6]);
                grafica.Series["poisson"].Points.AddXY((j + 1), valorDos);
            }
        }

        public DataTable MostrarResultado(int n, int m, int Xn, int a, int c, double landa, Chart grafica)
        {
            DataTable tabla = new DataTable();
            CrearFilas(n, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(n, m, Xn, a, c, landa, tabla);
            MostrarGrafica(n, tabla, grafica);
            return tabla;
        }

    }
}
