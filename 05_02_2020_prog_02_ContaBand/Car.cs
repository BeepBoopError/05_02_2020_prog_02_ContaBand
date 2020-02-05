using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_2020_prog_02_ContaBand
{
    class Car
    {
        public int passangers;

        public int contrabandAmount;

        public bool alreadyChecked = false;

        public static Random generator = new Random();

        public bool Examine()
        {
            if(alreadyChecked == true)
            {
                Console.WriteLine("This car has already been checked");

                return false;
            }


            bool result = false;

            if (generator.Next(1,6) <= contrabandAmount)
            {
                Console.WriteLine("This car car has "+ contrabandAmount +" illegal instuments in it!");
                result = true;
            }
            else
            {
                Console.WriteLine("No musicians in this car.");
            }

            alreadyChecked = true;

            return result;
        }

    }
}
