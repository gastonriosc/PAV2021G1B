using GridFreaks.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class ColorService
    {
        private ColorDao oColorDao;

        public ColorService()
        {
            oColorDao = new ColorDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<Entities.ColorPrenda> ObtenerTodos()
        {
            return oColorDao.GetAll();
        }

    }
}
