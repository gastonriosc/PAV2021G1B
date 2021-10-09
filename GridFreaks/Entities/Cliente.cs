using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridFreaks.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public string DomicilioCalle { get; set; }
        public int DomicilioNro { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
