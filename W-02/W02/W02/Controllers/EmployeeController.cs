using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W02.Dtos;
using W02.Models;
using W02.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<PostEmployeePModel>> Get()
        {
            using (var context = new Contex())
            {
                var departments = context.Employees.Select(data => new PostEmployeePModel()
                {

                    Id = data.Id,
                    Department_Id = data.Department_Id,
                    Name = data.Name,
                    E_mail = data.E_mail
                }).ToList();
                if (departments == null)
                {
                    return NotFound();
                }
                else
                {
                    return departments;
                }
            }

        }



        [HttpPost]
        public ActionResult<PostEmployeePModel> Post(Employee employee)
        {
            using (var context = new Contex())
            {
                if (employee != null && employee.Name != null)
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();

                    return new PostEmployeePModel()
                    {
                        Id = employee.Id,
                        Department_Id = employee.Department_Id,
                        Name = employee.Name,
                        E_mail = employee.E_mail
                    };
                }
                else
                {
                    return BadRequest();
                }
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}

