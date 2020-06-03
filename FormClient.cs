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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClientSet clientSet = new ClientSet();
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;

                if (clientSet.FirstName == "" || clientSet.MiddleName == "" || clientSet.LastName == "")
                {
                    throw new Exception("Поля ФИО обязательно должны быть заполнены!");
                }
               
                Program.psDb.ClientSet.Add(clientSet);
                Program.psDb.SaveChanges();
                ShowClient();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientSet in Program.psDb.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientSet.Id.ToString(), clientSet.FirstName, clientSet.MiddleName, clientSet.LastName,
                    clientSet.Phone, clientSet.Email
                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                Program.psDb.SaveChanges();
                ShowClient();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.psDb.ClientSet.Remove(clientSet);
                    Program.psDb.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }
    }
}
