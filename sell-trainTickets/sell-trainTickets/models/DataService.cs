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
			string sql = $"DELETE FROM public.\"TICKET\" WHERE \"ID\" = '{id}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd.ExecuteNonQuery();
			}
		}

		public void buyTicket(Ticket ticket, string email)
		{
			
			string sql = $"UPDATE public.\"SCHEDULE\" SET \"NUM_OF_FREE_SEATS\" = \"NUM_OF_FREE_SEATS\" - 1 " +
				$"WHERE \"RACE_ID\" = '{ticket.RaceId}' AND \"DATE\" = '{ticket.Date.ToString("d")}';";
			using (var cmd1 = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd1.ExecuteNonQuery();
			}
			sql = $"INSERT INTO public.\"TICKET\" (\"RACE_ID\", \"DEPARTURE_CITY\", \"ARRIVAL_CITY\", \"DEPARTURE_TIME\", \"ARRIVAL_TIME\"," +
				$" \"USER_EMAIL\", \"PRICE\", \"DATE\") VALUES ({ticket.RaceId}, '{ticket.DepartureCity}', '{ticket.ArrivalCity}', " +
				$"'{ticket.DepartureTime.ToString("t")}', '{ticket.ArrivalTime.ToString("t")}', '{email}', {ticket.Price}, '{ticket.Date.ToString("d")}');";
			using (var cmd2 = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				cmd2.ExecuteNonQuery();
			}

		}

		public List<Race> findRaces(string departureCity, string arrivalCity, DateTime date)
		{
			List<Race> races = new List<Race>();
			string sql = $"SELECT r.\"ID\", r.\"NAME\", r.\"STATIONS\", r.\"DEPARTURE_TIME\", r.\"ARRIVAL_TIME\", r.\"PRICE\" " +
				$"FROM public.\"RACE\" r JOIN public.\"SCHEDULE\" s ON r.\"ID\" = s.\"RACE_ID\"" +
				$" WHERE s.\"DATE\" = '{date.ToString("d")}' AND r.\"STATIONS\" LIKE '%{departureCity}%{arrivalCity}%' AND s.\"NUM_OF_FREE_SEATS\" > 0;";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						List<DateTime> departureTimes = new List<DateTime>();
						List<DateTime> arrivalTimes = new List<DateTime>();
						string[] dt = reader.GetString(3).Split(';');
						string[] at = reader.GetString(4).Split(';');
						for (int i = 0; i < dt.Length; i++)
						{
							departureTimes.Add(Convert.ToDateTime(dt[i]));
							arrivalTimes.Add(Convert.ToDateTime(at[i]));
						}
						Console.WriteLine(departureTimes[0]);
						races.Add(new Race(reader.GetInt32(0), reader.GetString(1), new List<string>(reader.GetString(2).Split(';')),
								departureTimes, arrivalTimes, reader.GetInt32(5)));
					}
				}
			}
			return races;
		}
		
		public Ticket createTicket(int raceId, DateTime date, string departureCity, string arrivalCity, string fullName)
		{
			List<string> departureTimes = new List<string>();
			List<string> arrivalTimes = new List<string>();
			List<string> stations = new List<string>();
			int price = 0;
			string sql = $"SELECT r.\"STATIONS\", r.\"DEPARTURE_TIME\", r.\"ARRIVAL_TIME\", r.\"PRICE\" FROM public.\"RACE\" r WHERE r.\"ID\" = '{raceId}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						stations = new List<string>(reader.GetString(0).Split(';'));
						departureTimes = new List<string>(reader.GetString(1).Split(';'));
						arrivalTimes = new List<string>(reader.GetString(2).Split(';'));
						price = reader.GetInt32(3);
					}
				}
			}
			int departureStationIndex = stations.FindIndex(x => x.Contains(departureCity));
			int arrivalStationIndex = stations.FindIndex(x => x.Contains(arrivalCity));
			string departureTime = departureTimes[departureStationIndex];
			string arrivalTime = arrivalTimes[arrivalStationIndex];
			price *= arrivalStationIndex - departureStationIndex;

			return new Ticket(raceId, date, departureCity, arrivalCity, Convert.ToDateTime(departureTime), Convert.ToDateTime(arrivalTime), fullName, price);
		}

		public List<Ticket> getUsersTickets(string email)
		{
			List<Ticket> tickets = new List<Ticket>();
			string sql = $"SELECT t.\"ID\", t.\"RACE_ID\", t.\"DEPARTURE_CITY\", t.\"ARRIVAL_CITY\", t.\"DEPARTURE_TIME\", t.\"ARRIVAL_TIME\"," +
				$"  t.\"DATE\" FROM public.\"TICKET\" t WHERE t.\"USER_EMAIL\" = '{email}';";
			using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						tickets.Add(new Ticket(reader.GetInt32(0), reader.GetInt32(1), Convert.ToDateTime(reader.GetString(6)), reader.GetString(2),
							reader.GetString(3),  Convert.ToDateTime(reader.GetString(4)), Convert.ToDateTime(reader.GetString(5))));
					}
				}
			}
			return tickets;
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
			ArrayList date = new ArrayList();
			string sql = $"SELECT DISTINCT s.\"DATE\" FROM public.\"SCHEDULE\" s;";
			using (var cmd1 = new NpgsqlCommand(sql, DBSource.getConnection()))
			{
				using (NpgsqlDataReader reader = cmd1.ExecuteReader())
				{
					while (reader.Read())
					{
						date.Add(Convert.ToDateTime(reader.GetString(0)));
					}
				}
			}
			date.Sort();
			TimeSpan span = DateTime.Today.Subtract((DateTime)date[0]);
			int diffInDays = (int)span.TotalDays;
			Console.WriteLine(diffInDays);
			for (int i = diffInDays; i > 0; i--)
			{
				sql = $"DELETE FROM public.\"SCHEDULE\" WHERE \"DATE\" = '{DateTime.Today.AddDays(-i).ToString("d")}';";
				using (var cmd = new NpgsqlCommand(sql, DBSource.getConnection()))
				{
					cmd.ExecuteNonQuery();
				}
			}
			ArrayList id = new ArrayList();
			ArrayList num_of_seats = new ArrayList();
			sql = $"SELECT r.\"ID\", r.\"NUM_OF_SEATS\" FROM public.\"RACE\" r;";
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
			for (int i = 31 - diffInDays; i < 31 ; i++)
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

