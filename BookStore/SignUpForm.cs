using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class SignUpForm : Form
    {
        List<UserDatabase> users;
        public SignUpForm()
        {
            InitializeComponent();
            this.users = new List<UserDatabase>();
        }

        static bool IsValidFirstName(string firstName)
        {
            string pattern = @"[A-Z][a-z]+";
            return Regex.IsMatch(firstName, pattern);
        }

        public static bool IsValidSurname(string surname)
        {
            string pattern = @"[A-Z][a-z]+";
            return Regex.IsMatch(surname, pattern);
        }

        public static bool IsValidLastName(string lastName)
        {
            string pattern = @"[A-Z][a-z]+";
            return Regex.IsMatch(lastName, pattern);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"[0]\d{9}";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static bool IsValidEGN(string egn)
        {
            string pattern = @"\d{10}";
            return Regex.IsMatch(egn, pattern);
        }
        static bool IsValidUsername(string username)
        {
            string usernamePattern = @"^[a-zA-Z0-9_-]+@[a-zA-Z0-9-]+\.[a-zA-Z]+";
            return Regex.IsMatch(username, usernamePattern);
        }

        static bool IsValidPassword(string password)
        {
            // Паролата трябва да бъде между 8 и 20 символа и да съдържа:
            // - поне една главна буква
            // - поне една малка буква
            // - поне една цифра
            // - поне един специален символ
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,20}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string egn = txtEGN.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isFirstNameValid = IsValidFirstName(firstName);
            bool isSurnameValid = IsValidSurname(surname);
            bool isLastNameValid = IsValidLastName(lastName);
            bool isPhoneNumberValid = IsValidPhoneNumber(phoneNumber);
            bool isEGNValid = IsValidEGN(egn);
            bool isUsernameValid = IsValidUsername(username);
            bool isPasswordValid = IsValidPassword(password);

            string message = "";

            if (!isFirstNameValid)
            {
                message += "Невалидно име.\n";
            }
            if (!isSurnameValid)
            {
                message += "Невалидно бащино име.\n";
            }
            if (!isLastNameValid)
            {
                message += "Невалидна фамилия.\n";
            }
            if (!isPhoneNumberValid)
            {
                message += "Невалиден телефонен номер.\n";
            }
            if (!isEGNValid)
            {
                message += "Невалидно ЕНГ.\n";
            }
            if (!isPasswordValid)
            {
                message += "Невалидна парола.\n";
            }
            if (!isUsernameValid)
            {
                message += "Невалидно потребителско име.\n";
            }
            message = "Всички данни са валидни.";
            UserDatabase userData = new UserDatabase(firstName, surname, lastName, egn, phoneNumber, username, password);
            string infoUsers = userData.Info();
            users.Add(userData);
            if (Regex.IsMatch(userData.Username, "^[a-zA-Z0-9_-]+@+stuff.com"))
            {
                using (StreamWriter writer = new StreamWriter("Employees.txt", true))
                {
                    writer.Write(infoUsers + "\n");
                }
            }
            else if (Regex.IsMatch(userData.Username, "^[a-zA-Z0-9_-]+@+adminStuff.com"))
            {
                using (StreamWriter writer = new StreamWriter("Admins.txt", true))
                {
                    writer.Write(infoUsers + "\n");
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("Users.txt", true))
                {
                    writer.Write(infoUsers + "\n");
                }
            }
            MessageBox.Show(message, "Валидация на данни", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForNewClientsUsers();
        }
        public void ClearForNewClientsUsers()
        {
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtLastName.Text = "";
            txtEGN.Text = "";
            txtPhoneNumber.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chBHideAndSeek_CheckedChanged(object sender, EventArgs e)
        {
            if (chBHideAndSeek.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
