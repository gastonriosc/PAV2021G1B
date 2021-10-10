using System;
using System.Collections.Generic;
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
    }
}
