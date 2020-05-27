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

		public void deleteSession(string MAC)
		{
			
			string sql = $"DELETE FROM public.\"SESSION\" WHERE \"MAC\" = '{MAC}';";
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

		public void addSession(string email, string MAC)
		{
			string sql = $"INSERT INTO public.\"SESSION\" VALUES ('{MAC}', '{email}');";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public bool isAdmin(string MAC)
		{
			bool isAdmin = false;
			string sql = $"SELECT u.\"IS_ADMIN\" FROM public.\"USER\" u JOIN public.\"SESSION\" s ON " +
				$"u.\"EMAIL\" = s.\"USER_EMAIL\" WHERE s.\"MAC\" = '{MAC}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						isAdmin = reader.GetBoolean(0); 
					} 				}
			}
			return isAdmin;
		}

		public bool isSuperAdmin(string MAC)
		{
			bool isSuperAdmin = false;
			string sql = $"SELECT u.\"IS_SUPER_ADMIN\" FROM public.\"USER\" u JOIN public.\"SESSION\" s ON " +
				$"u.\"EMAIL\" = s.\"USER_EMAIL\" WHERE s.\"MAC\" = '{MAC}';";
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

		public void addRace(int id, string name, string stations, string arrivalTime, string departureTime, int numOfSeats, int price)
		{
			string sql = $"INSERT INTO public.\"RACE\" VALUES ('{id}', '{name}', '{stations}', '{arrivalTime}', '{departureTime}', '{numOfSeats}', '{price}');";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public void deleteRace(int id)
		{
			string sql = $"DELETE FROM public.\"RACE\" WHERE \"ID\" = '{id}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
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

		private string getUsersEmail(string MAC)
		{
			string email = "";
			string sql = $"SELECT s.\"USER_EMAIL\" FROM public.\"SESSION\" s WHERE s.\"MAC\" = '{MAC}';";
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

		public User getUser(string MAC)
		{
			string sql = $"SELECT u.\"EMAIL\", u.\"FULLNAME\", u.\"PASSWORD\", u.\"IS_ADMIN\", u.\"IS_SUPER_ADMIN\" FROM public.\"USER\" u JOIN public.\"SESSION\" s ON " +
				$"u.\"EMAIL\" = s.\"USER_EMAIL\" WHERE s.\"MAC\" = '{MAC}';";
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

		public void refreshSchedule()
		{

		}

		public void fillSchedule()
		{
			ArrayList id = new ArrayList();
			ArrayList num_of_seats = new ArrayList();
			string sql = $"SELECT r.\"ID\", r.\"NUM_OF_SEATS\" FROM public.\"RACE\" r;";
			using (var cmd1 = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd1.ExecuteReader())
				{
					while (reader.Read())
					{
						id.Add(reader.GetInt32(0));
						num_of_seats.Add(reader.GetInt32(1));
					}
				}
			}
			for (int i = 1; i < 31; i++)
			{
				for (int j = 0; j < id.Count; j++)
				{
					sql = $"INSERT INTO public.\"SCHEDULE\" VALUES ('{id[j]}', '{num_of_seats[j]}', '{DateTime.Today.AddDays(i).ToString("d")}');";
					using (var cmd2 = new NpgsqlCommand(sql, DBSource.getConnection()))
					{
						cmd2.ExecuteNonQuery();
					}
				}
			}
		}
	}
}

