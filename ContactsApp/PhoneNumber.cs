using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона пользователя.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Номер телефона пользователя.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Конструктор класса <see cref="PhoneNumber"/> без параметров.
        /// </summary>
        public PhoneNumber()
        {

        }

        /// <summary>
        /// Конструктор класса <see cref="PhoneNumber"/> с параметрами.
        /// </summary>
        /// <param name="number">Номер телефона.</param>
        public PhoneNumber(string number)
        {
            Phone = number;
        }

        /// <summary>
        /// Возвращает и задает номер телефона пользователя.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
               if (value.Length != 11 || value[0] != '7' || HasOtherSymbols(value) ||  value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _phone = value;
            }
        }

        /// <summary>
        /// Проверяет строку на соответствие строки номеру телефона.
        /// </summary>
        /// <param name="str">Проверяемая строка.</param>
        /// <returns>True, если имеет символы, отличные от чисел, иначе false.</returns>
        private static bool HasOtherSymbols(string str)
        {
            foreach (var symbol in str)
            {
                if (symbol < '0' || symbol > '9')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
