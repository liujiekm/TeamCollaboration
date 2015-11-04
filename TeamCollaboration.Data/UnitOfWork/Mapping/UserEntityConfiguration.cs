using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).HasMaxLength(20).IsOptional();
            Property(c => c.Password).HasMaxLength(20).IsRequired();
            Property(c => c.Phone).HasMaxLength(15).IsOptional();
            Property(c => c.Mail).HasMaxLength(50).IsRequired();
            Property(c => c.Code).HasMaxLength(20).IsRequired();

            //FK_User_Notice   用户接收通知
            this.HasMany(a => a.NoticeTo).WithMany(t => t.NoticeToUsers).Map(m =>
            {
                m.ToTable("NoticeToUser");
                m.MapLeftKey("UId");
                m.MapRightKey("NId");
            });
            //FK_User_Task   用户接收任务
            this.HasMany(a => a.TaskTo).WithMany(t => t.TaskToUsers).Map(m =>
            {
                m.ToTable("Assign");
                m.MapLeftKey("UId");
                m.MapRightKey("TId");
            });
            //FK_User_Dictionary   
            this.HasMany(a => a.UserHaveDictionaries).WithMany(t => t.DictionaryToUsers).Map(m =>
            {
                m.ToTable("UserHaveDictionary");
                m.MapLeftKey("UId");
                m.MapRightKey("DId");
            });
        }
    }
}
