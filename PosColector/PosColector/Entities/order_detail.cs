using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class order_detail
    {
        public string cod_barras { get; set; }

        public string descripcion { get; set; }

        public decimal cant_cja { get; set; }

        public decimal cant_pza { get; set; }

        public unidad_articulo unidad { get; set; }
    }
}
