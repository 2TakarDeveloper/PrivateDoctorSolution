using System;
using System.ComponentModel.DataAnnotations;

namespace DTD.PDS.Entity.DatabaseTableClasses
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public string MedicineName { get; set; }
        public int Interval { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
