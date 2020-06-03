using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ShowProduct();
            ShowProvider();
            ShowProducts();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        void ShowProduct()
        {
            listViewProduct.Items.Clear();
            foreach (ProductSet productSet in Program.psDb.ProductSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    productSet.Id.ToString(),
                    productSet.IdProvider.ToString(),
                    productSet.Provider,
                    productSet.Product,
                    productSet.Number.ToString() + " шт.",
                   productSet.Price.ToString(),

                });
                item.Tag = productSet;
                listViewProduct.Items.Add(item);
            }
        }

        void ShowProvider()
        {
            comboBoxProvider.Items.Clear();
            foreach (ProviderSet providerSet in Program.psDb.ProviderSet)
            {
                string[] item = { providerSet.Id.ToString() + ".", providerSet.NameCompany.ToString() };
                comboBoxProvider.Items.Add(string.Join(" ", item));
            }
        }

        void ShowProducts()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProviderSet providerSet in Program.psDb.ProviderSet)
            {
                string[] item = { providerSet.TypeProduct.ToString() + ": ", providerSet.Product.ToString() };
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProvider.SelectedItem != null && comboBoxProduct.SelectedItem != null )
            {
                ProductSet productSet = new ProductSet();
                productSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                productSet.Provider = comboBoxProvider.SelectedItem.ToString().Split('.')[1];
                productSet.Product = comboBoxProduct.Text;

                if (textBoxNumber.Text != "")
                { productSet.Number = Convert.ToInt32(textBoxNumber.Text); }

                if (textBoxPrice.Text != "")
                { productSet.Price = Convert.ToInt32(textBoxPrice.Text); }

                Program.psDb.ProductSet.Add(productSet);
                Program.psDb.SaveChanges();
                ShowProduct();
            }

            else { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProduct.SelectedItems[0].Tag as ProductSet;
                productSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                productSet.Provider = comboBoxProvider.SelectedItem.ToString().Split('.')[1];
                productSet.Product = comboBoxProduct.Text;
                if (textBoxNumber.Text != "")
                { productSet.Number = Convert.ToInt32(textBoxNumber.Text); }

                if (textBoxPrice.Text != "")
                { productSet.Price = Convert.ToInt32(textBoxPrice.Text); }

                Program.psDb.SaveChanges();
                ShowProduct();
            }
        }

        private void ListViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProduct.SelectedItems[0].Tag as ProductSet;
                comboBoxProvider.Text = productSet.IdProvider.ToString() + "." + productSet.Provider;
                comboBoxProduct.Text = productSet.Product;
                textBoxNumber.Text = productSet.Number.ToString();
                textBoxPrice.Text = productSet.Price.ToString();
            }
            else
            {
                comboBoxProvider.Text = "";
                comboBoxProduct.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewProduct.SelectedItems[0].Tag as ProductSet;
                    Program.psDb.ProductSet.Remove(productSet);
                    Program.psDb.SaveChanges();
                    ShowProduct();
                }
                comboBoxProvider.Text = "";
                comboBoxProduct.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
