using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace W02.PModels
{
    public class PostDepartmentPModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
    }
}