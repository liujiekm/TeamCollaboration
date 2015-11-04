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
    public class MeetingRepository : Repository<Meeting>, IMeetingRepository
    {
        public MeetingRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在IMeetingRepository中添加契约，然后在当前类中实现



        public IEnumerable<Meeting> GetMeetingWithCondition(System.Linq.Expressions.Expression<Func<Meeting,bool>> condition)
        {
            IEnumerable<Meeting> queryMeeting = GetFilted(condition);
            return queryMeeting;
        }

        public IEnumerable<Notice> GetMeetingNoSendNotices(Meeting meeting)
        {
            IEnumerable<Notice> queryNotice = meeting.MeetingNotice.Where(a=>a.Status==1);
            return queryNotice;
        }


        public void EnableMeeting(Meeting meeting, int status)
        {
            throw new NotImplementedException();
        }

        public void CreateMeeting(Meeting meeting, User sponsor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetDisAttendUsers(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public User findByMeeting(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> GetMeetingByUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
