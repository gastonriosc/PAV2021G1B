using GridFreaks.DataAccessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks.BusinessLayer
{
    public class UserService
    {
        private UserDao oUserDao;

        public UserService()
        {
            oUserDao = new UserDao();
        }

        // llama al metodo para hacer la consulta a la BD 
        public IList<User> ObtenerTodos()
        {
            return oUserDao.GetAll();
        }


        public User ValidarUsuario(string usuario, string password)
        {
            //SIN PARAMETROS
            var usr = oUserDao.GetUserSinParametros(usuario);

            //CON PARAMETROS
            //var usr = oUsuarioDao.GetUserConParametros(usuario);

            // no se encuentra el usuarioi
            if (usr == null)
            {
                return null;
            }
            // encuentra el usuario y es valido
            else if  (usr.Contra != null && usr.Contra.Equals(password))
            {
                return usr;
            }
            // la contraseña no coincide
            return null;
        }
         internal bool CrearUsuario(User oUsuario)
        {
            return oUserDao.Create(oUsuario);
        }

        internal object ObtenerUsuario(string usuario)
        {
            //SIN PARAMETROS
            return oUserDao.GetUserSinParametros(usuario);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }

        internal IList<User> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oUserDao.GetByFiltersSinParametros(condiciones);
        }

        internal bool ActualizarUsuario(User oUsuarioSelected)
        {
            return oUserDao.Update(oUsuarioSelected);
        }

        internal bool ModificarEstadoUsuario(User oUsuarioSelected)
        {
            return oUserDao.DarBaja(oUsuarioSelected);
        }
    }
}
