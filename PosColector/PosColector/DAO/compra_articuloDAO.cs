using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class compra_articuloDAO : pos_colector
	{
		public order_detail insertPurchase(compra_articulo ca)
		{
			string sqlCommand = $"INSERT INTO compra_articulo(id_compra, cod_barras, num_articulo, cant_cja, cant_pza, precio_compra, no_captura, no_entrega) VALUES('{ca.id_compra}','{ca.item.cod_barras}',{getLastNumberItem(ca.id_compra)},{ca.getCantidadCja()},{ca.getCantidadPza()},{ca.precio_compra},0,0)";
			pos_colector.ExecuteSQL(sqlCommand);
			order_detail order_detail = new order_detail();
			order_detail.cod_barras = ca.item.cod_barras;
			order_detail.descripcion = ca.item.descripcion;
			order_detail.cant_cja = ca.getCantidadCja();
			order_detail.cant_pza = ca.getCantidadPza();
			order_detail.unidad = ca.medida;
			return order_detail;
		}

		public order_detail insert(compra_articulo ca)
		{
			string sqlCommand = $"INSERT INTO compra_articulo(id_compra, cod_barras, num_articulo, cant_cja, cant_pza, precio_compra, no_captura, no_entrega) VALUES('{ca.id_compra}','{ca.item.cod_asociado}',{getLastNumberItem(ca.id_compra)},{ca.getCantidadCja()},{ca.getCantidadPza()},{ca.precio_compra},0,0)";
			pos_colector.ExecuteSQL(sqlCommand);
			order_detail order_detail = new order_detail();
			order_detail.cod_barras = ca.item.cod_asociado;
			order_detail.descripcion = ca.item.descripcion;
			order_detail.cant_cja = ca.getCantidadCja();
			order_detail.cant_pza = ca.getCantidadPza();
			order_detail.unidad = ca.medida;
			return order_detail;
		}

		private long getLastNumberItem(Guid id_compra)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT CASE WHEN MAX(num_articulo) IS NULL THEN 1 ELSE (MAX(num_articulo) + 1) END num_articulo FROM compra_articulo WHERE id_compra='{id_compra.ToString()}'");
			return ((DbDataReader)(object)data).Read() ? long.Parse(((DbDataReader)(object)data)["num_articulo"].ToString()) : 0;
		}

		public void deleteLastItemPurchase(Guid id_compra)
		{
			pos_colector.ExecuteSQL(string.Format("DELETE FROM compra_articulo WHERE id_compra='{0}' AND num_articulo=(SELECT MAX(num_articulo) FROM compra_articulo WHERE id_compra='{0}')", id_compra.ToString()));
		}

		public List<order_detail> getPurchaseDetail(Guid id_compra)
		{
			List<order_detail> list = new List<order_detail>();
			string sqlCommand = $"SELECT ca.cod_barras,a.descripcion,ca.cant_cja,ca.cant_pza FROM compra_articulo ca INNER JOIN articulo a ON ca.cod_barras=a.cod_barras WHERE id_compra='{id_compra}' ORDER BY ca.num_articulo";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new order_detail
				{
					cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString(),
					descripcion = ((DbDataReader)(object)data)["descripcion"].ToString(),
					cant_cja = decimal.Parse(((DbDataReader)(object)data)["cant_cja"].ToString()),
					cant_pza = decimal.Parse(((DbDataReader)(object)data)["cant_pza"].ToString())
				});
			}
			return (list.Count > 0) ? list : null;
		}
	}
}
