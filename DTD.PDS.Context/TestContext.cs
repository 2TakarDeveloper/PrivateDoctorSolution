using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.PDS.Entity;
using DTD.PDS.Entity.DatabaseTableClasses;

namespace DTD.PDS.Context
{
    public class TestContext
    {
        public List<Test> GetAll(int patientId)
        {
            using (var context = new DatabaseContext())
            {
                return (from tests in context.Tests where tests.PatientId==patientId select tests).ToList();
            }
        }


   

        public bool Add(Test test)
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Tests.Add(test);
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


        public bool Remove(Test test)
        {
            using (var context = new DatabaseContext())
            {

                var item = context.Set<Test>().FirstOrDefault(r => r.Id == test.Id);
                if (item == null) return false;
                context.Tests.Remove(item);
                context.SaveChanges();
                return true;


            }
        }

        public bool Update(Test test)
        {

            using (var context = new DatabaseContext())
            {
                var item = context.Tests.SingleOrDefault(a => a.Id == test.Id);

                if (item == null) return false;
                item.PatientId = test.PatientId;
                item.IssueDate = test.IssueDate;
                item.Status = test.Status;
                item.TestName = test.TestName;
                context.SaveChanges();
                return true;

            }


        }





    }
}
