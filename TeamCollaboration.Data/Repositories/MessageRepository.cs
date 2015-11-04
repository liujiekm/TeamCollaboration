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
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在IMessageRepository中添加契约，然后在当前类中实现

        public void EnableMessage(Message message, int status)
        {
            throw new NotImplementedException();
        }

        public void sendMessageToAll(Message message, ChatRoom chatRoom, User fromUser)
        {
            throw new NotImplementedException();
        }

        public void sendMessageToOne(Message message, User fromUser, User toUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetMessage(ChatRoom chatRoom, User userFrom)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetMessageByTime(DateTime dateTime, User userFrom)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetMessageSingle(User userFrom, User userTo)
        {
            throw new NotImplementedException();
        }
    }
}
