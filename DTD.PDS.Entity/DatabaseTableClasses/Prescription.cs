using System;
using System.ComponentModel.DataAnnotations;

namespace DTD.PDS.Entity.DatabaseTableClasses
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
