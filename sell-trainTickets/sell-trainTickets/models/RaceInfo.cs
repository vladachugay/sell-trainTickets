using System;


namespace sellTrainTickets.Models
{
	public class RaceInfo
	{
		private DateTime date;
		private int raceId;
		private int numOfFreeSeats;

		public RaceInfo()
		{
		}

		public RaceInfo(DateTime date, int raceId, int numOfFreeSeats)
		{
			this.date = date;
			this.raceId = raceId;
			this.numOfFreeSeats = numOfFreeSeats;
		}

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		public int RaceId
		{
			get { return raceId; }
			set { raceId = value; }
		}

		public int NumOfFreeSeats
		{
			get { return numOfFreeSeats; }
			set { numOfFreeSeats = value; }
		}
	}
}

