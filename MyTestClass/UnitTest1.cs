using NUnit.Framework;
using MyLogicClass;

namespace MyTestClass
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Add()
        {
            MyMath m = new MyMath();
            int ex = 12;
            int actual = m.add(3,4);
            Assert.AreEqual(ex, actual, "MyMath.add has a problem there!!");
        }
        [Test]
        public void Test_Mul()
        {
            MyMath m = new MyMath();
            int ex = 12;
            int actual = m.mul(3, 4);
            Assert.AreEqual(ex, actual, "MyMath.mul has a problem there!!");
        }
    }
}