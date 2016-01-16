using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using System.IO;
using CsvHelper;
using System.Data.Entity.Migrations;
using CsvHelper.Configuration;

namespace lightning.Models
{
    public class SubjectTrackingInitializerCSV : DropCreateDatabaseAlways<SubjectTrackingDB>
    {
        protected override void Seed(SubjectTrackingDB context)
        {

            base.Seed(context);

            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "lightning.App_Data.Maths2.csv";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvReader csvReader = new CsvReader(reader);
                    csvReader.Configuration.WillThrowOnMissingField = false;
                    csvReader.Configuration.RegisterClassMap<MyClassMap>();
                    var subjects = csvReader.GetRecords<Subject>().ToArray();
                    
                    context.Subjects.AddOrUpdate(s => s.SubjectID, subjects);


                }
            }


            
            context.SaveChanges();
        }
        public sealed class MyClassMap : CsvClassMap<Subject>
        {
            public MyClassMap()
            {
                Map(m => m.Title).Index(0);
                Map(m => m.Module).Index(1);
                Map(m => m.Description).Index(2);
                Map(m => m.CreatedDate).Index(3);
                Map(m => m.ModifiedDate).Index(4);
                Map(m => m.UserName).Index(5);


            }
        }
    }
}

