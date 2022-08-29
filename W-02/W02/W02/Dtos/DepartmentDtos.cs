using System;
using W02.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace W02.Dtos
{
    public partial class DepartmentDtos
    {
        public DepartmentDtos()
        {
            Employees = new HashSet<Employee>();
            Prodacts = new HashSet<Prodact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Prodact> Prodacts { get; set; }
    }
}