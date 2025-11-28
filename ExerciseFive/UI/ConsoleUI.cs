using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.UI
{
    internal class ConsoleUI
    {

        public ConsoleUI()
        {
            Console.WriteLine("Welcome to the Garage application!");
            InitializeGarage();
            MenuLoop();
        }

        public int InitializeGarage()
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
        public void MenuLoop()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
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
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

    }

}
