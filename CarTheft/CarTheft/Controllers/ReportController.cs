using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarTheft.Models;

namespace CarTheft.Controllers
{
    public class ReportController : ApiController
    {
        [HttpGet]
        public ReportModel[] Get(string uuid)
        {
            ReportModel report1 = new ReportModel();
            report1.uuid = "001";
            report1.Description = "Car theft with violence";
            report1.LossCause = "Car Theft";
            report1.LossDate = "5 August 2017 12:00";
            report1.InjuredPeople = "False";
            report1.DeadPeople = "True";
            //report1.ReportedBy = "";
            //report1.History = "";
            //report1.Vehicles = "5 September 2017 12:00"; 

            ReportModel report2 = new ReportModel();
            report2.uuid = "002";
            report2.Description = "Flood incident";
            report2.LossCause = "Total Loss,Tornado";
            report2.LossDate = "5 July 2017 12:00";
            report2.InjuredPeople = "True";
            report2.DeadPeople = "False";
            //report2.ReportedBy = "";
            //report2.History = "";
            //report2.Vehicles = "5 September 2017 12:00";      

            ReportModel[]reportsArray = { report1, report2};
            return reportsArray;
        }

        public IHttpActionResult Post(ReportModel report)
        {
            return this.Ok<string>("SQL INSERT into Report(" + report.Description + ", " + report.LossCause + ")");
        }
    }
}
