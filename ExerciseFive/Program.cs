using ExerciseFive.GarageWorld;
using ExerciseFive.Vehicles;
using System;
using System.Diagnostics.Metrics;


            //Program starts here creates garage and ui the 2 dependencis the garage application needs.
            //var garage = new Garage();
            //var ui = new ConsoleUI();
            //var manager = new GarageManager(garage, ui);
            //manager.Run();

            var garage = new Garage<Vehicle>(5);
            var vehicle1 = new Boat("99", Color.Red, true);
            var vehicle2 = new Boat("88", Color.Blue, true);

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);

            foreach (var vehicle in garage)
            {
            Console.WriteLine(vehicle);
            }

            
            Console.WriteLine("Garage application done");

