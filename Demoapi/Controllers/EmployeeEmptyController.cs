using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demoapi.Models;

namespace Demoapi.Controllers
{
    public class EmployeeEmptyController : Controller
    {
        // GET: EmployeeEmpty
        [HttpGet]
        public IEnumerable<employee> Get()  // It's return All Employee List  
        {
            using (EmployeeEntities context = new EmployeeEntities())
            {
                return context.employees.ToList();
            }
        }

        [HttpGet]
        public employee Get(int Id)   // It's return Employee Base on Employee Id  
        {
            using (EmployeeEntities context = new EmployeeEntities())
            {
                return context.employees.FirstOrDefault(e => e.Id == Id);
            }
        }
    }
}