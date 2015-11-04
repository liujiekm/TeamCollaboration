using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Notice:Entity, IValidatableObject
    {
        public Notice()
        {
            GenerateNewIdentity();
        }
        public DateTime SendTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public Guid MId { get; set; }
        //public Guid TId { get; set; }
        public int Path { get; set; }
        public int Status { get; set; }
        public int IsRead { get; set; }
        public string Code { get; set; }
        public virtual Task Task { get; set; }     //通知所属的任务
        public virtual Meeting Meeting { get; set; }     //通知所属的会议
        public virtual ICollection<User> NoticeToUsers { get; set; }    //通知接受者

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}