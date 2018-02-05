using System;
using System.Collections.Generic;

namespace Bonus17
{
    internal class CarApp
    {
        private static int carsMade = 0;
        private static List<Car> carList = new List<Car>();

        public static void GetUserInput()
        {
            Console.Write("How many cars would you like to enter?: ");
            bool bit = int.TryParse(Console.ReadLine(), out int numOfCars);

            if (bit)
            {
                GetCarDetails(numOfCars);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You did not enter a valid integer. Please try again.");
                GetUserInput();
            }
        }

        private static void GetCarDetails(int numOfCars)
        {
            carsMade++;
            Console.WriteLine("\nEnter in the details of your car: ");

            Console.Write("What is the make?: ");
            string make = Console.ReadLine();

            Console.Write("What is the model?: ");
            string model = Console.ReadLine();

            Console.Write("What is the year?: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("What is the price?: ");
            double price = double.Parse(Console.ReadLine());

            if (isCarUsed())
            {
                Console.Write("What is the mileage?: ");
                double mileage = double.Parse(Console.ReadLine());
                carList.Add(new UsedCar(make, model, year, price, mileage));
            }
            else
            {
                carList.Add(new Car(make, model, year, price));
            }

            if (carsMade < numOfCars)
                GetCarDetails(numOfCars);
            else
            {
                foreach (Car car in carList)
                {
                    Console.WriteLine(car.ToString());
                }
                QuitConsoleApp();
            }
        }

        private static bool isCarUsed()
        {
            bool carIsUsed = false;
            Console.WriteLine("Is the car used? Y/N");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "y")
            {
                carIsUsed = true;
            }
            return carIsUsed;
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                CarApp.GetUserInput();
            }
        }
    }
}