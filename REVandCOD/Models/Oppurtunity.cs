using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REVandCOD.Models
{
    public class Oppurtunity
    {

        public string AccountName { get; set; }
        public string Portfolio { get; set; }
        public string OppurtunityType { get; set; }
        public string OppurtunityNo { get; set; }
        public string OppurtunityName { get; set; }
        public string  OppurtunityDescription { get; set; }
        public string  ProjectType { get; set; }
        public DateTime RFPDT { get; set; }
        public DateTime ProposalSubmissionDate { get; set; }
        public DateTime NegitationClosureDate { get; set; }

        public DateTime LOIDT { get; set; }
        public float WinningProbability { get; set; }
        public float OnDateClosureProbability { get; set; }
    }
}