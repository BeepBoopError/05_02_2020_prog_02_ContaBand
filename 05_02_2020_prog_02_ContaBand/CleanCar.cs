using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_2020_prog_02_ContaBand
{
    class CleanCar : Car
    {

        public CleanCar()
        {
            passangers = generator.Next(1, 4);

            contrabandAmount = 0;
        }

    }
}
