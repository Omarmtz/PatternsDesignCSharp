using PatternsLearning.DecoratorPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.DecoratorPattern.ConcreteClasses
{
    public class ConcreteComponent : Component
    {

        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
