using PatternsLearning.Strategy_Pattern.AbstractClasses;
using PatternsLearning.Strategy_Pattern.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy_Pattern.ConcreteClasses.ConcreteDucks
{
    class LoudRiverDuck : Duck
    {
        public LoudRiverDuck(IDisplayBehaviour dbh, IQuackBehaviour qbh, IFlyBehaviour fbh)
            : base(dbh, qbh, fbh)
        {

        }
    }
}
