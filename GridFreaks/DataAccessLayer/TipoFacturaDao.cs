using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class TipoFacturaDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<TipoFactura> GetAll()
        {
            List<TipoFactura> listadoTipoFacturas = new List<TipoFactura>();

            String strSql = string.Concat(" SELECT id, ",
                                          "        descripcion ",
                                          "  FROM TipoFactura");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoTipoFacturas.Add(ObjectMapping(row));
            }

            return listadoTipoFacturas;
        }

        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private TipoFactura ObjectMapping(DataRow row)
        {
            TipoFactura oTipoFactura = new TipoFactura
            {
                Id = row["id"].ToString(),
                Descripcion = row["descripcion"].ToString()
            };

            return oTipoFactura;
        }
    }
}
