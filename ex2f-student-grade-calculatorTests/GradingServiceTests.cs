using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex2f_student_grade_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2f_student_grade_calculator.Tests
{
    [TestClass()]
    public class GradingServiceTests
    {
        [TestMethod()]
        public void Expect_A_WhenAverageIsBetween90and100()
        {
            double average = 90;
            string expectedGrade = "A";
            string actualGrade = GradingService.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod()]
        public void Expect_B_WhenAverageIsBetween80and89()
        {
            double average = 83;
            string expectedGrade = "B";
            string actualGrade = GradingService.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod()]
        public void Expect_C_WhenAverageIsBetween70and79()
        {
            double average = 75;
            string expectedGrade = "C";
            string actualGrade = GradingService.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod()]
        public void Expect_D_WhenAverageIsBetween60and69()
        {
            double average = 60;
            string expectedGrade = "D";
            string actualGrade = GradingService.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod()]
        public void Expect_F_WhenAverageIsLessThan60()
        {
            double average = 59;
            string expectedGrade = "F";
            string actualGrade = GradingService.EvaluateGrade(average);
            Assert.AreEqual(expectedGrade, actualGrade);
        }


    }
}