namespace ClockHandAngleCalculator.Validations
{
    public class MinuteValidator
    {
        public bool IsValid(string minutes)
        {
            try
            {
                int.Parse(minutes);
            }
            catch
            {
                return false;
            }

            return int.Parse(minutes) < 60 && int.Parse(minutes) >= 0;
        }
    }
}