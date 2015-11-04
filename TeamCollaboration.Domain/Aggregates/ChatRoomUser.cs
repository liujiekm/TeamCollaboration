using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class ChatRoomUser: Entity ,IValidatableObject
    {
        public ChatRoomUser()
        {
            GenerateNewIdentity();
        }
        public Guid CId { get; set; }
        public Guid UId { get; set; }
        public int Status { get; set; }
        public virtual ChatRoom ChatRoom { get; set; }  //聊天室
        public virtual User User { get; set; }   //参与者

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
        //public virtual User User { get; set; }
    }
}