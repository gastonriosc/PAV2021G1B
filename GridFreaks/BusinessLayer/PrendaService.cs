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

        internal IList<Prenda> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oPrendaDao.GetByFiltersSinParametros(condiciones);
        }

        internal bool ObtenerPrenda(Prenda oPrenda)
        {
            //SIN PARAMETROS
            return oPrendaDao.GetPrendaParametrizada(oPrenda);
        }

        internal int ObtenerUltimoIdPrenda()
        {
            return oPrendaDao.GetLastIdPrenda();
        }

        internal bool CrearPrenda(Prenda oPrenda)
        {
            return oPrendaDao.Create(oPrenda);
        }

        internal bool ActualizarPrenda(Prenda oPrendaSelected)
        {
            return oPrendaDao.Update(oPrendaSelected);
        }

        internal bool ModificarEstadoPrenda(Prenda oPrendaSelected)
        {
            return oPrendaDao.DarBaja(oPrendaSelected);
        }
    }
}
