using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class FacturaDao
    {
        internal int GetLastIdFactura()
        {
            String strSql = "SELECT MAX(nroFactura) FROM Facturas";

            int ultimoId = int.Parse(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0][0].ToString());

            return ultimoId;
        }
    }
}
