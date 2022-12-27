using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosColector.Entities
{
	public class unidad_articulo
	{
		public Guid id_unidad { get; set; }

		public string descripcion { get; set; }

		public decimal cantidad_um { get; set; }

		public string tipo { get; set; }

		public override string ToString()
		{
			return descripcion + "/" + cantidad_um.ToString("G9");
		}
	}
}
