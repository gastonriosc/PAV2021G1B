using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class MarcaService
    {
        private MarcaDao oMarcaDao;

        public MarcaService()
        {
            oMarcaDao = new MarcaDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<Marca> ObtenerTodos()
        {
            return oMarcaDao.GetAll();
        }
    }
}
