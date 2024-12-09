using System;







namespace Furniture
{

    public abstract class Product
    {
        private static int idCounter = 0;
        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        protected Product(string name, decimal price, Category category)
        {
            Id = idCounter++;
            Name = name;
            Price = price >= 0 ? price : throw new ArgumentException("Цена не может быть отрицательной.");
            Category = category;
        }
    }
    /*
    public class Product
    {
        private int id;
        private decimal price;
        public static int idcounter = 0;
        public Category Category { get; set; }

        // Свойство Id с корректной установкой значения
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0)  // Проверка на неотрицательное значение
                    id = value;
            }
        }

        // Свойство для вывода продуктов
        public string Name { get; set; }

        // Свойство для цены продукта с проверкой
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)  // Проверка на неотрицательную цену
                    price = value;
            }
        }

        /*
        public Product(string name, int price, Category category)
        {
            Id = idcounter++;
            Name = name;  // Используем свойство Name
            Price = price;
            //huuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
            Category = Category;
        }
        
    
        public void SetPrice(decimal price)
        {
            this.Price = price;
        }
    */
    }