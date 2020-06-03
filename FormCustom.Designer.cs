namespace PetShop
{
    partial class FormCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustom));
            this.listViewCustom = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdWorker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOWorker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewCustom
            // 
            this.listViewCustom.BackColor = System.Drawing.Color.BurlyWood;
            this.listViewCustom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCustom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IdClient,
            this.FIOClient,
            this.IdWorker,
            this.FIOWorker,
            this.Product,
            this.Number,
            this.Data});
            this.listViewCustom.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewCustom.FullRowSelect = true;
            this.listViewCustom.GridLines = true;
            this.listViewCustom.HideSelection = false;
            this.listViewCustom.Location = new System.Drawing.Point(311, 13);
            this.listViewCustom.MultiSelect = false;
            this.listViewCustom.Name = "listViewCustom";
            this.listViewCustom.Size = new System.Drawing.Size(669, 191);
            this.listViewCustom.TabIndex = 0;
            this.listViewCustom.UseCompatibleStateImageBehavior = false;
            this.listViewCustom.View = System.Windows.Forms.View.Details;
            this.listViewCustom.SelectedIndexChanged += new System.EventHandler(this.ListViewCustom_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // IdClient
            // 
            this.IdClient.Text = "Id Клиента";
            this.IdClient.Width = 79;
            // 
            // FIOClient
            // 
            this.FIOClient.Text = "ФИО Клиета";
            this.FIOClient.Width = 199;
            // 
            // IdWorker
            // 
            this.IdWorker.Text = "Id Сотрудника";
            this.IdWorker.Width = 98;
            // 
            // FIOWorker
            // 
            this.FIOWorker.Text = "ФИО Сотрудника";
            this.FIOWorker.Width = 200;
            // 
            // Product
            // 
            this.Product.Text = "Товар";
            this.Product.Width = 202;
            // 
            // Number
            // 
            this.Number.Text = "Кол-во";
            this.Number.Width = 58;
            // 
            // Data
            // 
            this.Data.Text = "Дата оформления";
            this.Data.Width = 123;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(413, 233);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 55);
            this.buttonAdd.TabIndex = 1;
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
            this.buttonEdit.Location = new System.Drawing.Point(591, 233);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 55);
            this.buttonEdit.TabIndex = 2;
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
            this.buttonDel.Location = new System.Drawing.Point(769, 233);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 55);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.BackColor = System.Drawing.Color.Transparent;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelClient.Location = new System.Drawing.Point(12, 25);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(62, 19);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Клиент";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.BackColor = System.Drawing.Color.Transparent;
            this.labelWorker.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelWorker.Location = new System.Drawing.Point(12, 93);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(88, 19);
            this.labelWorker.TabIndex = 5;
            this.labelWorker.Text = "Сотрудник";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelProduct.Location = new System.Drawing.Point(12, 161);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(54, 19);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Товар";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelNumber.Location = new System.Drawing.Point(12, 229);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(97, 19);
            this.labelNumber.TabIndex = 7;
            this.labelNumber.Text = "Количество";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelData.Location = new System.Drawing.Point(12, 289);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(201, 19);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Дата оформления заказа";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxNumber.Location = new System.Drawing.Point(16, 251);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxNumber.Multiline = true;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(180, 23);
            this.textBoxNumber.TabIndex = 9;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.TextBoxNumber_TextChanged);
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.maskedTextBoxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxData.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.maskedTextBoxData.Location = new System.Drawing.Point(16, 311);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.maskedTextBoxData.Mask = "00/00/0000 90:00";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(197, 23);
            this.maskedTextBoxData.TabIndex = 10;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxClient.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClient.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(16, 47);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(282, 31);
            this.comboBoxClient.TabIndex = 11;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxWorker.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWorker.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(16, 115);
            this.comboBoxWorker.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(282, 31);
            this.comboBoxWorker.TabIndex = 12;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxProduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(16, 183);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(282, 31);
            this.comboBoxProduct.TabIndex = 13;
            // 
            // FormCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_31;
            this.ClientSize = new System.Drawing.Size(992, 350);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCustom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.FormCustom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCustom;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader IdClient;
        private System.Windows.Forms.ColumnHeader FIOClient;
        private System.Windows.Forms.ColumnHeader IdWorker;
        private System.Windows.Forms.ColumnHeader FIOWorker;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.ComboBox comboBoxProduct;
    }
}