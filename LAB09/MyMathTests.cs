using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    [TestFixture]
    class MyMathTests
    {
        [TestCase]
        public void Add01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(31, math.Add(11, 20));
        }

        [TestCase]
        public void Add02()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(31, math.Add(20, 11));
        }
        [TestCase]
        public void Add03()
        {
            MyMath math = new MyMath();
            Assert.IsTrue(math.Add(-10, 10) == 0);
        }

        [TestCase]
        public void Add04()
        {
            MyMath math = new MyMath();
            Assert.That(math.Add(20, 11), Is.AtLeast(20));
        }
        [TestCase]
        public void Sub01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(10, math.Sub(20, 10));
        }

        [TestCase]
        public void Sub02()
        {
            MyMath math = new MyMath();
            Assert.IsFalse(math.Sub(-10, 10) == 0);
        }

        [TestCase]
        public void Sub03()
        {
            MyMath math = new MyMath();
            Assert.AreNotEqual(math.Sub(20, 10), math.Sub(10, 20));
        }

        [TestCase]
        public void Mul01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(-10, math.Mul(2, -5));
        }

        [TestCase]
        public void Mul02()
        {
            MyMath math = new MyMath();
            Assert.IsNotNull(math.Mul(12, 1024));
        }

        [TestCase]
        public void Mul03()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(math.Mul(12, 1024), math.Mul(1024, 12));
        }

        [TestCase]
        public void Mul04()
        {
            MyMath math = new MyMath();
            Assert.That(math.Mul(12, 1024), Is.Not.Null);
        }

        [TestCase]
        public void IntDiv01()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(2, math.IntDiv(5, 2));
        }
    }
}
