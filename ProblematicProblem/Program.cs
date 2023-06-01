using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public class Program 
    {
        Random rng;
        bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            bool cont;
            switch (Console.ReadLine().ToLower())
            {
                case "yes":
                    cont = true;
                    break;
                case "no":
                    cont = false;
                    break;
            }
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList = bool.Parse(Console.ReadLine());
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
            }
            Console.WriteLine();
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            bool addToList = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            while (addToList)
            {
                Console.Write("What would you like to add? ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);
            }
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? yes/no: ");
            addToList = bool.Parse(Console.ReadLine());
        }

    }


}