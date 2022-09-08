using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityLayer.Concrete
{
    public class Contact
    {[Key]
        public int ContactId { get; set; }
        public string ConcactUserName { get; set; }
        public string? ConcactMail { get; set; }
        public string? ConcactSubject { get; set; }
        public string? ConcactMessage { get; set; }
        public DateTime ConcactDate { get; set; }
        public bool ConcactStatus { get; set; }//
    }
}
