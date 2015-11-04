//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  IMeetingRepository接口
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Domain.Repository
{
    public interface IMeetingRepository:IRepository<Meeting>
    {
        /// <summary>
        /// 取消会议
        /// </summary>
        /// <param name="meeting"></param>
        /// <param name="status"></param>
        void EnableMeeting(Meeting meeting, int status);

        /// <summary>
        /// 发起会议
        /// </summary>
        /// <param name="meeting"></param>
        /// <param name="sponsor"></param>
        void CreateMeeting(Meeting meeting, User sponsor);

        /// <summary>
        /// 得到目标会议未签到人员
        /// </summary>
        /// <param name="meeting">目标会议</param>
        /// <returns></returns>
        IEnumerable<User> GetDisAttendUsers(Meeting meeting);

        /// <summary>
        /// 获取会议发起人
        /// </summary>
        /// <param name="meeting"></param>
        /// <returns></returns>
        User findByMeeting(Meeting meeting);

        /// <summary>
        /// 获取用户发起的会议
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IEnumerable<Meeting> GetMeetingByUser(User user);


        ///// <summary>
        ///// 得到目标会议所有未发送的通知
        ///// </summary>
        ///// <param name="meeting">目标会议</param>
        ///// <returns></returns>
        //IEnumerable<Notice> GetMeetingNoSendNotices(Meeting meeting);

        ///// <summary>
        ///// 搜索会议
        ///// </summary>
        ///// <param name="condition">条件表达式</param>
        ///// <returns></returns>
        //IEnumerable<Meeting> GetMeetingWithCondition(Expression<Func<Meeting>> condition);

    }
}
