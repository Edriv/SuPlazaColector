using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
    public class compra
    {
		public Guid id_compra { get; set; }

		public string num_compra { get; set; }

		public Guid id_proveedor { get; set; }

		public DateTime fecha_compra { get; set; }

		public Guid id_pedido { get; set; }

		public short no_entrada { get; set; }

		public override string ToString()
		{
			return string.Format(num_compra);
		}
	}
}
