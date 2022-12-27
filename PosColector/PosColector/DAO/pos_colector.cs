using System.Data.Common;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;

namespace PosColector.DAO
{
	public class pos_colector
	{
		private static SqlCeConnection cnx;

		private static string stringConnection = "Data Source =" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\pos_colector.sdf;";

		public static SqlCeConnection getConnection()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			if (cnx == null)
			{
				cnx = new SqlCeConnection(stringConnection);
				((DbConnection)(object)cnx).Open();
			}
			return cnx;
		}

		public static SqlCeDataReader GetData(string sqlCommand)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			SqlCeCommand val = new SqlCeCommand(sqlCommand, getConnection());
			return val.ExecuteReader();
		}

		public static void ExecuteSQL(string sqlCommand)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			SqlCeCommand val = new SqlCeCommand(sqlCommand, getConnection());
			((DbCommand)(object)val).ExecuteNonQuery();
		}

		public static void BeginTrans()
		{
			getConnection().BeginTransaction();
		}

		public void CleanSync()
		{
		}
	}

}
