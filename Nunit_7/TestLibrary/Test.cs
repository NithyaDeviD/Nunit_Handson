using NUnit.Framework;
using Nunit_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    [TestFixture]
    public class Tests
    {



        Calculator c = new Calculator();
        [TestCase]
        public void TestCheck_NullException()
        {



            Assert.Throws<ArgumentNullException>(() => c.Divide(5, 0));
        }



    }
}
