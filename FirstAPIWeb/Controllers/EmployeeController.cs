﻿using FirstAPIWeb.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPIWeb.Models;
namespace FirstAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private RepositoryEmployee _repositoryEmployee;
        public EmployeeController(RepositoryEmployee repository)
        {
            _repositoryEmployee = repository;
        }
        [HttpGet("/GetAllEmployees")]
        // GET: EmployeeController
        public IEnumerable<EmployeeViewModel> GetAllEmployees()
        {
            List<Employee> employees = _repositoryEmployee.GetAllEmployee();
            var emplist = (from emp in employees
                           select new EmployeeViewModel()
                           {
                               EmpID = emp.EmployeeId,
                               FirstName = emp.FirstName,
                               LastName = emp.LastName,
                               BirthDate = (DateTime)emp.BirthDate,
                               HireDate = (DateTime)emp.HireDate,
                               Title = emp.Title,
                               City = emp.City,
                               ReportsTo = (int)emp.ReportsTo
                           }
                           ).ToList();
            
            return emplist;
        }
        [HttpPost]
        public Employee EmployeeDetails(int id)
        {
            Employee employees = _repositoryEmployee.GetEmployeeId(id);
            return employees;
        }
        [HttpPut]
        public Employee EditEmployee(int id,[FromBody] Employee updatedEmployee)
        {
            updatedEmployee.EmployeeId = id;
            Employee savedEmployee = _repositoryEmployee.UpdateEmployee(updatedEmployee);
            return savedEmployee;
        }
        [HttpDelete]
        public Employee Delete(int id, [FromBody] Employee deleteEmployeeData)
        {
            deleteEmployeeData.EmployeeId = id;
            Employee savedEmployee = _repositoryEmployee.DeleteEmployee(deleteEmployeeData);
            return savedEmployee;
        }
    }
}
