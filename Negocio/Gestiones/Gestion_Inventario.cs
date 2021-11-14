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
    public class Gestion_Inventario:Inventario, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_Inventario()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
        }

        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [Inventario] (IdDistribucion, IdTiempo, IdDistribucionM, IdTiempoM, CantidadOrdenar, PuntoReorden, CostoPorFaltantes, CostoMantenimiento, CostoOrdenar, InventarioInicial) values (" + this.IdDistribucion + ", " + this.IdTiempo + ", " + this.IdDistribucionM + ", " + this.IdTiempoM + ", '" + this.CantidadOrdenar + "', '" + this.PuntoReorden + "', '" + this.CostoPorFaltantes + "', '" + this.CostoMantenimiento + "', '" + this.CostoOrdenar + "', '" + this.InventarioInicial + "')");
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
                DataTable tablaR;
                tablaR = baseDeDatos.EjecutarDataTableSQL("select ID, IdDistribucion, IdTiempo, IdDistribucionM, IdTiempoM, CantidadOrdenar, PuntoReorden, CostoPorFaltantes, CostoMantenimiento, CostoOrdenar, InventarioInicial from [Inventario]");
                baseDeDatos.confirmarTransaccion();
                return tablaR;
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
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from Inventario"));
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
                string valor = "";
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                valor = Convert.ToString(baseDeDatos.EjecutarEscalar("select " + cadena + " from [Inventario] where (ID=" + identificador + ")"));
                baseDeDatos.confirmarTransaccion();
                return valor;
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
                baseDeDatos.EjecutarEscalar("update [Inventario] set IdDistribucion=" + this.IdDistribucion + ", IdTiempo=" + this.IdTiempo + ", IdDistribucionM=" + this.IdDistribucionM + ", IdTiempoM=" + this.IdTiempoM + ", CantidadOrdenar='" + this.CantidadOrdenar + "', PuntoReorden='" + this.PuntoReorden + "', CostoPorFaltantes='" + this.CostoPorFaltantes + "', CostoMantenimiento='" + this.CostoMantenimiento + "', CostoOrdenar='" + this.CostoOrdenar + "', InventarioInicial='" + this.InventarioInicial + "' where (ID=" + this.ID + ")");
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
                baseDeDatos.EjecutarEscalar("delete from [Inventario] where (ID=" + this.ID + ")");
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
