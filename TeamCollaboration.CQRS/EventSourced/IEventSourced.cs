//===================================================================================
// Jay@self
//===================================================================================
// 启用事件源的实体对象，接口契约
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/22 15:42:29
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.CQRS.Event;

namespace TeamCollaboration.CQRS.EventSourced
{
    /// <summary>
    /// 启用事件源的实体对象
    /// </summary>
    public interface IEventSourced
    {
        Guid Id { get;}



        /// <summary>
        /// 实体的版本，如果实体被跟新并且事件发生之后，版本需递增
        /// </summary>
        int Version { get; }



        /// <summary>
        /// 实体被加载之后发生在它身上的有序的事件集合
        /// </summary>
        IEnumerable<IEvent> Events { get; }
    }
}
