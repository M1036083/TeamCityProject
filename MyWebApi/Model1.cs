namespace MyWebApi
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("Model1")
        {
        }

        public virtual DbSet<EmployeeInfo> EmployeeInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);
        }
    }
}
