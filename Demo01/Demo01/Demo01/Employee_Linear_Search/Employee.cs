using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Employee_Linear_Search
{
    internal class Employee : IEquatable<Employee>, IEqualityComparer<Employee>, IComparer<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }

        public bool Equals(Employee? other)
        {
            if (other is not null)
            {
                return this == other;
            }
            return false;
        }

        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            // Built in Struct
            return HashCode.Combine(obj.Name);
        }

        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        //public override bool Equals(object? obj)
        //{
        //    Employee employee = obj as Employee;
        //    return this == employee;
        //}
    }
}
