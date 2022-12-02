using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockHandAngleCalculator.Tests
{
    [TestClass]
    public class AngleCalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void CalculateAngle_SixFifteen_ReturnsAngle()
        {
            var hours = "6";
            var minutes = "15";

            var angle = _calculator.Calculation(hours, minutes);

            angle.Should().Be(97.5);
        }

        [TestMethod]
        public void CalculateAngle_OneFortyTwo_ReturnsAngle()
        {
            var hours = "1";
            var minutes = "42";

            var angle = _calculator.Calculation(hours, minutes);

            angle.Should().Be(159);
        }

        [TestMethod]
        public void CalculateAngle_NineOClock_ReturnsAngle()
        {
            var hours = "9";
            var minutes = "0";

            var angle = _calculator.Calculation(hours, minutes);

            angle.Should().Be(90);
        }
    }
}
