using AreaCalc.figures;

namespace AreaCalcTests
{
    [TestClass]
    public class UnitTestPolygon
    {
        [TestMethod]
        public void TestPolygonCreateBelowZeroSide()
        {
            // ���� �� ������ �������������� ����� �����. �����
            var sides = new List<double> { 3, 5, 2, 6, 7, -8, 10, 11 };
            Action create = () => new Polygon(sides);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestPolygonCreateBelowZeroSides()
        {
            // ��������� ������ �������������� ����� �����. �����
            var sides = new List<double> { 3, 5, 2, -6, 7, -8, 10, -11 };
            Action create = () => new Polygon(sides);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestPolygonCreate()
        {
            // ���������� �������� ��-��
            var sides = new List<double> { 3, 5, 2, 6, 7, 8, 10, 11 };
            var fig = new Polygon(sides);
        }

        [TestMethod]
        public void TestPolygonAreaCall()
        {
            // ����� ���������������� ������, ������
            var sides = new List<double> { 3, 5, 2, 6, 7, 8, 10, 11 };
            var fig = new Polygon(sides);
            double res = 0.0;
            Action act = () => res = fig.Area;
            Assert.ThrowsException<NotImplementedException>(act);
        }
    }
}