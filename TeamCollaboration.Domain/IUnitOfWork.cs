//===================================================================================
// JayPrim's Project
//===================================================================================
// Unit Of Work 接口
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2015-09-15 13:20:09
// 版本号：  V1.0.0.0
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
