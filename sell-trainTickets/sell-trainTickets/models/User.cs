using System;

namespace sellTrainTickets.Models
{
	public class User
	{
		private string fullName;
		private string email;
		private string password;
		private bool isAdmin;
		private bool isSuperAdmin;

		public User()
		{
		}

		public User(string fullName, string email, string password)
		{
			this.fullName = fullName;
			this.email = email;
			this.password = password;
			this.isAdmin = false;
			this.isSuperAdmin = false;
		}

		public User(string fullName, string email, string password, bool isAdmin, bool isSuperAdmin)
		{
			this.fullName = fullName;
			this.email = email;
			this.password = password;
			this.isAdmin = isAdmin;
			this.isSuperAdmin = isSuperAdmin;
		}

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		
		public bool IsAdmin
		{
			get { return isAdmin; }
			set { isAdmin = value; }
		}

		public bool IsSuperAdmin
		{
			get { return isSuperAdmin; }
			set { isSuperAdmin = value; }
		}
	}
}

