using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class ChatRoom : Entity, IValidatableObject
    {
        public ChatRoom()
        {
            GenerateNewIdentity();
        }
        public Guid Sponsor { get; set; }   //发起人
        public DateTime LaunchTime { get; set; }

        //[ForeignKey("Meeting")]
        public Guid? MId { get; set; }
        public string Theme { get; set; }
        public int Status { get; set; }
        public string Code { get; set; }
        public virtual Meeting Meeting { get; set; }    //聊天室会议
        public virtual User SponsorUser { get; set; }  //聊天室发起者
        public virtual ICollection<ChatRoomUser> ChatRoomUser { get; set; }  //聊天室参与者记录
        public virtual ICollection<Message> Message { get; set; }  //与聊天室有关的聊天消息

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}