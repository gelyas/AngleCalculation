using AngleCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleCalculation.Services.ValidationService
{
    public interface IValidationService
    {
        string Message { get; set; }
        bool CheckValidData(ClockModel clock);
    }
}
