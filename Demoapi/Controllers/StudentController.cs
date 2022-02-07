using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demoapi.Models;
namespace Demoapi.Controllers
{
    public class StudentController : ApiController
    {
        public IEnumerable<employee> Get()  // It's return All Employee List  
        {
            using (EmployeeEntities context = new EmployeeEntities())
            {
                return context.employees.ToList();
            }
        }

        
        public employee Get(int Id)   // It's return Employee Base on Employee Id  
        {
            using (EmployeeEntities context = new EmployeeEntities())
            {
                return context.employees.FirstOrDefault(e => e.Id == Id);
            }
        }
    }
}