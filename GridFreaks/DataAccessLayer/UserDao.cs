using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    class UserDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<User> GetAll()
        {
            List<User> listadoUsuarios = new List<User>();

            String strSql = string.Concat(" SELECT usuario, ",
                                          "        nombre, ",
                                          "        apellido, ",
                                          "        contra, ",
                                          "        mail ",
                                          "  FROM Usuarios",
                                          "  WHERE borrado=0 ");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(ObjectMapping(row));
            }

            return listadoUsuarios;
        }



        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private User ObjectMapping(DataRow row)
        {
            User oUsuario = new User
            {
                Usuario = row["usuario"].ToString(),
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Mail = row["mail"].ToString(),
                Contra = row.Table.Columns.Contains("contra") ? row["contra"].ToString() : null
            };

            return oUsuario;
        }

        public User GetUserSinParametros(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT usuario, ",
                                          "        nombre, ",
                                          "        apellido, ",
                                          "        contra, ",
                                          "        mail ",
                                          "  FROM Usuarios",
                                          "  WHERE borrado =0 ");

            strSql += " AND usuario=" + "'" + nombreUsuario + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }
    }
}
