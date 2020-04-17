using System;

namespace sellTrainTickets.Models
{
	public class User
	{
		private int id;
		private string email;
		private string password;
		private string fullName;
		private bool isAdmin;
		private bool isSuperAdmin;

		public User()
		{
		}

		public User(int id, string email, string password, string fullName, bool isAdmin, bool isSuperAdmin)
		{
			this.id = id;
			this.email = email;
			this.password = password;
			this.fullName = fullName;
			this.isAdmin = isAdmin;
			this.isSuperAdmin = isSuperAdmin;
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
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

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
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

