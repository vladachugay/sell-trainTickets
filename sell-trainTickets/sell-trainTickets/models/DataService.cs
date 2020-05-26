using System;
using Npgsql;
using System.Collections.Generic;
using System.Collections;


namespace sellTrainTickets.Models
{
	public class DataService
	{
		public DataService()
		{
		}

		public List<User> getUserWithLogPass(string log, string pass)
		{
			List<User> users = new List<User>();
			string sql = $"SELECT * FROM public.\"USER\" WHERE \"EMAIL\" = '{log}' AND \"PASSWORD\" = '{pass}'";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						users.Add(new User(reader.GetString(1), reader.GetString(0),
								reader.GetString(2), reader.GetBoolean(3), reader.GetBoolean(4)));
					}
				}
			}	
			return users;
		}

		public void deleteSession(string IP)
		{
			
			string sql = $"DELETE FROM public.\"SESSION\" WHERE \"IP\" = '{IP}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}	
		}

		public void addUser(string fullName, string email, string pass)
		{
			string sql = $"INSERT INTO public.\"USER\" VALUES ('{email}', '{fullName}', '{pass}', False, False);";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public void addSession(string email, string IP)
		{
			string sql = $"INSERT INTO public.\"SESSION\" VALUES ('{IP}', '{email}');";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public bool isAdmin(string IP)
		{
			bool isAdmin = false;
			string sql = $"SELECT u.\"IS_ADMIN\" FROM public.\"USER\" u JOIN public.\"SESSION\" s ON " +
				$"u.\"EMAIL\" = s.\"USER_EMAIL\" WHERE s.\"IP\" = '{IP}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						isAdmin = reader.GetBoolean(0); 
					}
				}
			}
			return isAdmin;
		}

		public bool isSuperAdmin(string IP)
		{
			bool isSuperAdmin = false;
			string sql = $"SELECT u.\"IS_SUPER_ADMIN\" FROM public.\"USER\" u JOIN public.\"SESSION\" s ON " +
				$"u.\"EMAIL\" = s.\"USER_EMAIL\" WHERE s.\"IP\" = '{IP}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						isSuperAdmin = reader.GetBoolean(0);
					}
				}
			}
			return isSuperAdmin;
		}
		
		public void addAdmin(string email)
		{
			string sql = $"UPDATE public.\"USER\" SET \"IS_ADMIN\" = TRUE WHERE \"EMAIL\" = '{email}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public void deleteAdmin(string email)
		{
			string sql = $"UPDATE public.\"USER\" SET \"IS_ADMIN\" = FALSE WHERE \"EMAIL\" = '{email}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public void addRace(int id, string stations, string arrivalTime, string departureTime, int numOfSeats)
		{

		}

		public void deleteRace(int id)
		{

		}

		public void returnTicket(int id)
		{

		}

		public void buyTicket(Ticket ticket)
		{

		}

		public ArrayList findRaces(string departureCity, string arrivalCity, DateTime date)
		{
			return new ArrayList();
		}
		
		public Ticket createTicket(int raceId, string date, string deprtureCity, string arrivalCity, string fullName)
		{
			return new Ticket();
		}

		public List<Ticket> getUsersTickets(string email)
		{
			return new List<Ticket>();
		}

		private string getUsersEmail(string IP)
		{
			string email = "";
			string sql = $"SELECT s.\"USER_EMAIL\" FROM public.\"SESSION\" s WHERE s.\"IP\" = '{IP}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						email = reader.GetString(0);
					}
				}
			}
			return email;
		}

		public User getUser(string IP)
		{
			string sql = $"SELECT u.\"EMAIL\", u.\"FULLNAME\", u.\"PASSWORD\", u.\"IS_ADMIN\", u.\"IS_SUPER_ADMIN\" FROM public.\"USER\" u JOIN public.\"SESSION\" s ON " +
				$"u.\"EMAIL\" = s.\"USER_EMAIL\" WHERE s.\"IP\" = '{IP}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						return new User(reader.GetString(1), reader.GetString(0),
								reader.GetString(2), reader.GetBoolean(3), reader.GetBoolean(4));
					}
				}
			}
			return new User();
		}
	}
}

