using System;
using Npgsql;
using System.IO;

namespace sellTrainTickets.Models
{
	public class DBSource
	{
		public DBSource()
		{
			string path = "C:\\Users\\user\\Desktop\\KPI\\4sem\\trpz\\project\\sell-trainTickets\\sell-trainTickets\\sell-trainTickets\\config.txt";
			string pass = File.ReadAllText(path);
			var cs = $"Host=localhost;Username=postgres;Password={pass};Database=testdb";

			using var con = new NpgsqlConnection(cs);
			con.Open();

			using var cmd = new NpgsqlCommand();
			cmd.Connection = con;
		}
	}
}


