using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class TipoPrendaService
    {
        private TipoPrendaDao oTipoPrendaDao;

        public TipoPrendaService()
        {
            oTipoPrendaDao = new TipoPrendaDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<TipoPrenda> ObtenerTodos()
        {
            return oTipoPrendaDao.GetAll();
        }
    }
}
