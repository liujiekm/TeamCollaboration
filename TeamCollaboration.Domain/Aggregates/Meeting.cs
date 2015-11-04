using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamCollaboration.Domain.Aggregates
{
    public class Meeting : Entity, IValidatableObject
    {
        public Meeting()
        {
            GenerateNewIdentity();
        }
        public string  Theme { get; set; }
        public DateTime StartTime { get; set; }
        public string Room { get; set; }
        public string  Description { get; set; }
        public int IsPublic { get; set; }
        public int Status { get; set; }
        public Guid Sponsor { get; set; }
        
        //[ForeignKey("ChatRoom")]
        public Guid ChatRoomId { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Attend> MeetingAttend { get; set; }   //与会议有关的参会记录
        public virtual ChatRoom ChatRoom { get; set; }    //开会的聊天室
        public virtual ICollection<Notice> MeetingNotice { get; set; }  //会议通知
        public virtual ICollection<File> MeetingFile { get; set; }  //会议文件
        public virtual User SponsorUser { get; set; }    //会议发起人

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
        //public virtual User User { get; set; }
    }
}