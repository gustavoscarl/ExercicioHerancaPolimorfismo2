using ExercicioHerancaPolimorfismo2.Entities;

namespace ExercicioHerancaPolimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numProducts = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 0; i < numProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'c')
                {
                    products.Add(new Product { Name = name, Price = price });
                }
                else if (type == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct { Name = name, Price = price, ManufactureDate = manufactureDate });
                }
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct { Name = name, Price = price, CustomsFee = customsFee });
                }
                Console.WriteLine("PRICE TAGS: ");
                foreach (Product product in products)
                {
                    Console.WriteLine(product.priceTag());
                }
            }
        }
    }
}
