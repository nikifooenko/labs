using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        public static Product CreateProduct()
        {
            Console.WriteLine("Введите название: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите произвордителя: ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Введите цену: ");
            decimal price = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество: ");
            int amount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите срок годности(в днях): ");
            int shelfLife = Int32.Parse(Console.ReadLine());
            return new Product(name, manufacturer, price, shelfLife, amount);
        }

        public static void PrintProduct(Product product)
        {
            Console.WriteLine($"Название: {product.Name}");
            Console.WriteLine($"Производитель: {product.Manufacturer}");
            Console.WriteLine($"Цена: {product.Price}");
            Console.WriteLine($"Срок годносити в днях: {product.ShelfLife}");
            Console.WriteLine($"Количество: {product.Amount}");
            Console.WriteLine("----------------------------");
        }

        static void Main(string[] args)
        {
            Product[] storage = new Product[5];
            for (int i = 0; i < storage.Length; i++)
            {
                storage[i] = CreateProduct();
            }
            Console.WriteLine("Введите наименование для поиска: ");
            string searchName = Console.ReadLine();
            var foundProducts = storage.Where(i => i.Name.ToLower() == searchName.ToLower());
            if (foundProducts.Count() > 0)
            {
                Console.WriteLine("Результаты поиска: ");
                foreach (var product in foundProducts)
                {
                    PrintProduct(product);
                }
            }
            else
            {
                Console.WriteLine("Ничего не найдено");
            }

            Console.WriteLine("------Задание 3------");
            Console.WriteLine("Создание продукта: ");
            Product p = CreateProduct();
            Console.WriteLine("Перегружены операторы ++/-- для увеличения/уменьшения количества товара на 1");
            Console.WriteLine($"Исходное количество: {p.Amount}");
            p++;
            Console.WriteLine($"Изменённое количество: {p.Amount}");
            Console.WriteLine("Перегружены операторы +/- для увеличения/уменьшения количества товара на заданное количество");
            Console.WriteLine($"Исходное количество: {p.Amount}");
            p -= 10;
            Console.WriteLine($"Изменённое количество: {p.Amount}");
            Console.WriteLine("Перегружены оператор % для задания скидки на товар");
            Console.WriteLine($"Исходная цена: {p.Price}");
            p %= 20;
            Console.WriteLine($"Изменённая цена: {p.Price}");
        }
    }
}
