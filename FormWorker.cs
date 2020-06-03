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
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
            ShowWorker();
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                WorkerSet workerSet = new WorkerSet();
                workerSet.FirstName = textBoxFirstName.Text;
                workerSet.MiddleName = textBoxMiddleName.Text;
                workerSet.LastName = textBoxLastName.Text;
                workerSet.Position = textBoxPosition.Text;
                workerSet.Phone = textBoxPhone.Text;
                workerSet.Email = textBoxEmail.Text;
                workerSet.WorkTime = maskedTextBoxWorkTime.Text;

                if (workerSet.FirstName == "" || workerSet.MiddleName == "" || workerSet.LastName == "")
                {
                    throw new Exception("Поля ФИО обязательно должны быть заполнены!");
                }
                if (workerSet.Position == "")
                {
                    throw new Exception("Укажите вашу должность!");
                }
                Program.psDb.WorkerSet.Add(workerSet);
                Program.psDb.SaveChanges();
                ShowWorker();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ShowWorker()
        {
            listViewWorker.Items.Clear();
            foreach (WorkerSet workerSet in Program.psDb.WorkerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    workerSet.Id.ToString(), workerSet.FirstName, workerSet.MiddleName, workerSet.LastName,
                    workerSet.Position, workerSet.Phone, workerSet.Email, workerSet.WorkTime
                });
                item.Tag = workerSet;
                listViewWorker.Items.Add(item);
            }
            listViewWorker.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewWorker.SelectedItems.Count == 1)
            {
                WorkerSet workerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                workerSet.FirstName = textBoxFirstName.Text;
                workerSet.MiddleName = textBoxMiddleName.Text;
                workerSet.LastName = textBoxLastName.Text;
                workerSet.Position = textBoxPosition.Text;
                workerSet.Phone = textBoxPhone.Text;
                workerSet.Email = textBoxEmail.Text;
                workerSet.WorkTime = maskedTextBoxWorkTime.Text;
                Program.psDb.SaveChanges();
                ShowWorker();
            }


        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewWorker.SelectedItems.Count == 1)
                {
                    WorkerSet workerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                    Program.psDb.WorkerSet.Remove(workerSet);
                    Program.psDb.SaveChanges();
                    ShowWorker();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPosition.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                maskedTextBoxWorkTime.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorker.SelectedItems.Count == 1)
            {
                WorkerSet workerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                textBoxFirstName.Text = workerSet.FirstName;
                textBoxMiddleName.Text = workerSet.MiddleName;
                textBoxLastName.Text = workerSet.LastName;
                textBoxPosition.Text = workerSet.Position;
                textBoxPhone.Text = workerSet.Phone;
                textBoxEmail.Text = workerSet.Email;
                maskedTextBoxWorkTime.Text = workerSet.WorkTime;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPosition.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                maskedTextBoxWorkTime.Text = "";
            }
        }
    }
}
