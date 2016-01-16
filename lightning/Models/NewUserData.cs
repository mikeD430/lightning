using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightning.Models
{
    public class NewUserData
    {
        private SubjectTrackingDB db = new SubjectTrackingDB();
        public void CreateUserData(string newuser)
        {
            var master = db.Subjects.Where(s => s.UserName == "Master");

            foreach (var item in master)
            {
                item.UserName = newuser;
                db.Subjects.Add(item);
               

            }
            db.SaveChanges();
        }
    }
}
