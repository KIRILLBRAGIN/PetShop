namespace PetShop
{
    partial class FormProvider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProvider));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.labelTypeProduct = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(421, 313);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 55);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(599, 313);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 55);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonDel.ForeColor = System.Drawing.Color.Black;
            this.buttonDel.Location = new System.Drawing.Point(777, 313);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 55);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // listViewProvider
            // 
            this.listViewProvider.BackColor = System.Drawing.Color.BurlyWood;
            this.listViewProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameCompany,
            this.TypeProduct,
            this.Product,
            this.Address,
            this.Phone,
            this.Email});
            this.listViewProvider.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewProvider.FullRowSelect = true;
            this.listViewProvider.GridLines = true;
            this.listViewProvider.HideSelection = false;
            this.listViewProvider.Location = new System.Drawing.Point(221, 48);
            this.listViewProvider.MultiSelect = false;
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(716, 211);
            this.listViewProvider.TabIndex = 3;
            this.listViewProvider.UseCompatibleStateImageBehavior = false;
            this.listViewProvider.View = System.Windows.Forms.View.Details;
            this.listViewProvider.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 26;
            // 
            // NameCompany
            // 
            this.NameCompany.Text = "Название компании";
            this.NameCompany.Width = 157;
            // 
            // TypeProduct
            // 
            this.TypeProduct.Text = "Тип товара";
            this.TypeProduct.Width = 123;
            // 
            // Product
            // 
            this.Product.Text = "Товар";
            this.Product.Width = 90;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.Width = 138;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 93;
            // 
            // Email
            // 
            this.Email.Text = "Почта";
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.BackColor = System.Drawing.Color.Transparent;
            this.labelNameCompany.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelNameCompany.Location = new System.Drawing.Point(12, 26);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(159, 19);
            this.labelNameCompany.TabIndex = 4;
            this.labelNameCompany.Text = "Название компании";
            // 
            // labelTypeProduct
            // 
            this.labelTypeProduct.AutoSize = true;
            this.labelTypeProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelTypeProduct.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelTypeProduct.Location = new System.Drawing.Point(12, 86);
            this.labelTypeProduct.Name = "labelTypeProduct";
            this.labelTypeProduct.Size = new System.Drawing.Size(93, 19);
            this.labelTypeProduct.TabIndex = 5;
            this.labelTypeProduct.Text = "Тип товара";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelProduct.Location = new System.Drawing.Point(12, 154);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(54, 19);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Товар";
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_City.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelAddress_City.Location = new System.Drawing.Point(12, 214);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(52, 19);
            this.labelAddress_City.TabIndex = 7;
            this.labelAddress_City.Text = "Город";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelAddress_Street.Location = new System.Drawing.Point(12, 274);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(54, 19);
            this.labelAddress_Street.TabIndex = 8;
            this.labelAddress_Street.Text = "Улица";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelAddress_House.Location = new System.Drawing.Point(12, 334);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(42, 19);
            this.labelAddress_House.TabIndex = 9;
            this.labelAddress_House.Text = "Дом";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelPhone.Location = new System.Drawing.Point(217, 274);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 19);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Телефон";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelEmail.Location = new System.Drawing.Point(217, 334);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 19);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Почта";
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxNameCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameCompany.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxNameCompany.Location = new System.Drawing.Point(16, 48);
            this.textBoxNameCompany.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxNameCompany.Multiline = true;
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(180, 23);
            this.textBoxNameCompany.TabIndex = 12;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProduct.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxProduct.Location = new System.Drawing.Point(16, 176);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxProduct.Multiline = true;
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(180, 23);
            this.textBoxProduct.TabIndex = 13;
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxTypeProduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxTypeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTypeProduct.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Items.AddRange(new object[] {
            "Товары для кошек",
            "Товары для собак",
            "Товары для грызунов",
            "Товары для птиц",
            "Товары для рептилий",
            "Товары для рыб"});
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(16, 108);
            this.comboBoxTypeProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(180, 31);
            this.comboBoxTypeProduct.TabIndex = 14;
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxAddress_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_City.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxAddress_City.Location = new System.Drawing.Point(16, 236);
            this.textBoxAddress_City.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxAddress_City.Multiline = true;
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(180, 23);
            this.textBoxAddress_City.TabIndex = 15;
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxAddress_Street.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_Street.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxAddress_Street.Location = new System.Drawing.Point(16, 296);
            this.textBoxAddress_Street.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxAddress_Street.Multiline = true;
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(180, 23);
            this.textBoxAddress_Street.TabIndex = 16;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxAddress_House.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress_House.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxAddress_House.Location = new System.Drawing.Point(16, 356);
            this.textBoxAddress_House.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxAddress_House.Multiline = true;
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(180, 23);
            this.textBoxAddress_House.TabIndex = 17;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxPhone.Location = new System.Drawing.Point(221, 296);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(180, 23);
            this.textBoxPhone.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxEmail.Location = new System.Drawing.Point(221, 356);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 23);
            this.textBoxEmail.TabIndex = 19;
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_31;
            this.ClientSize = new System.Drawing.Size(954, 411);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.comboBoxTypeProduct);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelTypeProduct);
            this.Controls.Add(this.labelNameCompany);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameCompany;
        private System.Windows.Forms.ColumnHeader TypeProduct;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.Label labelTypeProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxTypeProduct;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}