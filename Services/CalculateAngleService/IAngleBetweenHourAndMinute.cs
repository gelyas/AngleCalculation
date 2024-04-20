using AngleCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleCalculation.Services.CalculateAngleService
{
    public interface IAngleBetweenHourAndMinute
    {
        void Calculate(ClockModel clock);
        void PrintResult();
    }
}
