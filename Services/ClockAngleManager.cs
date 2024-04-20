using AngleCalculation.Models;
using AngleCalculation.Services.CalculateAngleService;
using AngleCalculation.Services.ValidationService;


namespace AngleCalculation.Services
{
    public class ClockAngleManager
    {
        private readonly IAngleBetweenHourAndMinute angleBetweenHourAndMinute;
        private readonly IValidationService validationService;
        private readonly ClockModel clock;

        public ClockAngleManager(ClockModel clock, IAngleBetweenHourAndMinute angleBetweenHourAndMinute, IValidationService validationService)
        {
            this.angleBetweenHourAndMinute = angleBetweenHourAndMinute;
            this.validationService = validationService;
            this.clock = clock;
        }

        public void Calculate(ClockModel clock)
        {
            if (!validationService.CheckValidData(clock))
            {
                throw new Exception("Ошибка при валидации.");
            }
            angleBetweenHourAndMinute.Calculate(clock);
            angleBetweenHourAndMinute.PrintResult();
        }
    }
}
