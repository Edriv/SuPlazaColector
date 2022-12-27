using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class inventario_articulo
    {
        public Guid id_captura { get; set; }

        public string cod_barras { get; set; }

        public string descripcion { get; set; }

        public articulo item { get; set; }

        public Guid id_inventario { get; set; }

        public decimal cantidad { get; set; }

        public decimal cant_cja { get; set; }

        public decimal cant_pza { get; set; }

        public unidad_articulo medida { get; set; }

        public decimal getCantidadCja()
        {
            return medida.tipo.Equals("anexo") ? cantidad : 0.0m;
        }

        public decimal getCantidadPza()
        {
            return medida.tipo.Equals("principal") ? cantidad : (cantidad * medida.cantidad_um);
        }
    }
}
