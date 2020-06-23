using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIdatabases.Modelos
{
    public class Persona
    {


        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public bool Activo { get; set; }
 

    }
}
