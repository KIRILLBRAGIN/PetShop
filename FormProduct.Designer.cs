namespace PetShop
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdProvider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.BackColor = System.Drawing.Color.BurlyWood;
            this.listViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IdProvider,
            this.Provider,
            this.Product1,
            this.Number1,
            this.Price1});
            this.listViewProduct.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(252, 48);
            this.listViewProduct.MultiSelect = false;
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(600, 159);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.ListViewProduct_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 33;
            // 
            // IdProvider
            // 
            this.IdProvider.Text = "Id поставщика";
            this.IdProvider.Width = 104;
            // 
            // Provider
            // 
            this.Provider.Text = "Название компании";
            this.Provider.Width = 139;
            // 
            // Product1
            // 
            this.Product1.Text = "Товар";
            this.Product1.Width = 177;
            // 
            // Number1
            // 
            this.Number1.Text = "Кол-во";
            this.Number1.Width = 77;
            // 
            // Price1
            // 
            this.Price1.Text = "Цена";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(336, 222);
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
            this.buttonEdit.Location = new System.Drawing.Point(514, 222);
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
            this.buttonDel.Location = new System.Drawing.Point(692, 222);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 55);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxProvider.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProvider.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(15, 48);
            this.comboBoxProvider.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(211, 31);
            this.comboBoxProvider.TabIndex = 4;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxNumber.Location = new System.Drawing.Point(15, 184);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxNumber.Multiline = true;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(180, 23);
            this.textBoxNumber.TabIndex = 6;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.TextBoxNumber_TextChanged);
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.textBoxPrice.Location = new System.Drawing.Point(15, 244);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(180, 23);
            this.textBoxPrice.TabIndex = 7;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.TextBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelProvider.Location = new System.Drawing.Point(12, 26);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(93, 19);
            this.labelProvider.TabIndex = 8;
            this.labelProvider.Text = "Поставщик";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelProduct.Location = new System.Drawing.Point(12, 94);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(54, 19);
            this.labelProduct.TabIndex = 9;
            this.labelProduct.Text = "Товар";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelNumber.Location = new System.Drawing.Point(12, 162);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(97, 19);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Количество";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelPrice.Location = new System.Drawing.Point(12, 222);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(46, 19);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Цена";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxProduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(15, 116);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(211, 31);
            this.comboBoxProduct.TabIndex = 12;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_31;
            this.ClientSize = new System.Drawing.Size(864, 301);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduct";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ColumnHeader IdProvider;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Product1;
        private System.Windows.Forms.ColumnHeader Number1;
        private System.Windows.Forms.ColumnHeader Price1;
    }
}