using System;
using W02.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace W02.Dtos
{
    public class ProdactDtos
    {
        public int Id { get; set; }
        public int Department_Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        public virtual Department Department { get; set; }
    }
}