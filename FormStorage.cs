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
    public partial class FormStorage : Form
    {
        public FormStorage()
        {
            InitializeComponent();
            ShowProvider();
            ShowProduct();
            ShowStorage();
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {

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

        void ShowProduct()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProductSet productSet in Program.psDb.ProductSet)
            {
                string[] item = { productSet.Id.ToString() + "." ,productSet.Product.ToString() + " ", productSet.Number.ToString() + " шт." };
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }

        void ShowStorage()
        {
            listViewStorage.Items.Clear();
            foreach (StorageSet storageSet in Program.psDb.StorageSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    storageSet.Id.ToString(),
                    storageSet.ProviderSet.NameCompany,
                    storageSet.ProductSet.Product,
                    storageSet.ProductSet.Number.ToString() + " шт."
                }) ;
                item.Tag = storageSet;
                listViewStorage.Items.Add(item);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProvider.SelectedItem != null && comboBoxProduct.SelectedItem != null)
            {
                StorageSet storageSet = new StorageSet();
                storageSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                storageSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                Program.psDb.StorageSet.Add(storageSet);
                Program.psDb.SaveChanges();
                ShowStorage();
            }

            else { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ListViewStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count == 1)
            {
                StorageSet storageSet = listViewStorage.SelectedItems[0].Tag as StorageSet;
                comboBoxProvider.Text = storageSet.IdProvider.ToString() + ". " + storageSet.ProviderSet.NameCompany;
                comboBoxProduct.Text = storageSet.IdProduct.ToString() + ". " + storageSet.ProductSet.Product;
            }
            else
            {
                comboBoxProvider.Text = "";
                comboBoxProduct.Text = "";
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count == 1)
            {
                StorageSet storageSet = listViewStorage.SelectedItems[0].Tag as StorageSet;
                storageSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                storageSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                Program.psDb.SaveChanges();
                ShowStorage();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStorage.SelectedItems.Count == 1)
                {
                    StorageSet storageSet = listViewStorage.SelectedItems[0].Tag as StorageSet;
                    Program.psDb.StorageSet.Remove(storageSet);
                    Program.psDb.SaveChanges();
                    ShowStorage();
                }
                comboBoxProvider.Text = "";
                comboBoxProduct.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

