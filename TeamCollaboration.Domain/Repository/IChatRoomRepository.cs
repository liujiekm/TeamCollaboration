//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//   IChatRoomRepository接口
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
    public interface IChatRoomRepository:IRepository<ChatRoom>
    {
        /// <summary>
        /// 删除聊天室
        /// </summary>
        /// <param name="chatRoom">聊天室</param>
        /// <param name="enable">布尔值</param>
        void EnableChatRoom(ChatRoom chatRoom, int enable);

        /// <summary>
        /// 创建会议聊天室
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <param name="sponsor"></param>
        /// <param name="meeting"></param>
        void CreateChatRoom(ChatRoom chatRoom,User sponsor,Meeting meeting);

        /// <summary>
        /// 创建讨论群
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <param name="sponsor"></param>
        void CreateChatRoom2(ChatRoom chatRoom, User sponsor);

        /// <summary>
        /// 获取正在使用中的聊天室
        /// </summary>
        /// <param name="status"></param>
        void GetByStatus(int status);

        /// <summary>
        /// 根据发起时间获取用户创建的聊天室
        /// </summary>
        /// <param name="user"></param>
        /// <param name="LaunchTime"></param>
        /// <returns></returns>
        IEnumerable<ChatRoom> GetChatRoom(User user, DateTime LaunchTime);

        /// <summary>
        /// 通过会议找到聊天室
        /// </summary>
        /// <param name="meeting"></param>
        /// <returns></returns>
        ChatRoom GetByMeeting(Meeting meeting);

        /// <summary>
        /// 根据MId找到聊天室
        /// </summary>
        /// <param name="mId"></param>
        /// <returns></returns>
        Meeting findByMId(Guid mId);

        /// <summary>
        /// 根据会议找到聊天室
        /// </summary>
        /// <param name="chatRoom"></param>
        /// <returns></returns>
        Meeting GetMeeting(ChatRoom chatRoom);

        /// <summary>
        /// 获取用户发起的所有聊天室
        /// </summary>
        /// <param name="sponsor"></param>
        /// <returns></returns>
        IEnumerable<ChatRoom> GetBysponsor(User sponsor);

        /// <summary>
        /// 根据发起时间找到用户创建的聊天室
        /// </summary>
        /// <param name="sponsor"></param>
        /// <param name="launchTime"></param>
        /// <returns></returns>
        ChatRoom GetOneBysponsor(User sponsor, DateTime launchTime);


        
    }
}
