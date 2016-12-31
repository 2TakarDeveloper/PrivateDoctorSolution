using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.PDS.Entity;

namespace DTD.PDS.Context
{
    public class PatientContext
    {
        public List<Patient> GetAll()
        {
            using (var context = new DatabaseContext())
            {
                return (from patients in context.Patients select patients).ToList();
            }
        }


        public List<Patient> GetAllByName(string name)
        {
            using (var context = new DatabaseContext())
            {
                return (from patients in context.Patients where patients.Name == name select patients).ToList();
            }
        }

        public bool Add(Patient patient)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Patients.Add(patient);
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


        public bool Remove(Patient patient)
        {
            using (var context = new DatabaseContext())
            {

                var item = context.Set<Patient>().FirstOrDefault(r => r.Id == patient.Id);
                if (item == null) return false;
                context.Patients.Remove(item);
                context.SaveChanges();
                return true;


            }
        }

        public bool Update(Patient patient)
        {

            using (var context = new DatabaseContext())
            {
                var item = context.Patients.SingleOrDefault(a => a.Id == patient.Id);

                if (item == null) return false;
                item.Name = patient.Name;
                item.Email = patient.Email;
                item.Mobile = patient.Mobile;
                item.AppointmentDateTime = patient.AppointmentDateTime;
                context.SaveChanges();
                return true;

            }


        }







    }
}
