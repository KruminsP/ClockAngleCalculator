namespace ClockHandAngleCalculator.Validations
{
    public class HourValidator
    {
        public bool IsValid(string hours)
        {
            var parseResult = int.TryParse(hours,out var intHour);

            return intHour is <= 12 and > 0 && parseResult;
        }
    }
}