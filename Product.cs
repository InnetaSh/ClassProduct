using ClassProduct;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Создайте класс Product, который будет представлять продукт с следующими полями:

//Id(тип int)
//Name(тип string)
//Price(тип decimal)
//Category(тип string)
//Реализуйте интерфейс IComparable<Product> в классе Product. Напишите метод CompareTo, который будет сравнивать продукты по их цене. Если цены одинаковые, сравните по имени продукта.

//Создайте класс ProductComparerByName для сортировки продуктов по имени. Реализуйте в этом классе интерфейс IComparer<Product>.

namespace ClassProduct
{
    internal class Product : IComparable<Product>
    {
        public int Id;
        public string Name;
        public decimal Price;
        public string Category;
        public Product(int productId, string name, decimal price, string category)
        {
            Id = productId;
            Name = name;
            Price = price;
            Category = category;
        }

        public int CompareTo(Product? product)
        {
            if (product is null) throw new ArgumentException("Некорректное значение параметра");
            int rez = (int)(Price - product.Price);
            if (rez != 0)
                return rez;
            else
                return Name.CompareTo(product.Name);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, name - {Name}, price - {Price}, category - {Category}");
        }
    }
}

class ProductComparerByName : IComparer<Product>
{

    public int Compare(Product? x, Product? y)
    {
        if (x is null || y is null) throw new ArgumentException("Некорректное значение параметра");
        return x.Name.CompareTo(y.Name);
    }
    
}

class ProductComparerByCategory : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x is null || y is null) throw new ArgumentException("Некорректное значение параметра");
        int rez = x.Category.CompareTo(y.Category);
        if (rez != 0)
            return rez;
        return (int)(x.Price - y.Price);
    }

}