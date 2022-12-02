using ClockHandAngleCalculator.Validations;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockHandAngleCalculator.Tests
{
    [TestClass]
    public class HourValidatorTests
    {
        private HourValidator _hourValidator;

        [TestInitialize]
        public void Setup()
        {
            _hourValidator = new HourValidator();
        }

        [TestMethod]
        public void IsValid_EnterValidHour_ReturnsTrue()
        {
            var hours = "6";

            bool result = _hourValidator.IsValid(hours);

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsValid_EnterInvalidHour_ReturnsFalse()
        {
            var hours = "42";

            bool result = _hourValidator.IsValid(hours);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsValid_EnterEmptyString_ReturnsFalse()
        {
            var hours = "";

            bool result = _hourValidator.IsValid(hours);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsValid_EnterInvalidCharacters_ReturnsFalse()
        {
            var hours = "no";

            bool result = _hourValidator.IsValid(hours);

            result.Should().BeFalse();
        }
    }
}