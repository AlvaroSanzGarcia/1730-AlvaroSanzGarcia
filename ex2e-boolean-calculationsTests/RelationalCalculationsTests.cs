using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex2e_boolean_calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2e_boolean_calculations.Tests
{
    [TestClass()]
    public class RelationalCalculationsTests
    {
        [TestMethod()]
        public void IsFrankTest()
        {
            Assert.IsTrue(RelationalCalculations.IsFrank("Frank"));
        }
        
        [TestMethod()]
        public void IsNotFrankTest()
        {
            Assert.IsFalse(RelationalCalculations.IsFrank("James"));
        }



        [TestMethod()]
        public void IsEmptykTest()
        {
            Assert.IsTrue(RelationalCalculations.IsEmpty(""));
        }

        [TestMethod()]
        public void IsNotEmptykTest()
        {
            Assert.IsFalse(RelationalCalculations.IsEmpty("hello"));
        }



        [TestMethod()]
        public void IsTwoPointThreeTest()
        {
            Assert.IsTrue(RelationalCalculations.IsTwoPointThree(2.3m));
        }

        [TestMethod()]
        public void IsNotTwoPointThreeTest()
        {
            Assert.IsFalse(RelationalCalculations.IsTwoPointThree(2.8m));
        }



        [TestMethod()]
        public void IsFalseTest()
        {
            Assert.IsTrue(RelationalCalculations.IsFalse(false));
        }

        [TestMethod()]
        public void IsNotFalseTest()
        {
            Assert.IsFalse(RelationalCalculations.IsFalse(true));
        }



        [TestMethod()]
        public void AreEqualTest()
        {
            Assert.IsTrue(RelationalCalculations.AreEqual(4,4));
        }

        [TestMethod()]
        public void AreNotEqualTest()
        {
            Assert.IsFalse(RelationalCalculations.AreEqual(4, 7));
        }



        [TestMethod()]
        public void IsNotJonesTest()
        {
            Assert.IsTrue(RelationalCalculations.IsNotJones("Mark"));
        }

        [TestMethod()]
        public void IsJonesTest()
        {
            Assert.IsFalse(RelationalCalculations.IsNotJones("Jones"));
        }



        [TestMethod()]
        public void IsLargerThanZeroTest()
        {
            Assert.IsTrue(RelationalCalculations.IsLargerThanZero(1));
        }

        [TestMethod()]
        public void IsNotLargerThanZeroTest()
        {
            Assert.IsFalse(RelationalCalculations.IsLargerThanZero(0));
        }



        [TestMethod()]
        public void IsLessThanTest()
        {
            Assert.IsTrue(RelationalCalculations.IsLessThan(2, 4));
        }

        [TestMethod()]
        public void IsNotLessThanTest()
        {
            Assert.IsFalse(RelationalCalculations.IsLessThan(4, 2));
        }



        [TestMethod()]
        public void IsLargerOrEqualsThan500Test1()
        {
            Assert.IsTrue(RelationalCalculations.IsLargerOrEqualsThan500(500));
        }

        [TestMethod()]
        public void IsLargerOrEqualsThan500Test2()
        {
            Assert.IsTrue(RelationalCalculations.IsLargerOrEqualsThan500(500.0000001m));
        }

        [TestMethod()]
        public void IsNotLargerOrEqualsThan500Test()
        {
            Assert.IsFalse(RelationalCalculations.IsLargerOrEqualsThan500(499));
        }



        [TestMethod()]
        public void IsLessOrEqualsThanTest1()
        {
            Assert.IsTrue(RelationalCalculations.IsLessOrEqualsThan(4,4));
        }

        [TestMethod()]
        public void IsLessOrEqualsThanTest2()
        {
            Assert.IsTrue(RelationalCalculations.IsLessOrEqualsThan(3.99999999m, 4));
        }

        [TestMethod()]
        public void IsNotLessOrEqualsThanTest()
        {
            Assert.IsFalse(RelationalCalculations.IsLessOrEqualsThan(5, 4));
        }
    }
}