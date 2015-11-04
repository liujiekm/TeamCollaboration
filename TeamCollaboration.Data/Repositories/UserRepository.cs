using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Data.UnitOfWork;
using TeamCollaboration.Domain;
using TeamCollaboration.Domain.Aggregates;
using TeamCollaboration.Domain.Repository;
using Aggregates = TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.Repositories
{
    public class UserRepository:Repository<User>,IUserRepository
    {
       public UserRepository(IEnumerableUnitOfWork unitOfWork) :base(unitOfWork)
        {

        }



        //按业务重载Repository方法
      



        //要扩展方法，首先在IUserRepository中添加契约，然后在当前类中实现

       public void ChangePassword(User user, string newPsw)
       {
           User oldUser = Get(user.Id);
           User newUser = oldUser;
           newUser.Password = newPsw;
           Merge(oldUser,newUser);
           Modify(newUser);
       }

       public void EnableUser(User user, int enable)
       {
           User oldUser = Get(user.Id);
           User newUser = oldUser;
           newUser.Enable = enable;
           Merge(oldUser,newUser);
           Modify(newUser);
       }

       public IEnumerable<Notice> GetUserNotice(User user, DateTime dateTime)
       {
           IEnumerable<Notice> queryNotices = user.NoticeTo.Where(a=>a.SendTime==dateTime);
           return queryNotices;
       }

       public IEnumerable<Aggregates.Task> GetUserTask(User user, DateTime dateTime)
       {
           IEnumerable<Aggregates.Task> queryTask = user.TaskTo.Where(a=>a.StartTime==dateTime);
           return queryTask;
       }


       public void CreateUser(User user)
       {
           throw new NotImplementedException();
       }
    }
}
