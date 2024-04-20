using AngleCalculation.ClockFormat;
using AngleCalculation.Models;
using AngleCalculation.Services;
using AngleCalculation.Services.CalculateAngleService;
using AngleCalculation.Services.ValidationService;

class Program
{
    public static void Main()
    {

        var clock = new ClockModel()
        {
            ArrowHour = 13,
            ArrowMinute = 60,
            Format = ClockFormat.TwentyFour
        };

        ClockAngleManager clockAngleManager = new ClockAngleManager(clock, new AngleBetweenHourAndMinute(), new ValidationService());
        clockAngleManager.Calculate(clock);
    }
}