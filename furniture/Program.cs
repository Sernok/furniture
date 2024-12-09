using FurnitureApp;
using Furniture;
using System;
using furniture;

public class Program
{
    static void Main(string[] args)
    {
        DataContext context = new DataContext();
        context.Init();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Просмотр всех продуктов");
            Console.WriteLine("2. Добавить сырьё");
            Console.WriteLine("3. Добавить готовую продукцию");
            Console.WriteLine("4. Удалить продукт по ID");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    context.PrintProducts();
                    break;

                case "2": // Добавление сырья
                    Console.Write("Введите название сырья: ");
                    string rawName = Console.ReadLine();

                    Console.Write("Введите цену сырья: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal rawPrice) && rawPrice > 0)
                    {
                        context.RawMaterials.Add(new Material(rawName, rawPrice, context.SearchCategory("Сырьё")));
                        Console.WriteLine("Сырьё успешно добавлено.");
                    }
                    else
                    {
                        Console.WriteLine("Некорректная цена.");
                    }
                    break;

                case "3": // Добавление готовой продукции
                    Console.Write("Введите название готовой продукции: ");
                    string consumerName = Console.ReadLine();

                    Console.Write("Введите цену продукции: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal consumerPrice) && consumerPrice > 0)
                    {
                        Console.Write("Введите каталожный номер: ");
                        string catalogNumber = Console.ReadLine();

                        context.ConsumerUnits.Add(new ConsumerUnit(consumerName, consumerPrice, context.SearchCategory("Готовая продукция"), catalogNumber));
                        Console.WriteLine("Готовая продукция успешно добавлена.");
                    }
                    else
                    {
                        Console.WriteLine("Некорректная цена.");
                    }
                    break;

                case "4": // Удаление по ID
                    Console.Write("Введите ID продукта для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int idToRemove))
                    {
                        bool found = false;

                        var rawMaterial = context.RawMaterials.Find(r => r.Id == idToRemove);
                        if (rawMaterial != null)
                        {
                            context.RawMaterials.Remove(rawMaterial);
                            found = true;
                            Console.WriteLine("Сырьё успешно удалено.");
                        }

                        var consumerUnit = context.ConsumerUnits.Find(c => c.Id == idToRemove);
                        if (consumerUnit != null)
                        {
                            context.ConsumerUnits.Remove(consumerUnit);
                            found = true;
                            Console.WriteLine("Готовая продукция успешно удалена.");
                        }

                        if (!found)
                        {
                            Console.WriteLine("Продукт с таким ID не найден.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод ID.");
                    }
                    break;

                case "5": // Выход
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите снова.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
