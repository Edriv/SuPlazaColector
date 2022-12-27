using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class pedidoDAO : pos_colector
	{
		public bool existOrder(Guid id_pedido)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT id_pedido FROM orden WHERE id_pedido='{id_pedido.ToString()}'");
			return ((DbDataReader)(object)data).Read();
		}

		public pedido getPedido(Guid id_pedido)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT id_pedido, num_pedido, id_proveedor FROM orden WHERE id_pedido='{id_pedido.ToString()}'");
			object result;
			if (!((DbDataReader)(object)data).Read())
			{
				result = null;
			}
			else
			{
				pedido pedido = new pedido();
				pedido.id_pedido = new Guid(((DbDataReader)(object)data)["id_pedido"].ToString());
				pedido.num_pedido = ((DbDataReader)(object)data)["num_pedido"].ToString();
				pedido.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				result = pedido;
			}
			return (pedido)result;
		}

		public List<pedido> getListPedidosAut()
		{
			List<pedido> list = new List<pedido>();
			list.Add(new pedido
			{
				id_pedido = default(Guid),
				num_pedido = "--PEDIDOS--",
				id_proveedor = default(Guid)
			});
			SqlCeDataReader data = pos_colector.GetData("SELECT id_pedido, num_pedido, p.id_proveedor, pr.razon_social FROM orden p INNER JOIN proveedor pr ON p.id_proveedor=pr.id_proveedor WHERE status_pedido='autorizado' ORDER BY num_pedido");
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new pedido
				{
					id_pedido = new Guid(((DbDataReader)(object)data)["id_pedido"].ToString()),
					num_pedido = ((DbDataReader)(object)data)["num_pedido"].ToString(),
					id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString()),
					razon_social = ((DbDataReader)(object)data)["razon_social"].ToString()
				});
			}
			return list;
		}

		public List<pedido> getListPedidosCap()
		{
			List<pedido> list = new List<pedido>();
			list.Add(new pedido
			{
				id_pedido = default(Guid),
				num_pedido = "--PEDIDOS--",
				id_proveedor = default(Guid)
			});
			SqlCeDataReader data = pos_colector.GetData("SELECT p.id_pedido,p.num_pedido,pr.razon_social FROM orden p INNER JOIN compra c ON p.id_pedido=c.id_pedido INNER JOIN proveedor pr ON p.id_proveedor=pr.id_proveedor GROUP BY p.id_pedido,p.num_pedido,pr.razon_social ORDER BY p.num_pedido");
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new pedido
				{
					id_pedido = new Guid(((DbDataReader)(object)data)["id_pedido"].ToString()),
					num_pedido = ((DbDataReader)(object)data)["num_pedido"].ToString(),
					razon_social = ((DbDataReader)(object)data)["razon_social"].ToString()
				});
			}
			return list;
		}

		public void deleteOrder(Guid id_pedido)
		{
			List<compra> comprasPorPedido = new compraDAO().getComprasPorPedido(id_pedido);
			string sqlCommand;
			if (comprasPorPedido != null)
			{
				foreach (compra item in comprasPorPedido)
				{
					sqlCommand = $"DELETE FROM compra_articulo WHERE id_compra='{item.id_compra}'";
					pos_colector.ExecuteSQL(sqlCommand);
					sqlCommand = $"DELETE FROM compra WHERE id_compra='{item.id_compra}'";
					pos_colector.ExecuteSQL(sqlCommand);
				}
			}
			sqlCommand = $"DELETE FROM orden WHERE id_pedido='{id_pedido}'";
			pos_colector.ExecuteSQL(sqlCommand);
		}
	}
}
