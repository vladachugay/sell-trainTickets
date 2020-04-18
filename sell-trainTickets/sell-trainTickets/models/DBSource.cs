using System;
using Npgsql;
using System.IO;

namespace sellTrainTickets.Models
{
	public static class DBSource
	{
		private static NpgsqlConnection conn;
		private static string path = "C:\\Users\\user\\Desktop\\KPI\\4sem\\trpz\\project" +
			"\\sell-trainTickets\\sell-trainTickets\\sell-trainTickets\\config.txt";

		public static void openConnection()
		{
			string pass = File.ReadAllText(path);
			string cs = $"Server=127.0.0.1; Port=5432; User Id=postgres; Password={pass}; Database=postgres";
			conn = new NpgsqlConnection(cs);
			conn.Open();
		}

		public static void closeConnection()
		{
			conn.Close();
		}
	}
}


