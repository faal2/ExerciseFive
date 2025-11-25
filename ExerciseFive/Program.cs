using System;
using System.Diagnostics.Metrics;

namespace ExerciseFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program starts here creates garage and ui the 2 dependencis the garage application needs.
            var garage = new Garage();
            var ui = new ConsoleUI();
            var manager = new GarageManager(garage, ui);
            manager.Run();
            Console.WriteLine("Garage application done");
        }
    }
}
