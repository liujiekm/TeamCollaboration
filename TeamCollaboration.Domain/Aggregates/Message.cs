using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Message : Entity, IValidatableObject
    {
        public Message()
        {
            GenerateNewIdentity();
        }
        //public Guid CId { get; set; }
        public DateTime SendTime { get; set; }
        public int Status { get; set; }
 
        public Guid FromId { get; set; }
        //public Guid ToId { get; set; }
        
        public virtual ChatRoom ChatRoom { get; set; }      //消息来源的聊天室
        public virtual User MessageFromUser { get; set; }    //消息发送者
        public virtual User MessageToUser { get; set; }     //消息接收者

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}