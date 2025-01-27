using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStore
{
    public partial class LoginForm : Form
    {
        List<UserDatabase> logIn;
        public LoginForm()
        {
            InitializeComponent();
            logIn = new List<UserDatabase>();
        }

        public string GetTextBoxText()
        {
            return txtEmail.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO:
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string textFromTextBox = GetTextBoxText();
            CheckLogin("Users.txt", new UserForm(textFromTextBox));
            CheckLogin("Employees.txt", new EmployeeForm(textFromTextBox));
            CheckLogin("Admins.txt", new AdminForm(textFromTextBox));
        }
        private void CheckLogin(string filePath, Form form)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        List<string> args = line.Split(' ').ToList();

                        if (args.Count > 6 && txtEmail.Text.Equals(args[5]) && txtPassword.Text.Equals(args[6]))
                        {
                            UserDatabase userData = new UserDatabase(args[5], args[6]);
                            logIn.Add(userData);

                            form.ShowDialog();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при четене на файла {filePath}: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.ShowDialog();
        }

        private void picBoxUIDesign_Click(object sender, EventArgs e)
        {
            //TODO:
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

