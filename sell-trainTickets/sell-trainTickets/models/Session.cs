using System;

namespace sellTrainTickets.Models
{
	public class Session
	{
		private string userEmail;
		private string Mac;

		public Session()
		{
		}

		public Session(string userEmail, string MAC)
		{
			this.userEmail = userEmail;
			this.Mac = MAC;
		}

		public string UserEmail
		{
			get { return userEmail; }
			set { userEmail = value; }
		}

		public string MAC
		{
			get { return Mac; }
			set { Mac = value; }
		}
	}
}

