using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SeniorStick : IHockeyStick
    {
        void IHockeyStick.Shoot()
        {
            Console.WriteLine("\nBuilding a new senior hockey stick.");
        }
    }
}
