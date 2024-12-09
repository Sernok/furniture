using furniture;
using Furniture;
using System;
using System.Collections.Generic;

namespace FurnitureApp
{
    public class DataContext
    {
        public static List<Category> Categories { get; set; }
        public List<Material> RawMaterials { get; set; }
        public List<ConsumerUnit> ConsumerUnits { get; set; }

        public DataContext()
        {
            Categories = new List<Category>();
            RawMaterials = new List<Material>();
            ConsumerUnits = new List<ConsumerUnit>();
        }

        public void Init()
        {
            Categories.Add(new Category("Сырьё"));
            Categories.Add(new Category("Готовая продукция"));

            RawMaterials.Add(new Material("ЛДСП", 500, Categories[0]));
            RawMaterials.Add(new Material("Винты", 50, Categories[0]));

            ConsumerUnits.Add(new ConsumerUnit("Шкаф", 10000, Categories[1], "C001"));
            ConsumerUnits.Add(new ConsumerUnit("Стол", 7500, Categories[1], "C002"));
        }

        public void PrintProducts()
        {
            Console.WriteLine("Сырьё:");
            foreach (var rawMaterial in RawMaterials)
            {
                Console.WriteLine($"ID: {rawMaterial.Id}, Название: {rawMaterial.Name}, Цена: {rawMaterial.Price}");
            }

            Console.WriteLine("\nГотовая продукция:");
            foreach (var consumerUnit in ConsumerUnits)
            {
                Console.WriteLine($"ID: {consumerUnit.Id}, Название: {consumerUnit.Name}, Цена: {consumerUnit.Price}, Каталожный номер: {consumerUnit.CatalogNumber}");
            }
        }

        public Category SearchCategory(string CategoryName)
        {
            foreach (var category in Categories)
            {
                if (category.Name == CategoryName)
                {
                    return category;
                }
            }
            return new Category("");
        }

    }
}
