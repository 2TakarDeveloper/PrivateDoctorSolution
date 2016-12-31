using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.PDS.Context;
using DTD.PDS.Entity;

namespace DTD.PDS.BLL.Repo
{
    public class TestRepo
    {
        public List<Test> GetAll(int patientID)
        {

            return new TestContext().GetAll(patientID);

        }




        public bool Add(Test test)
        {

            try
            {
                new TestContext().Add(test);
                return true;
            }
            catch (Exception)
            {
                return false;

            }


        }


        public bool Remove(Test test)
        {
            try
            {
                new TestContext().Remove(test);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }

        public bool Update(Test test)
        {

            try
            {
                new TestContext().Update(test);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}
