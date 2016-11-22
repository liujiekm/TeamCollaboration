//===================================================================================
// Jay@self
//===================================================================================
// 事件消息总线
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 15:26:52
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.CQRS.Message;

namespace TeamCollaboration.CQRS.Event
{
    public interface IEventBus
    {
        void Publish(Envelope<IEvent> @Event);

        void Publish(IEnumerable<Envelope<IEvent>> @Events);
    }
}
