//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//   IChatRoomUserRepository接口
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
using System.Data.Entity;

namespace TeamCollaboration.Domain.Repository
{
    public interface IChatRoomUserRepository: IRepository<ChatRoomUser>
    {
        /// <summary>
        /// 踢出聊天室内的用户
        /// </summary>
        /// <param name="chatRoom">聊天室</param>
        /// <param name="user">用户</param>
        /// <param name="status">布尔值</param>
        void EnableChatRoomUser(ChatRoom chatRoom, User user,int status);

        /// <summary>
        /// 添加聊天室成员记录
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <param name="user"></param>
        void Join(ChatRoomUser chatRoomUser, ChatRoom chatRoom, User user);
        
        /// <summary>
        /// 根据聊天室获取人员参加记录
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <returns></returns>
        IEnumerable<ChatRoomUser> GetByChatRoom(ChatRoom chatRoom);

        /// <summary>
        /// 根据聊天室获取参与人员信息
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <returns></returns>
        IEnumerable<User> GetUsers(ChatRoom chatRoom);

        /// <summary>
        /// 获取用户参与的聊天室
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IEnumerable<ChatRoom> GetByUser(User user);
    }
}