using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCollaboration.Data.UnitOfWork;
using TeamCollaboration.Data.Repositories;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Data.Test
{
    /// <summary>
    /// UserRepository 的摘要说明
    /// </summary>
    [TestClass]
    public class UserRepositoryTest
    {
        public UserRepositoryTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        [TestInitialize()]
        public void MyTestInitialize() {


        }

        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        
        public void TestMethod1()
        {
            //测试示例代码
           
            var unitOfWork = new MainTCUnitOfWork();
            var userRepository = new UserRepository(unitOfWork);

            
            //Assert.IsNotNull(allItems);
            //Assert.IsTrue(allItems.Any());
            //Assert.IsTrue(allItems.All(ba => ba.Id != null));

        }

        
        public MainTCUnitOfWork context;
        [TestMethod]
        public void test()
        {
            var context = new MainTCUnitOfWork();
            User user = new User();
            user.Name = "张三";
            user.Password = "123";
            user.Phone = "111";
            user.Mail = "asa";
            user.Code = "u01";
            user.Enable = 1;

            context.Users.Add(user);

            User user2 = new User();
            user2.Name = "李四";
            user2.Password = "123";
            user2.Phone = "222";
            user2.Mail = "asa";
            user2.Code = "u02";
            user2.Enable = 1;

            context.Users.Add(user2);

            User user3 = new User();
            user3.Name = "王五";
            user3.Password = "123";
            user3.Phone = "333";
            user3.Mail = "asa";
            user3.Code = "u03";
            user3.Enable = 1;

            context.Users.Add(user3);
            //会议
            Meeting meeting = new Meeting();
            meeting.Theme = "讨论";
            meeting.StartTime = Convert.ToDateTime("2012-09-11");
            meeting.Room = "201";
            meeting.Description = "需求讨论";
            meeting.IsPublic = 1;
            meeting.Status = 1;
            meeting.Code = "m01";

            meeting.SponsorUser = user;

            context.Meetings.Add(meeting);
            //聊天室
            ChatRoom chatRoom = new ChatRoom();
            chatRoom.LaunchTime = Convert.ToDateTime("2012-09-11");
            chatRoom.Theme = "需求讨论";
            chatRoom.Status = 1;
            chatRoom.Code = "c01";

            chatRoom.Meeting = meeting;
            chatRoom.SponsorUser = user;

            context.ChatRooms.Add(chatRoom);
            //参与聊天室
            ChatRoomUser chatRoomUser = new ChatRoomUser();
            chatRoomUser.Status = 1;
            chatRoomUser.ChatRoom = chatRoom;
            chatRoomUser.User = user;

            context.ChatRoomUsers.Add(chatRoomUser);
            ChatRoomUser chatRoomUser2 = new ChatRoomUser();
            chatRoomUser2.Status = 1;
            chatRoomUser2.ChatRoom = chatRoom;
            chatRoomUser2.User = user2;

            context.ChatRoomUsers.Add(chatRoomUser2);
            ChatRoomUser chatRoomUser3 = new ChatRoomUser();
            chatRoomUser3.Status = 1;
            chatRoomUser3.ChatRoom = chatRoom;
            chatRoomUser3.User = user3;

            context.ChatRoomUsers.Add(chatRoomUser3);
            //私聊
            Message message = new Message();
            message.SendTime = Convert.ToDateTime("2012-09-09");
            message.Status = 1;

            message.MessageFromUser = user;
            message.MessageToUser = user2;

            context.Messages.Add(message);
            //群聊
            Message message2 = new Message();
            message2.SendTime = Convert.ToDateTime("2012-09-12");
            message2.Status = 1;

            message2.ChatRoom = chatRoom;
            message2.MessageFromUser = user;

            context.Messages.Add(message2);

            Message message3 = new Message();
            message3.SendTime = Convert.ToDateTime("2012-09-12");
            message3.Status = 1;

            message3.ChatRoom = chatRoom;
            message3.MessageFromUser = user3;

            context.Messages.Add(message3);


            //任务
            Task task = new Task();
            task.Name = "分析";
            task.Description = "需求分析";
            task.WorkHours = 3;
            task.StartTime = Convert.ToDateTime("2012-09-09");
            task.EndTime = Convert.ToDateTime("2012-09-10");
            task.Priority = 1;
            task.Status = 1;
            task.Code = "t01";

            task.SponsorUser = user;
            task.TaskToUsers = new List<User>
            {
                user,user2,user3
            };

            context.Tasks.Add(task);
            //
            Dictionary dictionary = new Dictionary();
            dictionary.FoldName = "需求分析";
            dictionary.Code = "d01";
            dictionary.Status = 1;
            dictionary.Type = 1;
            dictionary.DictionaryToUsers = new List<User>
            {
                user
            };

            context.Dictionarys.Add(dictionary);
            //任务文件
            File file = new File();
            file.FileName = "需求文档";
            file.UploadTime = Convert.ToDateTime("2012-09-12");
            file.Description = "asasas";
            file.Path = "as";
            file.Code = "f01";
            file.Status = 1;

            file.Task = new List<Task>
            {
                task
            };
            file.Dictionary = new List<Dictionary>
            {
                dictionary
            };

            context.Files.Add(file);
            //会议文件
            File file2 = new File();
            file2.FileName = "需求修改";
            file2.UploadTime = Convert.ToDateTime("2012-09-13");
            file2.Description = "asasas";
            file2.Path = "as";
            file2.Code = "f02";
            file2.Status = 1;
            file2.Meeting = new List<Meeting>
            {
                meeting
            };
            file2.Dictionary = new List<Dictionary>
            {
                dictionary
            };

            context.Files.Add(file2);
            //会议通知
            Notice notice = new Notice();
            notice.SendTime = Convert.ToDateTime("2012-09-09");
            notice.Title = "开会";
            notice.Content = "qwqas";
            notice.Path = 1;
            notice.Status = 1;
            notice.IsRead = 1;
            notice.Code = "n01";

            notice.Meeting = meeting;
            notice.NoticeToUsers = new List<User>
            {
                user,user2,user3
            };

            context.Notices.Add(notice);
            //任务通知
            Notice notice2 = new Notice();
            notice2.SendTime = Convert.ToDateTime("2012-09-09");
            notice2.Title = "需求";
            notice2.Content = "qwqas";
            notice2.Path = 1;
            notice2.Status = 1;
            notice2.IsRead = 1;
            notice2.Code = "n02";

            notice.Task = task;
            notice.NoticeToUsers = new List<User>
            {
                user,user2,user3
            };

            context.Notices.Add(notice2);
            //公告
            Board board = new Board();
            board.PublishTime = Convert.ToDateTime("2012-09-09");
            board.Title = "通知";
            board.Content = "asaqw";
            board.Code = "b01";
            board.Status = 1;

            board.AuthorUser = user;

            context.Boards.Add(board);
            //参会
            Attend attend = new Attend();
            attend.IsSign = 1;
            attend.Code = "a01";

            attend.User = user;
            attend.Meeting = meeting;

            context.Attends.Add(attend);
            Attend attend2 = new Attend();
            attend2.IsSign = 1;
            attend2.Code = "a02";

            attend2.User = user2;
            attend2.Meeting = meeting;

            context.Attends.Add(attend2);
            Attend attend3 = new Attend();
            attend3.IsSign = 1;
            attend3.Code = "a03";

            attend3.User = user3;
            attend3.Meeting = meeting;

            context.Attends.Add(attend3);

            context.Commit();
           
        }
    }
}
