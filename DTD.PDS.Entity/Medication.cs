using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.PDS.Entity
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
