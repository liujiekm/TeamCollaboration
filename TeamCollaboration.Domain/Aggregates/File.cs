using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class File : Entity, IValidatableObject
    {
        public File()
        {
            GenerateNewIdentity();
        }
        public string FileName { get; set; }
        public DateTime UploadTime { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string  Code { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Task> Task { get; set; }   //文件相关的任务
        public virtual ICollection<Meeting> Meeting { get; set; }  //文件相关的会议
        public virtual ICollection<Dictionary> Dictionary { get; set; }  //字典

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}