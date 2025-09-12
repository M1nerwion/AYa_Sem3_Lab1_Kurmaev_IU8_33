namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        [DataTestMethod]
        [DataRow(-2, -2)]
        [DataRow(-2, 2)]
        [DataRow(2, 2)]
        [DataRow(2, -2)]
        public void TestConstructorPoint(int a, int b)
        {
            Point ob = new Point(a, b);

            Assert.AreEqual(ob.X, a);
            Assert.AreEqual(ob.Y, b);
        }


        [TestMethod]
        public void TestConstructor3()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 3); 
            Point c = new Point(3, 0);

            Figure ob = new Figure(a, b, c);

            Assert.AreEqual(ob.Name, "Треугольник");
        }


        [TestMethod]
        public void TestConstructor4()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 3);
            Point c = new Point(3, 3);
            Point d = new Point(3, 0);

            Figure ob = new Figure(a, b, c, d);

            Assert.AreEqual(ob.Name, "Четырёхугольник");
        }

        [TestMethod]
        public void TestConstructor5()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 3);
            Point c = new Point(3, 3);
            Point e = new Point(5, 1);
            Point d = new Point(3, 0);

            Figure ob = new Figure(a, b, c, d, e);

            Assert.AreEqual(ob.Name, "Пятиугольник");
        }

        [TestMethod]
        public void TestLengthSide()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 3);
            Point c = new Point(2, 3);
            Point e = new Point(5, 1);
            Point d = new Point(5, 0);

            Figure ob = new Figure(a, b, c, d, e);

            Assert.AreEqual(ob.LengthSide(a, b), 3);
            Assert.AreEqual(ob.LengthSide(e, d), 1);
            Assert.AreEqual(ob.LengthSide(b, c), 2);
        }

        [TestMethod]
        public void TestPerimeterCalculator()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 3);
            Point c = new Point(3, 3);
            Point d = new Point(3, 0);

            Figure ob1 = new Figure(a, b, c, d);
            Figure ob2 = new Figure(a, b, c);

            Assert.AreEqual(ob1.PerimeterCalculator(), 12);
            Assert.AreEqual(ob2.PerimeterCalculator(), 6+Math.Sqrt(18));
        }
    }
}
