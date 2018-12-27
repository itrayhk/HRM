using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace HRM.Models
{
    public class UserRegistration
    {

        [Required]
        [StringLength(150)]
        [DisplayName("Email")]
        public string jb_email { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Name")]
        public string jb_applicant_name { get; set; }
    }
}