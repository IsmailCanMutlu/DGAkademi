using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace W02.Models
{
    public partial class Employee
    {

        public int Id { get; set; }
        public int Department_Id { get; set; }
        public string Name { get; set; }
        public string E_mail { get; set; }



        public virtual Department Department { get; set; }
    }


}