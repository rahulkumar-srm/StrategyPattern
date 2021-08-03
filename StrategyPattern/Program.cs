using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();

            modelDuck.FlyBehaviour = new FlyRocketPowered();

            modelDuck.PerformFly();

            Console.ReadKey();
        }
    }
}
