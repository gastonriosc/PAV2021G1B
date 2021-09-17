using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.Entities
{
    public class Prenda
    {
        public int Id { get; set; }
        public TipoPrenda TipoPrenda { get; set; }
        public ColorPrenda Color { get; set; }
        public string Temporada { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }
        public Marca Marca { get; set; }
        public string NombreImagen { get; set; }
    }
}
