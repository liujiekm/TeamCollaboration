using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Attend :Entity, IValidatableObject
    {
        public Attend()
        {
            GenerateNewIdentity();
        }
        public Guid UId { get; set; }
        public Guid MId { get; set; }
        public int IsSign { get; set; }
        public string Code { get; set; }
        public virtual User User { get; set; }    //会议参与者
        public virtual Meeting Meeting { get; set; }   //参与的会议

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}