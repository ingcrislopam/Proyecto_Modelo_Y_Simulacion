using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Distribuciones
{
    public class LineasDeEsperaUnCanal
    {
        public void CrearFilas(int n, DataTable tabla)
        {
            for (int fila = 0; fila < (n + 3); fila++)
            {
                tabla.Rows.Add();
            }
        }

        public void CrearColumnas(DataTable tabla)
        {
            for (int columna = 0; columna < 10; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("n");
                }
                if (columna == 1)
                {
                    tabla.Columns.Add("llegada");
                }
                if (columna == 2)
                {
                    tabla.Columns.Add("servicio");
                }
                if (columna == 3)
                {
                    tabla.Columns.Add("tiempo entre llegadas");
                }
                if (columna == 4)
                {
                    tabla.Columns.Add("tiempo de servicio");
                }
                if (columna == 5)
                {
                    tabla.Columns.Add("hora de llegada exacta");
                }
                if (columna == 6)
                {
                    tabla.Columns.Add("hora de iniciación del servicio");
                }
                if (columna == 7)
                {
                    tabla.Columns.Add("hora de terminación del servicio");
                }
                if (columna == 8)
                {
                    tabla.Columns.Add("tiempo de espera");
                }
                if (columna == 9)
                {
                    tabla.Columns.Add("tiempo en el sistema");
                }
            }
        }

        public void CrearProcedimientos(int n, double mediaTiempoEntreLlegadas, double mediaTiempoDeServicio, DataTable tabla, DataGridView dataG1, DataGridView dataG2) 
        {
            Base miBase = new Base();
            for (int fila = 0; fila < (n + 3); fila++)
            {
                for (int columna = 0; columna < 10; columna++)
                {
                    if (columna == 0) 
                    {
                        if (fila == (n + 1) || fila == (n + 2))
                        {

                        }
                        else 
                        {
                            miBase.ColumnaN(fila, columna, tabla);
                        }
                    }
                    if (columna == 1) 
                    {
                        ColumnaAleatorioLlegadaOServicio(n, fila, columna, tabla, dataG1);
                    }
                    if (columna == 2)
                    {
                        ColumnaAleatorioLlegadaOServicio(n, fila, columna, tabla, dataG2);
                    }
                    if (columna == 3) 
                    {
                        ColumnaTiempoEntreLlegadas(n, fila, columna, mediaTiempoEntreLlegadas, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaTiempoDeServicio(n, fila, columna, mediaTiempoDeServicio, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaHoraDeLlegadaExacta(n, fila, columna, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaHoraDeIniciacionDelServicio(n, fila, columna, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaHoraDeTerminacionDelServicio(n, fila, columna, tabla);
                    }
                    if (columna == 8) 
                    {
                        ColumnaTiempoDeEspera(n, fila, columna, tabla);
                    }
                    if (columna == 9) 
                    {
                        ColumnaTiempoEnElSistema(n, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaAleatorioLlegadaOServicio(int n, int fila, int columna, DataTable tabla, DataGridView dataG) 
        {
            if (fila == 0 || fila == (n + 1) || fila == (n + 2))
            {

            }
            else
            {
                tabla.Rows[fila][columna] = Math.Round(Convert.ToDouble(dataG[4, (fila - 1)].Value), 3);
            }
        }

        public void ColumnaTiempoEntreLlegadas(int n, int fila, int columna, double mediaTiempoEntreLlegadas, DataTable tabla) 
        {
            double llegada = 0;
            double tiempoEntreLlegadas = 0;
            if (fila == 0 || fila == (n + 1) || fila == (n + 2))
            {

            }
            else
            {
                llegada = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                tiempoEntreLlegadas = (mediaTiempoEntreLlegadas * -1) * Math.Log(llegada);
                tabla.Rows[fila][columna] = Math.Round(tiempoEntreLlegadas, 3);
            }
        }

        public void ColumnaTiempoDeServicio(int n, int fila, int columna, double mediaTiempoDeServicio, DataTable tabla) 
        {
            double servicio = 0;
            double tiempoDeServicio = 0;
            if (fila == 0 || fila == (n + 1) || fila == (n + 2))
            {

            }
            else
            {
                servicio = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                tiempoDeServicio = (mediaTiempoDeServicio * -1) * Math.Log(servicio);
                tabla.Rows[fila][columna] = Math.Round(tiempoDeServicio, 3);
            }
        }

        public void ColumnaHoraDeLlegadaExacta(int n, int fila, int columna, DataTable tabla) 
        {
            double horaDeLlegadaExactaAnterior = 0;
            double tiempoEntreLlegadas = 0;
            double horaDeLlegadaExacta = 0;
            if (fila == 0)
            {
                tabla.Rows[fila][columna] = 0;
            }
            else
            {
                if (fila == (n + 1) || fila == (n + 2))
                {

                }
                else 
                {
                    horaDeLlegadaExactaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                    tiempoEntreLlegadas = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    horaDeLlegadaExacta = horaDeLlegadaExactaAnterior + tiempoEntreLlegadas;
                    tabla.Rows[fila][columna] = Math.Round(horaDeLlegadaExacta, 3);
                }
            }
        }

        public void ColumnaHoraDeIniciacionDelServicio(int n, int fila, int columna, DataTable tabla) 
        {
            double horaDeLlegadaExacta = 0;
            double horaDeTerminacionDelServicioAnterior = 0;
            double mayor = 0;
            double horaDeIniciacionDelServicio = 0;
            if (fila == 0)
            {
                tabla.Rows[fila][columna] = 0;
            }
            else 
            {
                if (fila == (n + 1) || fila == (n + 2))
                {

                }
                else 
                {
                    horaDeLlegadaExacta = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    horaDeTerminacionDelServicioAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna + 1]);
                    mayor = horaDeLlegadaExacta;
                    if (horaDeTerminacionDelServicioAnterior > mayor)
                    {
                        mayor = horaDeTerminacionDelServicioAnterior;
                    }
                    horaDeIniciacionDelServicio = mayor;
                    tabla.Rows[fila][columna] = Math.Round(horaDeIniciacionDelServicio, 3);
                }
            }
        }

        public void ColumnaHoraDeTerminacionDelServicio(int n, int fila, int columna, DataTable tabla) 
        {
            double horaDeIniciacionDelServicio = 0;
            double tiempoDeServicio = 0;
            double horaDeTerminacionDelServicio = 0;
            if (fila == 0)
            {
                tabla.Rows[fila][columna] = 0;
            }
            else 
            {
                if (fila == (n + 1) || fila == (n + 2))
                {

                }
                else 
                {
                    horaDeIniciacionDelServicio = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    tiempoDeServicio = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                    horaDeTerminacionDelServicio = horaDeIniciacionDelServicio + tiempoDeServicio;
                    tabla.Rows[fila][columna] = Math.Round(horaDeTerminacionDelServicio, 3);
                }
            }
        }

        public double Promedio(int n, int columna, DataTable tabla) 
        {
            double suma = 0;
            double promedio = 0;
            for (int i = 1; i < (n + 1); i++)
            {
                suma = suma + Convert.ToDouble(tabla.Rows[i][columna]);
            }
            promedio = suma / n;
            return promedio;
        }

        public void ColumnaTiempoDeEspera(int n, int fila, int columna, DataTable tabla) 
        {
            double horaDeIniciacionDelServicio = 0;
            double horaDeLlegadaExacta = 0;
            double tiempoDeEspera = 0;
            double tiempoDeEsperaAnterior = 0;
            if (fila == 0) 
            {
                tabla.Rows[fila][columna] = 0;
            }
            else 
            {
                if (fila == (n + 1) || fila == (n + 2))
                {
                    if (fila == (n + 1))
                    {
                        tabla.Rows[fila][columna] = Math.Round(Promedio(n, columna, tabla), 3);
                    }
                    else 
                    {
                        tiempoDeEsperaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                        tiempoDeEspera = tiempoDeEsperaAnterior / 60;
                        tiempoDeEspera = tiempoDeEspera * 100;
                        tabla.Rows[fila][columna] = (Convert.ToString(Math.Round(tiempoDeEspera, 3)) + "%").Trim();
                    }
                    
                }
                else 
                {
                    horaDeIniciacionDelServicio = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    horaDeLlegadaExacta = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                    tiempoDeEspera = horaDeIniciacionDelServicio - horaDeLlegadaExacta;
                    tabla.Rows[fila][columna] = Math.Round(tiempoDeEspera, 3);
                }
                
            }
        }

        public void ColumnaTiempoEnElSistema(int n, int fila, int columna, DataTable tabla) 
        {
            double tiempoDeEspera = 0;
            double tiempoDeServicio = 0;
            double tiempoEnElSistema = 0;
            if (fila == 0) 
            {
                tabla.Rows[fila][columna] = 0;
            }
            else 
            {
                if (fila == (n + 1) || fila == (n + 2))
                {
                    if (fila == (n + 1)) 
                    {
                        tabla.Rows[fila][columna] = Math.Round(Promedio(n, columna, tabla), 3);
                    }
                    else 
                    {
 
                    } 
                }
                else 
                {
                    tiempoDeEspera = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    tiempoDeServicio = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                    tiempoEnElSistema = tiempoDeEspera + tiempoDeServicio;
                    tabla.Rows[fila][columna] = Math.Round(tiempoEnElSistema, 3);
                }
                
            }
        }

        public DataTable MostrarResultado(int n, double mediaTiempoEntreLlegadas, double mediaTiempoDeServicio, DataGridView dataG1, DataGridView dataG2) 
        {
            DataTable tabla = new DataTable();
            CrearFilas(n, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(n, mediaTiempoEntreLlegadas, mediaTiempoDeServicio, tabla, dataG1, dataG2);
            return tabla;
        }
    }
}
