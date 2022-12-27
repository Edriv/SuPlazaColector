using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Linq;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class pedido_articuloDAO : pos_colector
	{
		public bool existOrderItem(Guid id_pedido, short no_articulo)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT id_pedido, no_articulo FROM orden_articulo WHERE id_pedido='{id_pedido.ToString()}' AND no_articulo={no_articulo}");
			return ((DbDataReader)(object)data).Read();
		}

		public articulo getArticuloPedido(string find, pedido orden, int count)
		{
			string sqlCommand = string.Format("SELECT ord.cod_barras,COALESCE(ord.cod_anexo,a.cod_barras) cod_anexo,a.descripcion,a.id_unidad,a.cantidad_um,a.precio_compra,a.tipo_articulo,a.id_proveedor,COALESCE(ord.cantidad,0.000) cantidad,COALESCE(ord.por_surtir,0.000) por_surtir FROM articulo a JOIN (SELECT oa.cod_barras,oa.cod_anexo,cantidad,por_surtir FROM orden o JOIN orden_articulo oa ON o.id_pedido=oa.id_pedido AND o.id_pedido='{0}' JOIN articulo a ON (a.tipo_articulo='principal' OR a.tipo_articulo='asociado') AND (oa.cod_barras=a.cod_barras OR oa.cod_barras=a.cod_asociado) WHERE a.cod_barras='{1}' OR a.cod_interno='{1}') ord ON a.cod_barras=ord.cod_barras WHERE a.id_proveedor='{2}'", orden.id_pedido, find, orden.id_proveedor);
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			if (((DbDataReader)(object)data).Read())
			{
				articulo articulo = new articulo();
				articulo.cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString();
				articulo.cod_asociado = ((DbDataReader)(object)data)["cod_anexo"].ToString() ?? null;
				articulo.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				articulo.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				articulo.cantidad_um = decimal.Parse(((DbDataReader)(object)data)["cantidad_um"].ToString());
				articulo.precio_compra = decimal.Parse(((DbDataReader)(object)data)["precio_compra"].ToString());
				articulo.tipo_articulo = ((DbDataReader)(object)data)["tipo_articulo"].ToString();
				articulo.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				articulo.cant_pedida = decimal.Parse(((DbDataReader)(object)data)["cantidad"].ToString());
				articulo.por_surtir = decimal.Parse(((DbDataReader)(object)data)["por_surtir"].ToString());
				return articulo;
			}
			if (count != 0)
			{
				return getArticuloPedido($"0{find}", orden, --count);
			}
			return null;
		}

		public List<unidad_articulo> getUnidadesMedida(articulo a)
		{
			List<unidad_articulo> list = new List<unidad_articulo>();
			list.AddRange(new articuloDAO().getUnidadesAnexos(a.cod_barras));
			articulo articulo = new articuloDAO().getArticulo(a.cod_barras, 1);
			unidad_medida unidadMedida = new unidad_medidaDAO().getUnidadMedida(articulo.id_unidad);
			list.Add(new unidad_articulo
			{
				id_unidad = unidadMedida.id_unidad,
				descripcion = unidadMedida.descripcion,
				cantidad_um = articulo.cantidad_um,
				tipo = "principal"
			});
			list.OrderBy((unidad_articulo u) => u.descripcion);
			return list;
		}
	}
}
