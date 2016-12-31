
using System.Data.Entity;

using DTD.PDS.Entity;

namespace DTD.PDS.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("name=PDS")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medication> Medications { get; set; }


        //Storage
      

    }
}
