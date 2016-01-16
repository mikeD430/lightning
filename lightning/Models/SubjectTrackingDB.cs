using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace lightning.Models
{
    public class SubjectTrackingDB : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
