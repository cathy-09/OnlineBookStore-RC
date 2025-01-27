using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class CartForm : Form
    {
        private List<string> selectedBooks;
        private List<string> selectedAuthors;
        private List<string> infoUser;
        private List<decimal> listPriceBooks;
        public CartForm(List<string> selectedBooks, List<string> listAuthorBooks, List<decimal> listPriceBooks, List<string> infoUser)
        {
            InitializeComponent();
            this.selectedBooks = selectedBooks;
            this.selectedAuthors = listAuthorBooks;
            this.listPriceBooks = listPriceBooks;
            this.infoUser = infoUser;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            string email = "Няма имейл";
            if (lBDetailsUser.Items.Count > 0)
            {
                string lastUserInfo = lBDetailsUser.Items[lBDetailsUser.Items.Count - 1].ToString();
                string[] userDetails = lastUserInfo.Split(' ');
                if (userDetails.Length > 3)
                {
                    email = userDetails[3];
                }
            }
            List<string> combinedBooksAndAuthors = new List<string>();
            foreach (var item in lBOrder.Items)
            {
                combinedBooksAndAuthors.Add(item.ToString());
            }
            decimal totalPrice = 0;
            if (decimal.TryParse(txtPrice.Text, out totalPrice))
            {
                using (StreamWriter writer = new StreamWriter("OrderDetails.txt", true))
                {
                    writer.Write($"{email} "); 
                    foreach (var bookInfo in combinedBooksAndAuthors)
                    {
                        writer.Write($"{bookInfo} ");
                    }
                    writer.WriteLine($"{totalPrice:f2}");
                }
                MessageBox.Show("Поръчката беше успешно записана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Невалидна обща цена!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CombineBooksAndAuthors()
        {
            if (selectedBooks == null || selectedAuthors == null)
            {
                MessageBox.Show("Списъците не са инициализирани правилно!");
                return;
            }
            decimal totalPrice = 0;
            Dictionary<string, List<string>> bookAuthorMap = new Dictionary<string, List<string>>();
            Dictionary<string, decimal> bookTotalPriceMap = new Dictionary<string, decimal>();
            for (int i = 0; i < selectedBooks.Count; i++)
            {
                string book = selectedBooks[i];
                string author = selectedAuthors[i];
                decimal price = listPriceBooks[i];
                string key = $"{book} - {author}";

                if (bookAuthorMap.ContainsKey(key))
                {
                    bookAuthorMap[key].Add(book);
                    bookTotalPriceMap[key] += price;
                }
                else
                {
                    bookAuthorMap[key] = new List<string> { book };
                    bookTotalPriceMap[key] = price;
                }
            }
            foreach (var item in bookAuthorMap)
            {
                string combinedLine = $"{item.Key}";
                lBOrder.Items.Add(combinedLine);
            }
            totalPrice = bookTotalPriceMap.Values.Sum();
            txtPrice.Text = totalPrice.ToString("f2");
        }

        private void CombineUserInfo()
        {
            if (infoUser == null || infoUser.Count == 0)
            {
                MessageBox.Show("Информацията за потребителя не е налична!");
                return;
            }
            foreach (var userInfo in infoUser)
            {
                lBDetailsUser.Items.Add(userInfo);
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            CombineBooksAndAuthors();
            CombineUserInfo();
        }
    }
}
