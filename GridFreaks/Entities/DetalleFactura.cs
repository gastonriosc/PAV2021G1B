using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.Entities
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int NroFactura { get; set; }
        public Prenda Prenda { get; set; }
        public int Cantidad { get; set; }

        public int IdPrenda
        {
            get
            {
                return Prenda.Id;
            }
        }

        public Double Subtotal
        {
            get
            {
                return Cantidad * Prenda.Precio;
            }
        }
    }
}
