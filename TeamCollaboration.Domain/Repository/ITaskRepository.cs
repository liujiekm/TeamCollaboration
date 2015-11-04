//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  ITaskRepository接口
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
using Aggregates = TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Domain.Repository
{
    public interface ITaskRepository:IRepository<Aggregates.Task>
    {
        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="task"></param>
        /// <param name="enable"></param>
        void EnableTask(Aggregates.Task task, int enable);

        /// <summary>
        /// 创建任务（总）？？
        /// </summary>
        /// <param name="task"></param>
        /// <param name="sponsor"></param>
        /// <param name="toUsers"></param>
        void CreateTask(Aggregates.Task task, User sponsor, List<User> toUsers);



        /// <summary>
        /// 根据发布者获取有效任务
        /// </summary>
        /// <param name="user">发布者</param>
        /// <param name="status">任务状态</param>
        /// <returns></returns>
        IEnumerable<Aggregates.Task> GetTask(User user, int status);
       
        /// <summary>
        /// 按时间参数查询任务列表
        /// </summary>
        /// <param name="Time1">查询参数开始时间</param>
        /// <param name="Time2">查询参数结束时间</param>
        /// <param name="startTime">开始时间</param>
        /// <returns></returns>
        IEnumerable<Aggregates.Task> GetByTime(DateTime Time1,DateTime Time2,DateTime startTime);

        /// <summary>
        /// 根据优先级查询用户任务列表
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="priority">优先级</param>
        /// <returns></returns>
        IEnumerable<Aggregates.Task> GetByPriority(User user ,int priority);

        /// <summary>
        /// 获取任务接受着信息
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        IEnumerable<User> GetUserTaskTo(Aggregates.Task task);
    }
}
