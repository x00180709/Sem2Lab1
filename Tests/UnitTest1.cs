using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;

namespace Tests
{
    [TestClass]
    public class BMICalc_Verify
    {
        [TestMethod]
        public void TestMethod1()
        {
            BMI bmi = new BMI { WeightStones = 15, WeightPounds = 10, HeightFeet = 6, HeightInches = 2 };
            Assert.AreNotEqual(bmi.BMICategory, BMICategory.Normal);
        }
        public void TestMethod2()
        {
            BMI bmi = new BMI { WeightStones = 12, WeightPounds = 10, HeightFeet = 6, HeightInches = 2 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
        }
    }
}