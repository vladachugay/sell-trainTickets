using System;

namespace sellTrainTickets.Models
{
	public class Ticket
	{
		private int id;
		private int raceId;
		private DateTime date;
		private string departureCity;
		private string arrivalCity;
		private DateTime departureTime;
		private DateTime arrivalTime;
		private string fullName;
		private int price;

		public Ticket()
		{
		}

		public Ticket(int id, int raceId, DateTime date, string departureCity, string arrivalCity,
			DateTime departureTime, DateTime arrivalTime, string fullName, int price)
		{
			this.id = id;
			this.raceId = raceId;
			this.date = date;
			this.departureCity = departureCity;
			this.arrivalCity = arrivalCity;
			this.departureTime = departureTime;
			this.arrivalTime = arrivalTime;
			this.fullName = fullName;
			this.price = price;
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public int RaceId
		{
			get { return raceId; }
			set { raceId = value; }
		}

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		public string DepartureCity
		{
			get { return departureCity; }
			set { departureCity = value; }
		}

		public string ArrivalCity
		{
			get { return arrivalCity; }
			set { arrivalCity = value; }
		}

		public DateTime DepartureTime
		{
			get { return departureTime; }
			set { departureTime = value; }
		}

		public DateTime ArrivalTime
		{
			get { return arrivalTime; }
			set { arrivalTime = value; }
		}

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

		public int Price
		{
			get { return price; }
			set { price = value; }
		}
	}
}

