using System.Drawing;

namespace TestProject1
{
    [TestClass]
    public sealed class TestForTask2
    {
        [DataTestMethod]
        [DataRow(10, 20)]
        [DataRow(1.2, 1.2)]
        [DataRow(15, 1)]
        public void Test_Area(double a, double b)
        {
            Rectangle ob = new Rectangle(a, b);

            double area = a*b;

            Assert.AreEqual(area, ob.Area);
        }

        [DataTestMethod]
        [DataRow(10, 20)]
        [DataRow(1.2, 1.2)]
        [DataRow(5, 5)]
        public void Test_Perimeter(double a, double b)
        {
            Rectangle ob = new Rectangle(a, b);

            double perim = (a + b)*2;

            Assert.AreEqual(perim, ob.Perimeter);
        }
    }


}
