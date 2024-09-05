using AreaCalc.figures;

namespace AreaCalcTests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestTriangleCreateNegSide()
        {
            // ������� �������������, ������
            Action create = () => new Triangle(-5, 3, 4);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateNegSides()
        {
            // ������������ ��� �������, ������
            Action create = () => new Triangle(-5, -3, -4);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateNonExists1()
        {
            // �� ����������� ����������� ���-��, ���� ������� ������ ����� ������, ������
            Action create = () => new Triangle(4, 2, 1);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateNonExists2()
        {
            // �� ����������� ����������� ���-��, ���� ������� ����� ����� ������, ������
            Action create = () => new Triangle(3, 2, 1);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreateWrongSidesCount()
        {
            // ������� ����� ������, ����������� �� ������
            var sides = new List<double> { 3, 5, 6, 7 };
            Action create = () => new Triangle(sides);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void TestTriangleCreate()
        {
            // ������� �����������, ���������
            var fig = new Triangle(3, 5, 6);
        }

        [TestMethod]
        public void TestTriangleCreateFromList()
        {
            // ������� �����������, ����������� �� ������ ������, ���������
            var sides = new List<double> { 3, 5, 6 };
            var fig = new Triangle(sides);
        }

        [TestMethod]
        public void TestTriangleAreaRight1()
        {
            // ������������� ���-�, ������� 6
            var fig = new Triangle(3, 4, 5);
            Assert.AreEqual<double>(fig.Area, 6.0);
        }

        [TestMethod]
        public void TestTriangleAreaRight2()
        {
            // ������������� ���-�, ������� 30
            var fig = new Triangle(5, 12, 13);
            Assert.AreEqual<double>(fig.Area, 30.0);
        }

        [TestMethod]
        public void TestTriangleAreaDefault()
        {
            // ������� ������������ �� ��������� 3.3, 8, 5.7 = 7.87
            var fig = new Triangle(3.3, 8, 5.7);
            Assert.AreEqual<double>(Math.Round(fig.Area, 2), 7.87);
        }
    }
}