using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class DBHelper
    {
        private string string_conexion;
        private SqlConnection dbConnection;
        private SqlTransaction dbTransaction;
        private static DBHelper instance = new DBHelper();


        //lo hice public para poder hacer la transaccion en el facturaDao
        private DBHelper()
        {
            dbConnection = new SqlConnection();
            // cadena Targon
            //string_conexion = @"Data Source=DESKTOP-VGC54OT\SQLEXPRESS;Initial Catalog=gridFreaks2;Integrated Security=True";
            // cadena Rios
            string_conexion = @"Data Source=DESKTOP-0AAMHAV\SQLEXPRESS;Initial Catalog=gridFreaks;Integrated Security=True";

            dbConnection.ConnectionString = string_conexion;
        }

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public int EjecutarSQLConParametros(string strSql, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = string_conexion;
                // Abre la conexión
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public int EjecutarSQL(string strSql)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = string_conexion;
                // Abre la conexión
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }
        public void Open()
        {
            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Open();

        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }
        public void BeginTransaction()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbTransaction = dbConnection.BeginTransaction();
        }
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }
        // otra forma de cerrar la conexion
        public void Close()
        {
            if (dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }
    }

}
