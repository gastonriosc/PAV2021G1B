using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class FacturaService
    {
        private FacturaDao oFacturaDao;

        public FacturaService()
        {
            oFacturaDao = new FacturaDao();
        }

        //public IList<Prenda> ObtenerTodos()
        //{
        //    return oPrendaDao.GetAll();
        //}

        //internal IList<Prenda> ConsultarConFiltrosSinParametros(String condiciones)
        //{
        //    return oPrendaDao.GetByFiltersSinParametros(condiciones);
        //}

        //internal bool ObtenerFactura(Factura oFactura)
        //{
        //    //SIN PARAMETROS
        //    return oFacturaDao.GetPrendaParametrizada(oFactura);
        //}

        internal int ObtenerUltimoIdFactura()
        {
            return oFacturaDao.GetLastIdFactura();
        }

        //internal bool CrearFactura(Factura oFactura)
        //{
        //    return oFacturaDao.Create(oFactura);
        //}

        //internal bool ActualizarPrenda(Prenda oPrendaSelected)
        //{
        //    return oPrendaDao.Update(oPrendaSelected);
        //}

        //internal bool ModificarEstadoPrenda(Factura oFacturaSelected)
        //{
        //    return oFacturaDao.DarBaja(oFacturaSelected);
        //}
    }
}
