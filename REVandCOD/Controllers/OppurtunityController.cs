using REVandCOD.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REVandCOD.Controllers
{
    public class OppurtunityController : Controller
    {
        // GET: Oppurtunity
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewOpp()
        {
            var con = ConfigurationManager.ConnectionStrings["REVENUE"].ToString();
            var model = new List<Oppurtunity>();

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "SELECT * FROM[RevenueDB].[dbo].[Oppurtunity]";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Oppurtunity oppur = new Oppurtunity();

                        oppur.AccountName = oReader["AccountName"].ToString();
                        oppur.Portfolio = oReader["Portfolio"].ToString();
                        oppur.OppurtunityType = oReader["OppurtunityType"].ToString();
                        oppur.OppurtunityNo= oReader["OppurtunityNo"].ToString();
                        oppur.OppurtunityName= oReader["OppurtunityName"].ToString();
                        oppur.OppurtunityDescription= oReader["OppurtunityDescription"].ToString();
                        oppur.ProjectType= oReader["ProjectType"].ToString();
                        oppur.RFPDT= Convert.ToDateTime(oReader["RFPDT"]);
                        oppur.ProposalSubmissionDate= Convert.ToDateTime(oReader["ProposalSubmissionDate"]);
                        oppur.NegitationClosureDate= Convert.ToDateTime(oReader["NegitationClosureDate"]);
                        oppur.LOIDT= Convert.ToDateTime(oReader["LOIDT"]);
                        oppur.WinningProbability=Convert.ToInt64(oReader["WinningProbability"]);
                        oppur.OnDateClosureProbability= Convert.ToInt64(oReader["OnDateClosureProbability"]);
                        oppur.SignatureExpectedDate= Convert.ToDateTime(oReader["SignatureExpectedDate"]);

                        model.Add(oppur);
                    }

                    myConnection.Close();
                }
            }

            return View(model);
        }
    }
}