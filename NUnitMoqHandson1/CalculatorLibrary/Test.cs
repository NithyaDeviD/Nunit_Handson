using NUnit.Framework;
using NUnitMoqHandson1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalculatorLibrary1
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void TestAdditionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }
        [TestCase]
        public void TestAdditionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(-8, -1);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}