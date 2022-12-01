namespace ClockHandAngleCalculator.Validations
{
    public class HourValidator
    {
        public bool IsValid(string hours)
        {
            try
            {
                int.Parse(hours);
            }
            catch
            {
                return false;
            }

            return int.Parse(hours) <= 12 && int.Parse(hours) > 0;
        }
    }
}