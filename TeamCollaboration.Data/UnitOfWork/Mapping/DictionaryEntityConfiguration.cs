using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class DictionaryEntityConfiguration : EntityTypeConfiguration<Dictionary>
    {
        public DictionaryEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.FoldName).HasMaxLength(20).IsRequired();
            Property(c => c.Code).HasMaxLength(20).IsRequired();
        }
    }
}
