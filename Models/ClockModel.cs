using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleCalculation.ClockFormat;

namespace AngleCalculation.Models
{
    public class ClockModel
    {
        public int ArrowHour { get; set; }
        public int ArrowMinute { get; set;}
        public ClockFormat.ClockFormat Format { get; set;}
    }
}
