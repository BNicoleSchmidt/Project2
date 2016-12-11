using MeramecNetFlixProject.Services;
using NUnit.Framework;

namespace MeramecNetFlixProject.UnitTest.Services
{
    public class MemberServiceFixture : BaseFixture
    {
        [Test]
        public void ValidateLogin_Returns_False_If_Username_DNE()
        {
            var memberService = new MemberService();

            var actual = memberService.ValidateLogin(Random.String(), Random.String());

            Assert.IsFalse(actual);
        }

        [Test]
        public void ValidateLogin_Returns_True_If_Matching()
        {
            var memberService = new MemberService();
            Assert.True(memberService.ValidateLogin("nicole", "supersecret"));
        }

        [Test]
        public void ValidateLogin_Returns_False_If_Not_Matching()
        {
            var memberService = new MemberService();
            Assert.False(memberService.ValidateLogin("nicole", Random.String()));
        }
    }
}
