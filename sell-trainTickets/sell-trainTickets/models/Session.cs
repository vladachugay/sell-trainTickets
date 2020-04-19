using System;

namespace sellTrainTickets.Models
{
	public class Session
	{
		private string userEmail;
		private string ip;

		public Session()
		{
		}

		public Session(string userEmail, string ip)
		{
			this.userEmail = userEmail;
			this.ip = ip;
		}

		public string UserEmail
		{
			get { return userEmail; }
			set { userEmail = value; }
		}

		public string Ip
		{
			get { return ip; }
			set { ip = value; }
		}
	}
}

