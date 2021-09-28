using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class MarcaDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<Marca> GetAll()
        {
            List<Marca> listadoMarcas = new List<Marca>();

            String strSql = string.Concat("SELECT id, ",
                                          " nombre ",
                                          " FROM Marcas",
                                          " where borrado = 0");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoMarcas.Add(ObjectMapping(row));
            }

            return listadoMarcas;
        }

        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private Marca ObjectMapping(DataRow row)
        {
            Marca oMarca = new Marca
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oMarca;
        }

        public IList<Marca> GetByFiltersSinParametros(String condiciones)
        {

            List<Marca> lst = new List<Marca>();
            String strSql = string.Concat("SELECT * ",
                                          " FROM Marcas",
                                          " WHERE borrado = 0");

            strSql += condiciones;
            //if (parametros.ContainsKey("idPerfil"))
            //   strSql += " AND (u.id_perfil = @idPerfil) ";


            // if (parametros.ContainsKey("usuario"))
            //    strSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public bool GetMarcaParametrizado(Marca oMarca)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat("SELECT nombre, borrado",
                                          " FROM Marcas",
                                          " WHERE borrado = 0",
                                          " AND nombre = " + "'" + oMarca.Nombre + "'");


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
                return true;

            return false;
        }

        internal bool Update(Marca oMarca)
        {
            //SIN PARAMETROS

            string str_sql = "UPDATE Marcas " +
                             "SET nombre = " + "'" + oMarca.Nombre + "'" +
                             " WHERE id = " + "'" + oMarca.Id + "'";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
        internal int GetLastIdMarca()
        {
            String strSql = "SELECT MAX(id) FROM Marcas";

            int ultimoId = int.Parse(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0][0].ToString());

            return ultimoId;
        }

        internal bool Create(Marca oMarca)
        {
            string str_sql = "INSERT INTO Marcas (id, nombre, borrado)" +
                            " VALUES (" +
                            oMarca.Id + ", " +
                            "'" + oMarca.Nombre + "'" + ", " +
                            " 0)";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        internal bool DarBaja(Marca oMarca)
        {

            string str_sql = "UPDATE Marcas " +
                             "SET borrado = 1" +
                             " WHERE id=" + "'" + oMarca.Id + "'";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
    }
}
