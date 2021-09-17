using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class PrendaDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<Prenda> GetAll()
        {
            List<Prenda> listadoPrendas = new List<Prenda>();

            String strSql = string.Concat(" SELECT P.id,",
                                          " P.idTipoPrenda,",
                                          " TP.nombre as tipoPrenda,",
                                          " P.idColor,",
                                          " C.nombre as color,",
                                          " P.Temporada,",
                                          " P.Stock,",
                                          " P.Precio,",
                                          " P.idMarca,",
                                          " M.nombre as marca,",
                                          " P.nombreImagen",
                                          " FROM Prendas P",
                                          " INNER JOIN TipoPrenda TP ON (P.idTipoPrenda = TP.id)",
                                          " INNER JOIN Colores C ON (P.idColor = C.id)",
                                          " INNER JOIN Marcas M ON (P.idMarca = M.id)",
                                          " WHERE borrado=0 ");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPrendas.Add(ObjectMapping(row));
            }

            return listadoPrendas;
        }



        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private Prenda ObjectMapping(DataRow row)
        {
            Prenda oPrenda = new Prenda
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                TipoPrenda = new TipoPrenda() {
                    Id = Convert.ToInt32(row["idTipoPrenda"].ToString()),
                    Nombre = row["tipoPrenda"].ToString()
                },
                Color = new ColorPrenda() {
                    Id = Convert.ToInt32(row["idColor"].ToString()),
                    Nombre = row["color"].ToString()
                },
                Temporada = row["Temporada"].ToString(),
                Stock = Convert.ToInt32(row["Stock"].ToString()),
                Precio = Convert.ToInt32(row["Precio"].ToString()),
                Marca = new Marca() {
                    Id = Convert.ToInt32(row["idMarca"].ToString()),
                    Nombre = row["marca"].ToString()
                },
                NombreImagen = row["nombreImagen"].ToString(),
            };

            return oPrenda;
        }

        //public User GetUserSinParametros(string nombreUsuario)
        //{
        //    //Construimos la consulta sql para buscar el usuario en la base de datos.
        //    String strSql = string.Concat(" SELECT usuario, ",
        //                                  "        nombre, ",
        //                                  "        apellido, ",
        //                                  "        contra, ",
        //                                  "        mail ",
        //                                  "  FROM Usuarios",
        //                                  "  WHERE borrado =0 ");

        //    strSql += " AND usuario=" + "'" + nombreUsuario + "'";


        //    //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
        //    var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

        //    // Validamos que el resultado tenga al menos una fila.
        //    if (resultado.Rows.Count > 0)
        //    {
        //        return ObjectMapping(resultado.Rows[0]);
        //    }

        //    return null;
        //}


        //internal bool Create(User oUsuario)
        //{
        //    //CON PARAMETROS
        //    //string str_sql = "     INSERT INTO Usuarios (usuario, password, email, id_perfil, estado, borrado)" +
        //    //                 "     VALUES (@usuario, @password, @email, @id_perfil, 'S', 0)";

        //    // var parametros = new Dictionary<string, object>();
        //    //parametros.Add("usuario", oUsuario.NombreUsuario);
        //    //parametros.Add("password", oUsuario.Password);
        //    //parametros.Add("email", oUsuario.Email);
        //    //parametros.Add("id_perfil", oUsuario.Perfil.IdPerfil);

        //    // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
        //    //con parametros
        //    //return (DBHelper.GetDBHelper().EjecutarSQLConParametros(str_sql, parametros) == 1);

        //    //SIN PARAMETROS

        //    string str_sql = "INSERT INTO Usuarios (usuario, nombre, apellido, contra, mail, borrado)" +
        //                    " VALUES (" +
        //                    "'" + oUsuario.Usuario + "'" + "," +
        //                    "'" + oUsuario.Nombre + "'" + "," +
        //                    "'" + oUsuario.Apellido + "'" + "," +
        //                    "'" + oUsuario.Contra + "'" + "," +
        //                    "'" + oUsuario.Mail + "'" + ",0)";


        //    return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        //}

        //public IList<User> GetByFiltersSinParametros(String condiciones)
        //{

        //    List<User> lst = new List<User>();
        //    String strSql = string.Concat(" SELECT usuario, ",
        //                                      "        nombre, ",
        //                                      "        apellido, ",
        //                                      "        mail, ",
        //                                      "        contra ",
        //                                      "   FROM Usuarios u",
        //                                      "  WHERE u.borrado =0 ");

        //    strSql += condiciones;
        //    //if (parametros.ContainsKey("idPerfil"))
        //    //   strSql += " AND (u.id_perfil = @idPerfil) ";


        //    // if (parametros.ContainsKey("usuario"))
        //    //    strSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

        //    var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);


        //    foreach (DataRow row in resultado.Rows)
        //        lst.Add(ObjectMapping(row));

        //    return lst;
        //}

        //internal bool Update(User oUsuario)
        //{
        //    //SIN PARAMETROS

        //    string str_sql = "UPDATE Usuarios " +
        //                     "SET usuario=" + "'" + oUsuario.Usuario + "'" + "," +
        //                     " nombre=" + "'" + oUsuario.Nombre + "'" + "," +
        //                     " apellido=" + "'" + oUsuario.Apellido + "'" + "," +
        //                     " mail=" + "'" + oUsuario.Mail + "'" + "," +
        //                     " contra=" + "'" + oUsuario.Contra + "'" +
        //                     " WHERE usuario=" + "'" + oUsuario.Usuario + "'";

        //    return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        //}

        //internal bool DarBaja(User oUsuario)
        //{

        //    string str_sql = "UPDATE Usuarios " +
        //                     "SET borrado=1" +
        //                     " WHERE usuario=" + "'" + oUsuario.Usuario + "'";

        //    return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        //}
    }
}

