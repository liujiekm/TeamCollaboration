using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class ChatRoomEntityConfiguration : EntityTypeConfiguration<ChatRoom>
    {
        public ChatRoomEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Theme).HasMaxLength(20).IsRequired();
            Property(c => c.Code).HasMaxLength(20).IsRequired();

            //FK_ChatRoom_User  用户发起聊天室
            this.HasRequired(d => d.SponsorUser).WithMany(l => l.SponsorChatRoom).HasForeignKey(p => p.Sponsor).WillCascadeOnDelete(false);
        }
    }
}
