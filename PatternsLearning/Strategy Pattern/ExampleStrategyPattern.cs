using PatternsLearning.Strategy_Pattern.AbstractClasses;
using PatternsLearning.Strategy_Pattern.ConcreteClasses;
using PatternsLearning.Strategy_Pattern.ConcreteClasses.ConcreteBehaviours;
using PatternsLearning.Strategy_Pattern.ConcreteClasses.ConcreteDucks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Strategy_Pattern
{
    public class ExampleStrategyPattern
    {
        public static void DuckStrategyPatternExample()
        {
            List<Duck> duckList = new List<Duck>();

            //Mountain duck with simple Quack Method
            LoudRiverDuck river_duck = new LoudRiverDuck(
                new TerminalDisplay(),
                new SimpleQuack(),
                new SimpleFly());
            
            //Mountain duck with different Quack Method
            MountainDuck mountainDuck = new MountainDuck(
                new TerminalDisplay(),
                new LoudQuack(),
                new SimpleFly());

            duckList.Add(river_duck);
            duckList.Add(mountainDuck);

            foreach (var duck in duckList)
            {
                duck.Display();
                duck.Quack();
                duck.Fly();
                Console.WriteLine();
            }
        }

    }
}
