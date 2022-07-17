using System;
using System.Collections.Generic;

namespace Task862
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            Console.WriteLine("Вас приветствует телефонная книга.");

            AddNotes(phonebook);
            Print(phonebook);
            FindUser(phonebook);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод для добавления новых записей в словарь.
        /// </summary>
        /// <param name="phonebook"></param>
        static void AddNotes(Dictionary<string, string> phonebook)
        {
            Console.WriteLine("\nДля окончания заполнения введите пустую строку.");
            do
            {
                Console.Write("\nВведите номер телефона: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == string.Empty)
                {
                    break;
                }

                Console.Write("Введите Ф. И. О. владельца: ");
                string name = Console.ReadLine();
                if (name == string.Empty)
                {
                    break;
                }

                phonebook.Add(phoneNumber, name);

            } while (true);
        }

        /// <summary>
        /// Метод для поиска владельца по введенному номеру.
        /// </summary>
        /// <param name="phonebook"></param>
        static void FindUser(Dictionary<string, string> phonebook)
        {
            Console.WriteLine("\nПоиск владельца. \nДля окончания работы введите пустую строку.");

            do
            {
                Console.Write("\nВведите номер телефона: ");
                string number = Console.ReadLine();

                if (number == string.Empty)
                {
                    break;
                }
                else
                {
                    if (phonebook.TryGetValue(number, out var name) == true)
                    {
                        Console.WriteLine($"Номер принадлежит владельцу {name}.");
                    }
                    else
                    {
                        Console.WriteLine("Владельца по этому номеру не зарегистрировано.");
                    }
                }

            } while (true);
            
        }

        static void Print(Dictionary<string, string> phonebook)
        {
            Console.WriteLine("\nВаша телефонная книга: ");
            foreach (KeyValuePair<string, string> pair in phonebook)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
