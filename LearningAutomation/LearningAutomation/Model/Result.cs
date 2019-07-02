using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LearningAutomation.Model
{
    [DataContract]
    public class Result
    {
        [Required]
        [DataMember]
        public int ResultId { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int Score { get; set; }

        public virtual User User { get; set; }
    }
}
