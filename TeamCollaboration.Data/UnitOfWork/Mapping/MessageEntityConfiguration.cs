using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class MessageEntityConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.FromId).IsRequired();
            //Property(c => c.ToId).IsOptional();
            //Property(c => c.CId).IsOptional();
            ////FK_Message_User    用户发送消息
            this.HasRequired(d => d.MessageFromUser).WithMany(l => l.MessageFrom).HasForeignKey(p => p.FromId).WillCascadeOnDelete(false);
            //FK_Message_User   用户接受消息
            this.HasOptional(d => d.MessageToUser).WithMany(l => l.MessageTo).Map(p=>p.MapKey("ToId")).WillCascadeOnDelete(false);///////////
            //FK_Message_Chatroom   与聊天室有关的消息
            this.HasOptional(d => d.ChatRoom).WithMany(l => l.Message).Map(p => p.MapKey("CId")).WillCascadeOnDelete(false);
        }
    }
}
