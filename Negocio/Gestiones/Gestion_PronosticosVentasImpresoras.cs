using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Mapeos;
using System.Data;
using System.Windows.Forms;

namespace Negocio.Gestiones
{
    public class Gestion_PronosticosVentasImpresoras:PronosticosVentasImpresoras, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_PronosticosVentasImpresoras()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
        }

        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [PronosticosVentasImpresoras] (MesPronostico, CantidadVenta, Cobro, Evaluar) values ('" + this.MesPronostico + "', '" + this.CantidadVenta + "', '" + this.Cobro + "', '" + this.Evaluar + "')");
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
                tabla = baseDeDatos.EjecutarDataTableSQL("select ID, MesPronostico, CantidadVenta, Cobro, Evaluar from [PronosticosVentasImpresoras]");
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
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from PronosticosVentasImpresoras"));
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

        public string RetornarValor(string cadena, string identificador)
        {
            try
            {
                string cadenaFinal = "";
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                cadenaFinal = Convert.ToString(baseDeDatos.EjecutarEscalar("select " + cadena + " from [PronosticosVentasImpresoras] where (ID=" + identificador + ")"));
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
                baseDeDatos.EjecutarEscalar("update [PronosticosVentasImpresoras] set MesPronostico='" + this.MesPronostico + "', CantidadVenta='" + this.CantidadVenta + "', Cobro='" + this.Cobro + "', Evaluar='" + this.Evaluar + "' where (ID=" + this.ID + ")");
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
                baseDeDatos.EjecutarEscalar("delete from [PronosticosVentasImpresoras] where (ID=" + this.ID + ")");
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
