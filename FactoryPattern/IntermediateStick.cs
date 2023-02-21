﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class IntermediateStick : IHockeyStick
    {
        public IntermediateStick() 
        { 
        }
        void IHockeyStick.Shoot()
        {
            Console.WriteLine("\nBuilding a new intermediate hockey stick!");
        }
    }
}
