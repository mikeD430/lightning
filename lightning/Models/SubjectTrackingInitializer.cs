using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace lightning.Models
{
    public class SubjectTrackingInitializer : DropCreateDatabaseIfModelChanges<SubjectTrackingDB>
    {
        protected override void Seed(SubjectTrackingDB context)
        {
            base.Seed(context);

            //Create some subjects
            //var subjects = new List<Subject>
            //{
            //    new Subject {
            //        Title = "Maths",
            //        Description = "Mathematics",
            //        Module = "Algebra",
            //        UserName = "Louis Domingue",
            //        CreatedDate = DateTime.Today.AddDays(-1),
            //        ModifiedDate = DateTime.Today
            //    },
            //    new Subject {
            //        Title = "Maths",
            //        Description = "Mathematics",
            //        Module = "Ratio",
            //        UserName = "Louis Domingue",
            //        CreatedDate = DateTime.Today.AddDays(-1),
            //         ModifiedDate = DateTime.Today
            //    },

            //};
            //subjects.ForEach(s => context.Subjects.Add(s));
            //context.SaveChanges();
        }
    }
}
