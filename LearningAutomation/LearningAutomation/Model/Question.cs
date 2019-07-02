using LearningAutomation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LearningAutomation.Service
{
    [DataContract]
    public class Question
    {
        [Required]
        [DataMember]
        public Guid QuestionId { get; set; }

        [DataMember]
        public Guid TestId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Answer1 { get; set; }

        [DataMember]
        public string Answer2 { get; set; }

        [DataMember]
        public string Answer3 { get; set; }

        [DataMember]
        public string Answer4 { get; set; }

        public virtual Test Test { get; set; }
    }
}
