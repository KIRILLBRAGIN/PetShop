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
    public partial class FormCustom : Form
    {
        public FormCustom()
        {
            InitializeComponent();
            ShowClient();
            ShowWorker();
            ShowProduct();
            ShowCustom();
        }

        private void FormCustom_Load(object sender, EventArgs e)
        {

        }

        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet clientSet in Program.psDb.ClientSet)
            {
                string[] item = { clientSet.Id.ToString() + ".", clientSet.LastName.ToString() , clientSet.FirstName.ToString() , clientSet.MiddleName.ToString() };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }

        void ShowWorker()
        {
            comboBoxWorker.Items.Clear();
            foreach (WorkerSet workerSet in Program.psDb.WorkerSet)
            {
                string[] item = { workerSet.Id.ToString() + ".", workerSet.LastName.ToString(), workerSet.FirstName.ToString(), workerSet.MiddleName.ToString() };
                comboBoxWorker.Items.Add(string.Join(" ", item));
            }
        }

        void ShowProduct()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProductSet productSet in Program.psDb.ProductSet)
            {
                string[] item = { productSet.Id.ToString() + ".", productSet.Product.ToString() };
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }

        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
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

        void ShowCustom()
        {
            listViewCustom.Items.Clear();
            foreach (CustomSet customSet in Program.psDb.CustomSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   customSet.Id.ToString(),
                   customSet.IdClient.ToString(),
                   customSet.ClientSet.LastName + " " + customSet.ClientSet.FirstName + " " + customSet.ClientSet.MiddleName,
                   customSet.IdWorker.ToString(),
                   customSet.WorkerSet.LastName + " " + customSet.WorkerSet.FirstName + " " + customSet.WorkerSet.MiddleName,
                   customSet.IdProduct.ToString() + "." + customSet.ProductSet.Product,
                   
                   customSet.Number.ToString(),
                   customSet.Data,
                });
                item.Tag = customSet;
                listViewCustom.Items.Add(item);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxWorker.SelectedItem != null && comboBoxProduct.SelectedItem != null)
            {
                CustomSet customSet = new CustomSet();
                customSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                customSet.IdWorker = Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split('.')[0]);
                customSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                if (textBoxNumber.Text != "")
                { customSet.Number = Convert.ToInt32(textBoxNumber.Text); }
                customSet.Data = maskedTextBoxData.Text;
               
                Program.psDb.CustomSet.Add(customSet);
                Program.psDb.SaveChanges();
                ShowCustom();
            }

            else { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ListViewCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustom.SelectedItems.Count == 1)
            {
                CustomSet customSet = listViewCustom.SelectedItems[0].Tag as CustomSet;
                comboBoxClient.Text = customSet.IdClient.ToString() + "." + customSet.ClientSet.LastName + " " 
                    + customSet.ClientSet.FirstName + " " + customSet.ClientSet.MiddleName;
                comboBoxWorker.Text = customSet.IdWorker.ToString() + "." + customSet.WorkerSet.LastName + " " 
                    + customSet.WorkerSet.FirstName + " " + customSet.WorkerSet.MiddleName;
                comboBoxProduct.Text = customSet.IdProduct.ToString() + "." + customSet.ProductSet.Product;
                textBoxNumber.Text = customSet.Number.ToString();
                maskedTextBoxData.Text = customSet.Data.ToString();
            }
            else
            {
                comboBoxClient.Text = "";
                comboBoxWorker.Text = "";
                comboBoxProduct.Text = "";
                textBoxNumber.Text = "";
                maskedTextBoxData.Text = "";
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCustom.SelectedItems.Count == 1)
            {
                CustomSet customSet = listViewCustom.SelectedItems[0].Tag as CustomSet;
                customSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                customSet.IdWorker = Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split('.')[0]);
                customSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                if (textBoxNumber.Text != "")
                { customSet.Number = Convert.ToInt32(textBoxNumber.Text); }
                customSet.Data = maskedTextBoxData.Text;
                Program.psDb.SaveChanges();
                ShowCustom();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustom.SelectedItems.Count == 1)
                {
                    CustomSet customSet = listViewCustom.SelectedItems[0].Tag as CustomSet;
                    Program.psDb.CustomSet.Remove(customSet);
                    Program.psDb.SaveChanges();
                    ShowProduct();
                }
                comboBoxClient.Text = "";
                comboBoxWorker.Text = "";
                comboBoxProduct.Text = "";
                textBoxNumber.Text = "";
                maskedTextBoxData.Text = "";
                ShowCustom();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
