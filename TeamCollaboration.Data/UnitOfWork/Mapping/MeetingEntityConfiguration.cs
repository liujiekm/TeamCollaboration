using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class MeetingEntityConfiguration : EntityTypeConfiguration<Meeting>
    {
        public MeetingEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Theme).HasMaxLength(50);
            Property(c => c.Room).HasMaxLength(50).IsRequired();
            Property(c => c.Description).HasMaxLength(100);
            Property(c => c.Code).HasMaxLength(20).IsRequired();
            //FK_Meeting_ChatRoom   会议安排在聊天室
            this.HasRequired(d => d.ChatRoom).WithOptional(l => l.Meeting).WillCascadeOnDelete(false);
            //FK_Meeting_User     用户发起会议
            this.HasRequired(d => d.SponsorUser).WithMany(l => l.SponsorMeeting).HasForeignKey(p => p.Sponsor).WillCascadeOnDelete(false);
        }
    }
}
