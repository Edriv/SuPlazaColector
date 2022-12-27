using System;
using System.Data.Common;
using System.Data.SqlServerCe;
using PosColector.Entities;


namespace PosColector.DAO
{
	public class proveedorDAO : pos_colector
	{
		public bool exist(Guid id_proveedor)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT id_proveedor FROM proveedor WHERE id_proveedor='{id_proveedor.ToString()}'");
			return ((DbDataReader)(object)data).Read();
		}

		public proveedor getProveedor(Guid id_proveedor)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT id_proveedor, razon_social FROM proveedor WHERE id_proveedor='{id_proveedor.ToString()}'");
			if (((DbDataReader)(object)data).Read())
			{
				proveedor proveedor = new proveedor();
				proveedor.id_proveedor = new Guid(((DbDataReader)(object)data)["id_proveedor"].ToString());
				proveedor.razon_social = ((DbDataReader)(object)data)["razon_social"].ToString();
				return proveedor;
			}
			return null;
		}

		public void deleteOrderTrash()
		{
		}
	}

}
