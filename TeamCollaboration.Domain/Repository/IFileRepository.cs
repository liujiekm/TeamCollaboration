//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  IFileRepository接口
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
    public interface IFileRepository:IRepository<File>
    {
        ///// <summary>
        ///// 模糊查询文件
        ///// </summary>
        ///// <param name="user">当前用户，查询范围是其权限范围内所有文件</param>
        ///// <param name="condition">查询条件</param>
        ///// <returns></returns>
        //IEnumerable<File> GetSimilarFile(User user, string condition);
        
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="status"></param>
        void EnableFile(File file, int status);

        /// <summary>
        /// 上传任务文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="task"></param>
        /// <param name="dictionary"></param>
        void UpFileToTask(File file, Aggregates.Task task, Dictionary dictionary);
        
        /// <summary>
        /// 上传会议文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="meeting"></param>
        /// <param name="dictionary"></param>
        void UpFileToMeeting(File file, Meeting meeting, Dictionary dictionary);

        /// <summary>
        /// 获取任务文件
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        IEnumerable<File> GetTaskFile(Aggregates.Task task);


        /// <summary>
        /// 获取会议文件
        /// </summary>
        /// <param name="meeting"></param>
        /// <returns></returns>
        IEnumerable<File> GetMeetingFile(Meeting meeting);

        /// <summary>
        /// 根据上传时间获取文件
        /// </summary>
        /// <param name="datatime"></param>
        /// <returns></returns>
        IEnumerable<File> GetFileByDate(DateTime datatime);

        /// <summary>
        /// 通过文件名查找文件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        File findByName(string name);


    }
}
