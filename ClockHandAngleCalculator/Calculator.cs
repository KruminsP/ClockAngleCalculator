using System;

namespace ClockHandAngleCalculator
{
    public class Calculator
    {
        public double Calculation(string hourString, string minuteString)
        {
            var hours = int.Parse(hourString);
            hours = hours == 12 ? 0 : hours;
            var minutes = int.Parse(minuteString);
            var totalMinutes = hours * 60 + minutes;

            var degreesPerMinute = 6;
            var hourHandDegreesPerMinute = 0.5;

            var minuteHandAngle = minutes * degreesPerMinute;
            var hourHandAngle = totalMinutes * hourHandDegreesPerMinute;

            var angleBetweenHands = Math.Abs(hourHandAngle - minuteHandAngle);

            if (angleBetweenHands > 180)
            {
                angleBetweenHands = 360 - angleBetweenHands;
            }

            return angleBetweenHands;
        }
    }
}