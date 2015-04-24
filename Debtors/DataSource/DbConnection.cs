using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Debtors.DataSource
{
	public class DbConnection
	{
		private ConnectionStringSettingsCollection _settingsCollection;
		private SqlConnection _connection;

		public string CurrentConnectionString
		{
			get
			{
				return _settingsCollection["ConnectionString"].ConnectionString;
			}
		}

		public DbConnection()
		{
			_settingsCollection = ConfigurationManager.ConnectionStrings;
			_connection = new SqlConnection(CurrentConnectionString);
		}

		public DataTable GetUserEvents(int idUser)
		{
			SqlCommand command = new SqlCommand();
			command.CommandText = "GetUserEvents";
			command.CommandType = CommandType.StoredProcedure;
			SqlParameter parameter = new SqlParameter("idUser", idUser);
			command.Parameters.Add(parameter);
			command.Connection = _connection;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataSet data = new DataSet();
			_connection.Open();
			adapter.Fill(data);
			_connection.Close();

			return data.Tables[0];
		}

		public void Save(DataSet events)
		{

		}


	}
}
