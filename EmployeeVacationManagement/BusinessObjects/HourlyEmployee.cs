using System;
using EmployeeVacationManagement.Models;

namespace EmployeeVacationManagement.BusinessObjects
{
    public class HourlyEmployee : Employee
    {
        public static readonly int MaxVacationDays = 10;
        public EmployeeViewModel EmployeeVM { get; set; }

        public override void Work(int daysWorked)
        {
            EmployeeVM.AccumulatedVacationDays = ((daysWorked * MaxVacationDays) / WorkDaysPerYear);
        }

        public override void TakeVacation(float usedVacationDays)
        {
            EmployeeVM.AccumulatedVacationDays -= usedVacationDays;
        }

 
    }

}

