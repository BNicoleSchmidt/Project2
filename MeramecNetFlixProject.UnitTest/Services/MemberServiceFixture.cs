using MeramecNetFlixProject.Services;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.Services
{
    public class MemberServiceFixture : BaseFixture
    {
        [Test]
        public void ValidateLogin_Returns_False_If_Username_DNE()
        {
            var customerService = new MemberService();

            var actual = customerService.ValidateLogin(Random.String(), Random.String());

            Assert.IsFalse(actual);
        }
    }
}
