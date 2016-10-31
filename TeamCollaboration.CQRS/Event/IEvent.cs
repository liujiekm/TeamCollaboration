//===================================================================================
// Jay@self
//===================================================================================
// 事件接口契约
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 15:04:14
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
    public interface IEvent:IMessage
    {
        Guid Id { get; set; }

        Int32 Version { get; set; }

       DateTimeOffset TimeStamp { get; set; }
    }
}
