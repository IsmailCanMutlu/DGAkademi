using System;
using System.Collections.Generic;

#nullable disable


namespace W02.Models
{
    public partial class Department
    {


        public Department()
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