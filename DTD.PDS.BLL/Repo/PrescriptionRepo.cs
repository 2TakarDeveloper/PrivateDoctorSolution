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
    public class PrescriptionRepo
    {
        public List<Prescription> GetAll(int patientId)
        {

            return new PrescriptionContext().GetAll(patientId);

        }




        public bool Add(Prescription prescription)
        {

             return  new PrescriptionContext().Add(prescription);
         
        }


        public bool Remove(Prescription prescription)
        {
            
             return new PrescriptionContext().Remove(prescription);
        }

        public bool Update(Prescription prescription)
        {

             return new PrescriptionContext().Update(prescription);
                

        }
    }
}
