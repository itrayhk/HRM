namespace HRM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class jb_applicant_register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int regId { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Application No.")]
        public string jb_app_no { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Email")]
        public string jb_email { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Name")]
        public string jb_applicant_name { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [DisplayName("Application Date")]
        public DateTime? jb_app_date { get; set; }

        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        [DisplayName("Send Acknowledgement")]
        public DateTime? jb_email_ack { get; set; }

        [DisplayName("Register")]
        public bool? jb_resp_ack { get; set; }

        [StringLength(20)]
        [DisplayName("Password")]
        public string jb_app_pwd { get; set; }

        [StringLength(1000)]
        public string jb_email_desc { get; set; }

        [StringLength(20)]
        [DisplayName("Telephone No.")]
        public string jb_tel_no { get; set; }
    }
}
