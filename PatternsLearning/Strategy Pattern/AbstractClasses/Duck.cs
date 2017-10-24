using PatternsLearning.Strategy_Pattern.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy_Pattern.AbstractClasses
{
    public abstract class Duck
    {
        IDisplayBehaviour display;

        IQuackBehaviour quack;

        IFlyBehaviour fly;

        public Duck(IDisplayBehaviour dbh, IQuackBehaviour qbh, IFlyBehaviour fbh)
        {
            this.display = dbh;
            this.quack = qbh;
            this.fly = fbh;
        }

        public virtual void Fly()
        {
            this.fly.Fly();
        }

        public virtual void Display()
        {
            this.display.Display();
        }

        public virtual void Quack()
        {
            this.quack.Quack();
        }

    }
}
