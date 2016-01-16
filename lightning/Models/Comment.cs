using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lightning.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int SubjectID { get; set; }
        public string UserName { get; set; }
        [Required, MaxLength(250,ErrorMessage = "Max length 250 characters")]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public virtual Subject CSubject { get; set; }
        
    }
}
