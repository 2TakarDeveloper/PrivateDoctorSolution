using System;
using System.ComponentModel.DataAnnotations;

namespace DTD.PDS.Entity.DatabaseTableClasses
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public DateTime AppointmentDateTime { get; set; }
    }
}
