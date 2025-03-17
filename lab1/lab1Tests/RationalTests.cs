using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Tests
{
    [TestClass()]
    public class RationalTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Rational tmp = new Rational(3, 4);
            Assert.AreEqual("3/4", tmp.ToString());
        }
        [TestMethod()]
        public void ToStringNegativeTest() 
        { 
            Rational tmp1 =  new Rational (-4, 5);
            Rational tmp2 = new Rational(4, -5);
            Assert.AreEqual(tmp1.ToString(), tmp2.ToString());
            
            Rational tmp = new Rational(-4, -5);
            Assert.AreEqual("4/5", tmp.ToString());
        }

        [TestMethod()]
        public void ReductionTest()
        {
            Rational tmp =new Rational(3, 6);
            Assert.IsTrue("1/2"==tmp.ToString());
        }

        [TestMethod()]
        public void WholeTest()
        {
            Rational tmp = new Rational(3, 1);
            Assert.IsTrue("3"==tmp.ToString());
        }

        [TestMethod()]
        public void AddTest() 
        {
            Rational tmp = new Rational(2, 5);
            Rational res = tmp + new Rational(1, 2);
            Assert.AreEqual("9/10", res.ToString());
        }

        [TestMethod()]
        public void SubTest()
        {
            Rational tmp = new Rational(2, 5);
            Rational res = tmp - new Rational(1, 2);
            Assert.AreEqual("-1/10", res.ToString());
        }

        [TestMethod()]
        public void MulTest()
        {
            Rational tmp = new Rational(2, 5);
            Rational res = tmp *new Rational(1, 2);
            Assert.AreEqual("1/5", res.ToString());
        }

        [TestMethod()]
        public void DivTest()
        {
            Rational tmp = new Rational(2, 5);
            Rational res = tmp/new Rational(1, 2);
            Assert.AreEqual("4/5", res.ToString());
        }

        [TestMethod()]
        public void UnSubTest()
        {
            Rational tmp = -new Rational(1, 3);
            Assert.AreEqual("-1/3", tmp.ToString());

            tmp = -new Rational(-1, 3);
            Assert.AreEqual("1/3", tmp.ToString());
        }

        [TestMethod()]
        public void EqualTest()
        {
            Rational tmp1 = new Rational(1, 2);
            Rational tmp2 = new Rational(1, 2);
            Rational tmp3 = new Rational(1, 4);
            Assert.IsTrue(tmp1==tmp2);
            Assert.IsFalse(tmp2==tmp3);
        }

        [TestMethod()]
        public void NotEqualTest()
        {
            Rational tmp1 = new Rational(1, 2);
            Rational tmp2 = new Rational(1, 2);
            Rational tmp3 = new Rational(1, 4);
            Assert.IsTrue(tmp1 != tmp3);
            Assert.IsFalse(tmp1 != tmp2);
        }

        [TestMethod()]
        public void LessTest()
        {
            Rational tmp1 = new Rational(1, 2);
            Rational tmp2 = new Rational(3 , 4);
            Assert.IsTrue(tmp1< tmp2);
        }

        [TestMethod()]
        public void MoreTest()
        {
            Rational tmp1 = new Rational(1, 2);
            Rational tmp2 = new Rational(3, 4);
            Assert.IsTrue(tmp2 >tmp1);
        }
        [TestMethod()]
        public void LessOrEqualTest()
        {
              Rational tmp1 = new Rational(1, 2);
              Rational tmp2 = new Rational(3, 6);
              Rational tmp3 = new Rational(-1, 4);
            Assert.IsTrue(tmp1 <= tmp2);
            Assert.IsFalse(tmp1 <= tmp3);
        }

        [TestMethod()]
        public void MoreOrEqualTest()
        {
            Rational tmp1 = new Rational(1, 2);
            Rational tmp2 = new Rational(3, 6);
            Rational tmp3 = new Rational(-1, 4);
            Assert.IsTrue(tmp1 >= tmp2);
            Assert.IsTrue(tmp1 >= tmp3);
        }
    }
}