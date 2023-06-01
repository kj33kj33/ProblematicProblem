using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public class Program 
    {
        Random rng;
        bool cont = true;
        static List<string> activities = new List<string>()
        {
            "Movies",
            "Paintball",
            "Bowling",
            "Lazer Tag",
            "LAN Party",
            "Hiking",
            "Axe Throwing",
            "Wine Tasting"
        };
        public static void GetRandomActivity()
        {
            Random random = new Random();
            int randomNum = random.Next(activities.Count);
            var randomActivity = activities[randomNum];
            Console.WriteLine(randomActivity);
        }

        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                var userInput = Console.ReadLine().ToLower();

                if(userInput == "yes")
                {
                    Console.WriteLine();

                    GetRandomActivity();
                    //Console.Write("We are going to need your information first! What is your name? ");
                    //string userName = Console.ReadLine();
                    //Console.WriteLine();
                    //Console.Write("What is your age? ");
                    //int userAge = int.Parse(Console.ReadLine());
                    //Console.WriteLine();

                    Console.Write("\nWould you like to see the current list of activities? Sure/No thanks: ");
                    var input2 = Console.ReadLine().ToLower();
                    bool exit2 = false;

                    while (!exit2)
                    {
                        if (input2 == "sure")
                        {
                            Console.WriteLine();
                            bool seeList = true;
                            if (seeList)
                            {
                                foreach (string activity in activities)
                                {
                                    Console.Write($"{activity} ");
                                    Thread.Sleep(250);
                                }
                            }
                            Console.WriteLine();
                            Console.Write("\nWould you like to add any activities? yes/no: ");
                            var input3 = Console.ReadLine().ToLower();
                            bool exit3 = false;

                            while (!exit3)
                            {
                                if(input3 == "yes")
                                {
                                    Console.Write("\nWhat would you like to add? ");
                                    string userAddition = Console.ReadLine();
                                    activities.Add(userAddition);


                                    Console.WriteLine("\nWould you like to add more? yes/no: ");
                                    bool exit4 = false;
                                    var input4 = Console.ReadLine().ToLower();

                                    while (!exit4)
                                    {
                                        if (input4 == "yes")
                                        {
                                            exit4 = true;
                                        }
                                        else if (input4 == "no")
                                        {
                                            //exitProgram = true;
                                            exit2 = true;
                                            exit3 = true;
                                            exit4 = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter 'yes' or 'no'");
                                            input4 = Console.ReadLine().ToLower();
                                        }
                                    }
                                }     
                                else if (input3 == "no")
                                {
                                    exit2 = true;
                                    exit3 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter 'yes' or 'no'");
                                    input3 = Console.ReadLine().ToLower();
                                }
                            }

                            Console.WriteLine();

                        }
                        else if (input2 == "no thanks")
                        {
                            //exitProgram = true;
                            exit2 = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 'Sure' or 'No Thanks'");
                            input2 = Console.ReadLine().ToLower();
                        }
                    }
                }

                else if (userInput == "no")
                {
                    exitProgram = true;
                }
            }
        }
    }
}