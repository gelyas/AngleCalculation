using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleCalculation.ClockFormat;
using AngleCalculation.Models;

namespace AngleCalculation.Services.ValidationService
{
    internal class ValidationService : IValidationService
    {
        string IValidationService.Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CheckValidData(ClockModel clock)
        {
            switch (clock.Format)
            {
                case ClockFormat.ClockFormat.Twelwe:
                    if (clock.ArrowHour >= (int)ClockFormat.ClockFormat.Twelwe)
                    {
                        throw new Exception($"При выбранном диапозоне 12 часов не может быть более {(int)clock.Format}. Выборите другой формат времени");
                        //return false;
                    }
                    if (clock.ArrowHour <= 0)
                    {
                        throw new Exception($"При выбранном диапозоне 12 часов не может быть меньше или равно 0");
                        //return false;
                    }
                    break;

                case ClockFormat.ClockFormat.TwentyFour:
                    if (clock.ArrowHour >= (int)ClockFormat.ClockFormat.TwentyFour)
                    {
                        throw new Exception($"При выбранном диапозоне 24 часов не может быть более {(int)clock.Format}");
                        //return false;
                    }
                    else if (clock.ArrowHour <= 0)
                    {
                        throw new Exception($"При выбранном диапозоне 24 часов не может быть менее или равно 0");
                        //return false;
                    }
                    break;
            }

            return true;
        }
    }
}
