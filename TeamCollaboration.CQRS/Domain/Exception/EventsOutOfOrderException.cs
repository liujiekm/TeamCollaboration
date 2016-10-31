//===================================================================================
// Jay@self
//===================================================================================
// 自定义异常
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 15:32:09
// 版本号：  V1.0.0.0
//===================================================================================

using System;

namespace TeamCollaboration.CQRS.Domain.Exception
{
    public class EventsOutOfOrderException : System.Exception
    {
        public EventsOutOfOrderException(Guid id)
            : base(string.Format("Eventstore gave event for aggregate {0} out of order", id))
        {
        }
    }
}