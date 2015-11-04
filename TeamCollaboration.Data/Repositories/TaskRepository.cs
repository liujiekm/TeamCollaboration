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
    public class TaskRepository : Repository<TeamCollaboration.Domain.Aggregates.Task>, ITaskRepository
    {
        public TaskRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在ITaskRepository中添加契约，然后在当前类中实现

        public void EnableTask(Domain.Aggregates.Task task, int enable)
        {
            throw new NotImplementedException();
        }

        public void CreateTask(Domain.Aggregates.Task task, User sponsor, List<User> toUsers)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Aggregates.Task> GetTask(User user, int status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Aggregates.Task> GetByTime(DateTime Time1, DateTime Time2, DateTime startTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Aggregates.Task> GetByPriority(User user, int priority)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUserTaskTo(Domain.Aggregates.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
