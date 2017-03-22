//===================================================================================
//Jay@self
//=================================================================================== 
// 日志记录接口工厂类（创建具体日志记录类）
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CrossCutting.Logging
{

    public interface ILoggerFactory
    {
      
        ILogger Create();
    }
}