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
    public class ChatRoomRepository : Repository<ChatRoom>, IChatRoomRepository
    {
        public ChatRoomRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在IChatRoomRepository中添加契约，然后在当前类中实现


        public void EnableChatRoom(ChatRoom chatRoom, int enable)
        {
            throw new NotImplementedException();
        }

        public void CreateChatRoom(ChatRoom chatRoom, User sponsor, Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public void CreateChatRoom2(ChatRoom chatRoom, User sponsor)
        {
            throw new NotImplementedException();
        }

        public void GetByStatus(int status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatRoom> GetChatRoom(User user, DateTime LaunchTime)
        {
            throw new NotImplementedException();
        }

        public ChatRoom GetByMeeting(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public Meeting findByMId(Guid mId)
        {
            throw new NotImplementedException();
        }

        public Meeting GetMeeting(ChatRoom chatRoom)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatRoom> GetBysponsor(User sponsor)
        {
            throw new NotImplementedException();
        }

        public ChatRoom GetOneBysponsor(User sponsor, DateTime launchTime)
        {
            throw new NotImplementedException();
        }
    }
}
