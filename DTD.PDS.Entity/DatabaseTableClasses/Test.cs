using System;
using System.ComponentModel.DataAnnotations;

namespace DTD.PDS.Entity.DatabaseTableClasses
{
    public enum Status
    {
        Pending, Complete, Redo
    }

    public class Test
    {
        [Key]
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public string TestName { get; set; }
        public Status Status { get; set; }
        public DateTime IssueDate { get; set; }

    }
}
