using PatternsLearning.DecoratorPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.DecoratorPattern.ConcreteClasses
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(ConcreteComponent comp):base(comp)
        {

        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("DecoratorB.Operation()");
            AddedBehaviour();
        }

        private void AddedBehaviour()
        {
            Console.WriteLine("Added Behaviour Decorator B");
        }
    }
}
