
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EfCore;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TestProduct();
            //TestCategory();
        }

        static void TestProduct()
        {
            IProductService productService = new ProductManager(new EfProductRepository());
            int counter = 0;
            foreach (var p in productService.GetProductDetails())
            {
                Console.WriteLine($"{p.ProductName} - {p.CategoryName}");
                counter++;
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Toplam listelenen data : " + counter);
            Console.WriteLine("-------------------------------------------------------");
        }

        static void TestCategory()
        {
            ICategoryService categoryService = new CategoryManager(new EfCategoryRepository());
            int counter = 0;
            foreach (var c in categoryService.GetAll())
            {
                Console.WriteLine($"{c.CategoryName}");
                counter++;
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Toplam listelenen data : " + counter);
            Console.WriteLine("-------------------------------------------------------");
        }

    }
}

