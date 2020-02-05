using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_2020_prog_02_ContaBand
{
    class ContrabandCar : Car
    {

        public ContrabandCar()
        {
            passangers = generator.Next(1, 5);

            contrabandAmount = generator.Next(1, 5);
        }

    }
}
