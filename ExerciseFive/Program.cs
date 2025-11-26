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
            var vehicle1 = new Vehicle("99", Color.Red, 1);

            garage.AddVehicle(vehicle1);

            garage.RemoveVehicle(vehicle1);
            Console.WriteLine("Garage application done");

