using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio.Distribuciones
{
    public class CongruencialLineal
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
            for (int columna = 0; columna < 5; columna++)
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
            }
        }

        public void CrearProcedimientos(int n, int m, int Xn, int a, int c, DataTable tabla)
        {
            Base miBase = new Base();
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
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
                }
            }
        }

        public void MostrarGrafica(int n, DataTable tabla, Chart grafica)
        {
            int i = 0;
            double valor = 0;
            for (i = 0; i < n; i++)
            {
                valor = Convert.ToDouble(tabla.Rows[i][4]);
                grafica.Series["congruencial"].Points.AddXY((i + 1), valor);
            }
        }

        public DataTable MostrarResultado(int n, int m, int Xn, int a, int c, Chart grafica)
        {
            DataTable tabla = new DataTable();
            CrearFilas(n, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(n, m, Xn, a, c, tabla);
            MostrarGrafica(n, tabla, grafica);
            return tabla;
        }

        public DataTable MostrarResultadoSegundaOpcion(int n, int m, int Xn, int a, int c)
        {
            DataTable tabla = new DataTable();
            CrearFilas(n, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(n, m, Xn, a, c, tabla);
            return tabla;
        }
    }
}
