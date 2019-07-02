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
    public class LearningMaterial
    {
        [Required]
        [DataMember]
        public Guid LearningMaterialId { get; set; }
        
        [DataMember]
        public byte[] File { get; set; }
        
        [ForeignKey("LearningMaterialId")]
        public virtual List<Test> Tests { get; set; }
    }
}
