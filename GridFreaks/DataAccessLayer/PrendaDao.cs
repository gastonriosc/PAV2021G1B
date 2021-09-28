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
                                          " JOIN TipoPrenda TP ON (P.idTipoPrenda = TP.id)",
                                          " JOIN Colores C ON (P.idColor = C.id)",
                                          " JOIN Marcas M ON (P.idMarca = M.id)",
                                          " WHERE P.borrado=0 AND C.borrado=0 AND M.borrado=0");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPrendas.Add(ObjectMapping(row));
            }

            return listadoPrendas;
        }

        internal int GetLastIdPrenda()
        {
            String strSql = "SELECT MAX(id) FROM PRENDAS";

            int ultimoId = int.Parse(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0][0].ToString());

            return ultimoId;
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

        public Prenda GetPrendaSinParametros(int idPrenda)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT *",
                                          "  FROM Prendas",
                                          "  WHERE borrado =0 ");

            strSql += " AND id=" + idPrenda;


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public bool GetPrendaParametrizada(Prenda oPrenda)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat("SELECT idTipoPrenda, idColor, Temporada, Stock, Precio, idMarca, borrado, nombreImagen",
                                          " FROM Prendas",
                                          " WHERE borrado = 0",
                                          " AND idTipoPrenda = " + oPrenda.TipoPrenda.Id +
                                          " AND idColor = " + oPrenda.Color.Id +
                                          " AND Temporada = " + "'" + oPrenda.Temporada + "'" +
                                          " AND Stock = " + oPrenda.Stock +
                                          " AND Precio = " + oPrenda.Precio +
                                          " AND idMarca = " + oPrenda.Marca.Id +
                                          " AND nombreImagen = " + "'" + oPrenda.NombreImagen + "'");


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
                return true;

            return false;
        }


        internal bool Create(Prenda oPrenda)
        {
            string str_sql = "INSERT INTO Prendas (id, idTipoPrenda, idColor, Temporada, Stock, Precio, idMarca, borrado, nombreImagen)" +
                            " VALUES ("+
                            oPrenda.Id + ", " +
                            oPrenda.TipoPrenda.Id + ", " +
                            oPrenda.Color.Id + ", " +
                            "'" + oPrenda.Temporada + "'" + ", " +
                            oPrenda.Stock + ", " +
                            oPrenda.Precio + ", " +
                            oPrenda.Marca.Id + ", " +
                            " 0, " +
                            "'" + oPrenda.NombreImagen + "')";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        public IList<Prenda> GetByFiltersSinParametros(String condiciones)
        {

            List<Prenda> lst = new List<Prenda>();
            String strSql = string.Concat(" SELECT P.id, ",
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
                                          " WHERE P.borrado=0 AND C.borrado=0 AND M.borrado=0");

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

        internal bool Update(Prenda oPrenda)
        {
            //SIN PARAMETROS

            string str_sql = "UPDATE Prendas " +
                             "SET idTipoPrenda = " + oPrenda.TipoPrenda.Id + "," +
                             " idColor = " + oPrenda.Color.Id + "," +
                             " Temporada = " + "'" + oPrenda.Temporada + "'" + "," +
                             " Stock = " + oPrenda.Stock + "," +
                             " Precio = " + oPrenda.Precio + "," +
                             " idMarca = " + oPrenda.Marca.Id + "," +
                             " nombreImagen = " + "'" + oPrenda.NombreImagen + "'" +
                             " WHERE id = " + "'" + oPrenda.Id + "'";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        internal bool DarBaja(Prenda oPrenda)
        {

            string str_sql = "UPDATE Prendas " +
                             "SET borrado = 1" +
                             " WHERE id=" + "'" + oPrenda.Id + "'";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
    }
}

