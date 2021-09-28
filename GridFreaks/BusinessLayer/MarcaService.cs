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

        internal IList<Marca> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oMarcaDao.GetByFiltersSinParametros(condiciones);
        }

        internal bool RecuperarMarca(Marca oMarca)
        {
            return oMarcaDao.GetMarcaParametrizado(oMarca);
        }

        internal bool ActualizarMarca(Marca oMarcaSelected)
        {
            return oMarcaDao.Update(oMarcaSelected);
        }

        internal int ObtenerUltimoIdMarca()
        {
            return oMarcaDao.GetLastIdMarca();
        }

        internal bool CrearMarca(Marca oMarca)
        {
            return oMarcaDao.Create(oMarca);
        }

        internal bool ModificarEstadoMarca(Marca oMarca)
        {
            return oMarcaDao.DarBaja(oMarca);
        }
    }
}
