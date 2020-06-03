namespace PetShop
{
    partial class FormWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelWorkTime = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewWorker = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxWorkTime = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(15, 19);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(41, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.labelMiddleName.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelMiddleName.Location = new System.Drawing.Point(15, 81);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(79, 19);
            this.labelMiddleName.TabIndex = 1;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelLastName.Location = new System.Drawing.Point(15, 143);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(78, 19);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelPosition.Location = new System.Drawing.Point(15, 205);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(94, 19);
            this.labelPosition.TabIndex = 3;
            this.labelPosition.Text = "Должность";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelPhone.Location = new System.Drawing.Point(15, 267);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 19);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Телефон";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelEmail.Location = new System.Drawing.Point(15, 329);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 19);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Почта";
            // 
            // labelWorkTime
            // 
            this.labelWorkTime.AutoSize = true;
            this.labelWorkTime.BackColor = System.Drawing.Color.Transparent;
            this.labelWorkTime.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.labelWorkTime.Location = new System.Drawing.Point(15, 391);
            this.labelWorkTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWorkTime.Name = "labelWorkTime";
            this.labelWorkTime.Size = new System.Drawing.Size(117, 19);
            this.labelWorkTime.TabIndex = 6;
            this.labelWorkTime.Text = "Время работы";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 18F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(272, 355);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 55);
            this.buttonAdd.TabIndex = 7;
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
            this.buttonEdit.Location = new System.Drawing.Point(453, 355);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 55);
            this.buttonEdit.TabIndex = 8;
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
            this.buttonDel.Location = new System.Drawing.Point(634, 355);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 55);
            this.buttonDel.TabIndex = 9;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // listViewWorker
            // 
            this.listViewWorker.BackColor = System.Drawing.Color.BurlyWood;
            this.listViewWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWorker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Position,
            this.Phone,
            this.Email,
            this.WorkTime});
            this.listViewWorker.Font = new System.Drawing.Font("Roboto Light", 10F);
            this.listViewWorker.FullRowSelect = true;
            this.listViewWorker.GridLines = true;
            this.listViewWorker.HideSelection = false;
            this.listViewWorker.Location = new System.Drawing.Point(222, 43);
            this.listViewWorker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listViewWorker.MultiSelect = false;
            this.listViewWorker.Name = "listViewWorker";
            this.listViewWorker.Size = new System.Drawing.Size(572, 271);
            this.listViewWorker.TabIndex = 10;
            this.listViewWorker.UseCompatibleStateImageBehavior = false;
            this.listViewWorker.View = System.Windows.Forms.View.Details;
            this.listViewWorker.SelectedIndexChanged += new System.EventHandler(this.ListViewWorker_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 26;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            this.FirstName.Width = 64;
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Отчество";
            this.MiddleName.Width = 74;
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 69;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 81;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 67;
            // 
            // Email
            // 
            this.Email.Text = "Почта";
            this.Email.Width = 73;
            // 
            // WorkTime
            // 
            this.WorkTime.Text = "Время работы";
            this.WorkTime.Width = 100;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(19, 43);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(180, 23);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMiddleName.Location = new System.Drawing.Point(19, 105);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.textBoxMiddleName.Multiline = true;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(180, 23);
            this.textBoxMiddleName.TabIndex = 12;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Location = new System.Drawing.Point(19, 167);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(180, 23);
            this.textBoxLastName.TabIndex = 13;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPosition.Location = new System.Drawing.Point(19, 229);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.textBoxPosition.Multiline = true;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(180, 23);
            this.textBoxPosition.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Location = new System.Drawing.Point(19, 291);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(180, 23);
            this.textBoxPhone.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Location = new System.Drawing.Point(19, 353);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 23);
            this.textBoxEmail.TabIndex = 16;
            // 
            // maskedTextBoxWorkTime
            // 
            this.maskedTextBoxWorkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.maskedTextBoxWorkTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxWorkTime.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.maskedTextBoxWorkTime.Location = new System.Drawing.Point(19, 415);
            this.maskedTextBoxWorkTime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 15);
            this.maskedTextBoxWorkTime.Mask = "00:00 - 00:00";
            this.maskedTextBoxWorkTime.Name = "maskedTextBoxWorkTime";
            this.maskedTextBoxWorkTime.Size = new System.Drawing.Size(180, 23);
            this.maskedTextBoxWorkTime.TabIndex = 18;
            this.maskedTextBoxWorkTime.ValidatingType = typeof(System.DateTime);
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_31;
            this.ClientSize = new System.Drawing.Size(809, 462);
            this.Controls.Add(this.maskedTextBoxWorkTime);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.listViewWorker);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelWorkTime);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelWorkTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewWorker;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader WorkTime;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWorkTime;
    }
}