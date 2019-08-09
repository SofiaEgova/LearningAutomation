using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LearningAutomation.Model
{
    [DataContract]
    public class User
    {
        [Required]
        [DataMember]
        public Guid UserId { get; set; }

        [Required]
        [DataMember]
        public string Login { get; set; }
        
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [ForeignKey("ResultId")]
        public virtual List<Result> Results { get; set; }
    }
}
