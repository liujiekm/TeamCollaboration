using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class BoardEntityConfiguration : EntityTypeConfiguration<Board>
    {
        public BoardEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Title).HasMaxLength(20);
            Property(c => c.Content).HasMaxLength(100).IsRequired();
            Property(c => c.Code).HasMaxLength(20).IsRequired();
            //FK_Board_User   用户发布公告
            this.HasRequired(d => d.AuthorUser).WithMany(l => l.AuthorBoard).HasForeignKey(p => p.Author).WillCascadeOnDelete(false);
        }
    }
}
