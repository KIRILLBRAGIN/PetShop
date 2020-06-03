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
    public partial class FormProvider : Form
    {
        public FormProvider()
        {
            InitializeComponent();
            ShowProvider();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                textBoxNameCompany.Text = providerSet.NameCompany;
                comboBoxTypeProduct.Text = providerSet.TypeProduct;
                textBoxProduct.Text = providerSet.Product;
                textBoxAddress_City.Text = providerSet.Address_City;
                textBoxAddress_Street.Text = providerSet.Address_Street;
                textBoxAddress_House.Text = providerSet.Address_House;
                textBoxPhone.Text = providerSet.Phone;
                textBoxEmail.Text = providerSet.Email;
            }
            else
            {
                textBoxNameCompany.Text = "";
                comboBoxTypeProduct.Text = "";
                textBoxProduct.Text = "";
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        void ShowProvider()
        {
            listViewProvider.Items.Clear();
            foreach (ProviderSet providerSet in Program.psDb.ProviderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    providerSet.Id.ToString(), providerSet.NameCompany, providerSet.TypeProduct, providerSet.Product,
                   " г." + providerSet.Address_City + " ул." + providerSet.Address_Street + " д." + providerSet.Address_House,
                    providerSet.Phone, providerSet.Email
                });
                item.Tag = providerSet;
                listViewProvider.Items.Add(item);
            }
            listViewProvider.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProviderSet providerSet = new ProviderSet();
                providerSet.NameCompany = textBoxNameCompany.Text;
                providerSet.TypeProduct = comboBoxTypeProduct.Text;
                providerSet.Product = textBoxProduct.Text;
                providerSet.Address_City = textBoxAddress_City.Text;
                providerSet.Address_Street = textBoxAddress_Street.Text;
                providerSet.Address_House = textBoxAddress_House.Text;
                providerSet.Phone = textBoxPhone.Text;
                providerSet.Email = textBoxEmail.Text;

                if (providerSet.NameCompany == "")
                {
                    throw new Exception("Введите название компании!");
                }
                if (providerSet.TypeProduct == "")
                {
                    throw new Exception("Укажите тип товара!");
                }
                if (providerSet.Product == "")
                {
                    throw new Exception("Укажите название товара!");
                }
                if (providerSet.Address_City == "" || providerSet.Address_Street == "" || providerSet.Address_House == "")
                {
                    throw new Exception("Введите адрес!");
                }
                Program.psDb.ProviderSet.Add(providerSet);
                Program.psDb.SaveChanges();
                ShowProvider();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                providerSet.NameCompany = textBoxNameCompany.Text;
                providerSet.TypeProduct = comboBoxTypeProduct.Text;
                providerSet.Product = textBoxProduct.Text;
                providerSet.Address_City = textBoxAddress_City.Text;
                providerSet.Address_Street = textBoxAddress_Street.Text;
                providerSet.Address_House = textBoxAddress_House.Text;
                providerSet.Phone = textBoxPhone.Text;
                providerSet.Email = textBoxEmail.Text;
                Program.psDb.SaveChanges();
                ShowProvider();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                    Program.psDb.ProviderSet.Remove(providerSet);
                    Program.psDb.SaveChanges();
                    ShowProvider();
                }
                textBoxNameCompany.Text ="" ;
                comboBoxTypeProduct.Text = "";
                textBoxProduct.Text = "";
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
