using AreaCalc.figures;

namespace AreaCalcTests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestCircleCreateRadiusBelowZero()
        {
            // Радиус отрицательный, ошибка
            Action create = () => new Circle(-1);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestCircleCreateRadiusZero()
        {
            // Круг вырожден в точку, корректно
            var fig = new Circle(0);
        }

        [TestMethod]
        public void TestCircleCreateRadiusAboveZero()
        {
            // Обычный круг, корректно
            var fig = new Circle(10);
        }

        [TestMethod]
        public void TestCircleAreaRadiusZero()
        {
            // Точка, площадь = 0
            var fig = new Circle(0);
            Assert.AreEqual<double>(fig.Area, 0.0);
        }

        [TestMethod]
        public void TestCircleAreaRadius10()
        {
            // Площадь круга с радиусом 10 = 314.16
            var fig = new Circle(10);
            Assert.AreEqual<double>(Math.Round(fig.Area, 2), 314.16);
        }
    }
}