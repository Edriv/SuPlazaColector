using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class articulo
    {
        public string cod_barras { get; set; }

        public string cod_asociado { get; set; }

        public string descripcion { get; set; }

        public Guid id_unidad { get; set; }

        public decimal cantidad_um { get; set; }

        public decimal precio_compra { get; set; }

        public string tipo_articulo { get; set; }

        public Guid id_proveedor { get; set; }

        public decimal cant_pedida { get; set; }

        public decimal por_surtir { get; set; }
    }
}
