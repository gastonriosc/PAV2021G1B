using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    class DetalleFacturaDao
    {

        internal int GetLastIdDetalleFactura()
        {                               
            String strSql = "SELECT MAX(idDetalle) FROM DetalleFactura";

            int ultimoId = int.Parse(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0][0].ToString());

            return ultimoId;
        }

        public IList<DetalleFactura> GetAllFromFactura(int nro)
        {
            List<DetalleFactura> listadoDetalles = new List<DetalleFactura>();

            String strSql = string.Concat(" SELECT D.idDetalle,",
                                          " D.nroFactura,",
                                          " D.idPrenda,",
                                          " D.cantidad,",
                                          " D.anulado",
                                          " FROM DetalleFactura D",
                                          " WHERE nroFactura=@nro AND D.borrado=0");

            var paramDetalle = new Dictionary<string, object>();
            paramDetalle.Add("nro", nro);

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql, paramDetalle);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoDetalles.Add(ObjectMapping(row));
            }

            return listadoDetalles;
        }

        private DetalleFactura ObjectMapping(DataRow row)
        {
            DetalleFactura oDetalle = new DetalleFactura
            {
                IdDetalle = Convert.ToInt32(row["idDetalle"].ToString()),
                NroFactura = Convert.ToInt32(row["nroFactura"].ToString()),
                Prenda = new Prenda()
                {
                    Id = Convert.ToInt32(row["idPrenda"].ToString())
                },
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                Anulado = Convert.ToInt32(row["anulado"].ToString()),
            };

            return oDetalle;
        }
    }
}
