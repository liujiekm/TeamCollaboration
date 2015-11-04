using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Task : Entity, IValidatableObject
    {
        public Task()
        {
            GenerateNewIdentity();
        }
        public string Name { get; set; }
        //[ForeignKey("Sponsor")]
        public Guid Sponsor { get; set; }
        public string  Description { get; set; }
        public float WorkHours { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Notice> TaskNotice { get; set; }   //任务通知
        public virtual ICollection<File> TaskFile { get; set; }     //任务文件
        public virtual ICollection<User> TaskToUsers { get; set; }    //任务接受者
        public virtual User SponsorUser { get; set; }     //任务发起人

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}