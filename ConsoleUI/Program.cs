
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EfCore;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductRepository());
            int counter = 0;
            foreach (var p in productService.GetAllByPrice(10,50))
            {
                Console.WriteLine($"{p.ProductName}");
                counter++;
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Toplam listelenen data : "+counter);
            Console.WriteLine("-------------------------------------------------------");
        }

    }
}

