using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class ClienteDao
    {
        // escribe la consulta a hacer a la base de datos y retorna una lista de objetos usuarios
        public IList<Cliente> GetAll()
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            String strSql = string.Concat(" SELECT id, ",
                                          "        CUIT, ",
                                          "        nombre, ",
                                          "        domicilioCalle, ",
                                          "        domicilioNro, ",
                                          "        mail ",
                                          "  FROM Clientes",
                                          "  WHERE borrado = 0",
                                          "  ORDER BY nombre ASC");
            // aca obtenemos la datatable de la consulta
            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            // por cada fila materializa
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoClientes.Add(ObjectMapping(row));
            }

            return listadoClientes;
        }

        // materializa cada fila de la tabla de usuarios a un objeto Usuario
        private Cliente ObjectMapping(DataRow row)
        {
            Cliente oCliente = new Cliente
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                CUIT = row["CUIT"].ToString(),
                Nombre = row["nombre"].ToString(),
                DomicilioCalle = row["domicilioCalle"].ToString(),
                DomicilioNro = Convert.ToInt32(row["domicilioNro"].ToString()),
                Mail = row["mail"].ToString()

            };

            return oCliente;
        }
    }
}
