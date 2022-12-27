using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Linq;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class articuloDAO : pos_colector
	{
		public bool exist(string barCode)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT cod_barras FROM articulo WHERE cod_barras='{barCode}'");
			return ((DbDataReader)(object)data).Read();
		}

		public articulo getArticulo(string find, int count)
		{
			SqlCeDataReader data = pos_colector.GetData(string.Format("SELECT cod_barras, CASE WHEN cod_asociado IS NULL THEN cod_barras ELSE cod_asociado END cod_asociado, descripcion, id_unidad, cantidad_um, precio_compra, tipo_articulo, id_proveedor FROM articulo WHERE cod_barras='{0}' OR cod_interno='{0}'", find.ToString()));
			if (((DbDataReader)(object)data).Read())
			{
				articulo articulo = new articulo();
				articulo.cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString();
				articulo.cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString();
				articulo.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				articulo.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				articulo.cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString());
				articulo.precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString());
				articulo.tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString();
				articulo.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				return articulo;
			}
			if (count != 0)
			{
				return getArticulo($"0{find}", --count);
			}
			return null;
		}

		public List<unidad_articulo> getUnidadesAnexos(string barCode)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			List<unidad_articulo> list = new List<unidad_articulo>();
			string text = $"SELECT DISTINCT um.id_unidad,um.descripcion,a.cantidad_um,a.tipo_articulo\r\n  FROM articulo a JOIN unidad_medida um ON a.id_unidad=um.id_unidad \r\n  WHERE a.tipo_articulo='anexo' AND um.descripcion='Cja' AND cod_asociado='{barCode}' ORDER BY cantidad_um DESC";
			SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
			DataTable dataTable = new DataTable();
			SqlCeDataAdapter val2 = new SqlCeDataAdapter(val);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			foreach (DataRow row in dataTable.Rows)
			{
				list.Add(new unidad_articulo
				{
					id_unidad = new Guid(row["id_unidad"].ToString()),
					descripcion = row["descripcion"].ToString(),
					cantidad_um = decimal.Parse(row["cantidad_um"].ToString()),
					tipo = row["tipo_articulo"].ToString()
				});
			}
			((Component)(object)val2).Dispose();
			dataTable.Clear();
			dataTable.Dispose();
			((Component)(object)val).Dispose();
			GC.Collect();
			return list;
		}

		public articulo getArticuloByProveedor(string barCode, Guid providerID)
		{
			SqlCeDataReader data = pos_colector.GetData(string.Format("SELECT cod_barras, CASE WHEN cod_asociado IS NULL THEN cod_barras ELSE cod_asociado END cod_asociado, descripcion, id_unidad, cantidad_um, precio_compra, tipo_articulo, id_proveedor FROM articulo WHERE (cod_barras='{0}' OR cod_interno='{0}') AND id_proveedor='{1}'", barCode, providerID));
			object result;
			if (!((DbDataReader)(object)data).Read())
			{
				result = null;
			}
			else
			{
				articulo articulo = new articulo();
				articulo.cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString();
				articulo.cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString();
				articulo.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				articulo.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				articulo.cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString());
				articulo.precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString());
				articulo.tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString();
				articulo.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				result = articulo;
			}
			return (articulo)result;
		}

		public articulo getArticuloPrincipal(string cod_barras)
		{
			string sqlCommand = $"SELECT cod_barras, cod_asociado, descripcion, id_unidad, cantidad_um, precio_compra, tipo_articulo, id_proveedor FROM articulo WHERE cod_barras='{cod_barras.ToString()}' AND tipo_articulo='principal'";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			object result;
			if (!((DbDataReader)(object)data).Read())
			{
				result = null;
			}
			else
			{
				articulo articulo = new articulo();
				articulo.cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString();
				articulo.cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString();
				articulo.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				articulo.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				articulo.cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString());
				articulo.precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString());
				articulo.tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString();
				articulo.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				result = articulo;
			}
			return (articulo)result;
		}

		public articulo getArticuloAnexo(string cod_barras)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT cod_barras, cod_asociado, descripcion, id_unidad, cantidad_um, precio_compra, tipo_articulo, id_proveedor FROM articulo WHERE cod_asociado='{cod_barras.ToString()}' AND tipo_articulo='anexo'");
			object result;
			if (!((DbDataReader)(object)data).Read())
			{
				result = null;
			}
			else
			{
				articulo articulo = new articulo();
				articulo.cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString();
				articulo.cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString();
				articulo.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				articulo.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				articulo.cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString());
				articulo.precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString());
				articulo.tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString();
				articulo.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				result = articulo;
			}
			return (articulo)result;
		}

		public List<articulo> getListArticulos()
		{
			List<articulo> list = new List<articulo>();
			SqlCeDataReader data = pos_colector.GetData("SELECT cod_barras, cod_asociado, descripcion, id_unidad FROM articulo a");
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new articulo
				{
					cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString(),
					cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString(),
					descripcion = ((DbDataReader)(object)data)["descripcion"].ToString(),
					id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString()),
					cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString()),
					precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString()),
					tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString()
				});
			}
			return list;
		}

		public List<articulo> getUnidadesByArticulo(string barCode)
		{
			List<articulo> list = new List<articulo>();
			articulo articulo = new articuloDAO().getArticulo(barCode, 1);
			list.Add(articulo);
			if (articulo.tipo_articulo.Equals("principal") || articulo.tipo_articulo.Equals("asociado"))
			{
				SqlCeDataReader data = pos_colector.GetData($"SELECT cod_barras, cod_asociado, descripcion, id_unidad, cantidad_um, precio_compra, tipo_articulo FROM articulo WHERE cod_asociado='{barCode.ToString()}' AND tipo_articulo='anexo'");
				if (((DbDataReader)(object)data).Read())
				{
					list.Add(new articulo
					{
						cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString(),
						cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString(),
						descripcion = ((DbDataReader)(object)data)["descripcion"].ToString(),
						id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString()),
						cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString()),
						precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString()),
						tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString()
					});
				}
			}
			else if (articulo.tipo_articulo.Equals("anexo"))
			{
				SqlCeDataReader data = pos_colector.GetData($"SELECT cod_barras, cod_asociado, descripcion, id_unidad, cantidad_um, precio_compra, tipo_articulo FROM articulo WHERE cod_barras='{barCode.ToString()}' AND tipo_articulo='principal'");
				if (((DbDataReader)(object)data).Read())
				{
					list.Add(new articulo
					{
						cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString(),
						cod_asociado = ((DbDataReader)(object)data)["cod_asociado"].ToString(),
						descripcion = ((DbDataReader)(object)data)["descripcion"].ToString(),
						id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString()),
						cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString()),
						precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString()),
						tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString()
					});
				}
			}
			return list;
		}

		public List<unidad_articulo> getUnidadesMedida(articulo a)
		{
			List<unidad_articulo> list = new List<unidad_articulo>();
			if (a.cod_barras != a.cod_asociado)
			{
				articulo articulo = new articuloDAO().getArticulo(a.cod_asociado, 1);
				unidad_medida unidadMedida = new unidad_medidaDAO().getUnidadMedida(articulo.id_unidad);
				list.Add(new unidad_articulo
				{
					id_unidad = unidadMedida.id_unidad,
					descripcion = unidadMedida.descripcion,
					cantidad_um = articulo.cantidad_um,
					tipo = articulo.tipo_articulo
				});
			}
			articulo articulo2 = new articuloDAO().getArticulo(a.cod_barras, 1);
			unidad_medida unidadMedida2 = new unidad_medidaDAO().getUnidadMedida(articulo2.id_unidad);
			list.Add(new unidad_articulo
			{
				id_unidad = unidadMedida2.id_unidad,
				descripcion = unidadMedida2.descripcion,
				cantidad_um = articulo2.cantidad_um,
				tipo = articulo2.tipo_articulo
			});
			list.OrderBy((unidad_articulo u) => u.descripcion);
			return list;
		}

		public List<unidad_articulo> getUnidadesMedida(string barCode)
		{
			List<unidad_articulo> list = new List<unidad_articulo>();
			articulo articuloPrincipal = getArticuloPrincipal(barCode);
			if (articuloPrincipal == null)
			{
				throw new Exception("Artículo no encontrado");
			}
			list.AddRange(new articuloDAO().getUnidadesAnexos(articuloPrincipal.cod_barras));
			unidad_medida unidadMedida = new unidad_medidaDAO().getUnidadMedida(articuloPrincipal.id_unidad);
			list.Add(new unidad_articulo
			{
				id_unidad = unidadMedida.id_unidad,
				descripcion = unidadMedida.descripcion,
				cantidad_um = articuloPrincipal.cantidad_um,
				tipo = articuloPrincipal.tipo_articulo
			});
			return list;
		}
	}
}
