using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class inventarioDAO : pos_colector
	{
		public bool existInventario(Guid id_inventario)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT id_inventario_fisico FROM inventario_fisico WHERE id_inventario_fisico='{id_inventario.ToString()}'");
			return ((DbDataReader)(object)data).Read();
		}

		public inventario_articulo insert(inventario_articulo ia)
		{
			string sqlCommand = $"INSERT INTO inventario_captura(id_inventario_fisico,num_captura,cod_barras,fecha_captura,cant_cja,cant_pza) VALUES('{ia.id_inventario}',{getLastItemNumber(ia.id_inventario)},'{ia.item.cod_asociado}',GETDATE(),{ia.getCantidadCja()},{ia.getCantidadPza()})";
			pos_colector.ExecuteSQL(sqlCommand);
			inventario_articulo inventario_articulo = new inventario_articulo();
			inventario_articulo.cod_barras = ia.item.cod_asociado;
			inventario_articulo.descripcion = ia.item.descripcion;
			inventario_articulo.cant_cja = (ia.medida.tipo.Equals("anexo") ? ia.cantidad : 0m);
			inventario_articulo.cant_pza = (ia.medida.tipo.Equals("principal") ? ia.cantidad : (ia.medida.cantidad_um * ia.cantidad));
			inventario_articulo.medida = ia.medida;
			return inventario_articulo;
		}

		public long getLastItemNumber(Guid InventoryID)
		{
			string sqlCommand = $"SELECT CASE WHEN MAX(num_captura) IS NULL THEN 1 ELSE (MAX(num_captura) + 1) END num_captura FROM inventario_captura WHERE id_inventario_fisico='{InventoryID}'";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? long.Parse(((DbDataReader)(object)data)["num_captura"].ToString()) : 0;
		}

		public List<inventario> getInventories()
		{
			List<inventario> list = new List<inventario>();
			list.Add(new inventario
			{
				id_inventario = default(Guid),
				razon_social = "--INVENTARIOS--"
			});
			string sqlCommand = "SELECT fi.id_inventario_fisico, fi.id_proveedor, fi.[user_name], p.razon_social FROM inventario_fisico fi INNER JOIN proveedor p ON fi.id_proveedor=p.id_proveedor";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new inventario
				{
					id_inventario = new Guid(((DbDataReader)(object)data)["id_inventario_fisico"].ToString()),
					id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString()),
					razon_social = ((DbDataReader)(object)data)["razon_social"].ToString()
				});
			}
			return (list.Count > 0) ? list : null;
		}

		public List<inventario_articulo> getInventoryDetail(Guid id_inventario)
		{
			string sqlCommand = $"SELECT i.cod_barras,a.descripcion,i.cant_cja,i.cant_pza FROM inventario_captura i INNER JOIN articulo a ON i.cod_barras=a.cod_barras WHERE i.id_inventario_fisico='{id_inventario}' ORDER BY i.num_captura";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			List<inventario_articulo> list = new List<inventario_articulo>();
			while (((DbDataReader)(object)data).Read())
			{
				list.Add(new inventario_articulo
				{
					cod_barras = ((DbDataReader)(object)data)["cod_barras"].ToString(),
					descripcion = ((DbDataReader)(object)data)["descripcion"].ToString(),
					cant_cja = decimal.Parse(((DbDataReader)(object)data)["cant_cja"].ToString()),
					cant_pza = decimal.Parse(((DbDataReader)(object)data)["cant_pza"].ToString())
				});
			}
			return (list.Count > 0) ? list : null;
		}

		public void deleteInventory(Guid id_inventario)
		{
			string sqlCommand = $"DELETE FROM inventario_captura WHERE id_inventario_fisico='{id_inventario}'";
			pos_colector.ExecuteSQL(sqlCommand);
			sqlCommand = $"DELETE FROM inventario_fisico WHERE id_inventario_fisico='{id_inventario}'";
			pos_colector.ExecuteSQL(sqlCommand);
		}
	}

}
