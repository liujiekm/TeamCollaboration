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
    public class ChatRoomUserRepository : Repository<ChatRoomUser>,IChatRoomUserRepository
    {
        public ChatRoomUserRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在IChatRoomRepository中添加契约，然后在当前类中实现


        public void DeleteChatRoomUser(ChatRoom chatRoom, User user)
        {
            ChatRoomUser cruOld = Get(user.Id);
            ChatRoomUser cruNew = cruOld;
            cruNew.Status = 1;
            Merge(cruOld,cruNew);
            Modify(cruNew);
        }

        public void EnableChatRoomUser(ChatRoom chatRoom, User user, int status)
        {
            throw new NotImplementedException();
        }

        public void Join(ChatRoomUser chatRoomUser, ChatRoom chatRoom, User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatRoomUser> GetByChatRoom(ChatRoom chatRoom)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers(ChatRoom chatRoom)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatRoom> GetByUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
