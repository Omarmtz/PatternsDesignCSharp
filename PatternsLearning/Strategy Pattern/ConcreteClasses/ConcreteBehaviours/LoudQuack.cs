﻿using PatternsLearning.Strategy_Pattern.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy_Pattern.ConcreteClasses.ConcreteBehaviours
{
    class LoudQuack : IQuackBehaviour
    {

        public void Quack()
        {
            Console.WriteLine("QUACCCCCCKKKK!!!");
        }
    }
}
