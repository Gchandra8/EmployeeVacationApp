using System;
using EmployeeVacationManagement.Models;

namespace EmployeeVacationManagement.BusinessObjects
{
    public class Manager : SalariedEmployee
    {
        public static new readonly int MaxVacationDays = 30;
        public override void TakeVacation(float usedVacationDays)
        {
            EmployeeVM.AccumulatedVacationDays -= usedVacationDays;
        }

        public override void Work(int daysWorked)
        {
            EmployeeVM.AccumulatedVacationDays = ((daysWorked * MaxVacationDays) / WorkDaysPerYear) ;
        }
    }
}

