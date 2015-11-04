using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TeamCollaboration.Domain.Aggregates
{
    public class User:Entity, IValidatableObject
    {
        
        public User()
        {
            GenerateNewIdentity();
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Code { get; set; }
        public int Enable { get; set; }
        public virtual ICollection<Attend> UserAttend { get; set; }   //用户参会记录
        public virtual ICollection<Board> AuthorBoard { get; set; }   //用户发布的公告
        public virtual ICollection<Meeting> SponsorMeeting { get; set; }  //用户发起的会议
        public virtual ICollection<ChatRoom> SponsorChatRoom { get; set; }    //用户发起的聊天室
        public virtual ICollection<ChatRoomUser> ChatRoomUser { get; set; }     //用户参与聊天室记录
        public virtual ICollection<Message> MessageTo { get; set; }     //用户接收的消息
        public virtual ICollection<Message> MessageFrom { get; set; }       //用户发送的消息
        public virtual ICollection<Task> TaskTo { get; set; }        //用户接受的任务
        public virtual List<Task> TaskSponsor { get; set; }      //用户发起的任务
        public virtual ICollection<Notice> NoticeTo { get; set; }      //用户收到的通知
        public virtual ICollection<Dictionary> UserHaveDictionaries { get; set; }   //


        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            return validationResults;
        }
    }
}