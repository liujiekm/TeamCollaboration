using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.UnitOfWork.Mapping
{
    public class FileEntityConfiguration : EntityTypeConfiguration<File>
    {
        public FileEntityConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.FileName).HasMaxLength(50).IsRequired();
            Property(c => c.Description).HasMaxLength(50);
            Property(c => c.Path).HasMaxLength(50).IsRequired();
            Property(c => c.Code).HasMaxLength(20).IsRequired();
            //FK_File_Task   任务文件
            this.HasMany(a => a.Task).WithMany(t => t.TaskFile).Map(m =>
            {
                m.ToTable("TaskToFile");
                m.MapLeftKey("FId");
                m.MapRightKey("TId");
            });
            //FK_File_Meeting   会议文件
            this.HasMany(a => a.Meeting).WithMany(t => t.MeetingFile).Map(m =>
            {
                m.ToTable("MeetingToFile");
                m.MapLeftKey("FId");
                m.MapRightKey("MId");
            });
            //FK_File_Dictionary   文件目录
            this.HasMany(a => a.Dictionary).WithMany(t => t.File).Map(m =>
            {
                m.ToTable("FileInDictionary");
                m.MapLeftKey("FId");
                m.MapRightKey("DId");
            });
        }
    }
}
