namespace Powerlink
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PowerlinkModel : DbContext
    {
        public PowerlinkModel()
            : base("name=Powerlink_Model")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_Username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_Password)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_FName)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_LName)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Eqp_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Eqp_Category)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Eqp_Description)
                .IsUnicode(false);
        }
    }
}
