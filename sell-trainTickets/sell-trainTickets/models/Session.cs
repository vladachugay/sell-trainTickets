using System;

namespace sellTrainTickets.Models
{
	public class Session
	{
		private int userId;
		private string ip;

		public Session()
		{
		}

		public Session(int userId, string ip)
		{
			this.userId = userId;
			this.ip = ip;
		}

		public int UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		public string Ip
		{
			get { return ip; }
			set { ip = value; }
		}
	}
}

