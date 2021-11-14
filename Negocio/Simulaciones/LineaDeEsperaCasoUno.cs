using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Simulaciones
{
    public class LineaDeEsperaCasoUno
    {
        public void CrearFilas(string cadena, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadena);
            for (int fila = 0; fila < (n + 3); fila++)
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
            for (int columna = 0; columna < 10; columna++)
            {
                if (columna == 0)
                {
                    tabla.Columns.Add("numero");
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
                    tabla.Columns.Add("hora de iniciacion del servicio");
                }
                if (columna == 7)
                {
                    tabla.Columns.Add("hora de terminacion del servicio");
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

        public void CrearProcedimientos(string cadenaLlegada, string cadenaServicio, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < (n + 3); fila++)
                {
                    if (columna == 0) 
                    {
                        ColumnaNumero(cadenaLlegada, fila, columna, tabla);
                    }
                    if (columna == 1) 
                    {
                        ColumnaLlegada(cadenaLlegada, fila, columna, tabla);
                    }
                    if (columna == 2) 
                    {
                        ColumnaServicio(cadenaServicio, fila, columna, tabla);
                    }
                }
            }
        }

        public void CrearProcedimientosFaltantes(string cadenaLlegada, double mediaTiempoEntreLlegada, double mediaTiempoDeServicio, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            for (int fila = 0; fila < (n + 3); fila++)
            {
                for (int columna = 0; columna < 10; columna++)
                {
                    if (columna == 0) 
                    {
 
                    }
                    if (columna == 1) 
                    {
 
                    }
                    if (columna == 2) 
                    {
 
                    }
                    if (columna == 3) 
                    {
                        ColumnaTiempoEntreLlegadas(cadenaLlegada, fila, columna, mediaTiempoEntreLlegada, tabla);
                    }
                    if (columna == 4) 
                    {
                        ColumnaTiempoDeServicio(cadenaLlegada, fila, columna, mediaTiempoDeServicio, tabla);
                    }
                    if (columna == 5) 
                    {
                        ColumnaHoraDeLlegadaExacta(cadenaLlegada, fila, columna, tabla);
                    }
                    if (columna == 6) 
                    {
                        ColumnaHoraDeIniciacionDelServicio(cadenaLlegada, fila, columna, tabla);
                    }
                    if (columna == 7) 
                    {
                        ColumnaHoraDeTerminacionDelServicio(cadenaLlegada, fila, columna, tabla);
                    }
                    if (columna == 8) 
                    {
                        ColumnaTiempoDeEspera(cadenaLlegada, fila, columna, tabla);
                    }
                    if (columna == 9) 
                    {
                        ColumnaTiempoEnElSistema(cadenaLlegada, fila, columna, tabla);
                    }
                }
            }
        }

        public void ColumnaNumero(string cadenaLlegada, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila > n) 
            {
 
            }
            else
            {
                tabla.Rows[fila][columna] = fila;
            }
        }

        public void ColumnaLlegada(string cadenaLlegada, int fila, int columna, DataTable tabla)
        {
            string ncadena = "";
            if (fila == 1)
            {
                for (int i = 0; i < cadenaLlegada.Length; i++)
                {
                    if (Convert.ToString(cadenaLlegada[i]) == "-")
                    {
                        ncadena = ncadena.Trim();
                        tabla.Rows[fila][columna] = ncadena;
                        fila = fila + 1;
                        ncadena = "";
                    }
                    else
                    {
                        ncadena = ncadena + Convert.ToString(cadenaLlegada[i]);
                        ncadena = ncadena.Trim();
                    }
                }
            }
        }

        public void ColumnaServicio(string cadenaServicio, int fila, int columna, DataTable tabla)
        {
            string ncadena = "";
            if (fila == 1)
            {
                for (int i = 0; i < cadenaServicio.Length; i++)
                {
                    if (Convert.ToString(cadenaServicio[i]) == "-")
                    {
                        ncadena = ncadena.Trim();
                        tabla.Rows[fila][columna] = ncadena;
                        fila = fila + 1;
                        ncadena = "";
                    }
                    else
                    {
                        ncadena = ncadena + Convert.ToString(cadenaServicio[i]);
                        ncadena = ncadena.Trim();
                    }
                }
            }
        }

        public void ColumnaTiempoEntreLlegadas(string cadenaLlegada, int fila, int columna, double mediaTiempoEntreLlegada, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila == 0 || fila > n)
            {

            }
            else 
            {
                double llegada = 0;
                double tiempoEntreLlegada = 0;
                llegada = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                mediaTiempoEntreLlegada = mediaTiempoEntreLlegada * -1;
                tiempoEntreLlegada = mediaTiempoEntreLlegada * Math.Log(llegada);
                tiempoEntreLlegada = Math.Round(tiempoEntreLlegada, 3);
                tabla.Rows[fila][columna] = tiempoEntreLlegada;
            }
        }

        public void ColumnaTiempoDeServicio(string cadenaLlegada, int fila, int columna, double mediaTiempoDeServicio, DataTable tabla)
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila == 0 || fila > n)
            {

            }
            else
            {
                double llegada = 0;
                double tiempoDeServicio = 0;
                llegada = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                mediaTiempoDeServicio = mediaTiempoDeServicio * -1;
                tiempoDeServicio = mediaTiempoDeServicio * Math.Log(llegada);
                tiempoDeServicio = Math.Round(tiempoDeServicio, 3);
                tabla.Rows[fila][columna] = tiempoDeServicio;
            }
        }

        public void ColumnaHoraDeLlegadaExacta(string cadenaLlegada, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila > n) 
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
                    double horaDeLlegadaExactaAnterior = 0;
                    double tiempoEntreLlegadas = 0;
                    double horaDeLlegadaExacta = 0;
                    horaDeLlegadaExactaAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna]);
                    tiempoEntreLlegadas = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    horaDeLlegadaExacta = horaDeLlegadaExactaAnterior + tiempoEntreLlegadas;
                    horaDeLlegadaExacta = Math.Round(horaDeLlegadaExacta, 3);
                    tabla.Rows[fila][columna] = horaDeLlegadaExacta;
                }
            }
        }

        public void ColumnaHoraDeIniciacionDelServicio(string cadenaLlegada, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila > n) 
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
                    double horaDeTerminacionDelServicioAnterior = 0;
                    double horaDeLlegadaExacta = 0;
                    double mayor = 0;
                    double horaDeIniciacionDelServicio = 0;
                    horaDeTerminacionDelServicioAnterior = Convert.ToDouble(tabla.Rows[fila - 1][columna + 1]);
                    horaDeLlegadaExacta = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    mayor = horaDeLlegadaExacta;
                    if (horaDeTerminacionDelServicioAnterior > mayor) 
                    {
                        mayor = horaDeTerminacionDelServicioAnterior;
                    }
                    horaDeIniciacionDelServicio = mayor;
                    horaDeIniciacionDelServicio = Math.Round(horaDeIniciacionDelServicio, 3);
                    tabla.Rows[fila][columna] = horaDeIniciacionDelServicio;
                }
            }
        }

        public void ColumnaHoraDeTerminacionDelServicio(string cadenaLlegada, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila > n)
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
                    double tiempoDeServicio = 0;
                    double horaDeIniciacionDelServicio = 0;
                    double horaDeTerminacionDelServicio = 0;
                    tiempoDeServicio = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                    horaDeIniciacionDelServicio = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    horaDeTerminacionDelServicio = tiempoDeServicio + horaDeIniciacionDelServicio;
                    horaDeTerminacionDelServicio = Math.Round(horaDeTerminacionDelServicio, 3);
                    tabla.Rows[fila][columna] = horaDeTerminacionDelServicio;
                }
            }
        }

        public void ColumnaTiempoDeEspera(string cadenaLlegada, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            if (fila > n) 
            {
                if (fila == (n + 1)) 
                {
                    double suma = 0;
                    double promedio = 0;
                    for (int i = 0; i < (n + 1); i++)
                    {
                        suma = suma + Convert.ToDouble(tabla.Rows[i][columna]);
                    }
                    promedio = suma / n;
                    promedio = Math.Round(promedio, 3);
                    tabla.Rows[fila][columna] = promedio;
                }
                else 
                {
                    double promedio = 0;
                    double porcentaje = 0;
                    promedio = Convert.ToDouble(tabla.Rows[n + 1][columna]);
                    porcentaje = promedio / 60;
                    porcentaje = porcentaje * 100;
                    porcentaje = Math.Round(porcentaje, 3);
                    tabla.Rows[n + 2][columna] = ("" + porcentaje + "%").Trim();
                }
            }
            else 
            {
                if (fila == 0) 
                {
                    tabla.Rows[fila][columna] = 0;
                }
                else 
                {
                    double horaDeIniciacionDelServicio = 0;
                    double horaDeLlegadaExacta = 0;
                    double tiempoDeEspera = 0;
                    horaDeIniciacionDelServicio = Convert.ToDouble(tabla.Rows[fila][columna - 2]);
                    horaDeLlegadaExacta = Convert.ToDouble(tabla.Rows[fila][columna - 3]);
                    tiempoDeEspera = horaDeIniciacionDelServicio - horaDeLlegadaExacta;
                    tiempoDeEspera = Math.Round(tiempoDeEspera, 3);
                    tabla.Rows[fila][columna] = tiempoDeEspera;
                }
            }
        }

        public void ColumnaTiempoEnElSistema(string cadenaLlegada, int fila, int columna, DataTable tabla) 
        {
            int n = 0;
            int nf = 0;
            n = NumeroSimulaciones(cadenaLlegada);
            nf = n + 1;
            if (fila > n) 
            {
                double suma = 0;
                double promedio = 0;
                for (int i = 0; i < nf; i++)
                {
                    suma = suma + Convert.ToDouble(tabla.Rows[i][columna]);
                }
                promedio = suma / n;
                promedio = Math.Round(promedio, 3);
                tabla.Rows[n + 1][columna] = promedio;
            }
            else 
            {
                if (fila == 0) 
                {
                    tabla.Rows[fila][columna] = 0;
                }
                else 
                {
                    double tiempoDeEspera = 0;
                    double tiempoDeServicio = 0;
                    double tiempoEnElSistema = 0;
                    tiempoDeEspera = Convert.ToDouble(tabla.Rows[fila][columna - 1]);
                    tiempoDeServicio = Convert.ToDouble(tabla.Rows[fila][columna - 5]);
                    tiempoEnElSistema = tiempoDeEspera + tiempoDeServicio;
                    tiempoEnElSistema = Math.Round(tiempoEnElSistema, 3);
                    tabla.Rows[fila][columna] = tiempoEnElSistema;
                }
            }
        }
        

        public DataTable MostrarResultado(string cadenaLlegada, string cadenaServicio, double mediaTiempoEntreLlegada, double mediaTiempoDeServicio)
        {
            DataTable tabla = new DataTable();
            CrearFilas(cadenaLlegada, tabla);
            CrearColumnas(tabla);
            CrearProcedimientos(cadenaLlegada, cadenaServicio, tabla);
            CrearProcedimientosFaltantes(cadenaLlegada, mediaTiempoEntreLlegada, mediaTiempoDeServicio, tabla);
            return tabla;
        }
    }
}
