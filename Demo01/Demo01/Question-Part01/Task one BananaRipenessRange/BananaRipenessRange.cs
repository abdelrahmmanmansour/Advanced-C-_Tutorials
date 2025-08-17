using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01.Task_one_BananaRipenessRange
{
    #region Notes
    // Generic class definition for BananaRipenessRange
    // Why I Make where T : IComparable<T>?!:
    // Because The Operator >= and <= are used in the IsPerfectBanana method(he make error),
    // So I Make This Class Constraint to ensure that T supports comparison operations.
    // So , T must implement the IComparable<T> interface. 
    #endregion
    internal class BananaRipenessRange<T> where T : IComparable<T>
    {
        #region Properties to hold the minimum and maximum ripeness values
        // Properties to hold the minimum and maximum ripeness values:
        public T Min { get; set; }
        public T Max { get; set; }
        #endregion

        #region Constructor to initialize the minimum and maximum ripeness values
        // Constructor to initialize the minimum and maximum ripeness values:
        public BananaRipenessRange(T Min, T Max)
        {
            this.Min = Min;
            this.Max = Max;
        }
        #endregion

        #region Method to check if a given ripeness value is within the perfect range
        // Method to check if a given ripeness value is within the perfect range:
        public bool IsPerfectBanana(T Ripeness)
        {
            if (Ripeness.CompareTo(Min) >= 0 && Ripeness.CompareTo(Max) <= 0)
            {
                return true; // The banana is within the perfect ripeness range
            }
            else
            {
                return false; // The banana is not within the perfect ripeness range
            }
        }
        #endregion
    }
}
