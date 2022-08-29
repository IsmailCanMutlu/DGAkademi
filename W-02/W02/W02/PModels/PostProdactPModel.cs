using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace W02.PModels
{
    public class PostProdactPModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Department_Id { get; set; }
        public int Stock { get; set; }
    }
}