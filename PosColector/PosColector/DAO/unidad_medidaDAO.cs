using System;
using System.Data.Common;
using System.Data.SqlServerCe;
using PosColector.Entities;

namespace PosColector.DAO
{
	public class unidad_medidaDAO : pos_colector
	{
		public bool exist(Guid id_unidad)
		{
			string sqlCommand = $"SELECT id_unidad, descripcion FROM unidad_medida WHERE id_unidad='{id_unidad.ToString()}'";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read();
		}

		public unidad_medida getUnidadMedida(Guid id_unidad)
		{
			string sqlCommand = $"SELECT id_unidad, descripcion FROM unidad_medida WHERE id_unidad='{id_unidad.ToString()}'";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			if (((DbDataReader)(object)data).Read())
			{
				unidad_medida unidad_medida = new unidad_medida();
				unidad_medida.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				unidad_medida.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				return unidad_medida;
			}
			return null;
		}

		public unidad_medida getUnidadMedida(string barCode)
		{
			string sqlCommand = $"SELECT a.id_unidad, um.descripcion FROM articulo a INNER JOIN unidad_medida um ON a.id_unidad=um.id_unidad WHERE a.cod_barras='{barCode}'";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			if (((DbDataReader)(object)data).Read())
			{
				unidad_medida unidad_medida = new unidad_medida();
				unidad_medida.id_unidad = new Guid(((DbDataReader)(object)data)["id_unidad"].ToString());
				unidad_medida.descripcion = ((DbDataReader)(object)data)["descripcion"].ToString();
				return unidad_medida;
			}
			return null;
		}
	}

}
