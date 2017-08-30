using CarTheft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarTheft.Controllers
{
    public class AccountController : ApiController
    {
        public string Get() {
            return "All";
        }
        [HttpGet]
        public AccountModel[] Get(string username)
        {
            AccountModel account1 = new AccountModel();
            account1.uuid = "001";
            account1.Username = "miguel78";
            account1.Password = "Gato12345";
            account1.Verified = "True";
            account1.VerifiedMethod = "Email/SMS Confirmation";
            account1.CreationDate = "5 August 2017 12:00";
            account1.ApprovalDate = "8 August 2017 12:00";
            account1.LastLoginDate = "5 September 2017 12:00";
            account1.ApprovalAdmin = "Admin";
            account1.IsActive = "True";

            PersonModel person1 = new PersonModel();
            person1.uuid = "001";            
            person1.LastName = "Ramirez";
            person1.MiddleName = "Angel";
            person1.LastName2 = "Medina";
            person1.FirstName = "Miguel";
            person1.Phone = "55 55 55 55 55";
            person1.Email = "Miguel@email.com";            
            account1.Person = person1;

            RolModel rol1 = new RolModel();
            rol1.uuid = "001";
            rol1.Name = "User";
            rol1.Description = "Read and Edit Permission";
            rol1.UserRol = "1";
            rol1.IsActive = "True";
            rol1.CreationDate = "5 August 2017 12:00";
            account1.Rol = rol1;

            AccountModel account2 = new AccountModel();
            account2.uuid = "002";
            account2.Username = "Juan2000";
            account2.Password = "Perro12345";
            account2.Verified = "True";
            account2.VerifiedMethod = "Email/SMS Confirmation";
            account2.CreationDate = "5 August 2017 12:00";
            account2.ApprovalDate = "8 August 2017 12:00";
            account2.LastLoginDate = "5 September 2017 12:00";
            account2.ApprovalAdmin = "Admin";
            account2.IsActive = "True";

            PersonModel person2 = new PersonModel();
            person2.uuid = "002";
            person2.LastName = "Peres";
            person2.MiddleName = null;
            person2.LastName2 = "Lopez";
            person2.FirstName = "Juan";
            person2.Phone = "55 55 55 55 55";
            person2.Email = "juan_lopez@email.com";
            account2.Person = person2;

            RolModel rol2 = new RolModel();
            rol2.uuid = "002";
            rol2.Name = "User";
            rol2.Description = "Read and Edit Permission";
            rol2.UserRol = "1";
            rol2.IsActive = "True";
            rol2.CreationDate = "5 August 2017 12:00";
            account2.Rol = rol2;

            AccountModel account3 = new AccountModel();
            account3.uuid = "003";
            account3.Username = "jladron1880";
            account3.Password = "katun";
            account3.Verified = "True";
            account3.VerifiedMethod = "Email/SMS Confirmation";
            account3.CreationDate = "5 August 2017 12:00";
            account3.ApprovalDate = "8 August 2017 12:00";
            account3.LastLoginDate = "5 September 2017 12:00";
            account3.ApprovalAdmin = "Admin";
            account3.IsActive = "True";

            PersonModel person3 = new PersonModel();
            person3.uuid = "001";
            person3.LastName = "Ladron de Guevara";
            person3.MiddleName = "Alfredo";
            person3.LastName2 = "Herrero";
            person3.FirstName = "Jaime";
            person3.Phone = "55 55 55 55 55";
            person3.Email = "jladron_de_guevara@email.com";
            account3.Person = person3;

            RolModel rol3 = new RolModel();
            rol3.uuid = "001";
            rol3.Name = "User";
            rol3.Description = "Read and Edit Permission";
            rol3.UserRol = "1";
            rol3.IsActive = "True";
            rol3.CreationDate = "5 August 2017 12:00";
            account3.Rol = rol3;

            AccountModel[] accountsArray = { account1, account2, account3 };
            return accountsArray;
        }

        [HttpGet]
        public bool Get(string username, string password)
        {
            return true;
        }

        public IHttpActionResult Post(AccountModel account)
        {
            return this.Ok<string>("SQL INSERT into Account(" + account.Username + ", " + account.Password + ")");
        }
    }
}

