using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_2020_prog_02_ContaBand
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Hur många bilar vill du skapa?");

            int carAmount = NumberReader(64);

            List<Car> CarList = new List<Car>();

            for (int i = 0; i < carAmount; i++)
            {
                if (Car.generator.Next(1,3) == 1)
                {
                    CarList.Add(new ContrabandCar());
                }
                else
                {
                    CarList.Add(new CleanCar());
                }
            }

            bool runGame = true;

            while(runGame)
            {
                Console.WriteLine("Your score is " + score);

                Console.WriteLine("Which car would you like to inspect?");

                int carToCheck = NumberReader(CarList.Count);

                if (CarList[carToCheck - 1].Examine())
                {
                    score += CarList[carToCheck - 1].contrabandAmount;
                }
            }


        }


        static int NumberReader(int maxAmount)
        {
            bool done = false;

            int outputer = 1;

            while(!done)
            {
                Console.WriteLine("Input number between 1 and " + maxAmount);

                bool tester = int.TryParse(Console.ReadLine(), out outputer);

                if (tester)
                {
                    if (1 <= outputer && outputer <= maxAmount)
                    {
                        done = true;
                    }
                }
                
            }

            return outputer;
        }

    }
}
