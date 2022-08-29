using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace W02.Models
{
    public partial class Prodact
    {

        public int Id { get; set; }
        public int Department_Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }



        public virtual Department Department { get; set; }
    }


}