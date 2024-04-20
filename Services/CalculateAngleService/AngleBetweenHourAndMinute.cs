using AngleCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleCalculation.Services.CalculateAngleService
{
    public class AngleBetweenHourAndMinute : IAngleBetweenHourAndMinute
    {
        private double angleResult;
        void IAngleBetweenHourAndMinute.Calculate(ClockModel clock)
        {
            //double minuteRes = (double)clock.ArrowMinute/ 60; //от часа
            //double angleBeetweenHourAndHourMinute = 30 * minuteRes; //угол между 8 и 8 24
            //double angleBetweenNullAndHourMinute = 30 * clock.ArrowHour + angleBeetweenHourAndHourMinute; // Между временем 00.00 и часовой стрелкой в 8.24 будет угол
            //double angelBetweenNullAndMinute = 360 * clock.ArrowMinute / 60;

            //double angleBetweenHourAndMinute = angleBetweenNullAndHourMinute - angelBetweenNullAndMinute;

            //angleResult = angleBetweenHourAndMinute;

            angleResult = 30 * clock.ArrowHour + 0.5 * clock.ArrowMinute - 6 * clock.ArrowMinute;
        }

        public void PrintResult()
        {
            Console.WriteLine(angleResult);
        }
    }
}
