using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class AttendEntityConfiguration : EntityTypeConfiguration<Attend>
    {
        public AttendEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Code).HasMaxLength(20).IsRequired();
            //FK_Attend_User   用户参加会议
            this.HasRequired(d => d.User).WithMany(l => l.UserAttend).HasForeignKey(p => p.UId).WillCascadeOnDelete(false);
            //FK_Attend_Meeting   参加的会议
            this.HasRequired(d => d.Meeting).WithMany(l => l.MeetingAttend).HasForeignKey(p => p.MId).WillCascadeOnDelete(false);
        }
    }
}
