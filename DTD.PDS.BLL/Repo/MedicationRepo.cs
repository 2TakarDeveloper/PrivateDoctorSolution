using System;
using System.Collections.Generic;
using DTD.PDS.Context;
using DTD.PDS.Entity;

namespace DTD.PDS.BLL.Repo
{
    public class MedicationRepo
    {
        public List<Medication> GetAll(int prescriptionId)
        {

            return new MedicationContext().GetAll(prescriptionId);

        }




        public bool Add(Medication medication)
        {

            try
            {
                new MedicationContext().Add(medication);
                return true;
            }
            catch (Exception)
            {
                return false;

            }


        }


        public bool Remove(Medication medication)
        {
            try
            {
                new MedicationContext().Remove(medication);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
               

           
        }

        public bool Update(Medication medication)
        {

            try
            {
                new MedicationContext().Update(medication);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}
