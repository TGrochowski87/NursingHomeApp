//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NursingHomeApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NursingHomeEntities : DbContext
    {
        public NursingHomeEntities()
            : base("name=NursingHomeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeeLogin> EmployeeLogins { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<PatientLogin> PatientLogins { get; set; }
        public virtual DbSet<PatientMedicine> PatientMedicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
    }
}
