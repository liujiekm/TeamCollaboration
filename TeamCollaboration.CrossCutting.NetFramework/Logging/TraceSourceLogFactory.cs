//===================================================================================
//Jay@self
//=================================================================================== 
// 日志记录工厂类实现，记录到系统日志中
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================


using System;
using TeamCollaboration.CrossCutting.Logging;

namespace TeamCollaboration.CrossCutting.NetFramework.Logging
{

    public class TraceSourceLogFactory : ILoggerFactory
    {

        public ILogger Create()
        {
            return new TraceSourceLog();
        }

    }
}