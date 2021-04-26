using NUnit.Framework;
using Nunit_2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    [TestFixture, Author("Nithya Devi", "NithyaDevi.D@cognizant.com")]
    public class Tests
    {
        [TestCase, Category("Math"), Order(1)]



        public void TestAdditionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));



        }
        [TestCase, Category("Math"), Order(2)]
        public void TestAdditionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Add(-8, -1);
            Assert.That(result, Is.EqualTo(0));
        }



        [TestCase, Category("Math"), Order(3)]
        public void TestDivisionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Divide(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }



        [TestCase, Category("Math"), Order(4)]
        public void TestDivisionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Divide(2, 0);
            Assert.That(result, Is.EqualTo(0));
        }



        [TestCase, Category("Math"), Order(5)]
        public void TestMultiplicationIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(4, 2);
            Assert.That(result, Is.EqualTo(8));
        }
        [TestCase, Category("Math"), Order(6)]
        public void TestMultiplicationForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(2, 0);
            Assert.That(result, Is.EqualTo(0));
        }



        [TestCase, Category("Math"), Order(7)]
        public void TestSubtractionIfArgsAreGreaterThanZero()
        {
            Calculator c = new Calculator();
            int result = c.Subtract(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        [TestCase, Category("Math"), Order(8)]
        public void TestSubtractionForNumberLessOrEqualToZero()
        {
            Calculator c = new Calculator();
            int result = c.Subtract(-2, -4);
            Assert.That(result, Is.EqualTo(0));
        }



        [Test]

        [TestCaseSource(typeof(AddCases))]
        public void TestAddTestIfArgsAreGreaterThanZero(int a, int b)
        {
            Calculator c = new Calculator();
            int result = c.AddTest(a, b);
            Assert.That(result, Is.EqualTo(a + b));
        }
        class AddCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { 1, 1 };
                yield return new object[] { 5, 50 };
                yield return new object[] { 55, 56 };



            }
        }
    }
}
