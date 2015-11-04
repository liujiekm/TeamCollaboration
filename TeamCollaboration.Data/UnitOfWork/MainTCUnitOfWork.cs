using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TeamCollaboration.Domain.Aggregates;

using Aggregates =TeamCollaboration.Domain.Aggregates;
using System.Data.Entity.Infrastructure;
using TeamCollaboration.Data.UnitOfWork.Mapping;

namespace TeamCollaboration.Data.UnitOfWork
{
    public class MainTCUnitOfWork : DbContext, IEnumerableUnitOfWork
    { 
        //private readonly static string connStr = "Data Source=10.11.74.14;Initial Catalog=TeamContext;User ID=sa;Password=sa123;Integrated Security=True";
        public MainTCUnitOfWork()
            : base(System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString)
            //: base("Data Source=USER-20140118SD\\MSSQLSWRVER;Initial Catalog=TeamContext;Integrated Security=True")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendEntityConfiguration());
            modelBuilder.Configurations.Add(new BoardEntityConfiguration());
            modelBuilder.Configurations.Add(new ChatRoomEntityConfiguration());
            modelBuilder.Configurations.Add(new ChatRoomUserEntityConfiguration());
            modelBuilder.Configurations.Add(new DictionaryEntityConfiguration());
            modelBuilder.Configurations.Add(new FileEntityConfiguration());
            modelBuilder.Configurations.Add(new MeetingEntityConfiguration());
            modelBuilder.Configurations.Add(new MessageEntityConfiguration());
            modelBuilder.Configurations.Add(new NoticeEntityConfiguration());
            modelBuilder.Configurations.Add(new TaskEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            //modelBuilder.Configurations.Add()
        }

        #region 私有属性
        private IDbSet<Attend> _attends;
        public IDbSet<Attend> Attends
        {
            get
            {
                if(this._attends==null)
                {
                    this._attends= base.Set<Attend>();
                    
                }
                return this._attends;
            }
        }

        private IDbSet<Board> _boards;
        public IDbSet<Board> Boards
        {
            get
            {
                if (this._boards == null)
                {
                    this._boards = base.Set<Board>();

                }
                return this._boards;
            }
        }


        private IDbSet<ChatRoom> _chatRooms;
        public IDbSet<ChatRoom> ChatRooms
        {
            get
            {
                if (this._chatRooms == null)
                {
                    this._chatRooms = base.Set<ChatRoom>();

                }
                return this._chatRooms;
            }
        }


        private IDbSet<ChatRoomUser> _chatRoomUsers;
        public IDbSet<ChatRoomUser> ChatRoomUsers
        {
            get
            {
                if (this._chatRoomUsers == null)
                {
                    this._chatRoomUsers = base.Set<ChatRoomUser>();

                }
                return this._chatRoomUsers;
            }
        }


        private IDbSet<Dictionary> _dictionarys;
        public IDbSet<Dictionary> Dictionarys
        {
            get
            {
                if (this._dictionarys == null)
                {
                    this._dictionarys = base.Set<Dictionary>();

                }
                return this._dictionarys;
            }
        }

        private IDbSet<File> _files;
        public IDbSet<File> Files
        {
            get
            {
                if (this._files == null)
                {
                    this._files = base.Set<File>();

                }
                return this._files;
            }
        }



        private IDbSet<Meeting> _meetings;
        public IDbSet<Meeting> Meetings
        {
            get
            {
                if (this._meetings == null)
                {
                    this._meetings = base.Set<Meeting>();

                }
                return this._meetings;
            }
        }


        private IDbSet<Message> _messages;
        public IDbSet<Message> Messages
        {
            get
            {
                if (this._messages == null)
                {
                    this._messages = base.Set<Message>();

                }
                return this._messages;
            }
        }


        private IDbSet<Notice> _notices;
        public IDbSet<Notice> Notices
        {
            get
            {
                if (this._notices == null)
                {
                    this._notices = base.Set<Notice>();

                }
                return this._notices;
            }
        }


        private IDbSet<Aggregates.Task> _tasks;
        public IDbSet<Aggregates.Task> Tasks
        {
            get
            {
                if (this._tasks == null)
                {
                    this._tasks = base.Set<Aggregates.Task>();

                }
                return this._tasks;
            }
        }


        private IDbSet<User> _users;
        public IDbSet<User> Users
        {
            get
            {
                if (this._users == null)
                {
                    this._users = base.Set<User>();

                }
                return this._users;
            }
        }
        #endregion




        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = EntityState.Unchanged;
        }

        public void Commit()
        {
            base.SaveChanges();
        }


        /// <summary>
        /// 如果保存，则从数据库中查询原来的值更行实体
        /// </summary>
        public void CommitAndRefreshChanges()
        {
            var saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();
                    saveFailed = false;
                }
                catch (DbUpdateConcurrencyException ex)
                {

                    saveFailed = true;
                    ex.Entries.ToList().ForEach(p=>p.OriginalValues.SetValues(p.GetDatabaseValues()));
                }

            } while (saveFailed);
        }



        /// <summary>
        /// 执行纯SQL语句（性能提高）
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }


        /// <summary>
        /// 执行纯SQL语句的查询（性能提高）
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sqlQuery"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public DbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }


        /// <summary>
        /// 回滚修改，只需将状态修改为未修改状态
        /// </summary>
        public void RollbackChanges()
        {
            base.ChangeTracker.Entries().ToList().ForEach(p=>p.State=EntityState.Unchanged);
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = EntityState.Modified;
        }
    }
}
