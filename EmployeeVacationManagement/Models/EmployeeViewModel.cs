using System;
namespace EmployeeVacationManagement.Models
{
    public class EmployeeViewModel
    {       
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int WorkDays { get; set; }

        public float UsedVacationDays { get; set; }
    
        public float AccumulatedVacationDays { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public EmployeeViewModel()
        {
            AccumulatedVacationDays = 0;
        }
    }
    public enum EmployeeType
    {
        Hourly = 1,
        Salaried = 2,
        Manager = 3
    }
}

