using AreaCalc.figures;

namespace AreaCalcTests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestTriangleCreateNegSide()
        {
            // Сторона отрицательная, ошибка
            Action create = () => new Triangle(-5, 3, 4);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateNegSides()
        {
            // Отрицательны все стороны, ошибка
            Action create = () => new Triangle(-5, -3, -4);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateNonExists1()
        {
            // Не выполняется неравенство тре-ка, одна сторона больше суммы других, ошибка
            Action create = () => new Triangle(4, 2, 1);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateNonExists2()
        {
            // Не выполняется неравенство тре-ка, одна сторона равна сумме других, ошибка
            Action create = () => new Triangle(3, 2, 1);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateWrongSidesCount()
        {
            // Слишком много сторон, конструктор из списка
            var sides = new List<double> { 3, 5, 6, 7 };
            Action create = () => new Triangle(sides);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreate()
        {
            // Обычный треугольник, корректно
            var fig = new Triangle(3, 5, 6);
        }

        [TestMethod]
        public void TestTriangleCreateFromList()
        {
            // Обычный треугольник, конструктор из списка сторон, корректно
            var sides = new List<double> { 3, 5, 6 };
            var fig = new Triangle(sides);
        }

        [TestMethod]
        public void TestTriangleAreaRight1()
        {
            // Прямоугольный тре-к, площадь 6
            var fig = new Triangle(3, 4, 5);
            Assert.AreEqual<double>(fig.Area, 6.0);
        }

        [TestMethod]
        public void TestTriangleAreaRight2()
        {
            // Прямоугольный тре-к, площадь 30
            var fig = new Triangle(5, 12, 13);
            Assert.AreEqual<double>(fig.Area, 30.0);
        }

        [TestMethod]
        public void TestTriangleAreaDefault()
        {
            // Площадь треугольника со сторонами 3.3, 8, 5.7 = 7.87
            var fig = new Triangle(3.3, 8, 5.7);
            Assert.AreEqual<double>(Math.Round(fig.Area, 2), 7.87);
        }
    }
}