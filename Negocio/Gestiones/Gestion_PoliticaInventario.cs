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
    public class Gestion_PoliticaInventario:PoliticaInventario, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_PoliticaInventario()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
        }

        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [PoliticaInventario] (Distribucion, TiempoDeEntrega, AleatorioDistribucion, AleatorioTiempoDeEntrega, CantidadOrdenar, PuntoDeReorden, CostoPorFaltantes, CostoMantenimiento, CostoDeOrdenar, InventarioInicial) values (" + this.Distribucion + ", " + this.TiempoDeEntrega + ", " + this.AleatorioDistribucion + ", " + this.AleatorioTiempoDeEntrega + ", '" + this.CantidadOrdenar + "', '" + this.PuntoDeReorden + "', '" + this.CostoPorFaltantes + "', '" + this.CostoMantenimiento + "', '" + this.CostoDeOrdenar + "', '" + this.InventarioInicial + "')");
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
                tabla = baseDeDatos.EjecutarDataTableSQL("select ID, Distribucion, TiempoDeEntrega, AleatorioDistribucion, AleatorioTiempoDeEntrega, CantidadOrdenar, PuntoDeReorden, CostoPorFaltantes, CostoMantenimiento, CostoDeOrdenar, InventarioInicial from [PoliticaInventario]");
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
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from PoliticaInventario"));
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
                cadenaFinal = Convert.ToString(baseDeDatos.EjecutarEscalar("select " + cadena + " from [PoliticaInventario] where (ID=" + identificador + ")"));
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

        public int RetornarValorEntero(string cadena, string identificador)
        {
            try
            {
                int cadenaFinal = 0;
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                cadenaFinal = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select " + cadena + " from [PoliticaInventario] where (ID=" + identificador + ")"));
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
                baseDeDatos.EjecutarEscalar("update [PoliticaInventario] set Distribucion=" + this.Distribucion + ", TiempoDeEntrega=" + this.TiempoDeEntrega + ", AleatorioDistribucion=" + this.AleatorioDistribucion + ", AleatorioTiempoDeEntrega=" + this.AleatorioTiempoDeEntrega + ", CantidadOrdenar='" + this.CantidadOrdenar + "', PuntoDeReorden='" + this.PuntoDeReorden + "', CostoPorFaltantes='" + this.CostoPorFaltantes + "', CostoMantenimiento='" + this.CostoMantenimiento + "', CostoDeOrdenar='" + this.CostoDeOrdenar + "', InventarioInicial='" + this.InventarioInicial + "' where (ID=" + this.ID + ")");
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
                baseDeDatos.EjecutarEscalar("delete from [PoliticaInventario] where (ID=" + this.ID + ")");
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
