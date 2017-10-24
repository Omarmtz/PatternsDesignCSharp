using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.DecoratorPattern.AbstractClasses
{
    public abstract class Decorator : Component
    {
        Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if(component != null)
            {
                component.Operation();
            }
        }        
    }
}
