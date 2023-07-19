using System;
using EmployeeVacationManagement.Models;

namespace EmployeeVacationManagement.BusinessObjects
{
    public class SalariedEmployee : Employee
    {
        public static readonly int MaxVacationDays = 15;
        public EmployeeViewModel EmployeeVM { get; set; }

        public override void TakeVacation(float usedVacationDays)
        {
            EmployeeVM.AccumulatedVacationDays -= usedVacationDays;
        }

        public override void Work(int daysWorked)
        {
            EmployeeVM.AccumulatedVacationDays = ((daysWorked * MaxVacationDays) / WorkDaysPerYear);
        }
    }
}

