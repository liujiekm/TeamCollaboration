//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  IAttendRepository接口
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
    public interface IAttendRepository : IRepository<Attend>
    {
        /// <summary>
        /// 签到
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="meeting">会议</param>
        /// <param name="isSign">布尔值</param>
        void EnableAttend(User user,Meeting meeting,int isSign);

        /// <summary>
        /// 添加参会记录
        /// </summary>
        /// <param name="attend"></param>
        /// <param name="meeting"></param>
        /// <param name="user"></param>
        void Sign(Attend attend, Meeting meeting, User user);

        /// <summary>
        /// 获取所有有效参会记录
        /// </summary>
        /// <param name="isSign"></param>
        /// <returns></returns>
        IEnumerable<Attend> GetAttends(int isSign);

        /// <summary>
        /// 获取会议已经（还没）签到的用户列表
        /// </summary>
        /// <param name="meeting">会议</param>
        /// <param name="isSign">布尔值</param>
        /// <returns></returns>
        IEnumerable<User> GetByIsSign(Meeting meeting, int isSign);

        /// <summary>
        /// 根据会议获取与会人员信息
        /// </summary>
        /// <param name="meeting">会议</param>
        /// <returns></returns>
        IEnumerable<User> GetUser(Meeting meeting);

        /// <summary>
        /// 获取用户参加的会议记录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IEnumerable<Meeting> GetMeeting(User user);

    }
}
