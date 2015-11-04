using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Dictionary : Entity, IValidatableObject
    {
        public Dictionary()
        {
            GenerateNewIdentity();
        }
        //public Guid ParentId { get; set; }
        public string FoldName { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public virtual ICollection<File> File { get; set; }  //文件
        public virtual ICollection<User> DictionaryToUsers { get; set; }  //拥有者
        public virtual ICollection<Dictionary> Dictionarys { get; set; }  //

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}