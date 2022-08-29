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
    public class ProdactController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<PostProdactPModel>> Get()
        {
            using (var context = new Contex())
            {
                var departments = context.Prodacts.Select(data => new PostProdactPModel()
                {

                    Id = data.Id,
                    Department_Id = data.Department_Id,
                    Name = data.Name,
                    Stock = data.Stock
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
        public ActionResult<PostProdactPModel> Post(Prodact prodact)
        {
            using (var context = new Contex())
            {
                if (prodact != null && prodact.Name != null)
                {
                    context.Prodacts.Add(prodact);
                    context.SaveChanges();

                    return new PostProdactPModel()
                    {
                        Id = prodact.Id,
                        Department_Id = prodact.Department_Id,
                        Name = prodact.Name,
                        Stock= prodact.Stock
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
