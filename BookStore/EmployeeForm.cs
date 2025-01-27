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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(string labelTextStuff)
        {
            InitializeComponent();
            linkLabelUserInfo.Text = labelTextStuff;
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(linkLabelUserInfo.Text);
            userForm.ShowDialog();
        }
    }
}
