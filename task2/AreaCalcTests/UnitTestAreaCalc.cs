using AreaCalc.figures;
using AreaCalc.interfaces;

namespace AreaCalcTests
{
    [TestClass]
    public class UnitTestAreaCalc
    {
        [TestMethod]
        public void TestGetAreaForCircle()
        {
            // Площадь круга с радиусом 10 = 314.16
            IFigure fig = new Circle(10);
            Assert.AreEqual<double>(Math.Round(AreaCalc.AreaCalc.GetArea(fig), 2), 314.16);
        }

        [TestMethod]
        public void TestGetAreaForRightTriangle()
        {
            // Прямоугольный тре-к, площадь 30
            var fig = new Triangle(5, 12, 13);
            Assert.AreEqual<double>(AreaCalc.AreaCalc.GetArea(fig), 30.0);
        }

        [TestMethod]
        public void TestGetAreaForDefaultTriangle()
        {
            // Площадь треугольника со сторонами 3.3, 8, 5.7 = 7.87
            var fig = new Triangle(3.3, 8, 5.7);
            Assert.AreEqual<double>(Math.Round(AreaCalc.AreaCalc.GetArea(fig), 2), 7.87);
        }

        [TestMethod]
        public void TestGetAreaForPolygon()
        {
            // Вызов нереализованного метода, ошибка
            var sides = new List<double> { 3, 5, 2, 6, 7, 8, 10, 11 };
            var fig = new Polygon(sides);
            double res = 0.0;
            Action act = () => res = AreaCalc.AreaCalc.GetArea(fig);
            Assert.ThrowsException<NotImplementedException>(act);
        }
    }
}