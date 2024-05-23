namespace ContactsAppUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindContactTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteContactPicture = new System.Windows.Forms.PictureBox();
            this.EditContactPicture = new System.Windows.Forms.PictureBox();
            this.AddContactPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addContactToolStripMenuItem.Text = "Add contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.AddContactPicture_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editContactToolStripMenuItem.Text = "Edit contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactPicture_Click);
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeContactToolStripMenuItem.Text = "Remove contact";
            this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.DeleteContactPicture_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteContactPicture);
            this.panel1.Controls.Add(this.EditContactPicture);
            this.panel1.Controls.Add(this.AddContactPicture);
            this.panel1.Controls.Add(this.ContactsListBox);
            this.panel1.Controls.Add(this.FindContactTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 352);
            this.panel1.TabIndex = 4;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(2, 48);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(191, 238);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // FindContactTextBox
            // 
            this.FindContactTextBox.Location = new System.Drawing.Point(86, 12);
            this.FindContactTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindContactTextBox.Name = "FindContactTextBox";
            this.FindContactTextBox.Size = new System.Drawing.Size(76, 20);
            this.FindContactTextBox.TabIndex = 1;
            this.FindContactTextBox.TextChanged += new System.EventHandler(this.FindContactTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BirthdayDateTime);
            this.panel2.Controls.Add(this.VkTextBox);
            this.panel2.Controls.Add(this.EmailTextBox);
            this.panel2.Controls.Add(this.PhoneTextBox);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.SurnameTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(208, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 340);
            this.panel2.TabIndex = 5;
            // 
            // BirthdayDateTime
            // 
            this.BirthdayDateTime.Location = new System.Drawing.Point(91, 103);
            this.BirthdayDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthdayDateTime.Name = "BirthdayDateTime";
            this.BirthdayDateTime.Size = new System.Drawing.Size(163, 20);
            this.BirthdayDateTime.TabIndex = 11;
            this.BirthdayDateTime.ValueChanged += new System.EventHandler(this.BirthdayDateTime_ValueChanged);
            // 
            // VkTextBox
            // 
            this.VkTextBox.Location = new System.Drawing.Point(88, 252);
            this.VkTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.ReadOnly = true;
            this.VkTextBox.Size = new System.Drawing.Size(277, 20);
            this.VkTextBox.TabIndex = 10;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(91, 201);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(274, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(91, 150);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(274, 20);
            this.PhoneTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(91, 53);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(274, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(91, 15);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(274, 20);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "vk.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // DeleteContactPicture
            // 
            this.DeleteContactPicture.Image = global::ContactsAppUI.Properties.Resources.DeleteContactIcon_512x512;
            this.DeleteContactPicture.Location = new System.Drawing.Point(104, 289);
            this.DeleteContactPicture.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteContactPicture.Name = "DeleteContactPicture";
            this.DeleteContactPicture.Size = new System.Drawing.Size(46, 41);
            this.DeleteContactPicture.TabIndex = 5;
            this.DeleteContactPicture.TabStop = false;
            this.DeleteContactPicture.Click += new System.EventHandler(this.DeleteContactPicture_Click);
            // 
            // EditContactPicture
            // 
            this.EditContactPicture.Image = global::ContactsAppUI.Properties.Resources.EditContactIcon_512x512;
            this.EditContactPicture.Location = new System.Drawing.Point(54, 289);
            this.EditContactPicture.Margin = new System.Windows.Forms.Padding(2);
            this.EditContactPicture.Name = "EditContactPicture";
            this.EditContactPicture.Size = new System.Drawing.Size(45, 41);
            this.EditContactPicture.TabIndex = 4;
            this.EditContactPicture.TabStop = false;
            this.EditContactPicture.Click += new System.EventHandler(this.EditContactPicture_Click);
            // 
            // AddContactPicture
            // 
            this.AddContactPicture.Image = global::ContactsAppUI.Properties.Resources.AddContactIcon_512x512;
            this.AddContactPicture.Location = new System.Drawing.Point(5, 289);
            this.AddContactPicture.Margin = new System.Windows.Forms.Padding(2);
            this.AddContactPicture.Name = "AddContactPicture";
            this.AddContactPicture.Size = new System.Drawing.Size(44, 41);
            this.AddContactPicture.TabIndex = 3;
            this.AddContactPicture.TabStop = false;
            this.AddContactPicture.Click += new System.EventHandler(this.AddContactPicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox DeleteContactPicture;
        private System.Windows.Forms.PictureBox EditContactPicture;
        private System.Windows.Forms.PictureBox AddContactPicture;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox FindContactTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker BirthdayDateTime;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

