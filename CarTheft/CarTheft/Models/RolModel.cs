using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarTheft.Models
{
    public class RolModel
    {
        public string uuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserRol { get; set; }
        public string IsActive { get; set; }
        public string CreationDate { get; set; }        
    }
}