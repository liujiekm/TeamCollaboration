//===================================================================================
// Jay@Self
//===================================================================================
// 需长时间运行的任务的流程处理对象
// Sagas
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/23 10:40:11
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.CQRS.Command;
using TeamCollaboration.CQRS.Message;

namespace TeamCollaboration.CQRS.Processes
{

    /// <summary>
    /// 需长时间运行的任务的流程处理对象
    /// 类似workflow
    /// </summary>
    public interface IProcessManager
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        Guid Id { get;}


        bool Completed { get; }

        /// <summary>
        /// 持久化当前process之前需要发送到命令总线的命令
        /// </summary>
        IEnumerable<Envelope<ICommand>> Commands { get; }
    }
}
