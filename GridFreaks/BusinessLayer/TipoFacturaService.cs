using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class TipoFacturaService
    {
        private TipoFacturaDao oTipoFacturaDao;

        public TipoFacturaService()
        {
            oTipoFacturaDao = new TipoFacturaDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<TipoFactura> ObtenerTodos()
        {
            return oTipoFacturaDao.GetAll();
        }
    }
}
