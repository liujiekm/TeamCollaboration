//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// IUserRepository接口
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
    public interface IUserRepository:IRepository<User>
    {
        /// <summary>
        /// 禁用用户
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="enable">布尔值</param>
        void EnableUser(User user, int enable);

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        void CreateUser(User user);




        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="newPsw">新密码</param>
        void ChangePassword(User user,string newPsw);

        

        /// <summary>
        /// 根据时间获取用户的通知
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="dateTime">日期</param>
        /// <returns></returns>
        IEnumerable<Notice> GetUserNotice(User user,DateTime dateTime);

        /// <summary>
        /// 根据时间获取用户任务列表
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        IEnumerable<Aggregates.Task> GetUserTask(User user, DateTime dateTime);





      

        
        ///// <summary>
        ///// 获取任务接受者
        ///// </summary>
        ///// <param name="task"></param>
        ///// <returns></returns>
        //IEnumerable<User> GetTaskToUser(Aggregates.Task task);

        ///// <summary>
        ///// 获取任务发布者信息
        ///// </summary>
        ///// <param name="task">任务</param>
        ///// <returns></returns>
        //User GetTaskSponsor(Aggregates.Task task);

        

    }
}
