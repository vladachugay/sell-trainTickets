using System;
using Npgsql;
using System.Collections.Generic;


namespace sellTrainTickets.Models
{
	public class DataService
	{
		
		public DataService()
		{
		}

		public List<User> getUserWithLogPass(string log, string pass)
		{
			return new List<User>();
		}

		public void deleteSession(string IP)
		{

		}

		public void addUser(string fullName, string email, string pass)
		{
			User user = new User(fullName, email, pass);
			//
		}

		public void addSession(string email, string IP)
		{
			Session session = new Session(email, IP);
			//
		}

		public bool isAdmin(string IP)
		{
			return false;
		}

		public bool isSuperAdmin(string IP)
		{
			return false;
		}
		
		public void addAdmin(string email)
		{

		}

		public void deleteAdmin(string email)
		{

		}

		public void addRace(string stations, string arrivalTime, string departureTime, int numOfSeats)
		{

		}

		public void deleteRace(int id)
		{

		}

		public void returnTicket(Ticket ticket)
		{

		}

		public void buyTicket(Ticket ticket)
		{

		}
	}
}

