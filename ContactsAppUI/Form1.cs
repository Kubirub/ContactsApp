using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametextbox.Text; // Получение данных из nametextbox

            // Проверка, хранились ли в nametextbox данные
            if (!string.IsNullOrEmpty(name))
            {
                Contact contact = new Contact();
                contact.Name = name;

                // Сохранение данных в файл
                Project.Contacts.Add(contact);
                ProjectManager.SaveToFile(Project.Contacts, "contacts.json");

                MessageBox.Show("Данные успешно сериализованы и сохранены в contacts.json");
            }
            else
            {
                MessageBox.Show("Введите название в nametextbox");
            }
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            // Загрузка данных из файла
            Project.Contacts = ProjectManager.LoadFromFile("contacts.json");

            if (Project.Contacts.Count > 0)
            {
                Contact loadedContact = Project.Contacts[0];
                MessageBox.Show($"Название из загруженного объекта: {loadedContact.Name}");
            }
            else
            {
                MessageBox.Show("Отсутствуют данные для десериализации");
            }
        }
    }
}
