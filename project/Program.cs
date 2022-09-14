using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What flavour do you want? ");
            string pizza = Console.ReadLine();

            if (pizza == "ham" || pizza == "cheese")
            {
                Console.WriteLine($"okay, one {pizza} pizza!");
            }

            switch(pizza)
            {
                case "cheese":
                case "margherita":
                    Console.WriteLine("Suitable for vegetarians");
                
            }
        }
    }
}
