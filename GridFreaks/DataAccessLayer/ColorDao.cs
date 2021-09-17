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

            String strSql = string.Concat(" SELECT id, ",
                                          "        nombre ",
                                          "  FROM Colores");
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
    }
}
