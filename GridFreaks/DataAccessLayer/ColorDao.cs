using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class ColorDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<ColorPrenda> GetAll()
        {
            List<ColorPrenda> listadoColores = new List<ColorPrenda>();

            String strSql = string.Concat("SELECT id, ",
                                          " nombre ",
                                          " FROM Colores",
                                          " WHERE borrado = 0");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoColores.Add(ObjectMapping(row));
            }

            return listadoColores;
        }

        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private ColorPrenda ObjectMapping(DataRow row)
        {
            ColorPrenda oColor = new ColorPrenda
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oColor;
        }

        public IList<ColorPrenda> GetByFiltersSinParametros(String condiciones)
        {

            List<ColorPrenda> lst = new List<ColorPrenda>();
            String strSql = string.Concat("SELECT * ",
                                          " FROM Colores",
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

        internal bool DarBaja(ColorPrenda oColor)
        {

            string str_sql = "UPDATE Colores " +
                             "SET borrado = 1" +
                             " WHERE id=" + "'" + oColor.Id + "'";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        internal int GetLastIdColor()
        {
            String strSql = "SELECT MAX(id) FROM Colores";

            int ultimoId = int.Parse(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0][0].ToString());

            return ultimoId;
        }

        internal bool Create(ColorPrenda oColor)
        {
            string str_sql = "INSERT INTO Colores (id, nombre, borrado)" +
                            " VALUES (" +
                            oColor.Id + ", " +
                            "'" + oColor.Nombre + "'" + ", " +
                            " 0)";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        public bool GetColorParametrizado(ColorPrenda oColor)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat("SELECT nombre, borrado",
                                          " FROM Colores",
                                          " WHERE borrado = 0",
                                          " AND nombre = " + "'" + oColor.Nombre + "'");


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
                return true;

            return false;
        }

        internal bool Update(ColorPrenda oColor)
        {
            //SIN PARAMETROS

            string str_sql = "UPDATE Colores " +
                             "SET nombre = " + "'" + oColor.Nombre + "'" +
                             " WHERE id = " + "'" + oColor.Id + "'";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
    }
}
