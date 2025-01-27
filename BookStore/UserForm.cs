using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookStore
{
    public partial class UserForm : Form
    {
        public UserForm(string labelText)
        {
            InitializeComponent();
            linkLabelUserInfo.Text = labelText;
            LoadBooks("Products.txt");
        }
        private void LoadBooks(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файлът не съществува!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            chLBListBooks.Items.Clear();
            foreach (var line in lines)
            {
                chLBListBooks.Items.Add(line.Trim());
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            List<string> infoUser = new List<string>();
            string filePath = string.Empty;
            string username = linkLabelUserInfo.Text.Trim();
            if (Regex.IsMatch(username, "^[a-zA-Z0-9_-]+@stuff.com"))
            {
                filePath = "Employees.txt";
            }
            else if (Regex.IsMatch(username, "^[a-zA-Z0-9_-]+@adminStuff.com"))
            {
                filePath = "Admins.txt";
            }
            else
            {
                filePath = "Users.txt";
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файлът не съществува!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (StreamReader reader = new StreamReader(filePath, true))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    List<string> args = line.Split(' ').ToList();
                    if (username.Equals(args[5].Trim()))
                    {
                        UserDatabase userDatabase = new UserDatabase(args[0], args[1], args[2], args[5]);
                        string userDatabaseInfo = userDatabase.InfoUser();
                        infoUser.Add(userDatabaseInfo);
                        break;
                    }
                    line = reader.ReadLine();
                }
            }

            List<string> listTitleBooks = new List<string>();
            List<string> listAuthorBooks = new List<string>();
            List<decimal> listPriceBooks = new List<decimal>();

            if (chLBListBooks.CheckedItems.Count == 0)
            {
                MessageBox.Show("Моля, изберете книги преди да продължите.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string item in chLBListBooks.CheckedItems)
            {
                string[] bookInfo = item.Split('-');
                if (bookInfo.Length >= 3)
                {
                    string bookName = bookInfo[0].Trim();
                    string bookAuthor = bookInfo[1].Trim();
                    string priceStr = bookInfo.Length > 2 ? bookInfo[7].Trim() : string.Empty;
                    priceStr = priceStr.Replace("лв.", "").Trim();
                    if (decimal.TryParse(priceStr, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.GetCultureInfo("bg-BG"), out decimal price))
                    {
                        listTitleBooks.Add(bookName);
                        listAuthorBooks.Add(bookAuthor);
                        listPriceBooks.Add(price);
                    }
                    else
                    {
                        MessageBox.Show("Невалидна цена за книга: " + bookName, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неправилен формат на информацията за книга. Уверете се, че книгата съдържа име, автор и цена.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (listTitleBooks.Count == 0 || listAuthorBooks.Count == 0)
            {
                MessageBox.Show("Моля, изберете книги и автори преди да продължите.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            CartForm cartForm = new CartForm(listTitleBooks, listAuthorBooks, listPriceBooks, infoUser);
            cartForm.ShowDialog();
        }
    }
}
