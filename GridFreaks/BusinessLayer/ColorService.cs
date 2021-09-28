using GridFreaks.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridFreaks.Entities;

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

        internal IList<ColorPrenda> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oColorDao.GetByFiltersSinParametros(condiciones);
        }

        internal bool ModificarEstadoColor(ColorPrenda oColor)
        {
            return oColorDao.DarBaja(oColor);
        }

        internal bool CrearColor(ColorPrenda oColor)
        {
            return oColorDao.Create(oColor);
        }

        internal int ObtenerUltimoIdColor()
        {
            return oColorDao.GetLastIdColor();
        }

        internal bool RecuperarColor(ColorPrenda oColor)
        {
            return oColorDao.GetColorParametrizado(oColor);
        }

        internal bool ActualizarColor(ColorPrenda oColorSelected)
        {
            return oColorDao.Update(oColorSelected);
        }
    }
}
