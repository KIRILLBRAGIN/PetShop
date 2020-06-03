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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            if (Authorization.users.type == "worker")
            {
                buttonWorker.Enabled = false;
            }
            labelHello.Text = "Добро пожаловать, " + Authorization.users.login + "! ";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonWorker_Click(object sender, EventArgs e)
        {
            Form formWorker = new FormWorker();
            formWorker.Show();
        }

        private void ButtonClient_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void ButtonProvider_Click(object sender, EventArgs e)
        {
            Form formProvider = new FormProvider();
            formProvider.Show();
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            Form formProduct = new FormProduct();
            formProduct.Show();
        }

        private void ButtonStorage_Click(object sender, EventArgs e)
        {
            Form formStorage = new FormStorage();
            formStorage.Show();
        }

        private void ButtonCustom_Click(object sender, EventArgs e)
        {
            Form formCustom = new FormCustom();
            formCustom.Show();
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void ButtonClouse_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
