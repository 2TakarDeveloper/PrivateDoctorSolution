using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTD.PDS.Entity
{
    public enum Status
    {
        Pending, Complete, Redo
    }

    public class Test
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string TestName { get; set; }
        public Status Status { get; set; }
        public DateTime IssueDate { get; set; }

    }
}
