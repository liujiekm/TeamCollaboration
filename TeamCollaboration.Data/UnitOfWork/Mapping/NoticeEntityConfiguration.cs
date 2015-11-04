using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class NoticeEntityConfiguration : EntityTypeConfiguration<Notice>
    {
        public NoticeEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Title).HasMaxLength(50);
            Property(c => c.Content).HasMaxLength(200).IsRequired();
            Property(c => c.Code).HasMaxLength(20).IsRequired();
            //Property(c => c.TId).IsOptional();
            //Property(c => c.MId).IsOptional();
            //FK_Notice_Task    任务通知
            this.HasOptional(d => d.Task).WithMany(l => l.TaskNotice).Map(p=>p.MapKey("TId")).WillCascadeOnDelete(false);   //////
            //FK_Notice_Meeting   会议通知
            this.HasOptional(d => d.Meeting).WithMany(l => l.MeetingNotice).Map(p=>p.MapKey("MId")).WillCascadeOnDelete(false);  //////
        }
    }
}
