using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.BusinessLayer
{
    public class ClienteService
    {
        private ClienteDao oClienteDao;

        public ClienteService()
        {
            oClienteDao = new ClienteDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<Cliente> ObtenerTodos()
        {
            return oClienteDao.GetAll();
        }
    }
}
