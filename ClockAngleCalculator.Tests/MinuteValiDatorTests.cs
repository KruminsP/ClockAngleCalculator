using ClockHandAngleCalculator.Validations;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockHandAngleCalculator.Tests
{
    [TestClass]
    public class MinuteValidatorTests
    {
        private MinuteValidator _minuteValidator;

        [TestInitialize]
        public void Setup()
        {
            _minuteValidator = new MinuteValidator();
        }

        [TestMethod]
        public void IsValid_EnterValidHour_ReturnsTrue()
        {
            var minutes = "59";

            bool result = _minuteValidator.IsValid(minutes);

            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsValid_EnterInvalidHour_ReturnsFalse()
        {
            var minutes = "100";

            bool result = _minuteValidator.IsValid(minutes);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsValid_EnterEmptyString_ReturnsFalse()
        {
            var minutes = "";

            bool result = _minuteValidator.IsValid(minutes);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsValid_EnterInvalidCharacters_ReturnsFalse()
        {
            var minutes = "boo";

            bool result = _minuteValidator.IsValid(minutes);

            result.Should().BeFalse();
        }
    }
}
