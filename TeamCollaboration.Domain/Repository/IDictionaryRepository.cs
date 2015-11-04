//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  IDictionaryRepository接口
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
    public interface IDictionaryRepository:IRepository<Dictionary>
    {
        /// <summary>
        /// 得到用户有权的符合条件的子文件夹
        /// </summary>
        /// <param name="dictionary">目标文件夹</param>
        /// <param name="conditionExpression">条件</param>
        /// <returns></returns>
        IEnumerable<Dictionary> GetChildDic(User user,string conditionExpression);

        /// <summary>
        /// 得到文件夹下符合条件的文件
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="conditionExpression"></param>
        /// <returns></returns>
        IEnumerable<File> GetChildFile(Dictionary dictionary,string conditionExpression);


        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="dictionary">文件夹</param>
        /// <param name="status">布尔值</param>
        void EnableDictionary(Dictionary dictionary,int status);
    }
}
