using System;
using EmployeeVacationManagement.Models;

namespace EmployeeVacationManagement.BusinessObjects
{
    public abstract class Employee
    {
        public const int WorkDaysPerYear = 260;
        public EmployeeViewModel EmployeeVM { get; set; }

        public abstract void Work(int daysWorked);

        public abstract void TakeVacation(float usedVacationDays);
    }
}

