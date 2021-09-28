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
    }
}
