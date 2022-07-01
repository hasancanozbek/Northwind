
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
            Console.WriteLine(productService.GetAll().Message);
            foreach (var p in productService.GetProductDetails().Data)
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
            foreach (var c in categoryService.GetAll().Data)
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

