//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  INoticeRepository接口
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
    public interface INoticeRepository:IRepository<Notice>
    {
        /// <summary>
        /// 删除通知
        /// </summary>
        /// <param name="notice"></param>
        /// <param name="status"></param>
        void EnableNotice(Notice notice, int status);

        /// <summary>
        /// 发布任务通知
        /// </summary>
        /// <param name="notice"></param>
        /// <param name="task"></param>
        /// <param name="toUser"></param>
        void publishNoticeToTask(Notice notice,Aggregates.Task task,List<User> toUsers);
        
        /// <summary>
        /// 发布会议通知
        /// </summary>
        /// <param name="notice"></param>
        /// <param name="meeting"></param>
        /// <param name="toUsers"></param>
        void publishNoticeToMeeting(Notice notice, Meeting meeting, List<User> toUsers);

        /// <summary>
        /// 获取任务通知
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        IEnumerable<Notice> GetNoticeToTask(Aggregates.Task task);

        /// <summary>
        /// 获取会议通知
        /// </summary>
        /// <param name="meeting"></param>
        /// <returns></returns>
        IEnumerable<Notice> GetNoticeToMeeting(Meeting meeting);

        /// <summary>
        /// 获取通知接受者信息
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        IEnumerable<User> GetUserTo(Notice notice);

        /// <summary>
        /// 获取未读通知
        /// </summary>
        /// <param name="isRead"></param>
        /// <returns></returns>
        IEnumerable<Notice> GetNoticeByIsRead(int isRead);
    }
}
