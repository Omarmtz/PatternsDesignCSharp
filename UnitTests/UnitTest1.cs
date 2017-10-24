using System;
using NUnit.Framework;
using PatternsLearning.Strategy_Pattern.Behaviours;
using NSubstitute;
using PatternsLearning.ObserverPattern.AbstractClasses.Observable_Actions;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        /// <summary>
        /// Example of Substitute Framework.
        /// </summary>
        [Test]
        public void IsValidNumber_FakeValue_Returns10()
        {
            IDisplay displayStub = Substitute.For<IDisplay>();
            displayStub.Display().Returns(10);

            Assert.AreEqual(10, displayStub.Display());            
        }
    }
}
