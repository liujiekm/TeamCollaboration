using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class ChatRoomUserEntityConfiguration: EntityTypeConfiguration<ChatRoomUser>
    {
        public ChatRoomUserEntityConfiguration()
        {
            HasKey(c => c.Id);
            //FK_ChatRoomUser_ChatRoom    与聊天室有关的记录
            this.HasRequired(d => d.ChatRoom).WithMany(l => l.ChatRoomUser).HasForeignKey(p => p.CId).WillCascadeOnDelete(false);
            //FK_ChatRoomUser_User    用户参与聊天室的记录
            this.HasRequired(d => d.User).WithMany(l => l.ChatRoomUser).HasForeignKey(p => p.UId).WillCascadeOnDelete(false);
        }
    }
}
