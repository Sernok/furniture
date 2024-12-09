using FurnitureApp;
using System;

namespace Furniture
{
    public class Category
    {
        // Свойства для идентификатора и названия категории
        public int Id { get; set; }
        public string Name { get; set; }

        public int id
        {
            get { return id; }
            set
            {
                if (value >= 0)  // Проверка на неотрицательное значение
                    id = value;
            }
        }





        // Конструктор по умолчанию
        public Category()
        {
            Name = "Стулья";  // Значение по умолчанию для категории
        }

        // Конструктор с параметром для имени
        public Category(string name)
        {
            Name = name;
        }

        // Метод для вывода информации о категории
        public void Print()
        {
            Console.WriteLine($"Category: {Name}");
        }
    }
}
