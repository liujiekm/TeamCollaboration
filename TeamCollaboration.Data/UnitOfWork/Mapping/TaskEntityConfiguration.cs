using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class TaskEntityConfiguration : EntityTypeConfiguration<TeamCollaboration.Domain.Aggregates.Task>
    {
        public TaskEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).HasMaxLength(50).IsRequired();
            Property(c => c.Description).HasMaxLength(100);
            Property(c => c.Code).HasMaxLength(20).IsRequired();
            //FK_Task_User  任务发起人
            this.HasRequired(d => d.SponsorUser).WithMany(l => l.TaskSponsor).HasForeignKey(p => p.Sponsor).WillCascadeOnDelete(false);
        }
    }
}
