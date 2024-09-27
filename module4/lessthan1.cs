using System;

namespace module4
{
    internal class lessthan1
    {
        public static void ConsoleColours()
        {
            Console.WriteLine("Lesson 1: something about colours");
            while (true)
            {

                Console.Write("Colour? ");
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Your colour is {colour}. Grand.");
                        break;

                    case "Red":
                        goto case "red";

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Your colour is {colour}. Exquisite.");
                        break;

                    case "Green":
                        goto case "green";

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Your colour is {colour}. Delicious.");
                        break;

                    case "Cyan":
                        goto case "cyan";

                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Your colour is {colour}. Fancy.");
                        break;

                    case "Yellow":
                        goto case "yellow";

                    case "purple":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Your colour is {colour}. Majestic.");
                        break;

                    case "Purple":
                        goto case "purple";

                    case "black":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Your colour is {colour}. Default.");
                        break;

                    case "Black":
                        goto case "black";

                    case "white":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Your colour is {colour}. Edgy.");
                        break;

                    case "White":
                        goto case "white";

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Your colour is NaN. What.");
                        break;
                }

                Console.Write("Try another one? [y/n] ");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                {
                    Console.WriteLine("I guess you're stuck with it for the rest of this.");
                    break;
                }
            }
        }
    }
}
