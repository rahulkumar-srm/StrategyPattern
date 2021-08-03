using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
