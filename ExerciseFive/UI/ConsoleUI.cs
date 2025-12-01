using ExerciseFive.GarageWorld;
using ExerciseFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFive.UI
{
    internal class ConsoleUI : IUI
    {
        private IManager _garageManager;
        public void Run()
        {
            Console.WriteLine("Welcome to the Garage application!");
            int sizeOfGarage = GetGarageSize();
            _garageManager.MakeGarageSize(sizeOfGarage);

            if (GetSeedData())
            {
                _garageManager.ToSeedData();
            }

            MenuLoop();
        }

        public ConsoleUI(IManager garageManager)
        {
            _garageManager = garageManager;
        }


        public void DepartVehicle()
        {
            while (true)
            {
                Console.WriteLine("Please enter the registration number of the vehicle you want to check out"
                    + "\n0. Return to main menu");

                Console.Write("Write: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    continue;
                }

                if (input == "0")
                {
                    Console.WriteLine("Back to main menu");
                    break;
                }

                bool isRemoved = _garageManager.Depart(input);

                if (isRemoved)
                {
                    Console.WriteLine($"It worked. the register number{input} is out.");
                }
                else
                {
                    Console.WriteLine($"This register number {input} is not in.");
                }
                Console.WriteLine("\n");
            }
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

        public void WriteSearch()
        {
            Console.WriteLine("Please answer the following to search. ");

            Console.WriteLine("Registration Number:");
            Console.Write("Write: ");
            string? registerNumber = Console.ReadLine();
            if (registerNumber == null) registerNumber = "";

            Console.WriteLine("Color (Red, Blue, Black, White, Green):");
            Console.Write("Write: ");
            string? color = Console.ReadLine();
            if (color == null) color = "";

            Console.WriteLine("Number of wheels:");
            Console.Write("Write: ");
            string? wheelInput = Console.ReadLine();
            int.TryParse(wheelInput, out int wheels);


            IEnumerable<Vehicle> outputs = _garageManager.Search(registerNumber, color, wheels);

            Console.WriteLine("\nPresenting: ");
            bool aHit = false;

            foreach (Vehicle vehicle in outputs)
            {
                Console.WriteLine(vehicle.ToString());
                aHit = true;
            }

            if (!aHit)
            {
                Console.WriteLine("No hits.");
            }

            Console.WriteLine("\n");
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
                        WriteToConsoleVehicles();
                        break;
                    case '2':
                        WriteStatistics();
                        break;
                    case '3':
                        WriteSearch(); 
                        break;
                    case '4':
                        ParkVehicle(); 
                        break;
                    case '5':
                        DepartVehicle();
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

        private void WriteToConsoleVehicles()
        {
            IEnumerable<Vehicle> vehicles = _garageManager.GetVehicles();
            if (!vehicles.Any())
            {
                Console.WriteLine("The garage is empty.");
                return;
            }

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        public void WriteStatistics()
        {
            //Lista fordonstyper och hur många av varje som står i garaget 

            IEnumerable<Vehicle> vehicles = _garageManager.GetVehicles();
            if (!vehicles.Any())
            {
                Console.WriteLine("The garage is empty.");
                return;
            }

            Dictionary<string, int> vehicleAmounts = new Dictionary<string, int>();

            foreach (var vehicle in vehicles)
            {
                string type = vehicle.GetType().Name;

                if (vehicleAmounts.ContainsKey(type))
                {
                    vehicleAmounts[type]++;
                }
                else
                {
                    vehicleAmounts.Add(type, 1);
                }
            }

            foreach (var vehicle in vehicleAmounts)
            {
                Console.WriteLine($"{vehicle.Key}: {vehicle.Value}");
            }
        }

        public void ParkVehicle()
        {
            while (true)
            {
                Console.WriteLine("Please choose a vehicle type to park by inputting the number"
                    + "\n1. Car"
                    + "\n2. Bus"
                    + "\n3. Motorcycle"
                    + "\n4. Boat"
                    + "\n5. Airplane"
                    + "\n0. Return to main menu");

                Console.Write("Write: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    continue;
                }

                char nav = input[0];

                if (nav == '0')
                {
                    Console.WriteLine("Back to main menu");
                    break;
                }

                Console.WriteLine("Please enter the Registration Number:");
                Console.Write("Write: ");
                string? registerNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(registerNumber))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    continue;
                }

                Console.WriteLine("Please enter the Color (Red, Blue, Black, White, Green):");
                Console.Write("Write: ");
                string? colorInput = Console.ReadLine();
                Enum.TryParse(colorInput, true, out Color color);

                Vehicle? vehicleToPark = null;

                switch (nav)
                {
                    case '1':
                        Console.WriteLine("Is the car electric? (y/n)");
                        Console.Write("Write: ");
                        string? elecInput = Console.ReadLine();
                        bool isElectric = (elecInput?.ToLower() == "y");

                        vehicleToPark = new Car(registerNumber, color, isElectric);
                        break;

                    case '2':
                        Console.WriteLine("How many seats?");
                        Console.Write("Write: ");
                        string? seatInput = Console.ReadLine();
                        int.TryParse(seatInput, out int seats);

                        vehicleToPark = new Bus(registerNumber, color, seats);
                        break;

                    case '3':
                        Console.WriteLine("Has pillion seat? (y/n)");
                        Console.Write("Write: ");
                        string? pillionInput = Console.ReadLine();
                        bool hasPillion = (pillionInput?.ToLower() == "y");

                        vehicleToPark = new Motorcycle(registerNumber, color, hasPillion);
                        break;

                    case '4':
                        Console.WriteLine("Has roof? (y/n)");
                        Console.Write("Write: ");
                        string? roofInput = Console.ReadLine();
                        bool hasRoof = (roofInput?.ToLower() == "y");

                        vehicleToPark = new Boat(registerNumber, color, hasRoof);
                        break;

                    case '5':
                        Console.WriteLine("Lenght of it?"); 
                        Console.Write("Write: ");
                        string? lenghtInput = Console.ReadLine();
                        int.TryParse(lenghtInput, out int lenght);
                        vehicleToPark = new Airplane(registerNumber, color, lenght);
                        break;

                    default:
                        Console.WriteLine("Please enter some valid input (1-5, 0)");
                        continue;
                }

                if (vehicleToPark != null)
                {
                    var (success, outcome) = _garageManager.Park(vehicleToPark);
                    Console.WriteLine(outcome);

                    if (success)
                    {
                        break;
                    }
                    Console.WriteLine("\n");
                }
            }
        }

    }

}
