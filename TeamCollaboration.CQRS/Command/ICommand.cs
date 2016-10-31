//===================================================================================
// Jay@self
//===================================================================================
// 命令接口
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 14:59:07
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.CQRS.Message;

namespace TeamCollaboration.CQRS.Command
{
    public interface ICommand:IMessage
    {
        Guid Id { get; set; }

        Int32 ExpectedVersion { get; set; }
    }
}
