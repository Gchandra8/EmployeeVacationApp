using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeVacationManagement.BusinessObjects;
using EmployeeVacationManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeVacationManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeFactory _employeeFactory;

        public EmployeeController(EmployeeFactory employeeFactory)
        {
            _employeeFactory = employeeFactory;
        }

        // GET: EmployeeControler
        public ActionResult Index()
        {
            return View(EmployeeExtension.Employees);
        }

        // GET: EmployeeControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View(EmployeeExtension.Employees?.Where(i => i.EmployeeId == id).Single());
        }

        [HttpPost]
        public string SubmitValidation(int id, int workDays , float usedVacationDays, string employeeType)
        {
            var matchedEmployeeVM = EmployeeExtension.Employees?.Where(i => i.EmployeeId == id).Single();
            int vacationDaysPerYear = 0 ;
                 switch (employeeType)
                {
                    case "Hourly":
                        _employeeFactory._hourlyEmployee.EmployeeVM = matchedEmployeeVM;
                         vacationDaysPerYear = HourlyEmployee.MaxVacationDays;
                        _employeeFactory._hourlyEmployee.Work(Convert.ToInt32(workDays));
                        _employeeFactory._hourlyEmployee.TakeVacation(usedVacationDays);
                        break;
                    case "Salaried":
                        _employeeFactory._salariedEmployee.EmployeeVM = matchedEmployeeVM;
                        vacationDaysPerYear = SalariedEmployee.MaxVacationDays;
                    _employeeFactory._salariedEmployee.Work(Convert.ToInt32(workDays));
                        _employeeFactory._salariedEmployee.TakeVacation(usedVacationDays);
                        break;
                    case "Manager":
                        _employeeFactory._manager.EmployeeVM = matchedEmployeeVM;
                        vacationDaysPerYear = Manager.MaxVacationDays;
                       _employeeFactory._manager.Work(Convert.ToInt32(workDays));
                        _employeeFactory._manager.TakeVacation(usedVacationDays);
                        break;
                }
                if (matchedEmployeeVM.AccumulatedVacationDays < 0)
                {
                    matchedEmployeeVM.UsedVacationDays = 0;
                    matchedEmployeeVM.AccumulatedVacationDays = 0;
                return $"Can't exceed more than {vacationDaysPerYear} vacation days.";
                }             
                return string.Empty;
            
        }

        // POST: EmployeeControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
               
                var matchedEmployeeVM = EmployeeExtension.Employees?.Where(i => i.EmployeeId == id).Single();

                if (matchedEmployeeVM != null)
                {
                    matchedEmployeeVM.UsedVacationDays = float.Parse(collection["UsedVacationDays"]);
                    matchedEmployeeVM.WorkDays = Convert.ToInt32(collection["WorkDays"]);
                    switch (collection["EmployeeType"])
                    {
                        case "Hourly":
                            _employeeFactory._hourlyEmployee.EmployeeVM = matchedEmployeeVM;
                            _employeeFactory._hourlyEmployee.Work(Convert.ToInt32(collection["WorkDays"]));
                            _employeeFactory._hourlyEmployee.TakeVacation(float.Parse(collection["UsedVacationDays"]));
                            break;
                        case "Salaried":
                            _employeeFactory._salariedEmployee.EmployeeVM = matchedEmployeeVM;
                            _employeeFactory._salariedEmployee.Work(Convert.ToInt32(collection["WorkDays"]));
                            _employeeFactory._salariedEmployee.TakeVacation(float.Parse(collection["UsedVacationDays"]));
                            break;
                        case "Manager":
                            _employeeFactory._manager.EmployeeVM = matchedEmployeeVM;
                            _employeeFactory._manager.Work(Convert.ToInt32(collection["WorkDays"]));
                            _employeeFactory._manager.TakeVacation(float.Parse(collection["UsedVacationDays"]));
                            break;
                    }
                }
                return View("Index", EmployeeExtension.Employees);
            }
            catch
            {
                return View();
            }
        }
    }
}


