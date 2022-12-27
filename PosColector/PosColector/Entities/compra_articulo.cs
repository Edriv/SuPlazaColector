using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class compra_articulo
    {
		public Guid id_compra { get; set; }

		public articulo item { get; set; }

		public int num_articulo { get; set; }

		public decimal cantidad { get; set; }

		public decimal cant_cja { get; set; }

		public decimal cant_pzs { get; set; }

		public decimal precio_compra { get; set; }

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
