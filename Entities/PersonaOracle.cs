using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class PersonaOracle
    {


        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Activo { get; set; }
    }
}
