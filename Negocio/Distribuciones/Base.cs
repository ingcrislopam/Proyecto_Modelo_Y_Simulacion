using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Distribuciones
{
    public class Base
    {
        public void ColumnaN(int fila, int columna, DataTable tabla)
        {
            tabla.Rows[fila][columna] = fila;
        }

        public void ColumnaXn(int fila, int columna, int Xn, DataTable tabla)
        {
            if (fila == 0)
            {
                tabla.Rows[fila][columna] = Xn;
            }
            else
            {
                tabla.Rows[fila][columna] = tabla.Rows[fila - 1][columna + 2];
            }
        }

        public void ColumnaAxn(int fila, int columna, int a, int c, DataTable tabla)
        {
            int Xn = 0;
            Xn = Convert.ToInt32(tabla.Rows[fila][columna - 1]);
            tabla.Rows[fila][columna] = (a * Xn) + c;
        }

        public void ColumnaXnMasUno(int fila, int columna, int m, DataTable tabla)
        {
            int aXn = 0;
            aXn = Convert.ToInt32(tabla.Rows[fila][columna - 1]);
            tabla.Rows[fila][columna] = aXn % m;
        }

        public void ColumnaRi(int fila, int columna, int m, DataTable tabla)
        {
            int XnMasUno = 0;
            double ri = 0;
            XnMasUno = Convert.ToInt32(tabla.Rows[fila][columna - 1]);
            ri = Convert.ToDouble(XnMasUno) / Convert.ToDouble(m);
            tabla.Rows[fila][columna] = ri;
        }
    }
}
