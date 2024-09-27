using System;
using System.ComponentModel.Design;

namespace module4
{
    internal class lessthan4
    {
        public static void Tuples()
        {
            Console.WriteLine("\nLesson 4: Questionnaire in a tuple");
            Console.WriteLine("Finally, time for a small talk.");
            (string name, byte age, string birthdate, DayOfWeek favday, string favcolour, bool hasPet, string petName) UserInfo;
            UserInfo.favcolour = lessthan1.colour is null? lessthan1.colour : "lame";
            UserInfo.hasPet = false;
            UserInfo.petName = null;
            Console.Write("What's your name? ");
            UserInfo.name = Console.ReadLine();
            if (lessthan3.name_reversed is null || lessthan3.name_reversed == "")
            {
                Console.WriteLine("Fancy name. I guess you're not from around these parts.");
            }
            else
            {
                Console.Write("Jokes on you, I remember your name is ");
                UserInfo.name = lessthan3.name_reversed;
                Console.WriteLine(UserInfo.name + ".");
            }

            while (true)
            {
                Console.Write("What's your age again? ");
                if (byte.TryParse(Console.ReadLine(), out UserInfo.age)) { break; }
                else { Console.WriteLine("Quit fooling around, just answer!"); }
            }

            Console.Write("When were you born? ");
            UserInfo.birthdate = Console.ReadLine();
            Console.WriteLine("No way!");

            int favdayind;
            while (true)
            {
                Console.WriteLine("Use an index number to answer the next question. Or else.");
                Console.Write("What's your favourite day of week? ");
                try { favdayind = Convert.ToByte(Console.ReadLine()); }
                catch (FormatException) { continue; }
                if (Array.Exists(new int[] { 1, 2, 3, 4, 5, 6, 7 }, el => el == favdayind)) { break; }
            }
            Console.WriteLine("Out of all seven? Well, okay.");
            UserInfo.favday = (DayOfWeek)favdayind;

            for (int i = 0; i <= 4; i++)
            {
                if (i == 4) { Console.WriteLine("Okay, I'm tired of asking this."); break; }
                else if (i == 0) { Console.Write("Do you have a pet? "); }
                else { Console.Write("Do you have a pet? Yes or no? "); };
                var answer = Console.ReadLine();
                if (answer == "yes" || answer == "Yes")
                { 
                    UserInfo.hasPet = true;
                    Console.Write("And what's their name? ");
                    UserInfo.petName = Console.ReadLine();
                    break;
                }
                else if (answer == "no" || answer == "No") { break; }
            }

            Console.WriteLine($"So, your name is {UserInfo.name} ({UserInfo.name.Length} letters, woah) and your favourite day of the week is {UserInfo.favday},\n" +
                $"you were born at {UserInfo.birthdate} and currently are {UserInfo.age} yearls old,\n" +
                $"also, you have {(UserInfo.hasPet? "a" : "no")} pet," +
                $"{(UserInfo.petName is null? "what a loser" : $"by the name of {UserInfo.petName}" )}.\n" +
                $"Based on this info, I'm gonna guess that your favourite colour is {UserInfo.favcolour}. Isn't that right, {UserInfo.name}?");
            Console.ReadKey();
        }
    }
}
