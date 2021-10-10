using GridFreaks.Entities;
using System;
using System.Collections.Generic;
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
                                            "           ([nroFactura]   ",
                                            "           ,[fecha]         ",
                                            "           ,[idCliente]       ",
                                            "           ,[tipoFactura]   ",
                                            "           ,[total]    ",
                                            "           ,[descuento]    ",
                                            "           ,[borrado])      ",
                                            "     VALUES                 ",
                                            "           (@nroFactura   ",
                                            "           ,@fecha          ",
                                            "           ,@idCliente        ",
                                            "           ,@tipoFactura    ",
                                            "           ,@total     ",
                                            "           ,@descuento     ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("nroFactura", factura.NroFactura);
                parametros.Add("fecha", factura.Fecha);
                parametros.Add("idCliente", factura.Cliente.Id);
                parametros.Add("tipoFactura", factura.TipoFactura.Id);
                parametros.Add("total", factura.Total);
                parametros.Add("descuento", factura.Descuento);
                parametros.Add("borrado", 0);
                dm.EjecutarSQLConParametros (sql, parametros);

                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                factura.NroFactura = Convert.ToInt32(newId);


                foreach (var itemFactura in factura.Detalles)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[FacturasDetalle] ",
                                                        "           ([nroFactura]          ",
                                                        "           ,[idPrenda]          ",
                                                        "           ,[cantidad]      ",
                                                        "           ,[subtotal]             ",
                                                        "           ,[borrado])             ",
                                                        "     VALUES                        ", 
                                                        "           @nroFactura            ",
                                                        "           ,@idPrenda           ",
                                                        "           ,@cantidad       ",
                                                        "           ,@subtotal              ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_factura", factura.NroFactura);
                    paramDetalle.Add("idPrenda", itemFactura.IdProducto);
                    paramDetalle.Add("cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("subtotal", itemFactura.Subtotal);
                    paramDetalle.Add("borrado", 0);

                    dm.EjecutarSQLConParametros(sqlDetalle, paramDetalle);
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
    }
}
