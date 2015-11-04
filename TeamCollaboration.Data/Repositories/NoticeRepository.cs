using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Data.UnitOfWork;
using TeamCollaboration.Domain;
using TeamCollaboration.Domain.Aggregates;
using TeamCollaboration.Domain.Repository;

namespace TeamCollaboration.Data.Repositories
{
    public class NoticeRepository : Repository<Notice>, INoticeRepository
    {
        public NoticeRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在INoticeRepository中添加契约，然后在当前类中实现

        public void EnableNotice(Notice notice, int status)
        {
            throw new NotImplementedException();
        }

        public void publishNoticeToTask(Notice notice, Domain.Aggregates.Task task, List<User> toUsers)
        {
            throw new NotImplementedException();
        }

        public void publishNoticeToMeeting(Notice notice, Meeting meeting, List<User> toUsers)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notice> GetNoticeToTask(Domain.Aggregates.Task task)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notice> GetNoticeToMeeting(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUserTo(Notice notice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notice> GetNoticeByIsRead(int isRead)
        {
            throw new NotImplementedException();
        }
    }
}
