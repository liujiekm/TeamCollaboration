//===================================================================================
// Jay@self
//===================================================================================
// 事件仓储接口
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/1 11:07:42
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CQRS.Event
{
    public interface IEventStore
    {
        void Save(IEvent @event);

        IEnumerable<IEvent> Get(Guid aggregateId, Int32 fromVersion);

    }
}
