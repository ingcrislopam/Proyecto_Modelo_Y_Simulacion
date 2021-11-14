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
    public class Gestion_AleatoriosVentasImpresoras:AleatoriosVentasImpresoras, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_AleatoriosVentasImpresoras()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
        }
        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [AleatoriosVentasImpresoras] (Mes, Cantidad, Cobro) values ('" + this.Mes + "', '" + this.Cantidad + "', '" + this.Cobro + "')");
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
                tabla = baseDeDatos.EjecutarDataTableSQL("select ID, Mes, Cantidad, Cobro from [AleatoriosVentasImpresoras]");
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
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from AleatoriosVentasImpresoras"));
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

        public void Modificar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("update [AleatoriosVentasImpresoras] set Mes='" + this.Mes + "', Cantidad='" + this.Cantidad + "', Cobro='" + this.Cobro + "' where (ID=" + this.ID + ")");
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
                baseDeDatos.EjecutarEscalar("delete from [AleatoriosVentasImpresoras] where (ID=" + this.ID + ")");
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
