using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01.Range_Values
{
    // Generic class Range<T> that can be used to represent a range of values
    internal class Range<T> where T : IComparable<T>
    {
        #region Properties to hold the start and end of the range
        // Properties to hold the start and end of the range:
        public T Maximum { get; set; }
        public T Minimum { get; set; }
        #endregion

        #region Constructor to initialize the range with minimum and maximum values
        // Constructor to initialize the range with minimum and maximum values:
        public Range(T Maximum, T Minimum)
        {
            this.Maximum = Maximum;
            this.Minimum = Minimum;
        }
        #endregion

        #region Method to check if a value is within the range
        // Method to check if a value is within the range:
        public bool IsInRange(T Value)
        {
            return Value.CompareTo(Minimum) >= 0 && Value.CompareTo(Maximum) <= 0;
        }
        #endregion

        #region Method to Get Length of the range
        // Method to Get Length of the range:
        public double Get_Length()
        {
            return Convert.ToDouble(Maximum) - Convert.ToDouble(Minimum);
        }
        #endregion
    }
}
