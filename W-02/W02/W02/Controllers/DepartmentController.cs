using System;
using System.Collections.Generic;
using System.Linq;
using W02.Dtos;
using W02.Models;
using W02.PModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace W02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IMapper _mapper;
        public DepartmentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Department> Get()
        {
            using (var context = new Contex())
            {
                return context.Departments.ToList();
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Department> Get(int id)
        {
            using (var context = new Contex())
            {
                var departments = context.Departments.Where(data => data.Id == id).FirstOrDefault();
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
        public ActionResult<DepartmentDtos> Post(Department departments)
        {
            using (var context = new Contex())
            {
                if (departments != null && departments.Name != null)
                {
                    context.Add(departments);
                    context.SaveChanges();


                    return _mapper.Map<DepartmentDtos>(departments);

                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Department> Delete(int id)
        {
            using (var context = new Contex())
            {
                var data = context.Departments.Where(data => data.Id == id).FirstOrDefault();

                if (data == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Departments.Remove(data);
                    context.SaveChanges();
                    return data;
                }
            }

        }
    }



}

