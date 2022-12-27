using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class inventario
    {
        public Guid id_inventario { get; set; }

        public Guid id_proveedor { get; set; }

        public string razon_social { get; set; }

        public override string ToString()
        {
            return razon_social;
        }
    }
}
