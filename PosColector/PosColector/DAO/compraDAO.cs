using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class compraDAO : pos_colector
	{
		public enum Purchase
		{
			ByOrder,
			Free
		}

		public void insert(Purchase p, compra c)
		{
			string sqlCommand = "";
			switch (p)
			{
				case Purchase.ByOrder:
					sqlCommand = $"INSERT INTO compra(id_compra,id_proveedor,fecha_compra,id_pedido,cancelada,no_entrada) VALUES('{c.id_compra}','{c.id_proveedor}',GETDATE(),'{c.id_pedido}',0,0)";
					break;
				case Purchase.Free:
					sqlCommand = $"INSERT INTO compra(id_compra,fecha_compra,cancelada,no_entrada) VALUES('{c.id_compra}',GETDATE(),0,0)";
					break;
			}
			pos_colector.ExecuteSQL(sqlCommand);
		}

		public List<compra> getListComprasCap(Guid id_pedido)
		{
			List<compra> list = new List<compra>();
			list.Add(new compra
			{
				id_compra = default(Guid),
				num_compra = "--CAPTURAS--"
			});
			string sqlCommand = $"SELECT c.id_compra FROM compra c WHERE c.id_pedido='{id_pedido}' ORDER BY c.fecha_compra";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			int num = 1;
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new compra
				{
					id_compra = new Guid(((DbDataReader)(object)data)["id_compra"].ToString()),
					num_compra = num++.ToString()
				});
			}
			return (list.Count > 1) ? list : null;
		}

		public List<compra> getComprasPorPedido(Guid id_pedido)
		{
			List<compra> list = new List<compra>();
			string sqlCommand = $"SELECT c.id_compra FROM compra c WHERE c.id_pedido='{id_pedido}' ORDER BY c.fecha_compra";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			int num = 1;
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new compra
				{
					id_compra = new Guid(((DbDataReader)(object)data)["id_compra"].ToString()),
					num_compra = num++.ToString()
				});
			}
			return (list.Count > 0) ? list : null;
		}

		public List<compra> getComprasAbiertasCap()
		{
			List<compra> list = new List<compra>();
			list.Add(new compra
			{
				id_compra = default(Guid),
				num_compra = "--CAPTURAS--"
			});
			string sqlCommand = $"SELECT c.id_compra FROM compra c WHERE c.id_pedido IS NULL ORDER BY c.fecha_compra";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			int num = 1;
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new compra
				{
					id_compra = new Guid(((DbDataReader)(object)data)["id_compra"].ToString()),
					num_compra = num++.ToString()
				});
			}
			return (list.Count > 1) ? list : null;
		}

		public void deletePurchase(Guid id_compra)
		{
			string sqlCommand = $"DELETE FROM compra_articulo WHERE id_compra='{id_compra}'";
			pos_colector.ExecuteSQL(sqlCommand);
			sqlCommand = $"DELETE FROM compra WHERE id_compra='{id_compra}'";
			pos_colector.ExecuteSQL(sqlCommand);
		}
	}
}
