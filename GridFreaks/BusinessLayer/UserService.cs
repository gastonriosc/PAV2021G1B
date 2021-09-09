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
    class UserService
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
    }
}
