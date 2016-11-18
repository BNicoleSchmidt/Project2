using MeramecNetFlixProject.Services;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MeramecNetFlixProject.UnitTest.Services
{
    public class CustomerServiceFixture : BaseFixture
    {
        [Test]
        public void ValidateLogin_Returns_False_If_Username_DNE()
        {
            var customerService = new CustomerService();

            var actual = customerService.ValidateLogin(Random.String(), Random.String());

            Assert.IsFalse(actual);
        }
    }
}
