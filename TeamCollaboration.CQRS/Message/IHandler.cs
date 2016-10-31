//===================================================================================
// Jay@self
//===================================================================================
// 命令以及时间的处理程序接口契约
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 15:02:18
// 版本号：  V1.0.0.0
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CQRS.Message
{
    public interface IHandler<T> where T:IMessage
    {
        void Handle(T message);
    }
}
