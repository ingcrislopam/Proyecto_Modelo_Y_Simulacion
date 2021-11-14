using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Simulaciones;
using System.Windows.Forms;
using System.Data;

namespace Negocio.Gestiones
{
    public class Gestion_Simulacion:Simulacion, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_Simulacion()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
        }

        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [Simulacion] (IdArreglo, IdVenta) values (" + this.IdArreglo + ", " + this.IdVenta + ")");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Dato insertado correctamente");
            }
            catch (Exception ex)
            {
                baseDeDatos.CancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.Desconectar();
            }
        }

        public DataTable Buscar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                DataTable tabla;
                tabla = baseDeDatos.EjecutarDataTableSQL("select ID, IdArreglo, IdVenta from [Simulacion]");
                baseDeDatos.confirmarTransaccion();
                return tabla;
            }
            catch (Exception ex)
            {
                baseDeDatos.CancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.Desconectar();
            }
        }

        public int CantidadElementos()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                int n = 0;
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from Simulacion"));
                baseDeDatos.confirmarTransaccion();
                return n;
            }
            catch (Exception ex)
            {
                baseDeDatos.CancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally
            {
                baseDeDatos.Desconectar();
            }
        }

        public int RetornarValor(string cadena, string identificador)
        {
            try
            {
                int cadenaFinal = 0;
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                cadenaFinal = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select " + cadena + " from [Simulacion] where (ID=" + identificador + ")"));
                baseDeDatos.confirmarTransaccion();
                return cadenaFinal;
            }
            catch (Exception ex)
            {
                baseDeDatos.CancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally
            {
                baseDeDatos.Desconectar();
            }
        }

        public void Modificar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("update [Simulacion] set IdArreglo=" + this.IdArreglo + ", IdVenta=" + this.IdVenta + " where (ID=" + this.ID + ")");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Dato modificado correctamente");
            }
            catch (Exception ex)
            {
                baseDeDatos.CancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.Desconectar();
            }
        }

        public void Eliminar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("delete from [Simulacion] where (ID=" + this.ID + ")");
                baseDeDatos.confirmarTransaccion();
                MessageBox.Show("Dato eliminado correctamente");
            }
            catch (Exception ex)
            {
                baseDeDatos.CancelarTransaccion();
                throw new Exception(ex.Message);
            }
            finally 
            {
                baseDeDatos.Desconectar();
            }
        }
    }
}
