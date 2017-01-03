using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.PDS.Context;
using DTD.PDS.Entity;
using DTD.PDS.Entity.DatabaseTableClasses;

namespace DTD.PDS.BLL.Repo
{
    public class PatientRepo
    {
        public List<Patient> GetAll()
        {

            return new PatientContext().GetAll();

        }


        public List<Patient> GetAllByName(string name)
        {

            return new PatientContext().GetAllByName(name);

        }

        public bool Add(Patient patient)
        {

            try
            {
                new PatientContext().Add(patient);
                return true;
            }
            catch (Exception)
            {
                return false;

            }


        }


        public bool Remove(Patient patient)
        {
            try
            {
                new PatientContext().Remove(patient);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }

        public bool Update(Patient patient)
        {

            try
            {
                new PatientContext().Update(patient);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}
