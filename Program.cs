//Создайте класс Product, который будет представлять продукт с следующими полями:

//Id(тип int)
//Name(тип string)
//Price(тип decimal)
//Category(тип string)
//Реализуйте интерфейс IComparable<Product> в классе Product. Напишите метод CompareTo, который будет сравнивать продукты по их цене. Если цены одинаковые, сравните по имени продукта.

//Создайте класс ProductComparerByName для сортировки продуктов по имени. Реализуйте в этом классе интерфейс IComparer<Product>.

//Создайте класс ProductComparerByCategory для сортировки продуктов по категории и по цене внутри категории. Реализуйте в этом классе интерфейс IComparer<Product>.

//Создайте коллекцию из нескольких объектов Product.

//Реализуйте метод для сортировки коллекции с использованием метода Sort класса List<T> с различными компараторами.

//Выведите отсортированные коллекции на экран.



//Требования:
//Реализовать класс Product с описанными полями и методом CompareTo.
//Реализовать классы ProductComparerByName и ProductComparerByCategory.
//Создать метод для заполнения коллекции объектов Product.
//Написать метод для сортировки и вывода коллекции на экран с использованием различных компараторов.

using ClassProduct;
using System.Collections.Generic;

List<Product> products = new List<Product>
        {
            new Product (1, "яблоко", 59.99m, "фрукт"),
            new Product (2,"груша", 49.99m,  "фрукт" ),
            new Product( 3, "персик", 119.99m,  "фрукт" ),
            new Product (4, "диван", 17999.99m,  "мебель"),
            new Product (5,  "шкаф",  1499.99m, "мебель" ),
            new Product( 6, "нектарин", 119.99m,  "фрукт" ),
            new Product (7,  "стул",  1499.99m, "мебель" ),
            new Product (8, "вишня", 20.99m, "фрукт")
        };
Console.WriteLine("Список продуктов до сортировки:");
PrintProducts(products);
Console.WriteLine();

products.Sort();
Console.WriteLine("\nСписок продуктов после сортировки по цене, по имени:");
PrintProducts(products);

products.Sort(new ProductComparerByName());
Console.WriteLine("\nСписок продуктов после сортировки по имени:");
PrintProducts(products);

products.Sort(new ProductComparerByCategory());
Console.WriteLine("\nСписок продуктов после сортировки по категории, по цене:");
PrintProducts(products);


void PrintProducts(List<Product> products)
{
    foreach (var pr in products)
    {
        pr.PrintInfo();
    }
}