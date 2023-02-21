using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class JuniorStick : IHockeyStick
    {
        public void Shoot()
        {
            Console.WriteLine("\nBuilding a new junior hockey stick");
        }
    }
}
