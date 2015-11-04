using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Data.UnitOfWork.Mapping;

namespace TeamCollaboration.Domain.Aggregates
{
    public class TeContext : DbContext
    {
        public TeContext()
            : base("Data Source=USER-20140118SD\\MSSQLSWRVER;Initial Catalog=APIContext;Integrated Security=True")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Attend> Attend { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Board> Board { get; set; }
        public DbSet<ChatRoom> ChatRoom { get; set; }
        public DbSet<ChatRoomUser> ChatRoomUser { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<Dictionary> Dictionary { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Task> Task { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new AttendEntityConfiguration());
            modelBuilder.Configurations.Add(new MeetingEntityConfiguration());
            modelBuilder.Configurations.Add(new BoardEntityConfiguration());
            modelBuilder.Configurations.Add(new ChatRoomEntityConfiguration());
            modelBuilder.Configurations.Add(new ChatRoomUserEntityConfiguration());
            modelBuilder.Configurations.Add(new MessageEntityConfiguration());
            modelBuilder.Configurations.Add(new NoticeEntityConfiguration());
            modelBuilder.Configurations.Add(new TaskEntityConfiguration());
            modelBuilder.Configurations.Add(new FileEntityConfiguration());
            modelBuilder.Configurations.Add(new DictionaryEntityConfiguration());
        }
    }
}
