using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class VariableAleatoria
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
                    tabla.Columns.Add("f(x)");
                }
                if (columna == 6) 
                {
                    tabla.Columns.Add("integrar o F(x)");
                }
                if (columna == 7) 
                {
                    tabla.Columns.Add("inversa o f(x)^-1");
                }
            }
        }

        public void CrearProcedimientos(int n, int m, int Xn, int a, int c, string primerPar, string segundoPar, DataTable tabla)
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
                        ColumnafDeX(fila, columna, primerPar, segundoPar, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaIntegrar(fila, columna, primerPar, segundoPar, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaInversa(fila, columna, primerPar, segundoPar, tabla);
                    }
                }
            }
        }

        public void ColumnafDeX(int fila, int columna, string primerPar, string segundoPar, DataTable tabla) 
        {
            double ri = 0;
            double fDeX = 0;
            ri = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
            if (Convert.ToDouble(primerPar) == 0) 
            {
                fDeX = Convert.ToDouble(segundoPar);
            }
            if (Convert.ToDouble(segundoPar) == 0) 
            {
                fDeX = (Convert.ToDouble(primerPar) * ri);
            }
            if (Convert.ToDouble(primerPar) >= 0 && Convert.ToDouble(segundoPar) >= 0) 
            {
                fDeX = (Convert.ToDouble(primerPar) * (ri) + Convert.ToDouble(segundoPar));
            }
            if (Convert.ToDouble(primerPar) >= 0 && Convert.ToDouble(segundoPar) < 0) 
            {
                fDeX = (Convert.ToDouble(primerPar) * (ri) - Convert.ToDouble(segundoPar));
            }
            if (Convert.ToDouble(primerPar) < 0 && Convert.ToDouble(segundoPar) >= 0) 
            {
                fDeX = ((Convert.ToDouble(primerPar) * -1) * (ri) + Convert.ToDouble(segundoPar));
            }
            if (Convert.ToDouble(primerPar) < 0 && Convert.ToDouble(segundoPar) < 0) 
            {
                fDeX = ((Convert.ToDouble(primerPar) * -1) * (ri) - Convert.ToDouble(segundoPar));
            }
            tabla.Rows[fila][columna] = fDeX;
        }

        public void ColumnaIntegrar(int fila, int columna, string primerPar, string segundoPar, DataTable tabla) 
        {
            double ri = 0;
            double FDeX = 0;
            ri = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
            if (Convert.ToDouble(primerPar) == 0) 
            {
                FDeX = (Convert.ToDouble(segundoPar) * ri);
            }
            if (Convert.ToDouble(segundoPar) == 0) 
            {
                FDeX = ((Convert.ToDouble(primerPar) / 2) * Math.Pow(ri, 2));
            }
            if (Convert.ToDouble(primerPar) >= 0 && Convert.ToDouble(segundoPar) >= 0)
            {
                FDeX = (((Convert.ToDouble(primerPar) / 2) * Math.Pow(ri, 2)) + (Convert.ToDouble(segundoPar) * ri));
            }
            if (Convert.ToDouble(primerPar) >= 0 && Convert.ToDouble(segundoPar) < 0)
            {
                FDeX = (((Convert.ToDouble(primerPar) / 2) * Math.Pow(ri, 2)) + ((Convert.ToDouble(segundoPar) * -1) * ri));
            }
            if (Convert.ToDouble(primerPar) < 0 && Convert.ToDouble(segundoPar) >= 0)
            {
                FDeX = ((((Convert.ToDouble(primerPar) * -1) / 2) * Math.Pow(ri, 2)) + (Convert.ToDouble(segundoPar) * ri));
            }
            if (Convert.ToDouble(primerPar) < 0 && Convert.ToDouble(segundoPar) < 0)
            {
                FDeX = ((((Convert.ToDouble(primerPar) * -1) / 2) * Math.Pow(ri, 2)) + ((Convert.ToDouble(segundoPar) * -1) * ri));
            }
            tabla.Rows[fila][columna] = FDeX;
        }

        public void ColumnaInversa(int fila, int columna, string primerPar, string segundoPar, DataTable tabla) 
        {
            double ri = 0;
            double primero = 0;
            double segundo = 0;
            double inversa = 0;
            ri = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
            primero = Convert.ToDouble(primerPar);
            segundo = Convert.ToDouble(segundoPar);
            if (primero == 0) 
            {
                inversa = (ri / segundo);
            }
            if (segundo == 0) 
            {
                inversa = Math.Sqrt((2 * ri) / primero);
            }
            if (primero >= 0 && segundo >= 0)
            {
                inversa = ((1 / primero) * ((segundo * -1) + Math.Sqrt(((2 * primero) * ri) + Math.Pow(segundo, 2))));
            }
            if (primero >= 0 && segundo < 0)
            {
                inversa = ((1 / primero) * ((((segundo*-1) * -1) * -1) + Math.Sqrt(((2 * primero) * ri) + Math.Pow((segundo * -1), 2))));
            }
            if (primero < 0 && segundo >= 0)
            {
                inversa = ((1 / (primero * -1)) * ((segundo * -1) + Math.Sqrt(((2 * (primero * -1)) * ri) + Math.Pow(segundo, 2))));
            }
            if (primero < 0 && segundo < 0)
            {
                inversa = ((1 / (primero * -1)) * (((segundo * -1) * -1) + Math.Sqrt(((2 * (primero * -1)) * ri) + Math.Pow((segundo * -1), 2))));
            }
            tabla.Rows[fila][columna] = inversa;
        }

        public void MostrarGrafica(int n, DataTable tabla, Chart grafica)
        {
            double valorUno = 0;
            double valorDos = 0;
            double valorTres = 0;
            for (int i = 0; i < n; i++)
            {
                valorUno = Convert.ToDouble(tabla.Rows[i][5]);
                grafica.Series["funcion"].Points.AddXY((i + 1), valorUno);
            }
            for (int j = 0; j < n; j++)
            {
                valorDos = Convert.ToDouble(tabla.Rows[j][6]);
                grafica.Series["integrar"].Points.AddXY((j + 1), valorDos);
            }
            for (int k = 0; k < n; k++)
            {
                valorTres = Convert.ToDouble(tabla.Rows[k][7]);
                grafica.Series["inversa"].Points.AddXY((k + 1), valorTres);
            }
        }

        public DataTable MostrarResultado(int n, int m, int Xn, int a, int c, string primerPar, string segundoPar, Chart grafica)
        {
            DataTable tabla = new DataTable();
            CrearFilas(n, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(n, m, Xn, a, c, primerPar, segundoPar, tabla);
            MostrarGrafica(n, tabla, grafica);
            return tabla;
        }
    }
}
