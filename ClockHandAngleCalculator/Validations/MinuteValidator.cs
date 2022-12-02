namespace ClockHandAngleCalculator.Validations
{
    public class MinuteValidator
    {
        public bool IsValid(string minutes)
        {
            var parseResult = int.TryParse(minutes, out var intMinute);

            return intMinute is < 60 and > 0 && parseResult;
        }
    }
}