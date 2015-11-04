//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Unit Of Work 接口
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-15
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.Domain
{
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// 事物性提交，保证领域事物一致性，
        /// 如果遇到积极并发问题，则抛出异常
        /// </summary>
        void Commit();


        /// <summary>
        /// 提交之后跟新内存中载入的数据实体
        /// </summary>
        void CommitAndRefreshChanges();


        /// <summary>
        /// 回滚修改
        /// </summary>
        void RollbackChanges();
    }
}
