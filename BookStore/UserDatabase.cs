using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class UserDatabase
    {
        private string firstName;
        private string surname;
        private string lastName;
        private string egn;
        private string phoneNumber;
        private string username;
        private string password;

        public UserDatabase()
        {

        }

        public UserDatabase(string username,
            string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public UserDatabase(string firstName,
            string surname,
            string lastName,
            string username)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            this.Username = username;
        }

        public UserDatabase(string firstName,
            string surname,
            string lastName,
            string egn,
            string phoneNumber,
            string username,
            string password)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            this.Egn = egn;
            this.PhoneNumber = phoneNumber;
            this.Username = username;
            this.Password = password;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Egn
        {
            get { return egn; }
            set { egn = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Info()
        {
            return $"{this.FirstName} {this.Surname} {this.LastName} {this.Egn} {this.PhoneNumber} {this.Username} {this.Password}";
        }

        public string InfoUser()
        {
            return $"{this.FirstName} {this.Surname} {this.LastName} {this.Username}";
        }

        public string InfoForAdmins()
        {
            return $"{this.Username} {this.Password}";
        }
    }
}
