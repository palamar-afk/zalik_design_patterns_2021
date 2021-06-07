using System;
namespace Patterns
{
    class Customer
    {
        public void Main()
        {
            Console.WriteLine("Сначала произведем столы");
            CustomerService(new TableFurnitureFactory());
            Console.WriteLine();

            Console.WriteLine("Теперь надо стулья");
            CustomerService(new ChairFurnitureFactory());
        }

        public void CustomerService(IFurnitureFactory factory)
        {
            var table = factory.ProduceGreenFurniture();
            var chair = factory.ProduceRedFurniture();

            Console.WriteLine(table.GetResultForGreen());
            Console.WriteLine(chair.GetResultForRed());
        }
    }
}