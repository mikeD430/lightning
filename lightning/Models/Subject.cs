using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightning.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Module { get; set; }
        [Display(Name = "Picture")]
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public bool complete1 { get; set; }
        public bool complete2 { get; set; }
        public bool complete3 { get; set; }
        public bool complete4 { get; set; }  
        public bool complete5 { get; set; }
        public bool complete6 { get; set; }
        public bool tested1 { get; set; }
        public bool tested2 { get; set; }
        public bool tested3 { get; set; }
        public bool tested4 { get; set; }
        public bool tested5 { get; set; }
        public bool tested6 { get; set; }

    }
}
