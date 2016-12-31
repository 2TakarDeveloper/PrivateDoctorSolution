using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.PDS.Entity;

namespace DTD.PDS.Context
{
    public class PrescriptionContext
    {


        public List<Prescription> GetAll(int patientId)
        {
            using (var context = new DatabaseContext())
            {
                return (from prescriptions in context.Prescriptions where prescriptions.PatientId==patientId select prescriptions).ToList();
            }
        }




        public bool Add(Prescription prescription)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Prescriptions.Add(prescription);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }

            }
        }


        public bool Remove(Prescription prescription)
        {
            using (var context = new DatabaseContext())
            {

                var item = context.Set<Prescription>().FirstOrDefault(r => r.Id == prescription.Id);
                if (item == null) return false;
                context.Prescriptions.Remove(item);
                context.SaveChanges();
                return true;


            }
        }

        public bool Update(Prescription prescription)
        {

            using (var context = new DatabaseContext())
            {
                var item = context.Prescriptions.SingleOrDefault(a => a.Id == prescription.Id);

                if (item == null) return false;
                item.PatientId = prescription.PatientId;
                item.IssueDate = prescription.IssueDate;
                context.SaveChanges();
                return true;

            }


        }





    }
}
