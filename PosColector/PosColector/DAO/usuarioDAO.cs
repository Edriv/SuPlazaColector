using System.Data.Common;
using System.Data.SqlServerCe;

namespace PosColector.DAO
{
	public class usuarioDAO : pos_colector
	{
		public bool existUser(string user_name)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT user_name FROM usuario WHERE user_name='{user_name}'");
			return ((DbDataReader)(object)data).Read();
		}

		public bool existPermision(string user_name, string id_permiso)
		{
			SqlCeDataReader data = pos_colector.GetData($"SELECT user_name FROM usuario_permiso WHERE user_name='{user_name}' AND id_permiso='{id_permiso}'");
			return ((DbDataReader)(object)data).Read();
		}

		public bool AuthorizerUser(string password)
		{
			string sqlCommand = $"SELECT u.[user_name] FROM usuario u INNER JOIN usuario_permiso up ON u.[user_name]=up.[user_name] WHERE u.[password]='{password}' AND up.id_permiso='pos_colector'";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read();
		}
	}
}
