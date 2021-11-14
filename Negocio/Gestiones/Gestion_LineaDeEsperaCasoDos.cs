using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Mapeos;
using System.Windows.Forms;
using System.Data;

namespace Negocio.Gestiones
{
    public class Gestion_LineaDeEsperaCasoDos:LineaDeEsperaCasoDos, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_LineaDeEsperaCasoDos()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
        }

        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [LineaDeEsperaCasoDos] (TiempoEntreLlegada, TiempoDeServicio, AleatorioEntrada, AleatorioServicio) values (" + this.TiempoEntreLlegada + ", " + this.TiempoDeServicio + ", " + this.AleatorioEntrada + ", " + this.AleatorioServicio + ")");
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
                tabla = baseDeDatos.EjecutarDataTableSQL("select ID, TiempoEntreLlegada, TiempoDeServicio, AleatorioEntrada, AleatorioServicio from [LineaDeEsperaCasoDos]");
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
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from LineaDeEsperaCasoDos"));
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
                cadenaFinal = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select " + cadena + " from [LineaDeEsperaCasoDos] where (ID=" + identificador + ")"));
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
                baseDeDatos.EjecutarEscalar("update [LineaDeEsperaCasoDos] set TiempoEntreLlegada=" + this.TiempoEntreLlegada + ", TiempoDeServicio=" + this.TiempoDeServicio + ", AleatorioEntrada=" + this.AleatorioEntrada + ", AleatorioServicio=" + this.AleatorioServicio + " where (ID=" + this.ID + ")");
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
                baseDeDatos.EjecutarEscalar("delete from [LineaDeEsperaCasoDos] where (ID=" + this.ID + ")");
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
