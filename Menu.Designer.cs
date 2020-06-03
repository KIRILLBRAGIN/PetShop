namespace PetShop
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonWorker = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonProvider = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonStorage = new System.Windows.Forms.Button();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonClouse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorker.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonWorker.ForeColor = System.Drawing.Color.Black;
            this.buttonWorker.Location = new System.Drawing.Point(12, 43);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(170, 50);
            this.buttonWorker.TabIndex = 0;
            this.buttonWorker.Text = "Сотрудники";
            this.buttonWorker.UseVisualStyleBackColor = false;
            this.buttonWorker.Click += new System.EventHandler(this.ButtonWorker_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonClient.ForeColor = System.Drawing.Color.Black;
            this.buttonClient.Location = new System.Drawing.Point(188, 43);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(170, 50);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиенты";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.ButtonClient_Click);
            // 
            // buttonProvider
            // 
            this.buttonProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProvider.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonProvider.ForeColor = System.Drawing.Color.Black;
            this.buttonProvider.Location = new System.Drawing.Point(364, 43);
            this.buttonProvider.Name = "buttonProvider";
            this.buttonProvider.Size = new System.Drawing.Size(170, 50);
            this.buttonProvider.TabIndex = 2;
            this.buttonProvider.Text = "Поставщики";
            this.buttonProvider.UseVisualStyleBackColor = false;
            this.buttonProvider.Click += new System.EventHandler(this.ButtonProvider_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonProduct.Location = new System.Drawing.Point(12, 99);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(170, 50);
            this.buttonProduct.TabIndex = 3;
            this.buttonProduct.Text = "Товар";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // buttonStorage
            // 
            this.buttonStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStorage.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonStorage.ForeColor = System.Drawing.Color.Black;
            this.buttonStorage.Location = new System.Drawing.Point(188, 99);
            this.buttonStorage.Name = "buttonStorage";
            this.buttonStorage.Size = new System.Drawing.Size(170, 50);
            this.buttonStorage.TabIndex = 5;
            this.buttonStorage.Text = "Склад";
            this.buttonStorage.UseVisualStyleBackColor = false;
            this.buttonStorage.Click += new System.EventHandler(this.ButtonStorage_Click);
            // 
            // buttonCustom
            // 
            this.buttonCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom.Font = new System.Drawing.Font("Roboto", 16F);
            this.buttonCustom.ForeColor = System.Drawing.Color.Black;
            this.buttonCustom.Location = new System.Drawing.Point(12, 155);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(346, 50);
            this.buttonCustom.TabIndex = 6;
            this.buttonCustom.Text = "Оформление заказа";
            this.buttonCustom.UseVisualStyleBackColor = false;
            this.buttonCustom.Click += new System.EventHandler(this.ButtonCustom_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Roboto Black", 18F);
            this.labelHello.ForeColor = System.Drawing.Color.Black;
            this.labelHello.Location = new System.Drawing.Point(12, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 29);
            this.labelHello.TabIndex = 7;
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonUser.ForeColor = System.Drawing.Color.Black;
            this.buttonUser.Location = new System.Drawing.Point(248, 211);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(200, 30);
            this.buttonUser.TabIndex = 8;
            this.buttonUser.Text = "Сменить пользователя";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.ButtonUser_Click);
            // 
            // buttonClouse
            // 
            this.buttonClouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(199)))));
            this.buttonClouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClouse.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonClouse.ForeColor = System.Drawing.Color.Black;
            this.buttonClouse.Location = new System.Drawing.Point(454, 211);
            this.buttonClouse.Name = "buttonClouse";
            this.buttonClouse.Size = new System.Drawing.Size(80, 30);
            this.buttonClouse.TabIndex = 9;
            this.buttonClouse.Text = "Выйти";
            this.buttonClouse.UseVisualStyleBackColor = false;
            this.buttonClouse.Click += new System.EventHandler(this.ButtonClouse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_3;
            this.pictureBox1.Image = global::PetShop.Properties.Resources._123_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(361, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetShop.Properties.Resources.Без_имени_3;
            this.ClientSize = new System.Drawing.Size(544, 251);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClouse);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonCustom);
            this.Controls.Add(this.buttonStorage);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonProvider);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonWorker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonProvider;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonStorage;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonClouse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

