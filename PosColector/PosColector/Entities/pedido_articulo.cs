using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{

    public class pedido_articulo
    {
        public Guid id_pedido { get; set; }

        public articulo item { get; set; }

        public decimal cantidad { get; set; }
    }
}
