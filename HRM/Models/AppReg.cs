namespace HRM.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppReg : DbContext
    {
        public AppReg()
            : base("name=AppReg")
        {
        }

        public virtual DbSet<jb_applicant_register> jb_applicant_register { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<jb_applicant_register>()
                .Property(e => e.jb_app_no)
                .IsUnicode(false);

            modelBuilder.Entity<jb_applicant_register>()
                .Property(e => e.jb_email)
                .IsUnicode(false);

            modelBuilder.Entity<jb_applicant_register>()
                .Property(e => e.jb_applicant_name)
                .IsUnicode(false);

            modelBuilder.Entity<jb_applicant_register>()
                .Property(e => e.jb_app_pwd)
                .IsUnicode(false);

            modelBuilder.Entity<jb_applicant_register>()
                .Property(e => e.jb_email_desc)
                .IsUnicode(false);

            modelBuilder.Entity<jb_applicant_register>()
                .Property(e => e.jb_tel_no)
                .IsUnicode(false);
        }
    }
}
