using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class HiringDate
    {
        #region properties
        public virtual int Day { get; set; }
        public virtual int Month { get; set; }
        public virtual int Year { get; set; }

        #endregion

        #region constructor
        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                Console.WriteLine("InvalidDate");
            }
            else
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Hiring Date is {Day:D2}-{Month:D2}-{Year}";
        }

        

        #endregion
    }
}
