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
            string pizza = Input("what pizza would you like? ");
            

            if (pizza == "ham" || pizza == "cheese")
            {
                Print($"okay, one {pizza} pizza!", ConsoleColor.DarkYellow);
            }

            switch(pizza)
            {
                case "cheese":
                case "margherita":
                    Print("Suitable for vegetarians", ConsoleColor.Green);
                    break;
            }

            string music = Input("what music do you like? ");

            switch (music)
            {
                case "rock":
                case "metal":
                case "jazz":
                    Print("okay", ConsoleColor.Blue);
                    break;
                case "pop":
                    Print("okay", ConsoleColor.DarkMagenta);
                    break;
            }
        }

        /// <summary>
        /// prints a line
        /// </summary>
        /// <param name="line">the line to be printed</param>
        private static void Print(string line, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// ask user a question
        /// </summary>
        /// <param name="question">the question asked</param>
        /// <returns>the user answer</returns>
        private static string Input(string question)
        {
            Console.Write(question);
            return  Console.ReadLine();
        }
    }
}
