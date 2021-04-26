using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace CustomerCommLib
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void TestCase_SMTPService()
        {
            var smtpClient = new Mock<IMailSender>();
            smtpClient.Setup(x => x.SendMail("CTS20DN012@gmail.com", "Welcome User")).Returns(true);
            CustomerCommLib.CustomerComm component = new CustomerCommLib.CustomerComm(smtpClient.Object);
            Assert.AreEqual(true, component.SendMailToCustomer());
        }
    }

}
