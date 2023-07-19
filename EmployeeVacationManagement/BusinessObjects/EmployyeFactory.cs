using System;
namespace EmployeeVacationManagement.BusinessObjects
{
    public class EmployeeFactory
    {
        public readonly HourlyEmployee _hourlyEmployee;
        public readonly SalariedEmployee _salariedEmployee;
        public readonly Manager _manager;

        public EmployeeFactory()
        {
            _hourlyEmployee = new HourlyEmployee();
            _salariedEmployee = new SalariedEmployee();
            _manager = new Manager();
        }
    }

}

