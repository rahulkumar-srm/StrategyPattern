using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
