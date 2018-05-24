using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace REVandCOD.Models
{
    public class NewOppurtunity
    {
        

        [Required]
        [StringLength(255)]
        [Display(Name ="Account Name")]
        public string AccountName { get; set; }
        public string Portfolio { get; set; }
        [Required]
        public string OppurtunityType { get; set; }
        [Required]
        public string OppurtunityNo { get; set; }
        [Required]
        public string OppurtunityName { get; set; }
        [Required]
        public string CurrencyType { get; set; }
        [Required]
        [Display(Name = "SOW TCV")]
        public double SOW_TCV { get; set; }
        [Required]
        [Display(Name = "Project Manager")]
        public string ProjectManager { get; set; }
        [Required]
        [Display(Name = "Delivery Manager")]
        public string DeliveryManager { get; set; }
        [Required]
        [Display(Name = "Account DeliveryHead")]
        public string AccountDeliveryHead { get; set; }
        [Required]
        [Display(Name = "Client Partner")]
        public string ClientPartner { get; set; }


    }
}