namespace MeramecNetFlixProject.UnitTest
{
    public class BaseFixture
    {
        public RandomTester Random;
        public BaseFixture()
        {
            Random = new RandomTester();
        }
    }
}