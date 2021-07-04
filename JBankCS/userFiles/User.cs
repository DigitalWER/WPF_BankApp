using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBankCS
{
    class User
    {
		private static int _userIdCounter = 0;

		private int _id;
		private String _firstName;
		private String _lastName;
		private int _phoneNumber;
		private String _email;
		private String _username;
		private String _password;

		public User(String firstName, String lastName, int phoneNumber, String email, String username, String password)
		{
			this._id = ++_userIdCounter;
			this._firstName = firstName;
			this._lastName = lastName;
			this._phoneNumber = phoneNumber;
			this._email = email;
			this._username = username;
			this._password = password;
		}

		public String getFirstName()
		{
			return this._firstName;
		}

		public String getLastName()
		{
			return this._lastName;
		}

		public int getPhoneNumber()
        {
			return this._phoneNumber;
        }

		public String getEmail()
		{
			return this._email;
		}

		public String getUsername()
		{
			return this._username;
		}

		public String getPassword()
		{
			return this._password;
		}

		public int getId()
		{
			return this._id;
		}

		public void setFirstName(String firstName)
        {
			if (firstName == null)
			{
				return;
			}
			this._firstName = firstName;
		}

		public void setLastName(String lastName)
		{
			if (lastName == null)
			{
				return;
			}
			this._lastName = lastName;
		}

		public void setPhoneNumber(String phoneNumber)
		{
			if (int.TryParse(phoneNumber,out int number) && phoneNumber.Length == 9)
			{
				this._phoneNumber = number;
			}
            else
            {
				return;
            }
		}

		public void setEmail(String newEmail)
		{
			if (newEmail == null)
			{
				return;
			}
			this._email = newEmail;
		}

		public void setPassword(String password)
		{
			if (password == null)
			{
				return;
			}
			this._password = password;
		}

		

		

	}
}
