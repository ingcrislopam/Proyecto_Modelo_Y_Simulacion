using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class BaseDeDatos
    {
        private SqlConnection Conexion = null;
        private SqlCommand Comando = null;
        private SqlTransaction Transaccion = null;
        private String CadenaConexion;

        public BaseDeDatos()
        {
            Configurar();
        }

        private void Configurar()
        {
            this.CadenaConexion = @"Data Source=CRISTHIAN-PC\FACCI;Initial Catalog=Distribuciones;Integrated Security=True";
        }
        public void Conectar()
        {
            if (this.Conexion != null && !this.Conexion.State.Equals(ConnectionState.Closed))
            {
                throw new Exception("La conexión ya se encuentra abierta");
            }
            try
            {
                if (this.Conexion == null)
                {
                    this.Conexion = new SqlConnection();
                    this.Conexion.ConnectionString = CadenaConexion;
                }
                this.Conexion.Open();
            }
            catch (DataException ex)
            {
                throw new Exception("Error al conectarse con la base de datos", ex);
            }
        }
        public void Desconectar()
        {
            if (this.Conexion.State.Equals(ConnectionState.Open))
            {
                this.Conexion.Close();
            }
        }

        public void Previo(string strSql, params object[] parametros)
        {
            this.Comando = new SqlCommand();
            this.Comando.Connection = this.Conexion;
            this.Comando.CommandType = CommandType.StoredProcedure;
            this.Comando.CommandText = strSql;
            if (this.Transaccion != null)
            {
                this.Comando.Transaction = this.Transaccion;
            }
            SqlCommandBuilder.DeriveParameters(this.Comando);
            if (parametros.Length > 0)
            {
                int contador = 0;
                foreach (object item in parametros)
                {
                    Comando.Parameters[contador++].Value = item;
                }
            }

        }

        public void Previo(string strSql)
        {
            this.Comando = new SqlCommand();
            this.Comando.Connection = this.Conexion;
            this.Comando.CommandType = CommandType.Text;
            this.Comando.CommandText = strSql;
            if (this.Transaccion != null)
            {
                this.Comando.Transaction = this.Transaccion;
            }

        }
        public void Ejecutar(string strSql)
        {
            Previo(strSql);
            this.Comando.ExecuteNonQuery();
        }
        public object EjecutarEscalar(string strsql)
        {
            Previo(strsql);
            return this.Comando.ExecuteScalar();
        }

        public object EjecutarEscalar(string strSql, params object[] parametros)
        {
            Previo(strSql, parametros);
            return this.Comando.ExecuteScalar();
        }
        public void Ejecutar(string strSql, params object[] parametros)
        {
            Previo(strSql, parametros);
            this.Comando.ExecuteNonQuery();
        }
        public DataTable EjecutarDataTable(string strSql, params object[] parametros)
        {
            Previo(strSql, parametros);
            DataSet ds = new DataSet();
            new SqlDataAdapter(this.Comando).Fill(ds);
            return ds.Tables[0].Copy();
        }

        public DataTable EjecutarDataTableSQL(string strSql)
        {
            Previo(strSql);
            DataSet ds = new DataSet();
            new SqlDataAdapter(this.Comando).Fill(ds);
            return ds.Tables[0].Copy();
        }

        public SqlDataReader EjecutarReader(string strSql, params object[] parametros)
        {
            Previo(strSql, parametros);
            return this.Comando.ExecuteReader();
        }

        /// <summary>
        /// manejo de transacciones
        /// </summary>

        public void ComenzarTransaccion()
        {
            if (this.Transaccion == null || this.Transaccion.Connection == null)
            {
                this.Transaccion = this.Conexion.BeginTransaction();
            }
        }
        public void CancelarTransaccion()
        {
            if (this.Transaccion != null)
            {
                this.Transaccion.Rollback();
            }
        }
        public void confirmarTransaccion()
        {
            if (this.Transaccion != null)
            {
                this.Transaccion.Commit();
            }
        }
    }
}
