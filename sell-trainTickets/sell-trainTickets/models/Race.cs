using System;
using System.Collections.Generic;


namespace sellTrainTickets.Models
{
	public class Race
	{
		private int id;
		private string name;
		private List<string> stations;
		private List<DateTime> arrivalTime;
		private List<DateTime> departureTime;
		private int numOfSeats;

		public Race()
		{
		}

		public Race(int id, string name, List<string> stations, List<DateTime> arrivalTime, List<DateTime> departureTime, int numOfSeats)
		{
			this.id = id;
			this.name = name;
			this.stations = stations;
			this.arrivalTime = arrivalTime;
			this.departureTime = departureTime;
			this.numOfSeats = numOfSeats;
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string name
		{
			get { return name; }
			set { name = value; }
		}

		public string name
		{
			get { return name; }
			set { name = value; }
		}

		public List<string> Stations
		{
			get { return stations; }
			set { stations = value; }
		}

		public List<DateTime> ArrivalTime
		{
			get { return arrivalTime; }
			set { arrivalTime = value; }
		}

		public List<DateTime> DepartureTime
		{
			get { return departureTime; }
			set { departureTime = value; }
		}

		public int NumOfSeats
		{
			get { return numOfSeats; }
			set { numOfSeats = value; }
		}
	}
}

