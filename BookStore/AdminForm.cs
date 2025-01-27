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
    public partial class AdminForm : Form
    {
        public AdminForm(string labelTextStuffAdmin)
        {
            InitializeComponent();
            linkLabelUserInfo.Text = labelTextStuffAdmin;
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(linkLabelUserInfo.Text);
            userForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAppoint_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void btnFired_Click(object sender, EventArgs e)
        {
            ListBox selectedListBox = null;
            string filePath = string.Empty;
            string username = string.Empty;
            if (lBUsers.SelectedItem != null)
            {
                selectedListBox = lBUsers;
                filePath = "Users.txt";
            }
            else if (lBEmployees.SelectedItem != null)
            {
                selectedListBox = lBEmployees;
                filePath = "Employees.txt";
            }
            else
            {
                MessageBox.Show("Моля, изберете потребител или служител.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            username = selectedListBox.SelectedItem.ToString();
            DialogResult confirmResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете потребителя?", "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            List<string> lines = File.ReadAllLines(filePath).ToList();
            lines.RemoveAll(line => line.Contains(username));
            File.WriteAllLines(filePath, lines);
            selectedListBox.Items.Remove(selectedListBox.SelectedItem);
            MessageBox.Show("Потребителят е успешно изтрит.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lBUsers.Items.Clear();
            lBEmployees.Items.Clear();
            lBAdmins.Items.Clear();
            if (File.Exists("Users.txt"))
            {
                string[] users = File.ReadAllLines("Users.txt");
                foreach (var user in users)
                {
                    lBUsers.Items.Add(user);
                }
            }
            else
            {
                MessageBox.Show("Файлът Users.txt не съществува.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.Exists("Employees.txt"))
            {
                string[] employees = File.ReadAllLines("Employees.txt");
                foreach (var employee in employees)
                {
                    lBEmployees.Items.Add(employee);
                }
            }
            else
            {
                MessageBox.Show("Файлът Employees.txt не съществува.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.Exists("Admins.txt"))
            {
                string[] admins = File.ReadAllLines("Admins.txt");
                foreach (var admin in admins)
                {
                    lBAdmins.Items.Add(admin);
                }
            }
            else
            {
                MessageBox.Show("Файлът Admins.txt не съществува.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Информацията е успешно заредена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearControls()
        {
            txtFirstName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEGN.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (lBUsers.SelectedItem != null)
            {
                string selectedUser = lBUsers.SelectedItem.ToString();
                string[] userDetails = selectedUser.Split(' ');
                txtFirstName.Text = userDetails[0];
                txtSurname.Text = userDetails[1];
                txtLastName.Text = userDetails[2];
                txtEGN.Text = userDetails[3];
                txtPhoneNumber.Text = userDetails[4];
                txtUsername.Text = userDetails[5];
                txtPassword.Text = userDetails[6];
            }
            else
            {
                MessageBox.Show("Моля, изберете потребител от списъка.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (lBUsers.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете потребител за редактиране.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string lastName = txtLastName.Text;
            string egn = txtEGN.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(egn) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Моля, попълнете всички полета.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string oldUser = lBUsers.SelectedItem.ToString();
            lBUsers.Items.Remove(oldUser);
            string targetFile = "Users.txt";
            try
            {
                if (Regex.IsMatch(username, "^[a-zA-Z0-9._%+-]+@stuff.com$"))
                {
                    lBEmployees.Items.Add($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                    targetFile = "Employees.txt";
                }
                else
                {
                    lBUsers.Items.Add($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                }
                List<string> userLines = File.ReadAllLines("Users.txt").ToList();
                userLines.Remove(oldUser);
                File.WriteAllLines("Users.txt", userLines);
                using (var fs = new FileStream(targetFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                using (var writer = new StreamWriter(fs, Encoding.Default))
                {
                    writer.WriteLine($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                }
                MessageBox.Show("Данните са успешно актуализирани.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Грешка при запис в файл: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (lBEmployees.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете служител за редактиране.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedEmployee = lBEmployees.SelectedItem.ToString();
            string[] parts = selectedEmployee.Split(' ');
            if (parts.Length < 7)
            {
                MessageBox.Show("Невалиден формат на избрания служител.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtFirstName.Text = parts[0];
            txtSurname.Text = parts[1];
            txtLastName.Text = parts[2];
            txtEGN.Text = parts[3];
            txtPhoneNumber.Text = parts[4];
            txtUsername.Text = parts[5];
            txtPassword.Text = parts[6];
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (lBEmployees.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете служител за редактиране.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string lastName = txtLastName.Text;
            string egn = txtEGN.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(egn) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Моля, попълнете всички полета.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string oldEmployee = lBEmployees.SelectedItem.ToString();
            lBEmployees.Items.Remove(oldEmployee);
            string filePath = "Employees.txt";
            if (Regex.IsMatch(username, @"^[a-zA-Z0-9_-]+@adminStuff.com$"))
            {
                lBAdmins.Items.Add($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                filePath = "Admins.txt";
            }
            else if (Regex.IsMatch(username, @"^[a-zA-Z0-9_-]+@user.com$"))
            {
                lBUsers.Items.Add($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                filePath = "Users.txt";
            }
            else
            {
                if (!username.Contains("stuff.com") && !username.Contains("adminStuff.com"))
                {
                    lBEmployees.Items.Remove(oldEmployee);
                    lBUsers.Items.Add($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                    filePath = "Users.txt";
                }
                else
                {
                    lBEmployees.Items.Add($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                }
            }
            try
            {
                List<string> lines = File.ReadAllLines("Employees.txt").ToList();
                lines.Remove(oldEmployee);
                File.WriteAllLines("Employees.txt", lines);
                using (var fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                using (var writer = new StreamWriter(fs, Encoding.Default))
                {
                    writer.WriteLine($"{firstName} {surname} {lastName} {egn} {phoneNumber} {username} {password}");
                }
                MessageBox.Show("Данните са успешно актуализирани.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Грешка при запис в файл: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
