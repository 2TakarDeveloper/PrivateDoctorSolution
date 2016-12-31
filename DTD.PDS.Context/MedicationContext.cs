using System;
using System.Collections.Generic;
using System.Linq;
using DTD.PDS.Entity;

namespace DTD.PDS.Context
{
    public class MedicationContext
    {
        public List<Medication> GetAll(int prescriptionId)
        {
            using (var context = new DatabaseContext())
            {
                return (from medications in context.Medications where medications.PrescriptionId==prescriptionId select medications).ToList();
            }
        }




        public bool Add(Medication medication)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Medications.Add(medication);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                   
                }

            }
        }


        public bool Remove(Medication medication)
        {
            using (var context = new DatabaseContext())
            {

                var item = context.Set<Medication>().FirstOrDefault(r => r.Id == medication.Id);
                if (item == null) return false;
                context.Medications.Remove(item);
                context.SaveChanges();
                return true;


            }
        }

        public bool Update(Medication medication)
        {

            using (var context = new DatabaseContext())
            {
                var item = context.Medications.SingleOrDefault(a => a.Id == medication.Id);

                if (item == null) return false;
                item.MedicineName = medication.MedicineName;
                item.PrescriptionId = medication.PrescriptionId;
                item.StartDate = medication.StartDate;
                item.EndDate = medication.EndDate;
                item.Interval = medication.Interval;
                context.SaveChanges();
                return true;

            }


        }
    }
}
