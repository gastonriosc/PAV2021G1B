using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.DataAccessLayer
{
    public class FacturaDao
    {
        internal int GetLastIdFactura()
        {
            String strSql = "SELECT MAX(nroFactura) FROM Facturas";

            int ultimoId = int.Parse(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0][0].ToString());

            return ultimoId;
        }

        internal bool Create(Factura factura)
        {
            DBHelper dm = DBHelper.GetDBHelper();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[Facturas] ",
                                            "           ([fecha]         ",
                                            "           ,[idCliente]     ",
                                            "           ,[tipoFactura]   ",
                                            "           ,[total]         ",
                                            "           ,[descuento]     ",
                                            "           ,[borrado])      ",
                                            "     VALUES                 ",
                                            "           (@fecha          ",
                                            "           ,@idCliente      ",
                                            "           ,@tipoFactura    ",
                                            "           ,@total          ",
                                            "           ,@descuento      ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("fecha", factura.Fecha.ToString("yyyy-MM-dd"));
                parametros.Add("idCliente", factura.Cliente.Id);
                parametros.Add("tipoFactura", factura.TipoFactura.Id);
                parametros.Add("total", factura.Total);
                parametros.Add("descuento", factura.Descuento);
                parametros.Add("borrado", 0);
                dm.EjecutarSQLConParametros(sql, parametros);

                foreach (var itemFactura in factura.Detalles)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[DetalleFactura] ",
                                                        "           ([nroFactura]           ",
                                                        "           ,[idPrenda]             ",
                                                        "           ,[cantidad]             ",
                                                        "           ,[subtotal]             ",
                                                        "           ,[borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@nroFactura            ",
                                                        "           ,@idPrenda              ",
                                                        "           ,@cantidad              ",
                                                        "           ,@subtotal              ",
                                                        "           ,@borrado)              ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("nroFactura", factura.NroFactura);
                    paramDetalle.Add("idPrenda", itemFactura.IdPrenda);
                    paramDetalle.Add("cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("subtotal", itemFactura.Subtotal);
                    paramDetalle.Add("borrado", 0);

                    dm.EjecutarSQLConParametros(sqlDetalle, paramDetalle);

                    string sqlPrenda = string.Concat(" UPDATE Prendas",
                                                     " SET Stock-=@cant WHERE id=@idPrenda");

                    var paramPrenda = new Dictionary<string, object>();
                    paramPrenda.Add("cant", itemFactura.Cantidad);
                    paramPrenda.Add("idPrenda", itemFactura.IdPrenda);


                    dm.EjecutarSQLConParametros(sqlPrenda, paramPrenda);
                }

                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        public DataTable getFacturas(string condiciones)
        {
            string consulta = "SELECT D.idDetalle, F.nroFactura, F.fecha, C.nombre AS 'cliente', F.tipoFactura, T.nombre AS 'producto', M.nombre AS 'marca', D.subtotal AS 'importe'"
                            + " FROM Facturas AS F INNER JOIN"
                            + " Clientes AS C ON F.idCliente = C.id INNER JOIN"
                            + " DetalleFactura AS D ON F.nroFactura = D.nroFactura INNER JOIN"
                            + " Prendas AS P ON D.idPrenda = P.id INNER JOIN"
                            + " TipoPrenda AS T ON P.idTipoPrenda = T.id INNER JOIN"
                            + " Marcas AS M ON P.idMarca = M.id"
                            + " WHERE(F.borrado = 0)";

            consulta += condiciones;

            return DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }
    }
}
