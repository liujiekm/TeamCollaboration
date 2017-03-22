//===================================================================================
//Jay@self
//=================================================================================== 
// 日志记录接口工厂类通用类
// 提供统一的方式创建日志记录类
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
 
    public static class LoggerFactory
    {


        private static ILoggerFactory _currentLogFactory;


        public static void SetCurrent(ILoggerFactory logFactory)
        {
            _currentLogFactory = logFactory;
        }

        public static ILogger CreateLog()
        {
            return (_currentLogFactory != null) ? _currentLogFactory.Create() : null;
        }


    }
}