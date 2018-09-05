using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int quantity = 0;
            CartOperation ob = new CartOperation();
            Console.WriteLine("<------Enter Input to Proceed------->");
            Console.WriteLine("1.Add Item to cart  2.Remove item from cart  3. Display cart  4. clear cart  5.Exit");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            bool ExitCriteria = true;
            while(ExitCriteria)
            {
                if (UserInput == 1)
                {
                    Console.WriteLine("Enter Name of the Item:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity:");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    ob.AddItem(name, quantity);
                }
                else if (UserInput == 2)
                {
                    Console.WriteLine("Enter Name of the Item:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity:");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    ob.RemoveItem(name, quantity);
                }
                else if (UserInput == 3)
                {
                    ob.DisplayCart();
                }
                else if (UserInput == 4)
                    ob.ClearCart();
                else
                Console.WriteLine("Enter a Valid input");
                Console.WriteLine();
                Console.WriteLine("<------Enter Input to Proceed------->");
                Console.WriteLine("1.Add Item to cart  2.Remove item from cart  3. Display cart  4. clear cart  5.Exit");
                UserInput = Convert.ToInt32(Console.ReadLine());
                if (UserInput == 5)
                    ExitCriteria = false;

            }
            

            Console.ReadKey();
        }
    }
}
