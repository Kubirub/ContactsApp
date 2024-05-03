using ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AddEditContactForm : Form
    {
        /// <summary>
        /// Текущий контакт для редактирования/создания.
        /// </summary>
        public Contact CurrentContact { get; set; }
        public AddEditContactForm()
        {
            InitializeComponent();
            BirthdayDateTime.MaxDate = DateTime.Now;
            CurrentContact = TransferContact.Data;
            if (CurrentContact.Surname == null)
            {
                BlockCreateButton();
                СolorizeTextBoxes();
                CurrentContact.Birthday = BirthdayDateTime.Value;
            }
            else
            {
                UpdateContactInformation(CurrentContact);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlockCreateButton()
        {
            OkButton.Enabled = false;
        }

        /// <summary>
        /// Метод проверяет, можно ли разблокировать кнопку для принятия изменений.
        /// </summary>
        private void TryUnlockCreateButton()
        {
            if (CheckCorrectnessFields())
            {
                OkButton.Enabled = true;
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                SurnameTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                NameTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void BirthdayDateTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Birthday = BirthdayDateTime.Value;
                BirthdayDateTime.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                BirthdayDateTime.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.PhoneNumber.Phone = PhoneTextBox.Text;
                PhoneTextBox.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                PhoneTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                EmailTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.VkID = VkTextBox.Text;
                VkTextBox.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                VkTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void UpdateContactInformation(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            BirthdayDateTime.Value = contact.Birthday;
            PhoneTextBox.Text = contact.PhoneNumber.Phone;
            EmailTextBox.Text = contact.Email;
            VkTextBox.Text = contact.VkID;
        }

        /// <summary>
        /// Окрашивает пустые поля в красный цвет при создании нового контакта.
        /// </summary>
        private void СolorizeTextBoxes()
        {
            SurnameTextBox.BackColor = Color.LightCoral;
            NameTextBox.BackColor = Color.LightCoral;
            PhoneTextBox.BackColor = Color.LightCoral;
            EmailTextBox.BackColor = Color.LightCoral;
            VkTextBox.BackColor = Color.LightCoral;
        }

        /// <summary>
        /// Проверка, что все поля прошли валидацию.
        /// </summary>
        /// <returns>True, если все поля прошли валидацию, иначе false.</returns>
        private bool CheckCorrectnessFields()
        {
            if (SurnameTextBox.BackColor == NameTextBox.BackColor &&
                SurnameTextBox.BackColor == PhoneTextBox.BackColor &&
                SurnameTextBox.BackColor == EmailTextBox.BackColor &&
                SurnameTextBox.BackColor == VkTextBox.BackColor &&
                SurnameTextBox.BackColor == Color.White)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
