using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class PrendaService
    {
        private PrendaDao oPrendaDao;

        public PrendaService()
        {
            oPrendaDao = new PrendaDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<Prenda> ObtenerTodos()
        {
            return oPrendaDao.GetAll();
        }
    }
}
