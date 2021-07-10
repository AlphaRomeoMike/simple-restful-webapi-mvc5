using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Simple_Restful_Api.Controllers
{
    public class EmployeeController : ApiController
    {
        public string[] employees = { "Ali", "Faizan", "Hammad" };
        [HttpGet]
        public string[] GetEmployees()
        {
            return employees;
        }

        [HttpGet]
        public string GetEmployeeByIndex(int id)
        {
            try
            {
                return employees[id];
            }
            catch(Exception e)
            {
                return e.Message;
            }
            
        }
    }
}
