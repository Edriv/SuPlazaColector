using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class pedido
    {
        public Guid id_pedido { get; set; }

        public string num_pedido { get; set; }

        public Guid id_proveedor { get; set; }

        public string razon_social { get; set; }

        public override string ToString()
        {
            return num_pedido.ToString();
        }
    }
}
