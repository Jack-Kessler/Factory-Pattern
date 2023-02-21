using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class StickFactory
    {
        public static IHockeyStick BuildStick()
        {
            Console.WriteLine("\nWhat type of hockey stick do you need?\n");
            var answer = Console.ReadLine().ToLower();
            while (answer != "junior" && answer != "intermediate" && answer != "senior")
            {
                Console.WriteLine("\nInvalid Entry. Try Again.\n");
                answer = Console.ReadLine().ToLower();
            }

            switch (answer)
            {
                case "junior":
                    return new JuniorStick();
                case "intermediate":
                    return new IntermediateStick();
                case "senior":
                    return new SeniorStick();
                default:
                    return new SeniorStick();
            }

        }
    }
}
