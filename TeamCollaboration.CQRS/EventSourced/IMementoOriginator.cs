//===================================================================================
// Jay@Self
//===================================================================================
// 实例快照，以便能够快速重塑实例
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/23 10:18:37
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CQRS.EventSourced
{
    /// <summary>
    /// 实现当前接口的类可以重塑某个版本的实例的状态
    /// 保存当前对象的快照
    /// </summary>
    public  interface IMementoOriginator
    {
        /// <summary>
        /// 保存对象的快照
        /// </summary>
        /// <returns></returns>
        IMemento SaveToMemento();
    }


    /// <summary>
    /// 快照对象，可以方面重塑对象
    /// </summary>
    public interface IMemento
    {
        /// <summary>
        /// The version of the <see cref="IEventSourced"/> instance.
        /// </summary>
        int Version { get; }
    }
}
