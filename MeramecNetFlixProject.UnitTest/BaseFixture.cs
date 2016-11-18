using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeramecNetFlixProject.UnitTest
{
    [TestClass]
    public class BaseFixture
    {
        public RandomTester Random;
        public BaseFixture()
        {
            Random = new RandomTester();
        }
    }
}