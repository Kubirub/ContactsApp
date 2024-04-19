using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта пользователя.
    /// </summary>
    public class Contact : IComparable<Contact>, ICloneable
    {
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Эл. почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Дата рождения человека в контактах.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Vk ID человека в контактах.
        /// </summary>
        private string _vkID;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Конструктор класса <see cref="Contact"/> без параметров.
        /// </summary>
        public Contact()
        {
            PhoneNumber = new PhoneNumber();
        }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/> с параметрами.
        /// </summary>
        /// <param name="surname">Фамилия.</param>
        /// <param name="name">Имя.</param>
        /// <param name="email">Эл. почта.</param>
        /// <param name="birtday">День рождения.</param>
        /// <param name="vkID">Vk ID.</param>
        /// <param name="number">Номер телефона.</param>
        public Contact(
            string surname,
            string name,
            string email,
            DateTime birtday,
            string vkID,
            string number)
        {
            Surname = surname;
            Name = name;
            Email = email;
            Birthday = birtday;
            VkID = vkID;
            PhoneNumber = new PhoneNumber(number);

        }

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _surname = CreateFirstSymbolUpper(value);
            }
        }

        /// <summary>
        /// Делает первый символ переданной строки в верхний регистр.
        /// </summary>
        /// <param name="str">Переданная строка.</param>
        /// <returns>Строку в верхнем регистре.</returns>
        public static string CreateFirstSymbolUpper(string str)
        {
            var a = str[0].ToString();
            a = a.ToUpper();
            var b = a + str.Substring(1, str.Length - 1);
            return b;
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _name = CreateFirstSymbolUpper(value);
            }
        }

        /// <summary>
        /// Возвращает и задает эл. почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                if (value.IndexOf('@') != value.LastIndexOf('@') ||
               (value.LastIndexOf('.') < value.LastIndexOf('@')) ||
               (value.IndexOf('@') == -1))
                {
                    throw new ArgumentException();
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Vk ID человека в контактах.
        /// </summary>
        public string VkID
        {
            get
            {
                return _vkID;
            }
            set
            {
                if (value.Length > 15 || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _vkID = value;
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value > DateTime.Now || value.Year < 1900)
                {
                    throw new ArgumentException();
                }
                _birthday = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Метод создания клона объекта контакта.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Contact
                (
                Surname,
                Name,
                Email,
                Birthday,
                VkID,
                PhoneNumber.Phone
                );
        }

        /// <summary>
        /// Метод сравнения 2 массивов для сортировки.
        /// </summary>
        /// <param name="other">Объект сравнения.</param>
        /// <returns>Меньше нуля. Значит, текущий объект должен находиться перед объектом, 
        /// который передается в качестве параметра
        /// Равен нулю.Значит, оба объекта равны
        ///Больше нуля.Значит, текущий объект должен находиться после объекта, 
        ///передаваемого в качестве параметра</returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(Contact other)
        {
            if (other is Contact)
            {
                return Surname.CompareTo(other.Surname);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Переопределнный метод сравнения контактов.
        /// </summary>
        /// <param name="obj">Объект сравнения.</param>
        /// <returns>True, если все поля совпадают по значению.</returns>
        public override bool Equals(object obj)
        {
            Contact contact;
            if (obj is Contact)
            {
                contact = (Contact)obj;
            }
            else
            {
                return false;
            }
            return (
                this.Surname == contact.Surname &&
                this.Name == contact.Name &&
                this.Email == contact.Email &&
                this.PhoneNumber.Phone == contact.PhoneNumber.Phone &&
                this.VkID == contact.VkID &&
                this.Birthday == contact.Birthday);
        }
    }
}