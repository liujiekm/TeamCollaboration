//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//   IMessageRepository接口
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By 徐旺琥
// Creat Time 2015-09-20
//===================================================================================





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Domain.Repository
{
    public interface IMessageRepository:IRepository<Message>
    {
        /// <summary>
        /// 删除消息记录
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status"></param>
        void EnableMessage(Message message, int status);

        /// <summary>
        /// 多人聊天消息记录
        /// </summary>
        /// <param name="message"></param>
        /// <param name="chatRoom"></param>
        /// <param name="fromUser"></param>
        void sendMessageToAll(Message message, ChatRoom chatRoom, User fromUser);

        /// <summary>
        /// 私聊消息记录
        /// </summary>
        /// <param name="message"></param>
        /// <param name="fromUser"></param>
        /// <param name="toUser"></param>
        void sendMessageToOne(Message message, User fromUser, User toUser);

        /// <summary>
        /// 根据聊天室获取用户发言
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <param name="userFrom"></param>
        /// <returns></returns>
        IEnumerable<Message> GetMessage(ChatRoom chatRoom, User userFrom);

        /// <summary>
        /// 根据时间获取用户发言
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="userFrom"></param>
        /// <returns></returns>
        IEnumerable<Message> GetMessageByTime(DateTime dateTime, User userFrom);

        /// <summary>
        /// 根据发送和接收用户获取消息记录
        /// </summary>
        /// <param name="userFrom"></param>
        /// <param name="userTo"></param>
        /// <returns></returns>
        IEnumerable<Message> GetMessageSingle(User userFrom, User userTo);
    }
}
