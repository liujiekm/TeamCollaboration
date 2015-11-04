//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// 日志记录接口类
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
    public interface ILogger
    {
      
        void Debug(string message, params object[] args);

      
        void Debug(string message, Exception exception, params object[] args);

     
        void Debug(object item);

      
        void Fatal(string message, params object[] args);

      
        void Fatal(string message, Exception exception, params object[] args);

       
        void Info(string message, params object[] args);

     
        void Warning(string message, params object[] args);

      
        void Error(string message, params object[] args);

       
        void Error(string message, Exception exception, params object[] args);
    }
}