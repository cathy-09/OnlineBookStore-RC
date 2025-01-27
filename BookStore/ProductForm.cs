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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        private void LoadProductsFromFile(string filePath)
        {
            // Проверяваме дали файлът съществува
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файлът не съществува!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Прочитаме всички линии от файла
            string[] lines = File.ReadAllLines(filePath);

            // Изчистваме всички елементи в ListBox, за да избегнем дублиране
            lBProducts.Items.Clear();

            // Добавяме всеки ред от файла като елемент в ListBox
            foreach (var line in lines)
            {
                lBProducts.Items.Add(line.Trim());
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProductsFromFile("Products.txt");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string year = txtYear.Text.Trim();
            string genre = txtGenre.Text.Trim();
            string ISBN = txtISBN.Text.Trim();
            string publisher = txtPublisher.Text.Trim();
            string pageCount = txtPageCount.Text.Trim();
            string price = txtPrice.Text.Trim();
            string newBook = $"{bookTitle}-{author}-{year}-{genre}-{ISBN}-{publisher}-{pageCount}бр.-{price:F2}лв.";
            lBProducts.Items.Add(newBook);
            using (StreamWriter writer = new StreamWriter("Products.txt", true))
            {
                writer.WriteLine($"{bookTitle}-{author}-{year}-{genre}-{ISBN}-{publisher}-{pageCount}бр.-{price:F2}лв.");
            }
            ClearTextBoxes();
            MessageBox.Show("Книгата беше успешно добавена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearTextBoxes()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtGenre.Clear();
            txtPublisher.Clear();
            txtPageCount.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lBProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Моля, изберете книга от списъка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вземаме избрания елемент от ListBox
            string selectedProduct = lBProducts.SelectedItem.ToString();

            // Разделяме елемента на части
            string[] productDetails = selectedProduct.Split('-');

            // Зареждаме данните в TextBox-овете
            txtTitle.Text = productDetails[0].Trim();
            txtAuthor.Text = productDetails[1].Trim();
            txtYear.Text = productDetails[2].Trim();
            txtGenre.Text = productDetails[3].Trim();
            txtISBN.Text = productDetails[4].Trim();
            txtPublisher.Text = productDetails[5].Trim();
            txtPageCount.Text = productDetails[6].Trim();
            txtPrice.Text = productDetails[7].Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lBProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Моля, изберете книга от списъка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вземаме данните от текстовите полета
            string bookTitle = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string year = txtYear.Text.Trim();
            string genre = txtGenre.Text.Trim();
            string ISBN = txtISBN.Text.Trim();
            string publisher = txtPublisher.Text.Trim();
            string pageCount = txtPageCount.Text.Trim();
            string price = txtPrice.Text.Trim();

            // Форматираме новия ред
            string updatedBook = $"{bookTitle}-{author}-{year}-{genre}-{ISBN}-{publisher}-{pageCount}-{price:F2}";

            // Обновяваме елемента в ListBox
            lBProducts.Items[lBProducts.SelectedIndex] = updatedBook;

            // Записваме всички книги обратно в файл
            using (StreamWriter writer = new StreamWriter("Products.txt", false))
            {
                foreach (var item in lBProducts.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            // Изчистваме текстовите полета
            ClearTextBoxes();

            MessageBox.Show("Информацията беше успешно актуализирана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lBProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Моля, изберете книга, която да изтриете!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вземаме избрания елемент от ListBox
            string selectedProduct = lBProducts.SelectedItem.ToString();

            // Премахваме избрания елемент от ListBox
            lBProducts.Items.RemoveAt(lBProducts.SelectedIndex);

            // Презаписваме файла, като премахваме избрания елемент
            using (StreamWriter writer = new StreamWriter("Products.txt", false))
            {
                foreach (var item in lBProducts.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Книгата беше успешно изтрита!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadOrderDetailsFromFile(string filePath)
        {
            // Проверяваме дали файлът съществува
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файлът не съществува!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Прочитаме всички линии от файла
            string[] lines = File.ReadAllLines(filePath);

            // Изчистваме всички елементи в ListBox, за да избегнем дублиране
            lBOrder.Items.Clear();

            // Добавяме всеки ред от файла като елемент в ListBox
            foreach (var line in lines)
            {
                lBOrder.Items.Add(line.Trim());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderDetailsFromFile("OrderDetails.txt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFulfill_Click(object sender, EventArgs e)
        {
            if (lBOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Моля, изберете книга, която да изтриете!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вземаме избрания елемент от ListBox
            string selectedProduct = lBOrder.SelectedItem.ToString();

            // Премахваме избрания елемент от ListBox
            lBOrder.Items.RemoveAt(lBOrder.SelectedIndex);

            // Презаписваме файла, като премахваме избрания елемент
            using (StreamWriter writer = new StreamWriter("OrderDetails.txt", false))
            {
                foreach (var item in lBOrder.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Книгата беше успешно изтрита!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
