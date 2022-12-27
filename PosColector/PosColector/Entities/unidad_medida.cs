using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class unidad_medida
    {
        public Guid id_unidad { get; set; }

        public string descripcion { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
