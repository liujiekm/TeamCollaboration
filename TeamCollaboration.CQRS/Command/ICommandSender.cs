﻿//===================================================================================
// Jay@self
//===================================================================================
// 命令发送接口契约
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 15:24:49
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CQRS.Command
{
    public interface ICommandSender
    {
        void Sender<T>(T command) where T : ICommand;
    }
}
