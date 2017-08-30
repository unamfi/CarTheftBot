using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarTheft.Models
{
    public class AccountModel
    {
        public string uuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Verified { get; set; }
        public string VerifiedMethod { get; set; }
        public string CreationDate { get; set; }
        public string ApprovalDate { get; set; }
        public string LastLoginDate { get; set; }
        public string ApprovalAdmin { get; set; }
        public string IsActive { get; set; }        
        public PersonModel Person { get; set; }
        public RolModel Rol { get; set; }
    }
}