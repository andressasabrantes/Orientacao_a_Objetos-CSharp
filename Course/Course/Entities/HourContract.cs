using System;

namespace Course.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerhour { get; set; }
        public int Hours { get; set; }

        public HourContract() 
        { 
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerhour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerhour;
        }
    }
}
