using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class Exponencial
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
            for (int columna = 0; columna < 11; columna++)
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
                    tabla.Columns.Add("1-ri");
                }
                if (columna == 7) 
                {
                    tabla.Columns.Add("t");
                }
                if (columna == 8) 
                {
                    tabla.Columns.Add("media");
                }
                if (columna == 9) 
                {
                    tabla.Columns.Add("mediana");
                }
                if (columna == 10) 
                {
                    tabla.Columns.Add("varianza");
                }
            }
        }

        public void CrearProcedimientos(int n, int m, int Xn, int a, int c, double landa, DataTable tabla) 
        {
            Base miBase = new Base();
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < 11; columna++)
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
                        ColumnaUnoMenosRi(fila, columna, tabla);
                    }
                    if (columna == 7)
                    {
                        ColumnaT(fila, columna, landa, tabla);
                    }
                    if (columna == 8)
                    {
                        Media(fila, columna, landa, tabla);
                    }
                    if (columna == 9) 
                    {
                        Mediana(fila, columna, landa, tabla);
                    }
                    if (columna == 10) 
                    {
                        Varianza(fila, columna, landa, tabla);
                    }
                }
            }
        }

        public void ColumnaUnoMenosRi(int fila, int columna, DataTable tabla)
        {
            double ri = 0;
            double unoMenosRi = 0;
            ri = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
            unoMenosRi = 1 - ri;
            tabla.Rows[fila][columna] = unoMenosRi;
        }

        public void ColumnaT(int fila, int columna, double landa, DataTable tabla) 
        {
            double unoMenorRi = 0;
            double resultadoUno = 0;
            double resultadoDos = 0;
            double t = 0;
            unoMenorRi = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
            resultadoUno = (1 / landa) * -1;
            resultadoDos = Math.Log(unoMenorRi);
            t = resultadoUno * resultadoDos;
            tabla.Rows[fila][columna] = t;
        }

        public void Media(int fila, int columna, double landa, DataTable tabla) 
        {
            if (fila == 0) 
            {
                double media = 0;
                media = 1 / landa;
                tabla.Rows[fila][columna] = media;
            }
        }

        public void Mediana(int fila, int columna, double landa, DataTable tabla) 
        {
            if (fila == 0) 
            {
                double numerador = 0;
                double denominador = 0;
                double mediana = 0;
                numerador = Math.Log(2);
                denominador = landa;
                mediana = numerador / denominador;
                tabla.Rows[fila][columna] = mediana;
            }
        }

        public void Varianza(int fila, int columna, double landa, DataTable tabla) 
        {
            if (fila == 0) 
            {
                double potencia = 0;
                double varianza = 0;
                potencia = Math.Pow(landa, 2);
                varianza = 1 / potencia;
                tabla.Rows[fila][columna] = varianza;
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
                valorUno = Convert.ToDouble(tabla.Rows[i][4]);
                grafica.Series["ri"].Points.AddXY((i + 1), valorUno);
            }
            for (j = 0; j < n; j++)
            {
                valorDos = Convert.ToDouble(tabla.Rows[j][7]);
                grafica.Series["t"].Points.AddXY((j + 1), valorDos);
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
