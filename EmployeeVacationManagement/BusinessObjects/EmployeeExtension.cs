using System;
using EmployeeVacationManagement.Models;

namespace EmployeeVacationManagement.BusinessObjects
{
    public class EmployeeExtension
    {
        public static IList<EmployeeViewModel>? Employees { get; set; }

        public static void SetEmployees()
        {
            if (Employees is null)
            {
                Employees = new List<EmployeeViewModel>()
                {
                    new EmployeeViewModel(){EmployeeId= 1,EmployeeName="A",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 2 ,EmployeeName="B",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 3 ,EmployeeName="C",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 4 ,EmployeeName="D",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 5 ,EmployeeName="E",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 6 ,EmployeeName="F",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 7 ,EmployeeName="G",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 8 ,EmployeeName="H",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 9 ,EmployeeName="I",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 10 ,EmployeeName="J",EmployeeType=EmployeeType.Hourly},
                    new EmployeeViewModel(){EmployeeId= 11 ,EmployeeName="K",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 12 ,EmployeeName="L",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 13 ,EmployeeName="M",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 14 ,EmployeeName="N",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 15 ,EmployeeName="O",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 16 ,EmployeeName="P",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 17 ,EmployeeName="Q",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 18 ,EmployeeName="R",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 19 ,EmployeeName="S",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 20,EmployeeName="T",EmployeeType=EmployeeType.Salaried},
                    new EmployeeViewModel(){EmployeeId= 21 ,EmployeeName="U",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 22 ,EmployeeName="V",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 23 ,EmployeeName="W",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 24 ,EmployeeName="X",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 25 ,EmployeeName="Y",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 26 ,EmployeeName="Z",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 27 ,EmployeeName="AB",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 28 ,EmployeeName="BC",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 29 ,EmployeeName="CD",EmployeeType=EmployeeType.Manager},
                    new EmployeeViewModel(){EmployeeId= 30 ,EmployeeName="EF",EmployeeType=EmployeeType.Manager},

                };
            }

        }

    }
}

