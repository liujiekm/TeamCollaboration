using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Board:Entity, IValidatableObject
    {
        public Board()
        {
            GenerateNewIdentity();
        }
        public Guid Author { get; set; }
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
        public virtual User AuthorUser { get; set; }     //公告发布者

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}