using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.Entities
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public TipoFactura TipoFactura { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }
        public IList<DetalleFactura> Detalles { get; set; }

        public double ImporteTotal
        {
            get
            {
                return Total - Total * Descuento / 100;
            }
        }

        public override string ToString()
        {
            return TipoFactura + NroFactura.ToString("0001-00000000");
        }
    }
}
