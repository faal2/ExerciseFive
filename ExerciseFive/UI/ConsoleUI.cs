using ExerciseFive.GarageWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.UI
{
    internal class ConsoleUI
    {
        private GarageManager _garageManager;
        public void Run()
        {
            Console.WriteLine("Welcome to the Garage application!");
            int sizeOfGarage = GetGarageSize();
            _garageManager.MakeGarageSize(sizeOfGarage);
        }

        public ConsoleUI(GarageManager garageManager)
        {
            _garageManager = garageManager;
            //Console.WriteLine("Welcome to the Garage application!");
            //int sizeOfGarage = GetGarageSize();
            //bool seedData = GetSeedData();
            //MenuLoop();
        }

        public int GetGarageSize()
        {
            Console.WriteLine("Before we can start please pick the size of the garage (the amount of parking spots),"
                + " please remember that once you pick the size it is permenant for the duration of the application.");

            while (true)
            {
                Console.WriteLine("press '0' at anytime to exit the application.");
                Console.Write("Size of the garage: ");
                try
                {
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int sizeOfGarage))
                    {
                        if (sizeOfGarage == 0)
                        {
                            Console.WriteLine("You have ended the application");
                            Environment.Exit(0);
                        }
                        Console.WriteLine($"The size of the garage: {sizeOfGarage}");
                        return sizeOfGarage;
                    }
                    else
                    {
                        Console.WriteLine("Please enter some valid input.");
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
            }
        }

        public bool GetSeedData()
        {
            while (true)
            {
                Console.WriteLine("Would you like to fill the garage with vehicles (Seed Data)? (y/n)");
                Console.Write("Write: ");
                try
                {
                    string? seedInput = Console.ReadLine()?.ToLower();

                    if (seedInput == "0")
                    {
                        Console.WriteLine("You have ended the application");
                        Environment.Exit(0);
                    }
                    else if (seedInput == "y")
                    {
                        return true;
                    }
                    else if (seedInput == "n")
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter some valid input.");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
            }
        }

        public void MenuLoop()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 0) of your choice"
                    + "\n1. View all the vehicles parked"
                    + "\n2. View statistics of the parked vehicles"
                    + "\n3. Search"
                    + "\n4. Parking"
                    + "\n5. Departing"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':

                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                    case '5':

                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5)");
                        break;
                }
            }
        }

    }

}
