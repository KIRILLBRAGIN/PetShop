namespace PetShop
{
    partial class FormStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStorage));
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelProvider = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewStorage
            // 
            this.listViewStorage.BackColor = System.Drawing.Color.BurlyWood;
            this.listViewStorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Provider1,
            this.Product1,
            this.Number1});
            this.listViewStorage.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewStorage.FullRowSelect = true;
            this.listViewStorage.GridLines = true;
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(382, 50);
            this.listViewStorage.MultiSelect = false;
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(431, 282);
            this.listViewStorage.TabIndex = 0;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            this.listViewStorage.View = System.Windows.Forms.View.Details;
            this.listViewStorage.SelectedIndexChanged += new System.EventHandler(this.ListViewStorage_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 30;
            // 
            // Provider1
            // 
            this.Provider1.Text = "Поставщик";
            this.Provider1.Width = 104;
            // 
            // Product1
            // 
            this.Product1.Text = "Товар";
            this.Product1.Width = 200;
            // 
            // Number1
            // 
            this.Number1.Text = "Количество";
            this.Number1.Width = 89;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(16, 187);
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
            this.buttonEdit.Location = new System.Drawing.Point(182, 187);
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
            this.buttonDel.Location = new System.Drawing.Point(99, 248);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 55);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.BackColor = System.Drawing.Color.Transparent;
            this.labelProvider.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelProvider.Location = new System.Drawing.Point(12, 28);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(93, 19);
            this.labelProvider.TabIndex = 4;
            this.labelProvider.Text = "Поставщик";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxProvider.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProvider.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(16, 50);
            this.comboBoxProvider.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(326, 31);
            this.comboBoxProvider.TabIndex = 5;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelProduct.Location = new System.Drawing.Point(12, 96);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(54, 19);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Товар";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.comboBoxProduct.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(16, 118);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(326, 31);
            this.comboBoxProduct.TabIndex = 7;
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_31;
            this.ClientSize = new System.Drawing.Size(824, 366);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewStorage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStorage;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ColumnHeader Provider1;
        private System.Windows.Forms.ColumnHeader Product1;
        private System.Windows.Forms.ColumnHeader Number1;
    }
}