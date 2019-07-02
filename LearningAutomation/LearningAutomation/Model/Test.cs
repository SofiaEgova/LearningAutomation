using LearningAutomation.Service;
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
    public class Test
    {
        [Required]
        [DataMember]
        public Guid TestId { get; set; }

        [DataMember]
        public Guid LearningMaterialId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }
        
        public virtual LearningMaterial LearningMaterial { get; set; }

        [ForeignKey("TestId")]
        public virtual List<Question> Questions { get; set; }
    }
}
