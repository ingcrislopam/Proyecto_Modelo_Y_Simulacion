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
    public class Gestion_Aleatorio:Aleatoria, IGestion
    {
        BaseDatos.BaseDeDatos baseDeDatos;

        public Gestion_Aleatorio()
        {
            baseDeDatos = new BaseDatos.BaseDeDatos();
            IdCongruencial = new Congruencial();
        }

        public void Insertar()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                baseDeDatos.EjecutarEscalar("insert into [Aleatoria] (IdCongruencial, PrimerParametro, SegundoParametro, Funcion) values (" + this.IdCongruencial.ID + ", '" + this.PrimerParametro + "', '" + this.SegundoParametro + "', '" + this.Funcion + "')");
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
                tablaR = baseDeDatos.EjecutarDataTableSQL("Select Congruencial.ID, N, M, Xn, A, C, Aleatoria.ID, PrimerParametro, SegundoParametro, Funcion from [Congruencial] inner join [Aleatoria] on Congruencial.ID=Aleatoria.IdCongruencial");
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

        public DataTable BuscarCongruencial()
        {
            try
            {
                baseDeDatos.Conectar();
                baseDeDatos.ComenzarTransaccion();
                DataTable tablaC;
                tablaC = baseDeDatos.EjecutarDataTableSQL("select ID, N, M, Xn, A, C from [Congruencial]");
                baseDeDatos.confirmarTransaccion();
                return tablaC;
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
                n = Convert.ToInt32(baseDeDatos.EjecutarEscalar("select COUNT(*) from Aleatoria"));
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
                baseDeDatos.EjecutarEscalar("update [Aleatoria] set PrimerParametro='" + this.PrimerParametro + "', SegundoParametro='" + this.SegundoParametro + "', Funcion='" + this.Funcion + "' where (ID=" + this.ID + ")");
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
                baseDeDatos.EjecutarEscalar("delete from [Aleatoria] where (ID=" + this.ID + ")");
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
