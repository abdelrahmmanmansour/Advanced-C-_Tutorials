using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Employees
{
    class EmployeeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee emp1 = x as Employee;
            Employee emp2 = y as Employee;
            return emp1.Age.CompareTo(emp2.Age);
        }
    }
    class EmployeeGenenreicComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int Compare(object? x, object? y)
        {
            Employee emp1 = x as Employee;
            Employee emp2 = y as Employee;
            return emp1.Age.CompareTo(emp2.Age);
        }

        public int CompareTo(object? obj)
        {
            Employee E = (Employee)obj;
            return this.Age.CompareTo(E.Age);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

    }
}
