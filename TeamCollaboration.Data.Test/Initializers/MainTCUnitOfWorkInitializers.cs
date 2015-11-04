using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TeamCollaboration.Data.UnitOfWork;
using TeamCollaboration.Domain.Aggregates;

using agg = TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.Test.Initializers
{
    public class MainTCUnitOfWorkInitializers: DropCreateDatabaseIfModelChanges<MainTCUnitOfWork>
    {

        protected override void Seed(MainTCUnitOfWork context)
        {
            //示例代码
            context.Users.Add(new User
            {
                Name = "张三",
                Password = "123",
                Phone = "111",
                Mail = "qwq",
                Code = "u12",
                Enable = 1,
               
            });
            context.Tasks.Add(new agg.Task
            {
                Name="账单"
            });
            context.Notices.Add(new Notice
            {

            });
            context.Messages.Add(new Message
            {

            });
            context.Meetings.Add(new Meeting
            {

            });
            context.Files.Add(new File
            {

            });
            context.Dictionarys.Add(new Dictionary
            {

            });
            context.ChatRoomUsers.Add(new ChatRoomUser
            {

            });
            context.ChatRooms.Add(new ChatRoom
            {

            });
            context.Boards.Add(new Board
            {

            });
            context.Attends.Add(new Attend
            {

            });

            context.Commit();

        }
    }
}
