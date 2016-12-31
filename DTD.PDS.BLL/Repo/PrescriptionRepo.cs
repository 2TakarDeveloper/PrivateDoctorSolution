using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.PDS.Context;
using DTD.PDS.Entity;

namespace DTD.PDS.BLL.Repo
{
    public class PrescriptionRepo
    {
        public List<Prescription> GetAll(int patientId)
        {

            return new PrescriptionContext().GetAll(patientId);

        }




        public bool Add(Prescription prescription)
        {

            try
            {
                new PrescriptionContext().Add(prescription);
                return true;
            }
            catch (Exception)
            {
                return false;

            }


        }


        public bool Remove(Prescription prescription)
        {
            try
            {
                new PrescriptionContext().Remove(prescription);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }

        public bool Update(Prescription prescription)
        {

            try
            {
                new PrescriptionContext().Update(prescription);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}
