using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class TipoPrendaDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<TipoPrenda> GetAll()
        {
            List<TipoPrenda> listadoTipoPrendas = new List<TipoPrenda>();

            String strSql = string.Concat(" SELECT id, ",
                                          "        nombre ",
                                          "  FROM TipoPrenda");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTipoPrendas.Add(ObjectMapping(row));
            }

            return listadoTipoPrendas;
        }

        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private TipoPrenda ObjectMapping(DataRow row)
        {
            TipoPrenda oTipoPrenda = new TipoPrenda
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oTipoPrenda;
        }
    }
}
