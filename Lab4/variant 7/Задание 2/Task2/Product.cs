using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Product
    {
        private decimal price;
        private int shelfLife;
        private int amount;

        public string Name { get; private set; }
        public string Manufacturer { get; private set; }

        public decimal Price
        {
            get
            {
                return price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Цена не может быть отрицательной");
                }
                price = value;
            }
        }

        public int ShelfLife
        {
            get 
            {
                return shelfLife;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("срок годности не может быть отрицательным");
                }
                shelfLife = value;
            }
        }

        public int Amount
        {
            get 
            {
                return amount;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("количество не может быть отрицательным");
                }
                amount = value;
            }
        }

        public Product(string name, string manufacturer, decimal price, int shelfLife, int amount)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ShelfLife = shelfLife;
            Amount = amount;
        }

        public static Product operator --(Product p)
        {
            if (p.Amount == 0)
            {
                return p;
            }
            p.Amount--;
            return p;
        }

        public static Product operator ++(Product p)
        {
            p.Amount++;
            return p;
        }

        public static Product operator %(Product p, int discountPercent)
        {
            p.Price -= p.Price * (discountPercent / 100M);
            return p;
        }

        public static Product operator +(Product p, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Количество не может быть отрицательным");
            }
            p.Amount += amount;
            return p;
        }

        public static Product operator -(Product p, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Количество не может быть отрицательным");
            }
            if (amount > p.Amount)
            {
                throw new ArgumentException("Нельзя взять больше, чем есть");
            }
            p.Amount -= amount;
            return p;
        }
    }
}
